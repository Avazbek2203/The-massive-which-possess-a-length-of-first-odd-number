using System;

class Program
{
    static void Main(string[] args)
    {
        Random random = new Random();
        int number = 0;
        Console.Write("Enter a number : ");
        int inputNumber = Convert.ToInt32(Console.ReadLine());
        int[] arr = new int[inputNumber];
        int oddNumber;
        while (inputNumber != 0)
        {
            oddNumber = inputNumber % 10;
            inputNumber = inputNumber / 10;
            if (oddNumber % 2 != 0)
            {
                number = oddNumber;
                
            }
        }
            Console.WriteLine($"New massive which possess a length of first odd number is {number} : ");
            for (int i = 1; i <= number; i++)
            {
                  arr[i] = random.Next(1,10);
            Console.WriteLine(arr[i]);

        }
         }
}
