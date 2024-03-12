using System.Runtime.InteropServices;

namespace Homework6
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enter dog name");
            string nameInput = Console.ReadLine();

            Console.WriteLine("Enter dog breed");
            string breedInput = Console.ReadLine();

            Console.WriteLine("Enter dog color");
            string colorInput = Console.ReadLine();

            
            Console.WriteLine("Please choise 1 or 2 or 3");
            string choiseinput = Console.ReadLine();

            Dog object1 = new Dog(nameInput, breedInput, colorInput);

            while (true)
            {

                if (choiseinput == "1")
                {
                    Console.WriteLine(object1.Eat());
                }
                else if (choiseinput == "2")
                {
                    Console.WriteLine(object1.Play());

                }
                else if (choiseinput == "3")
                {
                    Console.WriteLine(object1.ChaseTail());

                }
                else
                {
                    Console.WriteLine("Wrong choise");
                  
                }
                break;
            }
        }   
    }
}
