using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CPRG211_Group1_Assignment1
{
    public class Appliance
    {
        public string ItemNumber { get; set; }
        public string Brand { get; set; }
        
        public int Wattage { get; set; }
        public string Colour { get; set; }
        public double Price { get; set; }

        public Appliance(string itemNumber, string brand, int wattage, string colour, double price)
        {
            this.ItemNumber = itemNumber;
            this.Brand = brand;
            this.Wattage = wattage;
            this.Colour = colour;
            this.Price = price;
        }
    }
}
