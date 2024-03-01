namespace AverageNumber
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enter the First number:");
            string input1 = Console.ReadLine();
            Console.WriteLine("Enter the Second number:");
            string input2 = Console.ReadLine();
            Console.WriteLine("Enter the third number:");
            string input3 = Console.ReadLine();
            Console.WriteLine("Enter the fourth number:");
            string input4 = Console.ReadLine();
            
            int number1;
            bool success1 = int.TryParse(input1, out number1);

            int number2;
            bool success2 = int.TryParse(input2, out number2);

            int number3;
            bool success3 = int.TryParse(input3, out number3);

            int number4;
            bool success4 = int.TryParse(input4, out number4);

            int result = (number1 + number2 + number3 + number4) / 4;
            Console.WriteLine($"The result is {result}");


        }
    }
}
