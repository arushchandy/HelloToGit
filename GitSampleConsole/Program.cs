﻿using System;
using System.Threading;

namespace GitSampleConsole
{
    internal class Program
    {
        private static void Main(string[] args)
        {
            Console.WriteLine("Hello World Anjana!");
            Console.WriteLine("Hello World Milan");
            Console.WriteLine("Hello World Nikhil");
        

            Console.ReadLine();
        }

        private static void PrintFrom10To20()
        {
            var i = 10;
            while (i < 20)
            {
                Console.WriteLine(i);
                i += 1;
                Thread.Sleep(100);
            }
        }
    }
}
