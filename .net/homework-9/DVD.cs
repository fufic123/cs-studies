public class DVD : Storage
{
    public double ReadSpeed { get; set; }
    public double WriteSpeed { get; set; }

    public DVD(string manufacturer, string model, int quantity, double price, double readSpeed, double writeSpeed)
        : base("DVD-диск", manufacturer, model, quantity, price)
    {
        ReadSpeed = readSpeed;
        WriteSpeed = writeSpeed;
    }

    public override void PrintInfo()
    {
        Console.WriteLine($"[DVD] {Manufacturer} {Model} - {ReadSpeed}/{WriteSpeed}x, {Quantity} шт., {Price} грн.");
    }
}
