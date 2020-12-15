using System;
using System.Diagnostics;
using Fibonacci;

internal class Program
{
    private static void Main(string[] args)
    {
        var stopwatch = new Stopwatch();
        stopwatch.Start();
        var results = Compute.Execute(args);
        foreach (var result in results) Console.WriteLine($"Hello World! {result}");
        stopwatch.Stop();

        Console.WriteLine($"Time elasped {stopwatch.Elapsed.TotalSeconds} s");
    }
}