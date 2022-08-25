using System;

namespace Homework2
{
    class Program
    {
        static void Main(string[] args)
        {
            //2nd task
            Console.WriteLine("2nd task");
            Console.Write("Type something: ");
            string input = Console.ReadLine();
            string reverseString = "";
            for(int i = input.Length -1 ; i>=0; i--)
            {
                reverseString += input[i];
            }
            Console.WriteLine("Reversed string is: " + reverseString);
            //3rd task 
            Console.WriteLine("3rd task");
            int[] numbers = { 10, 11, 12, 13, 14, 15, 16, 17, 18, 19, 20 };
            for (int i = 0; i < numbers.Length; i++)
            {
                if(numbers[i] % 2 == 0 || numbers[i] % 3 == 0)
                {
                    Console.WriteLine(numbers[i] + " is an even number");
                }
                else
                {
                    Console.WriteLine(numbers[i] + " is a prime number");
                }
            }
            //4th task 
            Console.WriteLine("4th task");
        }
    }
}
