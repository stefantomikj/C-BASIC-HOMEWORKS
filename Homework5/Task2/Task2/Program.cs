namespace Task2
{
    internal class Program
    {
        static void Main(string[] args)
        {
            while (true)
            {
                Console.WriteLine(" Please enter a number");
                string input = Console.ReadLine(); 

                if (int.TryParse(input, out int number))
                {
                    string phrase = "Hello from SEDC Codecademy 2024";
                    string result = Substrings(phrase, number);

                    Console.WriteLine($"First {number} characters: {result}");
                    Console.WriteLine($"Length of the new string: {result.Length}");
                    break;  
                }
                else
                {
                    Console.WriteLine("Invalid input");
                }
               
            }
        }

        public static string Substrings(string inputPhrase, int num)
        {
            if (num >= 0 && num <= inputPhrase.Length)
            {
                return inputPhrase.Substring(0, num);
            }
            else
            {
                return "Number exceeds the length of the string.";
            }
        }
    }
}
