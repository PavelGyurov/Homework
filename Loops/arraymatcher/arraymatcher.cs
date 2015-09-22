using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace arraymatcher
{
    class arraymatcher
    {
        static void Main(string[] args)
        {
            string input = Console.ReadLine();

            string first = input.Split('\\')[0];
            string second = input.Split('\\')[1];
            string command = input.Split('\\')[2];

            char[] arr1 = first.ToCharArray();
            char[] arr2 = second.ToCharArray();
            
            
            List<char> matching = new List<char>();
            List<char> leftunique = new List<char>();
            List<char> rightunique = new List<char>();

            foreach (var c in arr1)
            {
                if (arr2.Contains(c))
                {
                    matching.Add(c);
                }
                else
                {
                    leftunique.Add(c);
                }
            }

            foreach (var c in arr2)
            {
                if (arr1.Contains(c))
                {
                    continue;
                }
                else
                {
                    rightunique.Add(c);
                }
            }
            matching.Sort();
            rightunique.Sort();
            leftunique.Sort();

            switch (command)
            {
                case "join":
                    foreach (var c in matching)
                    {
                        Console.Write(c);
                    }
                    break;
                case "left exclude":
                    foreach (var c in rightunique)
                    {
                        Console.Write(c);
                    }
                    break;
                case "right exclude":
                    foreach (var c in leftunique)
                    {
                        Console.Write(c);
                    }
                    break;
                default:
                    break;
            }
            Console.WriteLine();
        }
    }
}
