namespace Homework9
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Queue<int> allNumbers = new Queue<int>();
            while (true) { 
            Console.WriteLine("Please enter number");
            string inputNumber = Console.ReadLine();
            if (int.TryParse(inputNumber, out int number))
            {

               
                allNumbers.Enqueue(number);

                Console.WriteLine("Do you want to enter another number Y or N");
                string retry = Console.ReadLine();
                if (retry.ToLower() == "n")
                {
                        while (allNumbers.Count > 0)
                        {
                            int exportNumber = allNumbers.Dequeue();
                            Console.WriteLine(exportNumber);
                        }
                        break;
                    }
                    continue;   
            }
            else
                {
                    Console.WriteLine("Please enter number");
                }
               

            }
         
            
        }
    }
}
