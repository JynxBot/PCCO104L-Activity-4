using System;

class Program
{
    static void Main(string[] args)
    {
        int num1 = 0;
        string message = "";

        while (true)
        {
            Console.Write("Enter Something: ");
            string input = Console.ReadLine();

            if (input.ToLower() == "exit")
            {
                Console.WriteLine("Exiting the program...");
                break;
            }

            int number;
            bool isNumeric = int.TryParse(input, out number);

            if (isNumeric)
            {
                int num2 = int.Parse(input);
                int sum = num1 + num2;
                Console.WriteLine($"Sum of {num1} and {num2} is {sum}.");
                num1 = num2;
            }
            else
            {
                message += input + " ";
                Console.WriteLine("Message so far: " + message);
            }
        }
    }
}