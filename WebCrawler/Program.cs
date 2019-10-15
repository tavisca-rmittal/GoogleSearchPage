using System;
using HtmlAgilityPack;
using System.Net.Http;
using System.Threading.Tasks;
using System.Linq;
using System.Collections.Generic;

namespace WebCrawler
{
    class Program
    {
        static void Main(string[] args)
        {
            startCrawlerAsync();


            Console.ReadLine();
        }

        private static async Task startCrawlerAsync()
        {
            var url = "https://www.automobile.tn/neuf/bmw.3/";
            var httpClient = new HttpClient();
            var html = await httpClient.GetStringAsync(url);

            var htmlDocument = new HtmlDocument();
            htmlDocument.LoadHtml(html);
            var cars = new List<Car>();
            
            var divs=htmlDocument.DocumentNode.Descendants("div")
           .Where(node=>node.GetAttributeValue("class","").Equals("versions-item")).ToList();
            //  .Where(node => node.GetAttributeValue("class", "").Equals("field cb off")).ToList();

            foreach (var iterateDiv in divs)
            {
                var car = new Car
                {
                 /*   Model =iterateDiv?.Descendants("h2")?.FirstOrDefault()?.InnerText,*/
                    Link = iterateDiv?.Descendants("a")?.FirstOrDefault()?.ChildAttributes("href")?.FirstOrDefault()?.Value
                };
                cars.Add(car);
            }

            foreach (var a in cars)
            {
                Console.WriteLine(a.Link);
            }
            
        }

    }
}