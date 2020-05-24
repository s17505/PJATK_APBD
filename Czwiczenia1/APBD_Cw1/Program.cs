using System;
using System.Net.Http;
using System.Text.RegularExpressions;
using System.Threading.Tasks;

namespace APBD_Cw1
{
    class Program
    {
        static async Task Main(string[] args)
        {
            var url = args.Length > 0 ? args[0] : "https://www.pja.edu.pl";
            var httpClient = new HttpClient();
            var response = await httpClient.GetAsync(url);

            //2xx - fine
            //4xx - error
            //5xx - critical err
            if (response.IsSuccessStatusCode)
            {
                string content = await response.Content.ReadAsStringAsync();
                var regex = new Regex(
                    "[a-z]+[a-z0-9]*@[a-z0-9]+\\.[a-z]+", RegexOptions.IgnoreCase
                );

                var matches = regex.Matches(content);
                foreach (var match in matches)
                {
                    Console.WriteLine(match);
                }
            }
        }
    }
}
