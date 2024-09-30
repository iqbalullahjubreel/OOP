public class User()
{
        static List<User> users = [];

    public string FirstName { get; set; }
    public string LastName { get; set;}
    public string Email { get; set;}
    public DateTime DateOfBirth { get; set; }
    public string PhoneNumber {get;set;}
    public string Address {get;set;}
    public string State {get;set;}
    public string Country {get;set;}
    public string Gender {get;set;}
    public string PassWord {get;set;}

    public void RegisterUser()
    {
        Console.WriteLine("enter your firstname");
        string FirstName = Console.ReadLine();
        Console.WriteLine("enter your Lasttname");
        string LastName = Console.ReadLine();
        Console.WriteLine("enter your Email");
        string Email = Console.ReadLine();
        Console.WriteLine("enter your dateOfBirth");
        DateTime DateOfBirth = DateTime.Parse(Console.ReadLine());
        Console.WriteLine("enter your phoneNumber");
        string PhoneNumber = Console.ReadLine();
        Console.WriteLine("enter your Address");
        string Address = Console.ReadLine();
        Console.WriteLine("enter your State");
        string State = Console.ReadLine();
        Console.WriteLine("enter your Country");
        string Country = Console.ReadLine();
        Console.WriteLine("enter your Gender");
        string Gender = Console.ReadLine();
        Console.WriteLine("enter your Password");
        string PassWord = Console.ReadLine();

        User owner = new User();
        owner.FirstName = FirstName;
        owner.LastName = LastName;
        owner.Email = Email;
        DateOfBirth = DateOfBirth;
        owner.PhoneNumber = PhoneNumber;
        owner.Address = Address;
        owner.State = State;
        owner.Country = Country;
        owner.Gender = Gender;
        owner.PassWord = PassWord;

        users.Add(owner);
    }
    public bool LoginUser()
    {
        Console.WriteLine("Enter Email");
        string Email = Console.ReadLine();
        Console.WriteLine("Enter password to Log In");
        string PassWord = Console.ReadLine();
        Console.WriteLine("Re-Enter password for confirmation");
        string Confirmation = Console.ReadLine();
        foreach (var users in users)
        {
            if (users.Email==Email && users.PassWord==PassWord)
            {
                Console.WriteLine("LogIn Sucesfull");
                return true;
            }
        }
            Console.WriteLine("LogIn UnSucesfull");
        return false;
    }
}