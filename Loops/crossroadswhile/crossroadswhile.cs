using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace crossroadswhile
{
    class crossroadswhile
    {
        static void Main(string[] args)
        {

            int n = int.Parse(Console.ReadLine());
            int[] board = new int[n];

            string input = Console.ReadLine();
            List<string> coordinates = new List<string>();
            

            while (input != "end")
            {
                if (coordinates.Contains(input))
                {
                    coordinates.Remove(input);
                    continue;
                }
                coordinates.Add(input);
                input = Console.ReadLine();
            }
            List<int> lines = new List<int>();
            List<int> bits = new List<int>();

            for (int i = 0; i < coordinates.Count; i++)
            {
                string[] arr = coordinates[i].Split(' ');
                lines.Add(int.Parse(arr[0]));
                bits.Add(int.Parse(arr[1]));
            }


            int crossroads = lines.Count;
            for (int i = 0; i < lines.Count; i++)
            {
                int test = 0;
                int newline = lines[i];
                int newbit = bits[i];
                while (newline < board.Length && newbit >= 0)         //down and right
                {
                    if (newline != lines[i] && newbit != bits[i])
                    {
                        test = board[newline] >> (newbit);
                        test &= 1;
                        if (test == 1)
                        {
                            crossroads++;
                        }
                    }
                    board[newline] |= (1 << newbit);
                    newline++;
                    newbit--;
                }

                newline = lines[i];
                newbit = bits[i];
                test = 0;


                while (newline < board.Length && newbit < n)         //down and left
                {
                    if (newline != lines[i] && newbit != bits[i])
                    {
                        test = board[newline] >> (newbit);
                        test &= 1;
                        if (test == 1)
                        {
                            crossroads++;
                        }
                    }
                    board[newline] |= (1 << newbit);
                    newline++;
                    newbit++;
                    
                }

                newline = lines[i];
                newbit = bits[i];
                test = 0;


                while (newline >= 0 && newbit < n)              //up and left
                {
                    if (newline != lines[i] && newbit != bits[i])
                    {
                        test = board[newline] >> (newbit);
                        test &= 1;
                        if (test == 1)
                        {
                            crossroads++;
                        }
                    }
                    board[newline] |= (1 << newbit);
                    newline--;
                    newbit++;
                    
                }

                newline = lines[i];
                newbit = bits[i];
                test = 0;
                while (newline >= 0 && newbit >= 0)          //up and right
                {
                    if (newline != lines[i] && newbit != bits[i])
                    {
                        test = board[newline] >> (newbit);
                        test &= 1;
                        if (test == 1)
                        {
                            crossroads++;
                        }
                    }
                    board[newline] |= (1 << newbit);
                    newline--;
                    newbit--;
                    
                }
            }

  
                foreach (var c in board)
                {
                    Console.WriteLine((uint)c);
                }
                Console.WriteLine(crossroads);
            }
        }
    }

