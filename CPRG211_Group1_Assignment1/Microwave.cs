namespace CPRG211_Group1_Assignment1;

    public class Microwave : Appliance
    {
        // create Microwave attributes
        private double _capacity;

        private string _roomType;
        public double Capacity { get { return _capacity; } set { _capacity = value; } }
        public string RoomType { get { return _roomType; } set { _roomType = value; } }
        public string room;
        //public string RoomTypeKitchen = "K";
        //public string RoomTypeWorkSite = "W";
        //public string DisplayRoomType { get; set; }

        // constructor
        public Microwave(string itemNumber, string brand, int quantity, int wattage, string colour, double price, double capacity, string roomType)
            : base(itemNumber, brand, quantity, wattage, colour, price)
        {
            this.Capacity = capacity;
            this.RoomType = roomType;
            if (roomType == "K")
            {
                this.RoomType = "Kitchen";
            }
            if (roomType == "W");
            {
                this.RoomType = "Work Site";
            }
            room = roomType;
    }

        // FormatToFile method
        public override string FormatToFile()
        {
            return $"{ItemNumber};{Brand};{Quantity};{Wattage};{Colour};{Price};{Capacity};{room}";
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
                   $"Capacity: {Capacity.ToString("f1")}\n" +
                   $"Room Type: {RoomType}";
        }

}