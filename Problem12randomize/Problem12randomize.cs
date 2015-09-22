using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Problem12randomize
{
    class Problem12randomize
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());
            List<int> nums = new List<int>();
            Random rng = new Random();
            for (int i = 1; i <= n; i++)
            {
                nums.Add(i);
            }
            while (nums.Count > 0)
            {
                int rand = rng.Next(0, nums.Count);
                Console.Write(nums[rand] + " ");
                nums.Remove(nums[rand]);
            }
            Console.WriteLine();
        }
    }
}
