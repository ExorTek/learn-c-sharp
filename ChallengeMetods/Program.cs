﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ChallengeMetods
{
    class Program
    {
        static void Main(string[] args)
        {
            int numberOne = 1;
            int numberTwo = 2;
            var result = Add(numberOne, numberTwo);

            Console.WriteLine(" --> " + result);
            Console.ReadLine();
        }

        static int Add(int numberOne, int numberTwo)
        {
            var result = numberOne + numberTwo;
            return result;
        }
    }
}
