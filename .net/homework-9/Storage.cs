using System;

public abstract class Storage
{
    public string Name { get; set; }
    public string Manufacturer { get; set; }
    public string Model { get; set; }
    public int Quantity { get; set; }
    public double Price { get; set; }

    public Storage(string name, string manufacturer, string model, int quantity, double price)
    {
        Name = name;
        Manufacturer = manufacturer;
        Model = model;
        Quantity = quantity;
        Price = price;
    }

    public abstract void PrintInfo();
}
