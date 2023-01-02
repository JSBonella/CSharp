namespace Login;

using System.Text.Json;
using Intro;
using Object;

public class Login {
    public static void Execute() {

        string UserJsonR = File.ReadAllText("./Repository/UserList.json");
        List<User> users = JsonSerializer.Deserialize<List<User>>(UserJsonR);

        Console.WriteLine("Please tell me the username and the password to login.");
        Console.Write("Username: ");

        string validUsername = Console.ReadLine();
        var validUser = users.FirstOrDefault(v => v.Username == validUsername);
            
            if(validUser == null) {
                Console.WriteLine("Wrong username, please try again!");
                Execute();
            }

        Console.Write("Password: ");
        string validPassword = Console.ReadLine();

            if (validUser.Password == validPassword) {
                Console.WriteLine("Correct password, you are logged in!");
            } else {
                Console.WriteLine("Wrong password, please try again!");
                Execute();
            }
                
        Introduction.Execute();
    }
}
