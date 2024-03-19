namespace Homework8
{
    public class Program
    {

        public static Customer AuthenticateCustomer()
        {
            Console.WriteLine("Welcome to the ATM");
            Console.Write("Please enter your card number: 1234-1234-1234-1234 ");
            string cardNumber = Console.ReadLine();
            Console.Write("Enter PIN: 4 digits ");
            string pin = Console.ReadLine();

            foreach (var customer in customers)
            {
                if (customer.CardNumber == cardNumber && customer.Pin == pin)
                    return customer;
            }

            return null;
        }

        public static void Main()
        {
            var customer = AuthenticateCustomer();
            if (customer != null)
            {
                Console.WriteLine($"Welcome {customer.FullName}");

                while (true)
                {
                    Console.WriteLine("What would you like to do:");
                    Console.WriteLine("1) Check Balance");
                    Console.WriteLine("2) Cash Withdrawal");
                    Console.WriteLine("3) Cash Deposit");

                    string choice = Console.ReadLine();


                    switch (choice)
                    {
                        case "1":
                            Console.WriteLine($"Your current balance is ${customer.Balance}");
                            break;
                        case "2":
                            Console.Write("Enter withdrawal amount:");
                            if (int.TryParse(choice, out int withdrawalAmount))
                            {
                                if (withdrawalAmount <= customer.Balance)
                                {
                                    customer.Balance -= withdrawalAmount;
                                    Console.WriteLine($"You withdrew ${withdrawalAmount}. You have ${customer.Balance} left on your account.");
                                }
                                else
                                {
                                    Console.WriteLine("Insufficient funds.");
                                }

                            }
                            else
                            {
                                Console.WriteLine("Invalid input. Please enter a valid amount.");
                            }



                            break;
                        case "3":
                            Console.Write("Enter deposit amount");
                            if (int.TryParse(choice, out int depositAmount))
                            {
                                customer.Balance += depositAmount;
                                Console.WriteLine($"Your new balance is ${customer.Balance}.");
                            }
                            else
                            {
                                Console.WriteLine("Invalid input. Please enter a valid amount.");
                            }
                            break;
                        default:
                            Console.WriteLine("Invalid choice. Please select a valid choice.");
                            break;
                    }
                    Console.Write("Do you want to perform another transaction? (Y/N): ");
                    if (Console.ReadLine().ToUpper() == "N")
                    {
                        Console.WriteLine("Thank you for using the ATM");
                        break;
                    }
                }
            }
            else
            {
                Console.WriteLine("Authentication failed");
            }
        }
        public class Atm
        {
            public List<Customer> customers = new List<Customer>
                {
            new Customer("1234-4567-4579-6597", "5876", "Stefan Tomik", 8000),
            new Customer("5678-5555-7892-2763", "0476", "Trpe Trpeski", 12000),
            new Customer("4627-7893-7924-8764", "0476", "Zoran Zorevski", 12000)
                };

        }
    }
}




