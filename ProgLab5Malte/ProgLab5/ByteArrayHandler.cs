using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProgLab5
{
    public static class ByteArrayHandler
    {
        public static void GetByteArray(string[] lines, List<Task<byte[]>> downloads)
        {
            var client = new HttpClient();
            foreach (var line in lines) downloads.Add(client.GetByteArrayAsync(line));
        }
    }
}
