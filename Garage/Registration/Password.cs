namespace Registration;

using System.Text.Json;
using Object;
public class Password{
    public static void Execute(string password) {
        
        PasswordCheck(password);
        
        static void tryagain(string password) {
            
            string UserJsonR = File.ReadAllText("./Repository/UserList.json");
            List<User> users = JsonSerializer.Deserialize<List<User>>(UserJsonR);
            
            password = Console.ReadLine();
            var validPassword = users.FirstOrDefault(v => v.Password == password);

                if (validPassword == null) {
                    Console.WriteLine("This password is not in use, continue the register.");
                } else {
                    Console.WriteLine("This password already exists, try another.");
                    tryagain(password);
                }

            PasswordCheck(password);
    
        }

        static void PasswordCheck(string password) {

        if(password.Length < 6) {
            Console.WriteLine("Invalid password, not enough characters, try again!");
            tryagain(password);
        }
               
        if(!password.Any(c => char.IsDigit(c))){
            Console.WriteLine("Invalid password, you need use one number at least, try again!");
            tryagain(password);
        }
                
        if(!password.Any(c => char.IsSymbol(c))) {
            Console.WriteLine("Invalid password, you need use one symbol at least, try again!");
            tryagain(password);
        }

        if(!password.Any(c => char.IsUpper(c))) {
            Console.WriteLine("Invalid password, you need use one letter in UpperCase at least, try again!");
            tryagain(password);
        }
        }    
    }
}
