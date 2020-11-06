using System;
using System.Collections.Generic;
using System.Linq;

namespace LeetCodeProblems
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] numbers = { 3, 1, 2, 10, 1 };
            int[] test = RunningSum(numbers);

            foreach (var n in test)
            {
                Console.WriteLine(n);
            }

        }
        #region MyRegion

        //public static int[] RunningSum(int[] nums)
        //{
        //    for (int i = 1; i < nums.Length; i++)
        //    {
        //       nums[i] = nums[i - 1] + nums[i];
        //    }
        //    return nums;
        //}
        #endregion
    }


}
