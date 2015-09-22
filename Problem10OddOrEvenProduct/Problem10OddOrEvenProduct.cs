using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Problem10OddOrEvenProduct
{
    class Problem10OddOrEvenProduct
    {
        static void Main(string[] args)
        {
            string input = Console.ReadLine();
            int[] nums = input.Split(' ').Select(n => Convert.ToInt32(n)).ToArray();
            int oddProduct = 1;
            int evenProduct = 1;
            for (int i = 0; i < nums.Length; i+=2)
            {
                evenProduct *= nums[i];
            }
            
            for (int i = 1; i < nums.Length; i += 2)
            {
                oddProduct *= nums[i];
            }
            if (evenProduct == oddProduct)
            {
                Console.WriteLine("yes \nproduct = {0}", oddProduct);
            }
            else
            {
                Console.WriteLine("no \nodd product = {0} \neven product = {1}", oddProduct, evenProduct);
            }
        }
    }
}
