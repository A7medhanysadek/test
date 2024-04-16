using System;
namespace AsynchronousProgramming
{
    class Main_class
    {
        static async Task Main(string[] args)
        {
            Console.Write("could you please paste the web page URL here to download the content:");
            var URL = Console.ReadLine();
            var content = await ReadWebpageContentAsync(URL);
            Console.WriteLine(content);
        }
        static async Task<string> ReadWebpageContentAsync(string url)
        {
            var clint = new HttpClient();
            var content = await clint.GetStringAsync(url);
            return content;
        }
    }
}