using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CPRG211_Group1_Assignment1
{
    public class Vacuum : Appliance
    {
        public int voltage;
        public int Quantity { get; set; }
        public string Grade { get; set; }
        public string BatteryVoltage { get; set; } // low = 18, high = 24

        public Vacuum(string itemNumber, string brand, int quantity, int wattage, string colour, double price, string grade, int batteryVoltage) :
            base(itemNumber, brand, quantity, wattage, colour, price)

        {
            this.Quantity = quantity;
            this.Grade = grade;
            if (batteryVoltage == 18)
            {
                this.BatteryVoltage = "Low";
            }
            else if (batteryVoltage == 24)
            {
                this.BatteryVoltage = "High";
            }
            voltage = batteryVoltage;
        }

        public override string ToString()
        {
            return $" ItemNumber: {ItemNumber} \nBrand: {Brand} \nQuantity: {Quantity} \nWattage: {Wattage} \nColour: {Colour} \nPrice: {Price} \nGrade: {Grade} \nBattery Voltage: {BatteryVoltage}";
        }
        public override string FormatToFile()
        {
            return $"{ItemNumber};{Brand};{Quantity};{Wattage};{Colour};{Price};{Grade};{voltage}";
        }
    }
}