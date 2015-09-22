using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Problem4PrintDeck
{
    class Problem4PrintDeck
    {
        static void Main(string[] args)
        {
            int suit = 0;
            for (int i = 2; i <= 14; i++)
            {
                for (int j = 1; j <= 4; j++)
                {
                    switch (j)
                    {
                        case 1: suit = 5;
                            break;
                        case 2: suit = 4;
                            break;
                        case 3: suit = 3;
                            break;
                        case 4: suit = 6;
                            break;
                        default:
                            break;
                    }
                    switch (i)
                    {
                        case 11: Console.Write("J{0} ",(char)suit);
                            break;
                        case 12: Console.Write("Q{0} ", (char)suit);
                            break;
                        case 13: Console.Write("K{0} ", (char)suit);
                            break;
                        case 14: Console.Write("A{0} ", (char)suit);
                            break;
                        default: Console.Write("{0}{1} ", i, (char)suit);
                            break;
                    }
                }
                Console.WriteLine();
            } 
        }
    }
}
