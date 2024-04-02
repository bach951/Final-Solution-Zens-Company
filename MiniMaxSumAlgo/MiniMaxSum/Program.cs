using MiniMaxSum;
using System;

class Program
{
    public static void Main(string[] args)
    {
        int[] arrayAfterSplit = new int[5];
        while (true)
        {
            var arrays = SplitString.StringUtils();
            if (arrays != null)
            {
                arrayAfterSplit = arrays.ToArray();
                break;
            }
        }
        while (true)
         {
            if (arrayAfterSplit.Length > 0)
            {
                Console.Write("Array: "); 
                for (int i = 0; i < arrayAfterSplit.Length; i++)
                {
                    Console.Write(arrayAfterSplit[i] + " ");
                }
                Console.WriteLine();
            }
            Console.WriteLine("========MENU========");
            Console.WriteLine("1. Minimum Sum and Max Sum of array");
            Console.WriteLine("2. Total of array");
            Console.WriteLine("3. Min of array");
            Console.WriteLine("4. Max of array");
            Console.WriteLine("5. Even Elements of array");
            Console.WriteLine("6. Odd Elements of array");
            Console.WriteLine("7. Enter another array");
            Console.WriteLine("8. Exit the program");
            Console.Write("Choose 1 of the options: ");

            string choice = Console.ReadLine();
            switch (choice)
            {
                case "1":
                    Function.MiniMaxSum(arrayAfterSplit);
                    break;
                case "2":
                    Function.TotalOfArray(arrayAfterSplit);
                    break;
                case "3":
                    Function.MinInArray(arrayAfterSplit);
                    break;
                case "4":
                    Function.MaxInArray(arrayAfterSplit);
                    break;
                case "5":
                    Function.EvenElementsInArray(arrayAfterSplit);
                    break;
                case "6":
                    Function.OddElementsInArray(arrayAfterSplit);
                    break;
                case "7":
                    while (true)
                    {
                        var arrays = SplitString.StringUtils();
                        if (arrays != null)
                        {
                            arrayAfterSplit = arrays.ToArray();
                            break;
                        }
                    }
                    break;
                case "8":
                    return;
                default:
                    break;

            }
            Console.WriteLine();
            Console.WriteLine("Press enter to continue...");
            Console.ReadLine();
            Console.Clear();
        }
    }
}
