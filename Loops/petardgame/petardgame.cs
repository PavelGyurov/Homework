using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Numerics;

namespace petardgame
{
    class petardgame
    {
        static void Main(string[] args)
        {
            BigInteger start = BigInteger.Parse(Console.ReadLine());
            BigInteger end = BigInteger.Parse(Console.ReadLine());
            string replace = Console.ReadLine();
            BigInteger sum = 0;

            for (BigInteger i = start; i < end; i++)
            {
                if (i % 5 == 0)
                {
                    sum += i;
                }
                else
                {
                    sum += (i%5);
                }
            }

            bool odd = true;

            if (sum % 2 == 0)
            {
                odd = false;
            }

            string number = Convert.ToString(sum);
            string firstnumber = Convert.ToString(number[0]);
            string lastnumber = Convert.ToString(number[number.Length - 1]);


            if (odd == true)
            {
                number = number.Replace(lastnumber, replace);
            }
            else
            {
                number = number.Replace(firstnumber, replace);
            }
            Console.WriteLine(number);
        }
    }
}
