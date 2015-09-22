using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace EncryptedMatrix
{
    class EncryptedMatrix
    {
        static void Main(string[] args)
        {
            string word = Console.ReadLine();
            char diagonal = char.Parse(Console.ReadLine());
            int[] nums = new int[word.Length];

            for (int i = 0; i < word.Length; i++)
            {
                nums[i] = word[i] % 10;
            }
            int[] dupnums = new int[nums.Length];

            for (int i = 0; i < nums.Length; i++)
            {
                dupnums[i] = nums[i];
            }

            for (int i = 0; i < nums.Length; i++)
            {
                if (nums[i] % 2 == 0)
                {
                    nums[i] *= nums[i];
                }
                else
                {
                    if (i > 0)
                    {
                        nums[i] += dupnums[i - 1];   
                    }
                    if (i < nums.Length - 1)
                    {
                        nums[i] += dupnums[i + 1];   
                    }
                }
            }

            StringBuilder numbers = new StringBuilder();

            for (int i = 0; i < nums.Length; i++)
            {
                numbers.Append(nums[i]);
            }
           
            int[,] matrix = new int[numbers.Length, numbers.Length];

         
            if (diagonal == '/')
            {
                int col = numbers.Length - 1;
                for (int i = 0; i < numbers.Length; i++)
                {
                    matrix[col, i] = (char)numbers[i];
                    col--;
                }
            }

            if (diagonal == '\\')
            {
                int col = numbers.Length - 1;
                int row = 0;
                for (int i = 0; i < numbers.Length; i++)
                {
                    matrix[row, i] = (char)numbers[i];
                    col--;
                    row++;
                }
            }
            
            for (int i = 0; i < numbers.Length; i++)
            {
                for (int j = 0; j < numbers.Length; j++)
                {
                    if (matrix[i,j] != 0)
                    {
                        Console.Write("{0,2}",(char)matrix[i,j]);
                    }
                    else
	                {
                        Console.Write("{0,2}", 0);
	                }
                    
                }
                Console.WriteLine();
            }
        }
    }
}
