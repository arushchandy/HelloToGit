﻿using System;
using System.Threading;

namespace GitSampleConsole
{
    internal class Program
    {
        private static void Main(string[] args)
        {
            Console.WriteLine("Hello World!");

            PrintFrom1To10();

            Console.ReadLine();
        }

        private static void PrintFrom1To10()
        {
            var i = 0;
            while (i < 10)
            {
                Console.WriteLine(i);
                i += 1;
                Thread.Sleep(100);
            }
        }
    }
}