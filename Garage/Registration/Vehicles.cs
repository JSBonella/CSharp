namespace Registration;

using Intro;
using Object;
using System.Text.Json;

public class Vehicles {
    public static void Execute() {

        Console.WriteLine("Hello, here we are going to put your vehicle in us list, please complete the questions below.");
        
        Console.WriteLine("What is the type of the vehicle you want to register?");
        Console.WriteLine("Car, Bike, Van, Truck.");
            string type = Console.ReadLine();
        
        Console.WriteLine("What is the model of your vehicle?");
            string model = Console.ReadLine();
        
        Console.WriteLine("What is the year of the vehicle?");
            int year = int.Parse(Console.ReadLine());
        
        Console.WriteLine("What is the color of the vehicle?");
            string color = Console.ReadLine();
        
        Console.WriteLine("What is the price you want to sell your vehicle?");
            decimal price = decimal.Parse(Console.ReadLine());

        switch(type) {

            case "Car": 

                string CarJsonR = File.ReadAllText("./Repository/CarList.json");
                List<Vehicle> cars = JsonSerializer.Deserialize<List<Vehicle>>(CarJsonR);

                cars.Add(new Vehicle(type, model, year, color, price));

                var identacaoJson = new JsonSerializerOptions{WriteIndented = true};
                string CarJsonW = JsonSerializer.Serialize<List<Vehicle>>(cars, identacaoJson);
                StreamWriter streamCar = new StreamWriter("./Repository/CarList.json");
                streamCar.WriteLine(CarJsonW);
                streamCar.Close();

            break;

            case "Bike":

                string BikeJsonR = File.ReadAllText("./Repository/BikeList.json");
                List<Vehicle> bikes = JsonSerializer.Deserialize<List<Vehicle>>(BikeJsonR);

                bikes.Add(new Vehicle(type, model, year, color, price));

                identacaoJson = new JsonSerializerOptions{WriteIndented = true};
                string BikeJsonW = JsonSerializer.Serialize<List<Vehicle>>(bikes, identacaoJson);
                StreamWriter streamBike = new StreamWriter("./Repository/BikeList.json");
                streamBike.WriteLine(BikeJsonW);
                streamBike.Close();

            break;

            case "Van":

                string VanJsonR = File.ReadAllText("./Repository/VanList.json");
                List<Vehicle> vans = JsonSerializer.Deserialize<List<Vehicle>>(VanJsonR);

                vans.Add(new Vehicle(type, model, year, color, price));

                identacaoJson = new JsonSerializerOptions{WriteIndented = true};
                string VanJsonW = JsonSerializer.Serialize<List<Vehicle>>(vans, identacaoJson);
                StreamWriter streamVan = new StreamWriter("./Repository/VanList.json");
                streamVan.WriteLine(VanJsonW);
                streamVan.Close();

            break;

            case "Truck":

                string TruckJsonR = File.ReadAllText("./Repository/TruckList.json");
                List<Vehicle> trucks = JsonSerializer.Deserialize<List<Vehicle>>(TruckJsonR);

                trucks.Add(new Vehicle(type, model, year, color, price));

                identacaoJson = new JsonSerializerOptions{WriteIndented = true};
                string TruckJsonW = JsonSerializer.Serialize<List<Vehicle>>(trucks, identacaoJson);
                StreamWriter streamTruck = new StreamWriter("./Repository/TruckList.json");
                streamTruck.WriteLine(TruckJsonW);
                streamTruck.Close();

            break;

            default:
                Console.WriteLine("Type not detected, please try again.");
                Execute();
            break;

        }
        
        Console.WriteLine("Thanks for complete the questions, now your vehicle is registred is us page.");
        Console.WriteLine("Now you are redirected to the main page.");
        Introduction.Execute();

    }
}