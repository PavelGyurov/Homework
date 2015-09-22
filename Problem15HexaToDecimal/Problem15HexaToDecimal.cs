using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Problem15HexaToDecimal
{
    class Problem15HexaToDecimal
    {
        static void Main(string[] args)
        {
            string hex = Console.ReadLine();
            long sum = 0;
            string tempbin = hex;
            for (int i = 0; i < hex.Length; i++)
            {
                string lastdigit = tempbin.Substring(tempbin.Length - 1, 1);
                switch (lastdigit)
                {
                    case "A": lastdigit = "10";
                        break;
                    case "B": lastdigit = "11";
                        break;
                    case "C": lastdigit = "12";
                        break;
                    case "D": lastdigit = "13";
                        break;
                    case "E": lastdigit = "14";
                        break;
                    case "F": lastdigit = "15";
                        break;
                    default:
                        break;
                }
                int digit = int.Parse(lastdigit);
                sum = sum + (digit * (long)(Math.Pow(16, i)));
                tempbin = tempbin.Remove(tempbin.Length - 1);
            }
            Console.WriteLine(sum);
        }
    }
}
