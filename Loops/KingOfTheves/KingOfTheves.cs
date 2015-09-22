using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace KingOfTheves
{
    class KingOfTheves
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());
            char s = char.Parse(Console.ReadLine());

            int upperwidth = 1;
            int sidewidth = n / 2;
            for (int i = 0; i < n/2; i++)
            {
                string gem = new string(s, upperwidth);
                string side = new string('-', sidewidth);
                Console.WriteLine(side + gem + side);
                upperwidth += 2;
                sidewidth --;
            }

            string middle = new string(s, n);
            Console.WriteLine(middle);

            int width = n - 2;
            for (int i = 0; i < n/2; i++)
            {
                string side = new string('-', i + 1);
                string gem = new string (s, width);
                Console.WriteLine(side + gem+ side);
                width -=2;
            }
        }
    }
}
