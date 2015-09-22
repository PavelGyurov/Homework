using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Globalization;
using System.Threading;

namespace CurrencyCheck
{
    class CurrencyCheck
    {
        static void Main(string[] args)
        {
            Thread.CurrentThread.CurrentCulture = CultureInfo.GetCultureInfo("en-US");

            decimal r = decimal.Parse(Console.ReadLine());
            decimal d = decimal.Parse(Console.ReadLine());
            decimal e = decimal.Parse(Console.ReadLine());
            decimal b = decimal.Parse(Console.ReadLine());
            decimal m = decimal.Parse(Console.ReadLine());

            r *= 0.035M;
            d *= 1.5M;
            e *= 1.95M;
            b /= 2M;

            decimal[] arr = new decimal[5] { r, d, e, b, m };
            //decimal cheapes = decimal.Round(arr.Min(), 2);
            decimal cheapes = arr.Min();
            Console.WriteLine("{0:F2}",cheapes);
        }
    }
}
