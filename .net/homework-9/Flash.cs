public class Flash : Storage
{
    public double Capacity { get; set; } 
    public double Speed { get; set; }

    public Flash(string manufacturer, string model, int quantity, double price, double capacity, double speed) 
        : base("Flash-память", manufacturer, model, quantity, price)
    {
        Capacity = capacity;
        Speed = speed;
    }

    public override void PrintInfo()
    {
        Console.WriteLine($"[Flash] {Manufacturer} {Model} - {Capacity} ГБ, {Speed} МБ/с, {Quantity} шт., {Price} грн.");
    }
}
