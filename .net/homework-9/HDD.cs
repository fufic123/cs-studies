public class HDD : Storage
{
    public double Capacity { get; set; }
    public string USBType { get; set; }

    public HDD(string manufacturer, string model, int quantity, double price, double capacity, string usbType)
        : base("Съемный HDD", manufacturer, model, quantity, price)
    {
        Capacity = capacity;
        USBType = usbType;
    }

    public override void PrintInfo()
    {
        Console.WriteLine($"[HDD] {Manufacturer} {Model} - {Capacity} ТБ, {USBType}, {Quantity} шт., {Price} грн.");
    }
}
