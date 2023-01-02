namespace Object;

public class Vehicle {
    public string Type {get; set;}
    public string Model {get; set;}
    public int Year {get; set;}
    public string Color {get; set;}
    public decimal Price {get; set;}

        public Vehicle(string type, string model, int year, string color, decimal price) {
            Type = type;
            Model = model; 
            Year = year;
            Color = color;
            Price = price;
        }
}