using System;

namespace Task_1
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enter your birthday (DD-MM-YYYY):");
            string inputDate = Console.ReadLine();

            int age = AgeCalculator(inputDate);
            Console.WriteLine($"User age is: {age}");
        }

       public static int AgeCalculator(string inputBirthDay)
        {
            DateTime today = DateTime.Now;            
            DateTime birthDate;

            DateTime.TryParse(inputBirthDay, out birthDate);
            int age = today.Year - birthDate.Year;
            return age; 
            

        }
    }
}


