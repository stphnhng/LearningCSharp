using System;
using ScrapeLibrary;

namespace ScrapeClient
{
    class MainClass
    {
        public static void Main(string[] args)
        {
            Scrape myScrape = new Scrape();
            string value = myScrape.ScrapeWebpage("http://msdn.microsoft.com");
            Console.WriteLine(value);
        }
    }
}
