
namespace TASK1
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int[] arrayOfNumbers = new int[0];
            while (true)
            {
                Console.WriteLine("Please enter a number:");
                string input = Console.ReadLine();
                
                if (int.TryParse(input, out int number))
                {
                    Array.Resize(ref arrayOfNumbers, arrayOfNumbers.Length + 1);
                    arrayOfNumbers[arrayOfNumbers.Length - 1] = number;
                }
                else
                {
                    Console.WriteLine("Invalid input, please try again");
                }

                Console.WriteLine("Do you want to enter another number? (y/n)");
                string input1 = Console.ReadLine();
                if (input1 != "y" && input1 != "Y")
                {
                    break;
                }

            }
            int sum = 0;
            for (int i = 0; i < arrayOfNumbers.Length; i++)
            {
                if (arrayOfNumbers[i] % 2 == 0)
                {
                    sum += arrayOfNumbers[i];
                    
                }
            }
            Console.WriteLine($"Sum of Even number are: {sum}");
        }
    }
}

