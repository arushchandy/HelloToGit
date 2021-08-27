using System;
using System.Threading;

namespace GitSampleConsole
{
    internal class Program
    {
        private static void Main(string[] args)
        {
            Console.WriteLine("Hello World Kavitha!");
  
        

            Console.ReadLine();
        }

        private static void PrintFrom20To30()
        {
            var i = 20;
            while (i < 30)
            {
                Console.WriteLine(i);
                i += 1;
                Thread.Sleep(100);
            }
        }
    }
}
