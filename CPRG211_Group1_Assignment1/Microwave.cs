namespace CPRG211_Group1_Assignment1;

internal class Microwave : Appliance
{
    // create Microwave attributes
    private int _capacity;

    private string _roomType;
    public double Capacity { get { return _capacity; } set { _capacity = (int)value; } }
    public string RoomType { get { return _roomType; } set { _roomType = value; } }
    public string RoomTypeKitchen = "K";
    public string RoomTypeWorkSite = "W";
    public string DisplayRoomType { get; set; }


    // constructor
    public Microwave(string itemNumber, string brand, int quantity, int wattage, string colour, double price, double capacity, string roomType)
        : base(itemNumber, brand, quantity, wattage, colour, price)

    {
        this.Capacity = capacity;
        this.RoomType = roomType;
    }

    // FormatToFile method
    public string FormatToFile()
    {
        return $"{ItemNumber};{Brand};{Quantity};{Wattage};{Colour};{Price};{Capacity};{RoomType}";
    }

    // ToString method
    public override string ToString()
    {
        return $"Item number: {ItemNumber}\n" +
               $"Brand: {Brand}\n" +
               $"Quantity: {Quantity}\n" +
               $"Wattage: {Wattage}\n" +
               $"Colour: {Colour}\n" +
               $"Price: {Price}\n" +
               $"Capacity: {Capacity}\n" +
               $"Room Type: {RoomType}";
    }
}