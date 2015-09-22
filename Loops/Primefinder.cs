using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Numerics;


namespace Loops
{
    class Primefinder
    {
        static void Main(string[] args)
        {
            int a = int.Parse(Console.ReadLine());
            int b = int.Parse(Console.ReadLine());
            int n = Math.Min(a, b);
            int m = Math.Max(a, b);
            for (int i = n; i <= m ; i++)
            {
                for (int j = 2; j <= i; j++)
                {
                    if (i == 2)
                    {
                        Console.WriteLine(i);
                        break;
                    }
                    if (i % j == 0)
                    {
                        break;
                    }
                   
                    if (j > Math.Sqrt(i))
                    {
                        Console.WriteLine(i);
                        break;
                    }
                }
                
            }
        }
    }
}
