using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Problem1Numbers1toN
{
    class Problem1Numbers1toN
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());
            for (int i = 1; i <= n; i++)
            {
                if (i < n)
	                    {
                            Console.Write("{0} ", i);
	                    }
                
                else if (i == n)
                {
                    Console.Write(i);
                }
            }
            Console.WriteLine();
        }
    }
}
