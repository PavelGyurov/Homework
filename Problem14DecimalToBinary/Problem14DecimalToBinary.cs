using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Problem14DecimalToBinary
{
    class Problem14DecimalToBinary
    {
        static void Main(string[] args)
        {
            long input = long.Parse(Console.ReadLine());
            long number = input;
            int power = 0;
            string output = string.Empty;
            while (number / 2 != 0)
            {
                number /= 2;
                power++;
            }

            while (power >=0)
            {
                    if (input - (long)(Math.Pow(2,power)) >= 0)
                        {
                            input -= (long)(Math.Pow(2,power));
                            output += "1";
                        }
                    else
                        {
                            output += "0";
                        }
                power--;
            }
            Console.WriteLine(output);
        }
    }
}
