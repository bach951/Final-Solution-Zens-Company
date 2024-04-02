using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MiniMaxSum
{
    public static class SplitString
    {
        public static int[] StringUtils()
        {
            Console.WriteLine("Please enter 5 numbers: ");
            string input = Console.ReadLine();
            string[] numberStrings = input.Split(new char[] { ' ' }, StringSplitOptions.RemoveEmptyEntries);
            if (numberStrings.Length != 5)
            {
                Console.WriteLine("The string must contain exactly 5 numbers, each number separated by a space");
                Console.WriteLine();
                return null;
            }
            int[] numbers = new int[numberStrings.Length];
            for (int i = 0; i < numberStrings.Length; i++)
            {
                if (!int.TryParse(numberStrings[i], out numbers[i]))
                {
                    Console.WriteLine("The string must contain exactly 5 numbers, each number separated by a space");
                    Console.WriteLine();
                    return null;
                }
            }
            return numbers;
        }
    }
}
