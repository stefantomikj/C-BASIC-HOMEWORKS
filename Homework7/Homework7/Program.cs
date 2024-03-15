using System;

class Program
{
    static void Main()
    {
        NumberStats();
    }

    static void NumberStats()
    {
        

        while (true)
        {
            Console.Write("Please enter a number: ");
            string userInput = Console.ReadLine();

            if (double.TryParse(userInput, out double number))
            {
                string numberType;
                if (number % 1 == 0)
                {
                    numberType = "Integer";
                }
                else
                {
                    numberType = "Decimal";
                }

                string numberSign;
                if (number > 0)
                {
                    numberSign = "Positive";
                }
                else if (number < 0)
                {
                    numberSign = "Negative";
                }
                else {
                    numberSign = "Zero";
                }
           

                string numberParity;
                if (number % 2 == 0)
                {
                    numberParity = "Even";
                }
                else
                {
                    numberParity = "Odd";
                }

                Console.WriteLine($"Stats for number: {number}");
                Console.WriteLine($"{numberSign}\n{numberType}\n{numberParity}");

                Console.Write("Press Y to try again or X to exit: ");
                string retry = Console.ReadLine();
                if (retry.ToLower() == "y")
                {
                    continue;   
                }
                break;
            }
            else
            {
                Console.WriteLine("Invalid input. Please enter number");
            }
        }
    }
}