using System;
using System.Net.Http;
using System.IO;
using System.Threading.Tasks;
class Program
{
    static async Task<long> DownloadFileAsync(string url, string path)
    {
        using HttpClient client = new HttpClient();
        byte[] data = await client.GetByteArrayAsync(url);
        await File.WriteAllBytesAsync(path, data);
        return data.Length;
    }
    static async Task Main()
    {
        long size = await DownloadFileAsync("https://example.com/file.txt", "file.txt");
        Console.WriteLine(size);
    }
}