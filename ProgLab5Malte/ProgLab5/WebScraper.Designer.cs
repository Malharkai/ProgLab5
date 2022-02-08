namespace ProgLab5
{
    partial class WebScraper
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.buttonSaveImages = new System.Windows.Forms.Button();
            this.textBoxUrl = new System.Windows.Forms.TextBox();
            this.richTextBoxURLs = new System.Windows.Forms.RichTextBox();
            this.buttonExtract = new System.Windows.Forms.Button();
            this.labelImagesFound = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // buttonSaveImages
            // 
            this.buttonSaveImages.Location = new System.Drawing.Point(660, 415);
            this.buttonSaveImages.Name = "buttonSaveImages";
            this.buttonSaveImages.Size = new System.Drawing.Size(128, 23);
            this.buttonSaveImages.TabIndex = 0;
            this.buttonSaveImages.Text = "Save Images";
            this.buttonSaveImages.UseVisualStyleBackColor = true;
            this.buttonSaveImages.Click += new System.EventHandler(this.buttonSaveImages_Click);
            // 
            // textBoxUrl
            // 
            this.textBoxUrl.Location = new System.Drawing.Point(12, 12);
            this.textBoxUrl.Name = "textBoxUrl";
            this.textBoxUrl.Size = new System.Drawing.Size(599, 23);
            this.textBoxUrl.TabIndex = 1;

            // 
            // richTextBoxURLs
            // 
            this.richTextBoxURLs.Location = new System.Drawing.Point(12, 41);
            this.richTextBoxURLs.Name = "richTextBoxURLs";
            this.richTextBoxURLs.Size = new System.Drawing.Size(776, 368);
            this.richTextBoxURLs.TabIndex = 2;
            this.richTextBoxURLs.Text = "";

            // 
            // buttonExtract
            // 
            this.buttonExtract.Location = new System.Drawing.Point(660, 12);
            this.buttonExtract.Name = "buttonExtract";
            this.buttonExtract.Size = new System.Drawing.Size(128, 23);
            this.buttonExtract.TabIndex = 3;
            this.buttonExtract.Text = "Extract";
            this.buttonExtract.UseVisualStyleBackColor = true;
            this.buttonExtract.Click += new System.EventHandler(this.buttonExtract_Click);
            // 
            // labelImagesFound
            // 
            this.labelImagesFound.AutoSize = true;
            this.labelImagesFound.Location = new System.Drawing.Point(12, 419);
            this.labelImagesFound.Name = "labelImagesFound";
            this.labelImagesFound.Size = new System.Drawing.Size(83, 15);
            this.labelImagesFound.TabIndex = 4;
            this.labelImagesFound.Text = "Images found:";
            // 
            // WebScraper
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.labelImagesFound);
            this.Controls.Add(this.buttonExtract);
            this.Controls.Add(this.richTextBoxURLs);
            this.Controls.Add(this.textBoxUrl);
            this.Controls.Add(this.buttonSaveImages);
            this.Name = "WebScraper";
            this.Text = "Maltes Web Scraper";

            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Button buttonSaveImages;
        private TextBox textBoxUrl;
        private RichTextBox richTextBoxURLs;
        private Button buttonExtract;
        private Label labelImagesFound;
    }
}