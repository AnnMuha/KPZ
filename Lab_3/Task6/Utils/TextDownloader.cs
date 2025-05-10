using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Http;
using System.Text;
using System.Threading.Tasks;

namespace Task6.Utils
{
    public static class TextDownloader
    {
        public static async Task<string> LoadFromUrl(string url)
        {
            using (var client = new HttpClient())
            {
                return await client.GetStringAsync(url);
            }
        }
    }
}
