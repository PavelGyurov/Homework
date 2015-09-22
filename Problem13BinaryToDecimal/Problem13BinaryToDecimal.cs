using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Problem13BinaryToDecimal
{
    class Problem13BinaryToDecimal
    {
        static void Main(string[] args)
        {
            string bin = Console.ReadLine();
            long sum = 0;
            string tempbin = bin;
            for (int i = 0; i < bin.Length; i++)
            {
                string lastdigit = tempbin.Substring(tempbin.Length-1,1);
                int digit = int.Parse(lastdigit);
                sum = sum + (digit * (long)(Math.Pow(2, i)));
                tempbin = tempbin.Remove(tempbin.Length-1);
            }
            Console.WriteLine(sum);
        }
    }
}
