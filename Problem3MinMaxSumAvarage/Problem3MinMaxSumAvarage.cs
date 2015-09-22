using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Problem3MinMaxSumAvarage
{
    class Problem3MinMaxSumAvarage
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());
            int sum = 0;
            int min = int.MaxValue;
            int max = 0;
            for (int i = 0; i < n; i++)
            {
                int num = int.Parse(Console.ReadLine());

                if (num > max)
                {
                    max = num;
                }
                if (min > num)
                {
                    min = num;
                }
                
                sum += num;
            }
            double avr = (double)sum / (double)n;
            Console.WriteLine("min = {0}", min);
            Console.WriteLine("max = {0}", max);
            Console.WriteLine("sum = {0}", sum);
            Console.WriteLine("avg = {0:f2}", avr);
            
        }
    }
}
