using System.Reflection.Metadata.Ecma335;

namespace TASK4
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Please write name");
            string name = Console.ReadLine();

            string[] namesArray = new string[0];
            Array.Resize(ref namesArray, namesArray.Length + 1);
            namesArray[namesArray.Length - 1] = name;

            while (true)
            {
               Console.WriteLine("Do you want enter another name(Y / N)");
                string input = Console.ReadLine();

                if(input != "Y" && input!="N")
                {
                    Console.WriteLine("Wrong input");
                }
                
                else if (input == "Y")
                {
                    Console.WriteLine("Please write name");
                    name = Console.ReadLine();
                    
                    Array.Resize(ref namesArray, namesArray.Length + 1);
                    namesArray[namesArray.Length - 1] = name;
                      
                }
                else if(input == "N") {
                    break;  
                }

            }
                for (int i = 0; i < namesArray.Length; i++)
                {
                    Console.WriteLine(namesArray[i]);

                }

            
        }


    }
}
