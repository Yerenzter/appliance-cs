using System;

public class Appliance {
    public string brand;
    public string manfacturer;
    public string model;
}

public class Smartphone : Appliance {
    public string Brand(string brand) {
        return "Brand: " + brand;
    }
    
    public string Manufacturer(string manufacturer) {
        return "Manufacturer: " + manufacturer;
    }
    
    public string Model(string model) {
        return "Model: " + model;
    }
}

class MainActivity {
    static void Main(String[] args) {
        Smartphone smartphone = new Smartphone();
        
        Console.WriteLine(smartphone.Brand("LG"));
    }
}
