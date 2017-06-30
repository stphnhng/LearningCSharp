﻿using System;
using System.IO;
using System.Net;

namespace ScrapeLibrary
{
    public class Scrape
    {
        // "/Users/stephen/desktop/C#/learning"
        public string ScrapeWebpage(string url)
        {
            return GetWebpage(url);
        }

        public string ScrapeWebpage(string url, string filepath)
        {
            string reply = GetWebpage(url);

            File.WriteAllText(filepath, reply);
            return reply;

        }

        private string GetWebpage(string url)
        {
            WebClient client = new WebClient();
            string content = client.DownloadString(url);
            content += "\nThats All Folks";
            return content;
        }
    }
}
