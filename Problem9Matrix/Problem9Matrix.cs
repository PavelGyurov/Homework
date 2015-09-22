using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Problem9Matrix
{
    class Problem9Matrix
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());
            for (int i = 1; i <= n; i++)
            {
                for (int k = i; k < n+i; k++)
                {
                    Console.Write("{0} ", k);
                }
                Console.WriteLine();
            }
        }
    }
}
