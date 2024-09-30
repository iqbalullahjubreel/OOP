// // // // See https://aka.ms/new-console-template for more information
// // // Console.WriteLine("Hello, World!"); 



// // //         Console.WriteLine("Hello, World!");
        
// // //         User Manager = new User();
// // //         Account bank = new Account();
// // //             bool check = true;
// // //             while (check)
// // // {
// // //                 Console.WriteLine("Welcome to Banking APP");
// // //                 Console.WriteLine("1. Register");
// // //                 Console.WriteLine("2.  Log In");
// // //                 Console.WriteLine("3.  open Account");
// // //                 Console.WriteLine("4. View Transaction");
// // //                 Console.WriteLine("5. Deposit");
// // //                 Console.WriteLine("6. Withdraw ");
// // //                 Console.WriteLine("7.  Transfer");
// // //                 Console.WriteLine("8.  view balance");
// // //                 Console.WriteLine("9.  close account");
// // //                 Console.WriteLine("choose an option");
// // //                 string option = Console.ReadLine();
// // //                 switch (option)
// // //     {
// // //                     case "1":
// // //                         Manager.Register();
// // //                         break;
// // //                     case "2":
// // //                         Manager.LogIn(); 
// // //                         break;
// // //                     case "3":
// // //                         bank.OpenAccount();
// // //                         break;
// // //                     case "4":
// // //                         bank.Deposit();
// // //                         break;
// // //                     case "5":
// // //                         bank.Withdraw();
// // //                         break;
// // //                     case "6":
// // //                         bank.Transfer();
// // //                         break;
// // //                     case "7":
// // //                         bank.ViewBalance();
// // //                         break;
// // //                     case "8":
// // //                         bank.CloseAccount();
// // //                         break;
// // //                     case "9":
// // //                         bank.ViewTransaction();
// // //                         break;
// // //                     default:
// // //                         Console.WriteLine("Invalid option, try again");
// // //                         break;
// // //      }
// // // }


// // public class Account()
// // {
// //          List<Account> Owner = [];
// //     public string AccountNumber { get; set; }
// //     public string AccountName { get; set;}
// //     public string BVN { get; set; }
// //     public string NIN { get; set; }
// //     public decimal AccountBalance { get; set; }
// //     public DateTime DateOpened { get; set; }
// //     public string AccountType { get; set; }
// //     public string AccountStatus { get; set; }
// //     public string CardNumber { get; set; }
// //     public int Pin { get; set; }
// //     public string AccountHolder { get; set; }

// //     public Account()
// //     {

// //     }
// //      public Account(string AccountNumber, string accountName, string AccountHolder, string BVN, string NIN, string AccountType, int Pin)
// //     {
// //         AccountNumber = AccountNumber;
// //         AccountName = accountName;
// //         AccountHolder = AccountHolder;
// //         BVN = BVN;
// //         NIN = NIN;
// //         AccountType = AccountType;
// //         AccountBalance = 0.0m;
// //         DateOpened = DateTime.Now;
// //         AccountStatus = "Active";
// //         Pin = Pin;
// //     }   
// //     public void OpenAccount(User user)
// //     {
// //         Console.WriteLine("enter your Account type savings / current");
// //         string Accounttype = Console.ReadLine();
// //         Console.WriteLine("enter the name of the Accountholder");
// //         string AccountHolder = Console.ReadLine();
// //         Console.WriteLine("enter your BVN");
// //         string BVN = Console.ReadLine();
// //         Console.WriteLine("enter your NIN");
// //         string NIN = Console.ReadLine();
// //         Console.WriteLine("enter PIN");
// //         int Pin = int.Parse(Console.ReadLine());
// //         string AccountNumber = new Random().Next(100000, 99999999).ToString();
// //         string AccountName = $"{user.FirstName} {user.LastName}";

// //         Account account = new Account(AccountNumber, AccountName, user.Email, BVN, NIN, AccountType, Pin);
// //         Owner.Add(account);
// //         Console.WriteLine($"Account created successfully. Account Number: {AccountNumber}");

