using System;
using System.Net;

namespace AssembliesAndNamespaces
{
    class MainClass
    {
        public static void Main(string[] args)
        {

            WebClient client = new WebClient();
            string reply = client.DownloadString("http://msdn.microsoft.com");
            // site:microsoft.com question - looks up microsoft code to do something.

            Console.WriteLine(reply);

            string text = "stuff inputted to a file";

            //System.IO.File.WriteAllText("/Users/stephen/desktop/C#/learning/Assembliesandnamespaces", text);

            Console.WriteLine("Hello World!");
        }
    }
}
