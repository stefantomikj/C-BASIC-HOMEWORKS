using System.Collections.Generic;

namespace SwapNumbers
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enter the First number:");
            string input1 = Console.ReadLine();
            Console.WriteLine("Enter the Second number:");
            string input2 = Console.ReadLine();

            int number1;
            bool success1 = int.TryParse(input1, out number1);

            int number2;
            bool success2 = int.TryParse(input2, out number2);

            number1 = number1 + number2;
            number2 = number1 - number2;
            number1 = number1 - number2;
            Console.WriteLine($"first number {number1}");
            Console.WriteLine($"second number {number2}");
        }
    }
}
