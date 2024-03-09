using System.Reflection.Metadata.Ecma335;

namespace TASK2
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string[] studentsG1 = new string [] { "Petko", "Stanko", "Darko", "Trpe", "Ivica" };
            string[] studentsG2 = new string[] { "Trajce", "Ace", "Bojan", "Stefan", "Zoran" };

            Console.WriteLine("Please write 1 or 2");
            string input = Console.ReadLine();
        

            if(!int.TryParse(input, out int number)) {

                Console.WriteLine("Invalid input, please try again");
            }
            else if(number == 1) {
                foreach (string student in studentsG1)
                {
                    Console.WriteLine($"The Students in G1 are: {student}");
                }

            }
            else if (number == 2){
                foreach (string student in studentsG2)
                {
                    Console.WriteLine($"The Students in G2 are: {student}");
                }

            }
        }
    }
}
