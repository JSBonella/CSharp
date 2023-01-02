namespace Registration;

using System.Text.Json;
using Object;
public class Username {
    public static void Execute(string username) {                                        

        UsernameCheck(username);

        static void tryagain(string username) {

            string UserJsonR = File.ReadAllText("./Repository/UserList.json");
            List<User> users = JsonSerializer.Deserialize<List<User>>(UserJsonR);
            
            username = Console.ReadLine();
            var validUser = users.FirstOrDefault(v => v.Username == username);

                if (validUser == null) {
                Console.WriteLine("This username is not in use, continue the register.");
                } else {
                Console.WriteLine("This username already exists, try another.");
                tryagain(username);
                }

            UsernameCheck(username);

        }

        static void UsernameCheck(string username) {

            if (username.Length < 6 ) {
                Console.WriteLine("Invalid username, you need at least 6 characters. Try again!");
                tryagain(username);
            }
        }
    }
}