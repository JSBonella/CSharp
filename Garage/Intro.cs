namespace Intro;

using Login;
using Registration;
using Research;
class Introduction {
    public static void Execute() {
        Console.WriteLine("Welcome to our garage, here you could find many vehicles to buy and put your to sell.");
        Console.WriteLine("What you want to do now?");
        Console.WriteLine("1 - Register");
        Console.WriteLine("2 - Login");
        Console.WriteLine("3 - Buy");
        Console.WriteLine("4 - Sell");

        var option = Console.ReadLine();

        switch (option) {
            case "1":
                Users.Execute();
            break;

            case "2":
                Login.Execute();
            break;

            case "3":
                Research.Execute();
            break;

            case "4":
                Vehicles.Execute();
            break;

            default:
                Console.WriteLine("Invalid option, please try again.");
                Introduction.Execute();
            break;
        }
    }
}