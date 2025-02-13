using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CPRG211_Group1_Assignment1
{
    public class Dishwasher : Appliance
    {


        //private int quantity;
        //private int wattage;
        public string sound;
        //private double price;
        //private string feature;
        //private string soundRating;

        //public string ItemNumber {  get; set; }
        //public string Brand {  get; set; }
        //public int Quantity { get { return quantity; } set { quantity = value; } }
        //public int Wattage { get; set; }
        //public string Colour { get; set; }
        //public double Price { get; set; }
        public string Feature { get; set; }
        public string SoundRating { get; set; }

        public Dishwasher(string itemNumber, string brand, int quantity, int wattage, string colour, double price, string feature, string soundRating) :
            base(itemNumber, brand, quantity, wattage, colour, price)
        {
            //this.ItemNumber = itemNumber;
            //this.Brand = brand;
            //this.Quantity = quantity;
            //this.Wattage = wattage;
            //this.Colour = colour;
            //this.Price = price;
            this.Feature = feature;
            if (soundRating == "Qt")
            {
                this.SoundRating = "Quietest";
            }
            else if (soundRating == "Qr")
            {
                this.SoundRating = "Quieter";
            }
            else if (soundRating == "Qu")
            {
                this.SoundRating = "Quiet";
            }
            else
            {
                this.SoundRating = "Moderate";
            }
            sound = soundRating;

        }

        public override string ToString()
        {
            return $" ItemNumber: {ItemNumber} \nBrand: {Brand} \nQuantity: {Quantity} \nWattage: {Wattage} \nColour: {Colour} \nPrice: {Price} \nFeature:{Feature} \nSoundRating: {SoundRating}";
        }

    }
}