namespace Registration;

using System.Text.Json;
using Intro;
using Object;

public class Users {
    public static void Execute() {

        string UserJsonR = File.ReadAllText("./Repository/UserList.json");
        List<User> users = JsonSerializer.Deserialize<List<User>>(UserJsonR);
        

        Console.WriteLine("Welcome, please complete the registration to be able to see all the tools of the page.");

        Console.WriteLine("What is the username you want to use?");
        Console.WriteLine("Minnimum of 6 characters to create the username, could user numbers and special characters as well.");

        tryagainUsername:

        string username = Console.ReadLine();
        var validUser = users.FirstOrDefault(v => v.Username == username);
        
            if (validUser == null) {
                Console.WriteLine("This username is valid, continue the register.");
            } else {
                Console.WriteLine("This username already exists, try another.");
                goto tryagainUsername;
            }

        Username.Execute(username);

        Console.WriteLine("Valid username, now enter the password.");

        Console.WriteLine("The password need a minimum of six characters and contain at least one number, one symbol and one uppercase letter.");
        
        tryagainPassword:

        var password = Console.ReadLine();
        var validPassword = users.FirstOrDefault(v => v.Password == password);
        
            if (validPassword == null) {
                Console.WriteLine("This username is valid, continue the register.");
            } else {
                Console.WriteLine("This username already exists, try another.");
                goto tryagainPassword;
            }

        Password.Execute(password);

        Console.WriteLine("Valid password.");

        users.Add(new User(username, password));

        var identacaoJson = new JsonSerializerOptions{WriteIndented = true};
        string UserJsonW = JsonSerializer.Serialize<List<User>>(users, identacaoJson);
        StreamWriter streamUser = new StreamWriter("./Repository/UserList.json");
        streamUser.WriteLine(UserJsonW);
        streamUser.Close();

        Console.WriteLine("Thanks for make the register in us garage, please enjoy the visit!!!");
        
        Introduction.Execute();
    }
}