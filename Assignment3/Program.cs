using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using BDSA2020.Assignment03;

namespace Assignment3
{
    class Program
    {
        static void Main(string[] args)
        {
            var q = new Queries();

            foreach (var v in q.ReverseWizard())
            {
                Console.WriteLine(v);
            }
            
        }
    }
}