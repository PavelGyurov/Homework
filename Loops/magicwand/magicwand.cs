using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace magicwand
{
    class magicwand
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());

            string top = new string('.', ((3 * n) + 2) / 2);
            Console.WriteLine(top + "*" + top);

            int middle = 1;
            int sidecount = (3 * n) / 2;
            for (int i = 0; i < (n/2)+1; i++)
            {
                string side = new string('.', sidecount);
                string midl = new string('.', middle);
                Console.WriteLine(side + "*" + midl + "*" + side);
                sidecount--;
                middle += 2;
            }

            
            string wandmid = new string('*', n);
            string mid = new string('.',n+2);
            Console.WriteLine(wandmid + mid + wandmid);

            int middlecount = (3 * n) - 2;
            for (int i = 1; i <= n / 2; i++)
            {
                string side = new string('.', i);
                string mid1 = new string('.', middlecount);
                Console.WriteLine(side + "*" + mid1 + "*" + side);
                middlecount -= 2;
            }
            string handle = "*" + new string('.',n) + "*";

            int initialside = (n / 2) - 1;
            for (int i = 0; i < n/2; i++)
            {
                string side = new string('.', initialside);
                string space = new string('.', i);
                string wantprong = "*" + new string('.', n / 2) + "*";
                Console.WriteLine(side + wantprong + space + handle + space + wantprong + side);
                initialside--;
            }
            string side1 = new string('*', (n / 2) + 1);
            string sidespace = new string('.', n / 2);
            Console.WriteLine(side1 + sidespace + handle + sidespace + side1);

            string spaceh = new string('.', n);
            for (int i = 0; i < n; i++)
            {
                
                Console.WriteLine(spaceh+handle+spaceh);
            }
            string wandbase = new string('*',n+2);
            Console.WriteLine(spaceh + wandbase + spaceh);
        }
    }
}
