using System.Net;
void DisplayMenu()
{
    Console.WriteLine("1. Log in.");
    Console.WriteLine("2. Register.");
    Console.WriteLine("3. exit.");
}
string GetUserLoggedIn()
{
    Console.Write("Enter your name: ");
    var firstName = Console.ReadLine();
    Console.Write("Enter your password: ");
    var pass = Console.ReadLine();
    var credentials = $"{firstName}:{pass}";
    return credentials;
}
bool IsUserRegistered(string credentials, List <string> userLists)
{
    var newUser = credentials.Split(':').First();
    foreach (var user in userLists)
    {
        var userName = user.Split(':').First();
        if (userName == newUser)
        {
            Console.WriteLine("You are logged in.");
            return true;
        }
    }
    return false;
}
bool IsUserAvailable(string credentials, List <string> userLists)
{
    var newUser = credentials.Split(':').First();
    foreach (var user in userLists)
    {
        var userName = user.Split(':').First();  
        if(newUser == userName)
        {
            Console.Clear();
            Console.WriteLine($"username {userName} is already taken.");
            return false;
        }
    }
    return true;
}
var usersList = new List<string>() {"guro:1234" };

while (true)
{
    DisplayMenu();
    Console.Write("Please enter the number you want: ");
    var num = Convert.ToInt32(Console.ReadLine());

    if (num == 1)
    {
        Console.Clear();
        var credentials = GetUserLoggedIn();
        Console.WriteLine(credentials);
        bool isUserregistered = IsUserRegistered(credentials, usersList);
        if(!isUserregistered)
        {
            Console.WriteLine("incorrect credentials. there is no user with this name.");
        }
    }
    else if (num == 2)
    {
        Console.Clear();
        var credentials = GetUserLoggedIn();
        Console.WriteLine(credentials);
        var isAvailable = IsUserAvailable(credentials, usersList);
        if(isAvailable)
        {
            usersList.Add(credentials);
            var userName = credentials.Split(':').First();
            Console.WriteLine($"welcome {userName}");
        }
    }
    else if (num == 3)
    {
        Console.Clear();
        break;
    }
}