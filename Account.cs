public class Account
{
    // 
    static List<Account> accounts = new List<Account>();    
    public string AccountNumber { get; set; }
    public string BVN { get; set; }
    public string NIN { get; set; }
    public string AccountName { get; set; }
    public decimal Balance { get; private set; }
    public DateTime DateOpened { get; set; }
    public string AccountType { get; set; }
    public string AccountStatus { get; set; }
    public string AccountHolder { get; set; }
    public int Pin {get; set;}
    
    public Account()
    {
        
    }

    public Account(string accountNumber, string accountName, string accountHolder, string bvn, string nin, string accountType, int pin)
    {
        AccountNumber = accountNumber;
        AccountName = accountName;
        AccountHolder = accountHolder;
        BVN = bvn;
        NIN = nin;
        AccountType = accountType;
        Balance = 0.0m;
        DateOpened = DateTime.Now;
        AccountStatus = "Active";
        Pin = pin;
    }

    public void OpenAccount(User user)
    {
        Console.WriteLine("Enter account type (Savings/Current): ");
        string accountType = Console.ReadLine();
        string accountNumber = new Random().Next(100000, 999999).ToString();
        Console.WriteLine("Enter BVN: ");
        string bvn = Console.ReadLine();
        Console.WriteLine("Enter NIN: ");
        string nin = Console.ReadLine();
        Console.WriteLine("Enter PIN: ");
        int pin = int.Parse(Console.ReadLine());
        string accountName = $"{user.FirstName} {user.LastName}";
        Account account = new Account(accountNumber, accountName, user.Email, bvn, nin, accountType, pin);
        accounts.Add(account);
        Console.WriteLine($"Account created successfully. Account Number: {accountNumber}");
    }

    public void ViewUserAccounts(User user)
    {
        //empty list of user accounts
        List<Account> userAccounts = new List<Account>();
       foreach(var account in accounts)
       {
         if(account.AccountHolder == user.Email)
         {
            userAccounts.Add(account);
         }
       }

       if(userAccounts.Count == 0)
       {
            Console.WriteLine("Currently, you do not have any account");
       }
       else
       {
            Console.WriteLine("LIST OF MY ACCOUNTS");
            foreach(var account in userAccounts)
            {
                Console.WriteLine($"Account Number: {account.AccountNumber}, Balance: {account.Balance}, Status: {account.AccountStatus}");
            }
       }
    }

    public void Deposit(User user)
    {
        Console.Write("Enter account number: ");
        string accountNumber = Console.ReadLine();
        //check the account
        foreach(var account in accounts)
        {
            //check if the account exist and the user is the owner of the account
            if(account.AccountNumber == accountNumber && account.AccountHolder == user.Email)
            { 
                if(account.AccountStatus == "Active")
                {
                    Console.Write("Enter deposit amount: ");
                    decimal amount = decimal.Parse(Console.ReadLine());
                    Console.Write("Enter pin : ");
                    int pin = int.Parse(Console.ReadLine());
                    if(account.Pin == pin)
                    {
                         account.Balance += amount;
                        Console.WriteLine("Deposit successful.");
                        return;
                    }
                    else
                    {
                        Console.WriteLine("Invalid Pin");
                        return;
                    }
                    
                }
                else
                {
                    Console.WriteLine("Account is InActive. Transaction can not be completed");
                    return;
                }
            }
        }
        Console.WriteLine("Account is invalid!");
    }
}