// //     }
// //         public void Deposit()
// //         {
// //             Console.WriteLine("enter amount you want to deposit");
// //             string send = Console.ReadLine();
// //             Console.WriteLine("enter the account number");
// //             string number = Console.ReadLine();
           
// //             Console.WriteLine("enter your pin");
// //             int pin = int.Parse(Console.ReadLine());

// //             Account owner = new Account();
// //             owner.Pin = Pin;
// //         }
// //         public void Withdraw()
// //         {    
// //             Console.WriteLine("enter your card number");
// //             string CardNumber = Console.ReadLine();
// //             Console.WriteLine("enter your pin");
// //             string Pin = Console.ReadLine();
// //             Account owner = new Account();
// //             owner.CardNumber = CardNumber;
// //             Pin = Pin;
// //         }
// //         public void Transfer ()
// //         {    
// //             Console.WriteLine("enter amount you want to send");
// //             string send = Console.ReadLine();
// //             Console.WriteLine("enter the account number");
// //             string number = Console.ReadLine();
// //             Console.WriteLine("enter the Account type");
// //             string AccountType = Console.ReadLine();
// //         }
// //         public void ViewBAlance()
// //         {
// //                 // string balance = Withdraw + Transfer-Deposit;
// //         }
// //         public void CloseAccount()
// //         {
// //             Console.WriteLine("Input 1: to exit this site");
// //             string logout = Console.ReadLine();
// //             if (logout=="1")
// //             {
// //                 // Account.Clear();
// //             }
// //         }

// //     internal void OpenAccount()
// //     {
// //         throw new NotImplementedException();
// //     }

// //     internal void ViewBalance()
// //     {
// //         throw new NotImplementedException();
// //     }
// // }
// // //     Console.WriteLine("enter your Account balance");
// //         //     string AccountBalance = Console.ReadLine();
// //         //     Console.WriteLine("enter the date opened");
// //         //     string DateOpened = Console.ReadLine();
// //         //     Console.WriteLine("enter your Account type");
// //         //     string AccountType = Console.ReadLine();
// //         //     Console.WriteLine("enter your Account status");
// //         //     string AccountStatus = Console.ReadLine();
            

// //         // Account owner = new Account();
// //         // owner.AccountBalance = AccountBalance;
// //         // owner.DateOpened = DateOpened;
// //         // owner.AccountType = AccountType;
// //         // owner.AccountStatus = AccountStatus;


// public class Transaction()
// {
//             // List<Transaction> Owner = [];
//     public DateTime? TransactionDate {get;set;}
//     public string? SendingAccount {get;set;}
//     public string? RecievingAccount {get;set;}
//     public string? TransactionReference {get;set;}
//     public string? TransactionStatus {get;set;}
//     public string? Narration {get;set;}
//     public string? TransactionAmount {get;set;}

//     public void ViewTransaction()
//     {
//         Console.WriteLine("input the transaction date");
//         DateTime TransactionDate = DateTime.Parse(Console.ReadLine());
//         Console.WriteLine("input sending account");
//         string SendingAccount = Console.ReadLine();
//         Console.WriteLine("input the Recieving account");
//         string RecievingAccount = Console.ReadLine();
//         Console.WriteLine("input the transaction reference");
//         string TransactionReference = Console.ReadLine();
//         Console.WriteLine("input the transaction status");
//         string TransactionStatus = Console.ReadLine();
//         Console.WriteLine("input the Narration");
//         string Narration = Console.ReadLine();
//         Console.WriteLine("input the transaction amount");
//         string TransactionAmount = Console.ReadLine();

//         Transaction owner = new Transaction();
//         TransactionDate = TransactionDate;
//         owner.SendingAccount = SendingAccount;
//         owner.RecievingAccount = RecievingAccount;
//         owner.TransactionReference = TransactionReference;
//         owner.TransactionStatus = TransactionStatus;
//         owner.Narration = Narration;
//         owner.TransactionAmount = TransactionAmount;
//     }
// }
