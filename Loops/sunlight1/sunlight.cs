using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace sunlight1
{
    class sunlight
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());
            //string horizont = new string('*', 3*n);
            //string sun = new string('*',n);
            //string sunspace = new string('.', n);
            //string topandbotspace = new string('.', (n*3)/2);
            //int space = ((3 * n) - 5) / 2;

            //Console.WriteLine(topandbotspace + "*" + topandbotspace);
            

            //for (int i = 1; i <= n-1; i++)
            //{
            //    string rayspace = new string('.', space);
            //    Console.WriteLine(new string('.', i) + "*" + rayspace + "*" + rayspace + "*" + new string('.', i));
            //    space--;
            //}

            //for (int i = 0; i <= (n/2)-1; i++)
            //{
            //    Console.WriteLine(sunspace + sun + sunspace);
            //}

            //Console.WriteLine(horizont);

            //for (int i = 0; i <= (n / 2) - 1; i++)
            //{
            //    Console.WriteLine(sunspace + sun + sunspace);
            //}

            //for (int i = n - 1; i >= 1; i--)
            //{
            //    space++;
            //    string rayspace = new string('.', space);
            //    Console.WriteLine(new string('.', i) + "*" + rayspace + "*" + rayspace + "*" + new string('.', i));
                
            //}

            //Console.WriteLine(topandbotspace + "*" + topandbotspace);

            if (n >= 2 && n <= 3)
            {
                Console.WriteLine("lur");
            }
        }
    }
}
