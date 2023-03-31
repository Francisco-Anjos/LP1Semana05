using System;
using System.Diagnostics;
using System.Threading;

namespace Tempo
{
    class Program
    {
        static void Main(string[] args)
        {
           Stopwatch crono1 = new Stopwatch();
           Stopwatch crono2 = new Stopwatch();
           crono1.Start();
           Thread.Sleep(500);
           crono2.Start();
           Thread.Sleep(300);
           crono1.Stop();
           crono2.Stop();

           double elapsedcrono1 = crono1.Elapsed.TimeInSeconds;
           double elapsedcrono2 = crono2.Elapsed.TimeInSeconds;   

           Console.WriteLine($"Time elapsed for crono1 {elapsedcrono1:F2}");       
           Console.WriteLine($"Time elapsed for crono2 {elapsedcrono2:F2}");               
        }
    }
}
