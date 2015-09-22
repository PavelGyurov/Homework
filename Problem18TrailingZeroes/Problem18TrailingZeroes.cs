using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Numerics;

namespace Problem18TrailingZeroes
{
    class Problem18TrailingZeroes
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());
            BigInteger fac = 1;
            for (int i = 1; i <= n; i++)
            {
                fac *= i;
            }
            Console.WriteLine(fac);
            int zeroes = 0;
            while (fac % 10 == 0)
            {
                fac /= 10;
                zeroes ++;
            }
            Console.WriteLine(zeroes);
        }
    }
}
