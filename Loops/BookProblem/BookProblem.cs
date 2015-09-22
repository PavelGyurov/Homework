using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace BookProblem
{
    class BookProblem
    {
        static void Main(string[] args)
        {
            //decimal pages = decimal.Parse(Console.ReadLine());
            //decimal campgingdays = decimal.Parse(Console.ReadLine());
            //decimal dailypages = decimal.Parse(Console.ReadLine());

            //decimal readingdays = 30M - campgingdays;
            //if (readingdays == 0 || dailypages == 0)
            //{
            //    Console.WriteLine("never");
            //    return;
            //}

            //decimal pagespermonth = dailypages * readingdays;
            
            //decimal neededmonths = Math.Ceiling(pages/pagespermonth);
            //Console.WriteLine("{0:F0} years {1} months", neededmonths/12, neededmonths%12);

            int test = 10 >> 8;
            Console.WriteLine(test);
        }
    }
}
