using System;
using System.Diagnostics;
using System.Text;

class Program
{
    static void Main(string[] args)
    {
        // Measure performance using Stopwatch
        Stopwatch sw = new Stopwatch();

        /////////////////////////////////
        // Inefficient string concatenation
        /////////////////////////////////
        sw.Start();

        string text = "";
        for (int i = 0; i < 10000; i++)
        {
            text += "A";
        }

        sw.Stop();
        Console.WriteLine("String concatenation time: " + sw.ElapsedMilliseconds + " ms");

        /////////////////////////////////
        // Efficient StringBuilder usage
        /////////////////////////////////
        sw.Reset();
        sw.Start();

        StringBuilder sb = new StringBuilder();
        for (int i = 0; i < 10000; i++)
        {
            sb.Append("A");
        }

        string result = sb.ToString();

        sw.Stop();
        Console.WriteLine("StringBuilder time: " + sw.ElapsedMilliseconds + " ms");

        Console.ReadLine();
    }
}
