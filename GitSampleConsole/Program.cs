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

            PrintFrom1To10(num); //error code creation

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
