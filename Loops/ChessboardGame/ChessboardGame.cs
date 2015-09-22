using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace ChessboardGame
{
    class ChessboardGame
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());
            string input = Console.ReadLine();
            input = input.PadRight((n * n)+1, '.');
            char[] symbols = new char[n*n];
            symbols = input.ToCharArray();

            int whitescore = 0;
            int blackscore = 0;

          
            for (int i = 0; i <= (n*n)-1; i+=2)        //blackscore
            {
                if ((int)symbols[i] >= 48 && symbols[i] <= 57)
                {
                    blackscore += (int)symbols[i];
                }
                else if ((int)symbols[i] >= 97 && symbols[i] <= 122)
                {
                    blackscore += (int)symbols[i];
                }
                else if ((int)symbols[i] >= 65 && symbols[i] <= 90)
                {
                    whitescore += (int)symbols[i];
                }
                //Console.WriteLine(symbols[i]);
            }


            for (int i = 1; i < n*n; i += 2)        //whitescore
            {
                if ((int)symbols[i] >= 48 && symbols[i] <= 57)
                {
                    whitescore += (int)symbols[i];
                }
                else if ((int)symbols[i] >= 97 && symbols[i] <= 122)
                {
                    whitescore += (int)symbols[i];
                }
                else if ((int)symbols[i] >= 65 && symbols[i] <= 90)
                {
                    blackscore += (int)symbols[i];
                }
                //Console.WriteLine(symbols[i]);
            }
            if (blackscore == whitescore)
            {
                Console.WriteLine("Equal result: {0}", blackscore);
            }
            else if (blackscore > whitescore)
            {
                Console.WriteLine("The winner is: black team");
                Console.WriteLine("{0}", blackscore - whitescore);
            }
            else
            {
                Console.WriteLine("The winner is: white team");
                Console.WriteLine("{0}", whitescore-blackscore);
            }
         

        }
    }
}
