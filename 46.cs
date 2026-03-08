using System;
using System.Net.Http;
using System.Threading.Tasks;
class Program
{
    static async Task Main()
    {
        string[] urls = { "https://example.com", "https://nonexistent.url" };
        using HttpClient client = new HttpClient();
        foreach (string url in urls)
        {
            try
            {
                string content = await client.GetStringAsync(url);
                Console.WriteLine($"Downloaded {url}: {content.Length} characters");
            }
            catch
            {
                Console.WriteLine($"URL {url} is inaccessible");
            }
        }
    }
}