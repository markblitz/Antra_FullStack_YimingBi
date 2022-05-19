﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Question1_FizzBuzz
{
    public class FizzBuzz
    {
        public FizzBuzz(int stopNumber)
        {
            for (int i = 1; i <= stopNumber; i++)
            {
                if ((i % 3 == 0) & (i % 5 == 0)) {
                    Console.WriteLine("FizzBuzz");
                }
                else if (i % 3 == 0) {
                    Console.WriteLine("Fizz");
                }
                else if (i% 5 == 0) {
                    Console.WriteLine("Buzz");
                }
                else {
                    Console.WriteLine(i);
                }
            }
        }
    }
}
