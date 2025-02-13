using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Tasks;

namespace CPRG211_Group1_Assignment1
{
    public class Refrigerator : Appliance
    {
        //private int quantity;
        public string door;

        //public string ItemNumber { get; set; }
        //public string Brand { get; set; }
        //public int Quantity { get { return quantity; } set { quantity = value; } }
        //public int Wattage { get; set; }
        //public string Colour { get; set; }
        //public double Price { get; set; }
        public string DoorsNumber { get; set; }
        public int Height { get; set; }
        public int Width { get; set; }

        public Refrigerator(string itemNumber, string brand, int quantity, int wattage, string colour, double price, string doors, int height, int width) :
            base(itemNumber, brand, quantity, wattage, colour, price)
        {
            //this.ItemNumber = itemNumber;
            //this.Brand = brand;
            //this.Quantity = quantity;
            //this.Wattage = wattage;
            //this.Colour = colour;
            //this.Price = price;
            this.Height = height;
            this.Width = width;
            if (doors == "2")
            {

                this.DoorsNumber = "Double Doors";
            }
            else if (doors == "3")
            {

                this.DoorsNumber = "Three Doors";
            }
            else
            {

                this.DoorsNumber = "Four Doors";
            }
            door = doors;

        }

        public override string ToString()
        {
            return $" ItemNumber: {ItemNumber} \nBrand: {Brand} \nQuantity: {Quantity} \nWattage: {Wattage} \nColour: {Colour} \nPrice: {Price} \nNumber of Doors: {DoorsNumber} \nHeight: {Height} \nWidth: {Width}";
        }
    }
}