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
            for (int i = input.Length - 1; i >= 0; i--)
            {
                reverseString += input[i];
            }
            Console.WriteLine("Reversed string is: " + reverseString);
            ////3rd task 
            Console.WriteLine("3rd task");
            int[] numbers = { 10, 11, 12, 13, 14, 15, 16, 17, 18, 19, 20 };
            for (int i = 0; i < numbers.Length; i++)
            {
                if (numbers[i] % 2 == 0 || numbers[i] % 3 == 0)
                {
                    Console.WriteLine(numbers[i] + " is an even number");
                }
                else
                {
                    Console.WriteLine(numbers[i] + " is a prime number");
                }
            }
            ////1st task 
            Console.WriteLine("1st task");
            for (int i = 0; i < 100; i++)
            {
                Console.WriteLine($"positive = {i} and negative = {-i}");
            }


            //4th task 
            Console.WriteLine("4th task");
            bool flag = true;
            int[] inputNumbers = new int[0];
            int increment = 0;


            do
            {
                Console.WriteLine("Please enter the number...\n");
                int num = Convert.ToInt32(Console.ReadLine());
                Array.Resize(ref inputNumbers, inputNumbers.Length + 1);
                inputNumbers[increment] = num;
                int[] tekEdedler = new int[1];
                increment++;
                Console.WriteLine("Would you like to continue?");
                string answer = Console.ReadLine();
                if (answer != "y" && answer != "Y")
                {
                    flag = false;
                    Console.WriteLine("exiting ...");
                    for (int i = 0; i < inputNumbers.Length; i++)
                    {
                        if (inputNumbers[i] % 2 != 0)
                        {
                            tekEdedler[tekEdedler.Length - 1] = inputNumbers[i];
                            Array.Resize(ref tekEdedler, tekEdedler.Length + 1);
                        }
                    }
                    int min = tekEdedler[0];
                    int max = 0;
                    for (int i = 0; i < tekEdedler.Length; i++)
                    {
                        if (tekEdedler[i] < min)
                        {
                            min = tekEdedler[i];
                        }
                        else if (tekEdedler[i] > max)
                        {
                            max = tekEdedler[i];
                        };

                    }
                    Console.WriteLine("Final result is " + (max - min));
                }

            } while (flag);

        }
    }
}
