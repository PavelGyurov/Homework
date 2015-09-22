using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace gameoflife
{
    class gameoflife
    {
        static void Main(string[] args)
        {
            int[,] board = new int[10, 10];
            List<int> alivex = new List<int>();
            List<int> alivey = new List<int>();
            int n = int.Parse(Console.ReadLine());
            int neibourcount = 0;

            for (int i = 0; i < n; i++)
            {
                int x = int.Parse(Console.ReadLine());
                int y = int.Parse(Console.ReadLine());

                board[x, y] = 1;
            }



            for (int x = 0; x < board.GetLength(0); x++)
            {

                for (int y = 0; y < board.GetLength(1); y++)
                {
                    neibourcount = 0;
                    if (x - 1 >= 0 && y - 1 >= 0)       // 001
                    {                                   // 000
                        if (board[x-1,y-1] == 1)        // 000
                        {
                            neibourcount++;
                        }
                    }
                    if (x - 1 >= 0)                 //010
                    {                               //000
                        if (board[x - 1, y] == 1)   //000
                        {
                            neibourcount++;
                        }
                    }
                    if (x - 1 >= 0 && y + 1 <= 9)       // 100
                    {                                   // 000
                        if (board[x - 1, y + 1] == 1)   // 000
                        {
                            neibourcount++;
                        }
                    }
                    if (y + 1 <= 9)                     // 000
                    {                                   // 100
                        if (board[x, y + 1] == 1)       // 000
                        {
                            neibourcount++;
                        }
                    }
                    if (y + 1 <= 9 && x + 1 <= 9)       // 000
                    {                                   // 000
                        if (board[x+1, y + 1] == 1)     // 100
                        {
                            neibourcount++;
                        }
                    }
                    if (x + 1 <= 9)                         // 000
                    {                                       // 000
                        if (board[x + 1, y] == 1)           // 010
                        {
                            neibourcount++;
                        }
                    }
                    if (x + 1 <= 9 && y -1 >= 0)            // 000
                    {                                       // 000
                        if (board[x + 1, y-1] == 1)         // 001
                        {
                            neibourcount++;
                        }
                    }
                    if (y - 1 >= 0)                       // 000
                    {                                     // 001
                        if (board[x, y - 1] == 1)         // 000
                        {
                            neibourcount++;
                        }
                    }
                    if (board[x,y] == 1 && neibourcount >= 2 && neibourcount <= 3)
                    {
                        alivex.Add(x);
                        alivey.Add(y);
                    }
                    if (board[x, y] == 0 && neibourcount == 3)
                    {
                        alivex.Add(x);
                        alivey.Add(y);
                    }
                    
                    //Console.Write("{0}", board[x, (9 - y)]);
                }
                //Console.WriteLine();
            }

            //Console.WriteLine();

                for (int x = 0; x < board.GetLength(0); x++)
                {
                    for (int y = 0; y < board.GetLength(1); y++)
                    {
                        board[x, y] = 0;
                    }
                }
            int row = 0;
            int col = 0;

                for (int i = 0; i < alivex.Count; i++)
                {
                    row = alivex[i];
                    col = alivey[i];
                    board[row, col] = 1;

                }

                for (int x = 0; x < board.GetLength(0); x++)
                {

                    for (int y = 0; y < board.GetLength(1); y++)
                    {
                        Console.Write("{0}", board[x, (9 - y)]);
                    }
                    Console.WriteLine();
                }

        }
    }
}
