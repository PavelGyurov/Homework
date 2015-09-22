using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace DecryptMessage
{
    class DecryptMessage
    {
        static void Main(string[] args)
        {
            string input = Console.ReadLine();
            int messageCount = 0;
            List<string> messages = new List<string>();

            while (input != "START" && input != "start")
            {
                input = Console.ReadLine();
            }
            while (true)
            {
                input = Console.ReadLine();

                if (input == "START" || input == "start")
                {
                    continue;
                }
                if (string.IsNullOrWhiteSpace(input))
                {
                    continue;
                }

                if (input == "END" || input == "end")
                {
                    break;
                }

                char[] characters = input.ToCharArray();

                for (int i = 0; i < characters.Length; i++)
                {
                    if ((int)characters[i] >= 65 && (int)characters[i] <= 77)
                    {
                        characters[i] += (char)13;
                        continue;
                    }
                    else if ((int)characters[i] >= 97 && (int)characters[i] <= 109)
                    {
                        characters[i] += (char)13;
                        continue;
                    }
                    else if ((int)characters[i] >= 78 && (int)characters[i] <= 90)
                    {
                        characters[i] -= (char)13;
                        continue;
                    }
                    else if ((int)characters[i] >= 110 && (int)characters[i] <= 122)
                    {
                        characters[i] -= (char)13;
                        continue;
                    }

                }
                Array.Reverse(characters);

                input = new string(characters);


                input = input.Replace('+', ' ');
                input = input.Replace('%', ',');
                input = input.Replace('&', '.');
                input = input.Replace('#', '?' );
                input = input.Replace('$', '!');


                messages.Add(input);
                messageCount++;

            }



            if (messageCount == 0)
            {
                Console.WriteLine("No message received.");
            }
            else
            {
                Console.WriteLine("Total number of messages: {0}", messageCount);
                foreach (var message in messages)
                {
                    Console.WriteLine(message);
                }
            }
        }
    }
}
