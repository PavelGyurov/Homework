using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Problem5
{
    class Problem5
    {
        static void Main(string[] args)
        {
            double n = double.Parse(Console.ReadLine());
            double x = double.Parse(Console.ReadLine());
            double fac = 1;
            double sum = 1;
            for (int i = 1; i <= n; i++)
            {
                fac = 1;
                for (int k = 1; k <= i; k++)
                {
                    fac *= k;

                }
                sum += fac / (Math.Pow(x, i));
            }
            Console.WriteLine("{0:f5}",sum);
        }
    }
}
