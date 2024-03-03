using System.Reflection.Emit;

namespace Homework3
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //TASK 1
            int firstNumber;
            while (true)
            {
                Console.WriteLine("Please enter first number");
                string input1 = Console.ReadLine();
                if (int.TryParse(input1, out firstNumber))
                {
                    break;
                }

                Console.WriteLine("You enter wrong number");
            }
            Console.WriteLine($" You enter number {firstNumber} ");


            int secondNumber;
            while (true)
            {
                Console.WriteLine("Please enter second number");
                string input2 = Console.ReadLine();
                if (int.TryParse(input2, out secondNumber))
                {
                    break;
                }

                Console.WriteLine("You enter wrong number");
            }
            Console.WriteLine($" You enter number {secondNumber} ");

            Console.WriteLine("Please enter some Operator : + - / *");
            string operation = Console.ReadLine();
            int sum = firstNumber + secondNumber;
            int multiply = firstNumber * secondNumber;
            int divide = firstNumber / secondNumber;
            int subtraction = firstNumber - secondNumber;

            switch (operation)
            {
                case "+":
                    Console.WriteLine($"Result is : {sum}");
                    break;
                case "-":
                    Console.WriteLine($"Result is : {subtraction}");
                    break;
                case "/":
                    Console.WriteLine($"Result is : {divide}");
                    break;
                case "*":
                    Console.WriteLine($"Result is : {multiply}");
                    break;
                default:
                    Console.WriteLine("Please enter correct operation");
                    break;
            }

            //TASK 2
            int thirdNumber;
            while (true)
            {
                Console.WriteLine("Please enter third number");
                string input3 = Console.ReadLine();
                if (int.TryParse(input3, out thirdNumber))
                {
                    break;
                }

                Console.WriteLine("You enter wrong number");
            }
            for (int j = 1; j > thirdNumber; j--)
            {
                    Console.WriteLine($"{j}");
                }



                int fourNumber;
                while (true)
                {
                    Console.WriteLine("Please enter four number");
                    string input4 = Console.ReadLine();
                    if (int.TryParse(input4, out fourNumber))
                    {
                        break;
                    }

                    Console.WriteLine("You enter wrong number");
                }
                for (int i = 1; i < fourNumber; i++)
                {
                    
                     Console.WriteLine($"{i}");
                    
                }

            }
        }
    }
}