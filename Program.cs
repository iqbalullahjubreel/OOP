// See https://aka.ms/new-console-template for more information
Console.WriteLine("Hello, World!"); 


// using MyConsole;

// internal class Program

     static void Main(string[] args)
    {
        Console.WriteLine("Hello, World!");
        User chat = new User();
        chat.LogIn();
        User Manager = new User();
        Account bank = new Account();
        bank.OpenAccount()
        Transaction Pos = new Transaction();
        {
            bool check = true;
            while (check)
            {
                Console.WriteLine("Welcome to Banking APP");
                Console.WriteLine("1. Register");
                Console.WriteLine("2.  Log In");
                Console.WriteLine("3.  open Account");
                Console.WriteLine("4. View Transaction");
                Console.WriteLine("5. Deposit");
                Console.WriteLine("6. Withdraw ");
                Console.WriteLine("7.  Transfer");
                Console.WriteLine("8.  view balance");
                Console.WriteLine("9.  close account");
                Console.WriteLine("choose an option");
                string option = Console.ReadLine();
                switch (option)
                {
                    case "1":
                        Manager.Register();
                        break;
                    case "2":
                        Manager.LogIn(); 
                        break;
                    case "3":
                        bank.OpenAccount();
                        break;
                    case "4":
                        Manager.Deposit();
                        break;
                    case "5":
                        Manager.Withdraw();
                        break;
                    case "6":
                        Manager.Transfer();
                        break;
                    case "7":
                        Manager.View balance();
                        break;
                    case "8":
                        Manager.close account();
                        break;
                    case "9":
                        Manager.ViewTransaction();
                        break;
                    default:
                        Console.WriteLine("Invalid option, try again");
                        break;
                }
            }
        }
    }

