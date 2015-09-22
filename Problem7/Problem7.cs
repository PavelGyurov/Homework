using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Numerics;



namespace Problem7
{
    class Problem7
    {
        static void Main(string[] args)
        {
            BigInteger n = BigInteger.Parse(Console.ReadLine());
            BigInteger k = BigInteger.Parse(Console.ReadLine());
            
            BigInteger fac = 1;                    // factorail of N!/K!
            for (BigInteger i = (k + 1); i <= n; i++)
            {
                fac *= i;
            }
            BigInteger nkfac = 1;                   // factorail of N/K
            for (BigInteger i = 1; i <= (n-k); i++)
            {
                nkfac *= i;
            }
            Console.WriteLine(fac/nkfac);
            
        }
    }
}
