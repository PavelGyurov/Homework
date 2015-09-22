using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Problem19SpiralMatrix
{
    class Problem19SpiralMatrix
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());
            for (int i = 1; i <= n; i++)
            {
                Console.Write(i+" ");
            }
            Console.WriteLine();
            for (int i = 0; i < n-2; i++)
            {
                if (i == 0)
                {
                    for (int j = 0; j < n - 1; j++)
                    {
                        Console.Write(((4 * n) - 4) + j + " ");
                    }
                    Console.Write(n+1);
                    Console.WriteLine();
                }
                else
                {
                   
                    Console.Write((4 * n) - (4 + i) + " ");
                    Console.Write(n + 1 + i);
                    Console.WriteLine();
                }
                
            }
            for (int i = (3*n)-2; i >= (2*n)-1; i--)
            {
                Console.Write(i+" ");
            }
            Console.WriteLine();

            
        }
    }
}
