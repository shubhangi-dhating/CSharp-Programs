using System;
using System.Threading.Tasks;

class Program
{
    static async Task Main(string[] args)
    {
        Console.WriteLine("Process Started...");

        await DownloadData();

        Console.WriteLine("Process Completed.");
        Console.ReadLine();
    }

    static async Task DownloadData()
    {
        Console.WriteLine("Downloading Data...");

        await Task.Delay(3000); // Wait for 3 seconds

        Console.WriteLine("Download Finished.");
    }
}
