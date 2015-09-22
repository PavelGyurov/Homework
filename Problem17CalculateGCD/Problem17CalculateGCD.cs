using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Problem17CalculateGCD
{
    class Problem17CalculateGCD
    {
        static void Main(string[] args)
        {
            int a = int.Parse(Console.ReadLine());
            int b = int.Parse(Console.ReadLine());
            a = Math.Abs(a);
            b = Math.Abs(b);
            int c = new int();
            while (a != 0 && b != 0)
            {
                c = Math.Abs(Math.Max(a, b)) - Math.Abs(Math.Min(a, b));
                a = Math.Min(a,b);
                b = c;
            }
            Console.WriteLine(a);
        }
    }
}
