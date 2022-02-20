using System;
using System.Collections.Generic;
using System.Text;
using System.Net.Http;

namespace Palette
{
    class Program
    {

        public static async void Main(String s)
        {

            s = s.Replace(" ", "%20");

            var client = new HttpClient();
            var request = new HttpRequestMessage
            {
                Method = HttpMethod.Get,
                RequestUri = new Uri("https://recipe-by-api-ninjas.p.rapidapi.com/v1/recipe?query=" + s),
                Headers =
    {
        { "x-rapidapi-host", "recipe-by-api-ninjas.p.rapidapi.com" },
        { "x-rapidapi-key", "b736fe1b7emsh82c8b7781ad71cdp16ddd3jsnd818d081e59d" },
    },
            };
            using (var response = await client.SendAsync(request))
            {
                response.EnsureSuccessStatusCode();
                var body = await response.Content.ReadAsStringAsync();
                Console.WriteLine(body);
            }
        }
    }
}
