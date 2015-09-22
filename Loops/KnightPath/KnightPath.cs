using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace KnightPath
{
    class KnightPath
    {
        static void Main(string[] args)
        {
            string move = Console.ReadLine();
            int[] board = new int[8];
            board[0] = 1;
            int bit = 0;
            int row = 0;
            int oldbit = 0;
            int oldrow = 0;
            
            while (move != "stop")
            {
                string[] moves = move.Split(' ');
                string firstmove = moves[0];
                string secondmove = moves[1];

                switch (firstmove)
                {
                    case "up":
                        row -= 2;
                        break;
                    case "down":
                        row += 2;
                        break;
                    case "left":
                        bit += 2;
                        break;
                    case "right":
                        bit -= 2;
                        break;
                     default:
                        break;
                }

                switch (secondmove)
                {
                    case "up":
                        row -= 1;
                        break;
                    case "down":
                        row += 1;
                        break;
                    case "left":
                        bit += 1;
                        break;
                    case "right":
                        bit -= 1;
                        break;
                    default:
                        break;
                }
                if (row >= 0 && row <= 7 && bit >= 0 && bit <= 7) //legal
                {
                    board[row] ^= (1 << bit);
                    oldbit = bit;
                    oldrow = row;
                }
                else
                {
                    row = oldrow;
                    bit = oldbit;
                }
                
                move = Console.ReadLine();
            }
            int zerocount = 0;
            foreach (var k in board)
            {
                if (k == 0)
                {
                    zerocount++;
                }
            }
            if (zerocount == board.Length)
            {
                Console.WriteLine("[Board is empty]");
            }
            else
            {
                foreach (var k in board)
                {
                    if (k != 0)
                    {
                        Console.WriteLine(k);
                    }
                }
            }
        }
    }
}
