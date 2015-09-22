using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace loan
{
    class loan
    {
        static void Main(string[] args)
        {
            double price = double.Parse(Console.ReadLine());
            double term = double.Parse(Console.ReadLine());
            double intrest = double.Parse(Console.ReadLine());
            double friendintrest = double.Parse(Console.ReadLine());

            double bankdamage = price * (Math.Pow((1 + intrest), term));
            double frienddamage = price + (price * friendintrest);

            if (frienddamage <= bankdamage)
            {
                Console.WriteLine("{0:F2} Friend", frienddamage);
            }
            else
            {
                Console.WriteLine("{0:F2} Bank", bankdamage);
            }
        }
    }
}
