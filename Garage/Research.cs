namespace Research;

using Intro;
using Object;
using Login;
using System.Text.Json;
public class Research {
    public static void Execute() {

        Console.WriteLine("You are trying find a vehicle? Tell me the type you are looking for.");
        
        Console.WriteLine("Car, Bike, Van, Truck");
        var option = Console.ReadLine();

        switch(option) {

            case "Car":

                string CarJson = File.ReadAllText("./Repository/CarList.json");
                List<Vehicle> cars = JsonSerializer.Deserialize<List<Vehicle>>(CarJson);

                foreach (var car in cars) {   
                    Console.WriteLine($"{car.Model}");
                }

                    if (cars.Count == 0) {
                        Console.WriteLine("We do not have any trucks, we are going to redirect you to homepage.");
                        Login.Execute();
                    }
                
                Console.WriteLine("Which car you want see the full description?");
                var typeOfvehicle = Console.ReadLine();
                var vehicleChoiced = cars.FirstOrDefault(v => v.Model == typeOfvehicle);

                if (vehicleChoiced == null) {
                
                    Console.WriteLine("Wrong model, try again.");
                    Research.Execute();
                }   

                Console.WriteLine("The vehicle you had selected is:");
                Console.WriteLine($"Model : {vehicleChoiced.Model}");
                Console.WriteLine($"Year : {vehicleChoiced.Year}");
                Console.WriteLine($"Color : {vehicleChoiced.Color}");
                Console.WriteLine($"Price : ${vehicleChoiced.Price}");

                Console.ReadKey();

            break;
    
            case "Bike":

                string BikeJson = File.ReadAllText("./Repository/BikeList.json");
                List<Vehicle> bikes = JsonSerializer.Deserialize<List<Vehicle>>(BikeJson);

                foreach (var bike in bikes) {   
                    Console.WriteLine($"{bike.Model}");
                }

                    if (bikes.Count == 0) {
                        Console.WriteLine("We do not have any trucks, we are going to redirect you to homepage.");
                        Login.Execute();
                    }

                Console.WriteLine("Which bike you want see the full description?");
                typeOfvehicle = Console.ReadLine();
                vehicleChoiced = bikes.FirstOrDefault(v => v.Model == typeOfvehicle);

                if (vehicleChoiced == null) {
                
                    Console.WriteLine("Wrong model, try again.");
                    Research.Execute();
                }   

                Console.WriteLine($"Model : {vehicleChoiced.Model}");
                Console.WriteLine($"Year : {vehicleChoiced.Year}");
                Console.WriteLine($"Color : {vehicleChoiced.Color}");
                Console.WriteLine($"Price : {vehicleChoiced.Price}");

                Console.ReadKey();

            break;

            case "Van":

                string VanJson = File.ReadAllText("./Repository/VanList.json");
                List<Vehicle> vans = JsonSerializer.Deserialize<List<Vehicle>>(VanJson);

                foreach (var van in vans) {   
                    Console.WriteLine($"{van.Model}");
                }

                    if (vans.Count == 0) {
                        Console.WriteLine("We do not have any trucks, we are going to redirect you to homepage.");
                        Login.Execute();
                    }

                Console.WriteLine("Which van you want see the full description?");
                typeOfvehicle = Console.ReadLine();
                vehicleChoiced = vans.FirstOrDefault(v => v.Model == typeOfvehicle);

                if (vehicleChoiced == null) {
                
                    Console.WriteLine("Wrong model, try again.");
                    Research.Execute();
                }   

                Console.WriteLine($"Model : {vehicleChoiced.Model}");
                Console.WriteLine($"Year : {vehicleChoiced.Year}");
                Console.WriteLine($"Color : {vehicleChoiced.Color}");
                Console.WriteLine($"Price : {vehicleChoiced.Price}");

                Console.ReadKey();

            break;

            case "Truck":
                
                string TruckJson = File.ReadAllText("./Repository/TruckList.json");
                List<Vehicle> trucks = JsonSerializer.Deserialize<List<Vehicle>>(TruckJson);

                foreach (var truck in trucks) {   
                    Console.WriteLine($"{truck.Model}");
                }
                    
                    if (trucks.Count == 0) {
                        Console.WriteLine("We do not have any trucks, we are going to redirect you to homepage.");
                        Login.Execute();
                    }

                Console.WriteLine("Which truck you want see the full description?");
                typeOfvehicle = Console.ReadLine();
                vehicleChoiced = trucks.FirstOrDefault(v => v.Model == typeOfvehicle);

                if (vehicleChoiced == null) {
                
                    Console.WriteLine("Wrong model, try again.");
                    Research.Execute();
                }   

                Console.WriteLine($"Model : {vehicleChoiced.Model}");
                Console.WriteLine($"Year : {vehicleChoiced.Year}");
                Console.WriteLine($"Color : {vehicleChoiced.Color}");
                Console.WriteLine($"Price : {vehicleChoiced.Price}");

                Console.ReadKey();

            break;

            default:

                Console.WriteLine("Type not detected, please try again.");
                Research.Execute();
                
            break;

        }
            Introduction.Execute();
        }
}  