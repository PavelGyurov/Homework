using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TrailingZeroesPropper
{
    class TrailingZeroesPropper
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());
            int counter = 0;
            int tempn = n;
            while (tempn / 5 != 0)
            {
                tempn /= 5;
                counter++;
            }
            
            int zeroes = 0;
            int tempzeroes = 0;
            while (counter > 0)
            {
                tempzeroes = n/((int)(Math.Pow(5, counter)));
                zeroes += tempzeroes;
                counter--;
            }
            Console.WriteLine(zeroes);
        }
    }
}
