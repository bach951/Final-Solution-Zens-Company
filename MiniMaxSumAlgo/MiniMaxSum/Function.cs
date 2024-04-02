using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MiniMaxSum
{
    public static class Function
    {
        public static void MiniMaxSum(int[] nums)
        {
            var miniMaxSumArr = new int[nums.Length];
            for (int i = 0; i < nums.Length; i++)
            {
                miniMaxSumArr[i] = nums[i];
            }
            Array.Sort(miniMaxSumArr);
            int minSum = miniMaxSumArr[0] + miniMaxSumArr[1] + miniMaxSumArr[2] + miniMaxSumArr[3];
            Array.Reverse(miniMaxSumArr);
            int maxSum = miniMaxSumArr[0] + miniMaxSumArr[1] + miniMaxSumArr[2] + miniMaxSumArr[3];
            Console.WriteLine(minSum + " " + maxSum);
        }

        public static void TotalOfArray(int[] nums)
        {
            int totalOfArray = 0;
            for (int i = 0; i < nums.Length; i++)
            {
                totalOfArray += nums[i];
            }
            Console.WriteLine("Total of array: " + totalOfArray);
        }

        public static void MinInArray(int[] nums)
        {
            int minInArray = nums[0];
            for (int i = 0; i < nums.Length; i++)
            {
                if (nums[i] < minInArray)
                {
                    minInArray = nums[i];
                }
            }
            Console.WriteLine("Min of array: " + minInArray);
        }

        public static void MaxInArray(int[] nums)
        {
            int maxInArray = nums[0];
            for (int i = 0; i < nums.Length; i++)
            {
                if (nums[i] > maxInArray)
                {
                    maxInArray = nums[i];
                }
            }
            Console.WriteLine("Max of array: " + maxInArray);
        }

        public static void EvenElementsInArray(int[] nums)
        {
            List<int> evenElements = new List<int>();
            for (int i = 0; i < nums.Length; i++)
            {
                if (nums[i] % 2 == 0)
                {
                    evenElements.Add(nums[i]);
                }
            }
            if(evenElements.Any())
            {
                Console.Write("Even elements in array: ");
            }
            foreach (int i in evenElements)
            {
                Console.Write(i + " ");
            }
            Console.WriteLine();
        }

        public static void OddElementsInArray(int[] nums)
        {
            List<int> oddElements = new List<int>();
            for (int i = 0; i < nums.Length; i++)
            {
                if (nums[i] % 2 != 0)
                {
                    oddElements.Add(nums[i]);
                }
            }
            if (oddElements.Any())
            {
                Console.Write("Odd elements in array: ");
            }
            foreach (int o in oddElements)
            {
                Console.Write(o + " ");
            }
            Console.WriteLine();
        }
    }
}
