using System;
using MyCodeLibrary; // uses MyCodeLibrary to scrape webpage

namespace MyClient
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
