using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Problem16DeciToHex
{
    class Problem16DeciToHex
    {
        static void Main(string[] args)
        {
            long input = long.Parse(Console.ReadLine());
            long number = input;
            int power = 0;
            string output = string.Empty;
            while (number / 16 != 0)
            {
                number /= 16;
                power++;
            }
            
            while (power >= 0)
            {
                long leftmostdigit = (long)(Math.Pow(16, power));
                    long digit = input / leftmostdigit;
                    switch (digit)
                    {
                        case 10: output += "A";
                            break;
                        case 11: output += "B";
                            break;
                        case 12: output += "C";
                            break;
                        case 13: output += "D";
                            break;
                        case 14: output += "E";
                            break;
                        case 15: output += "F";
                            break;
                        default: output += digit;
                            break;
                    }
                    input -= (leftmostdigit*digit);
                power--;
            }
            Console.WriteLine(output);
        }
    }
}
