﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Problem6NandKfactorial
{
    class Problem6NandKfactorial
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());
            int k = int.Parse(Console.ReadLine());
            int fac = 1;
            for (int i = (k+1); i <= n; i++)
            {
                fac *= i;
            }
            Console.WriteLine(fac);
        }
    }
}
