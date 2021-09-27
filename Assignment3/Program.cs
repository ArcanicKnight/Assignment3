using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;

namespace Assignment3
{
    class Program
    {
        static void main(string[] args)
        {
            int[] ys = {1600, 1700, 1900, 2000};
            var leapYears = ys.Where(y => DateTime.IsLeapYear(y));
            foreach (var y in leapYears)
            {
                Console.WriteLine(y);
            }
        }
    }
}