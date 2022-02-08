using System.Net;
using System.Text.RegularExpressions;

namespace ProgLab5
{
    public partial class WebScraper : Form
    {
        private readonly List<Task<byte[]>> downloads = new List<Task<byte[]>>();
        private readonly List<string> imageLinkList = new List<string>();
        private Task<byte[]> downloadsFinished;
        private string format = "";
        private int i;
        private string path = "";


        public WebScraper()
        {
            InitializeComponent();
            if (imageLinkList.Count == 0) buttonSaveImages.Enabled = false;
            textBoxUrl.Text = "https://www.gp.se/";
        }

        private async void buttonSaveImages_Click(object sender, EventArgs e)
        {
            using (var dialog = new FolderBrowserDialog())
            {
                if (dialog.ShowDialog() != DialogResult.OK) return;
                path = dialog.SelectedPath;
                ByteArrayHandler.GetByteArray(richTextBoxURLs.Lines , downloads);

                while (downloads.Count > 0)
                    for (i = 0; i < imageLinkList.Count; i++)
                    {
                        downloadsFinished = await Task.WhenAny(downloads);

                        if (imageLinkList[i].Contains(".png"))
                        {
                            format = ".png";
                            DownloadFiles();
                        }

                        if (imageLinkList[i].Contains(".bmp"))
                        {
                            format = ".bmp";
                            DownloadFiles();
                        }

                        if (imageLinkList[i].Contains(".jpg"))
                        {
                            format = ".jpg";
                            DownloadFiles();
                        }

                        if (imageLinkList[i].Contains(".jpeg"))
                        {
                            format = ".jpeg";
                            DownloadFiles();
                        }

                        if (imageLinkList[i].Contains(".gif"))
                        {
                            format = ".gif";
                            DownloadFiles();
                        }
                        downloads.Remove(downloadsFinished);
                    }
            }
        }
        private async Task DownloadFiles()
        {
            var fs = new FileStream($"{path}" + "\\" + $"image{i}" + $"{format}", FileMode.Create);
            await fs.WriteAsync(downloadsFinished.Result, 0, downloadsFinished.Result.Length);
        }

        private void buttonExtract_Click(object sender, EventArgs e)
        {
            imageLinkList.Clear();
            var pattern = "<img.+?src=[\"'](.+?)[\"'].*?>";
            var html = string.Empty;
            var url = textBoxUrl.Text;
            if (url == String.Empty || !url.Contains("https://www."))
            {
                MessageBox.Show("Please enter a valid input.");
                return;
            }
            var request = (HttpWebRequest)WebRequest.Create(url);
            using (var response = (HttpWebResponse)request.GetResponse())
            using (var stream = response.GetResponseStream())
            using (var reader = new StreamReader(stream))
            {
                html = reader.ReadToEnd();
            }

            foreach (Match match in Regex.Matches(html, pattern, RegexOptions.IgnoreCase))
            {
                var imageLink = match.Groups[1].Value;
                imageLinkList.Add(textBoxUrl.Text + imageLink);
            }

            richTextBoxURLs.Lines = imageLinkList.ToArray();
            labelImagesFound.Text = $"Images found: {imageLinkList.Count}";
            if (imageLinkList.Count > 0) buttonSaveImages.Enabled = true;
        }
    }
}