using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Numerics;

namespace Problem8CatalanNumbers
{
    class Problem8CatalanNumbers
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());
            BigInteger fac = 1;         //2n!/n!
            for (int i = n+1; i <= 2*n; i++)
            {
                fac *= i;
            }
            BigInteger facn1 = 1;         //(n+1)!
            for (int i = 1; i <= n+1; i++)
            {
                facn1 *= i;
            }
            Console.WriteLine(fac/facn1);
        }
    }
}
