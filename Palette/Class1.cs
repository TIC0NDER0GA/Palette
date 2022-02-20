using System;
using System.Collections.Generic;
using System.Text;
using System.Net.Http;

namespace Palette
{
    class Program
    {
        static String query;

        public static async void Main(String s)
        {

            s = s.Replace(" ", "%20");
            s += "&offset=1";


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
                query = body;
            }

            
        }

        public static async void Ingredient()
        {
            var client = new HttpClient();
            var request = new HttpRequestMessage
            {
                Method = HttpMethod.Get,
                RequestUri = new Uri("https://nutrition-by-api-ninjas.p.rapidapi.com/v1/nutrition?query=bacon"),
                Headers =
    {
        { "x-rapidapi-host", "nutrition-by-api-ninjas.p.rapidapi.com" },
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



        public static string Recipe()
        {
            return query;
        }

    }
}
