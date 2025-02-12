using CPRG211_Group1_Assignment1;

internal class Microwave : Appliance
{
    private int _capacity;

    private string _roomType;
    public int Capacity { get { return _capacity; } set { _capacity = value; } }
    public string RoomType { get { return _roomType; } set { _roomType = value; } }
    public string RoomTypeKitchen = "K";
    public string RoomTypeWorkSite = "W";
    public string DisplayRoomType { get; set; }

    public Microwave(int itemNumber, string brand, int quantity, int wattage, string colour, int price, int capacity, string roomType)
        : base(itemNumber, quantity, brand, wattage, colour, price)
    {
        this.Capacity = capacity;
        this.RoomType = roomType;
    }
    public string FormatToFile()
    {
        return $"{ItemNumber};{Brand};{Quantity};{Wattage};{Colour};{Price};{Capacity};{RoomType}"
    }

    public override string ToString()
    {
        return $"Item number: {ItemNumber}\n" +
                $"Brand: {Brand}\n" +
                "Quantity: {Quantity}\n" +
                $"Wattage: {Wattage}\n" +
                $"Colour: {Colour}\n" +
                $"Price: {Price}";
    }
}


