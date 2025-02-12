using CPRG211_Group1_Assignment1;

// INSERT APPLIANCES.TXT TO LIST HERE
List<Appliance> appliances = new List<Appliance>();

while (true)
{
    Console.WriteLine("Welcome to Modern Appliances!");
    Console.WriteLine("How May We Assist You?");
    Console.WriteLine("1 - Check out appliance \n2 - Find appliances by brand \n3 - Display appliances by type \n4 - Produce random appliance List \n5 - Save & exit");
    Console.WriteLine("Enter option: ");
    string option = Console.ReadLine();

    if (option == "1")
    {
        //INSERT CHECK OUT APPLIANCE HERE
    }
    else if (option == "2")
    {
        //INSERT FIND APPLIANCES BY BRAND HERE
        Console.WriteLine("Enter brand to search for:");
        string brand = Console.ReadLine();

        Console.WriteLine("Matching Appliances:");
        var newList = appliances.FindAll(item => item.Brand == brand);

        foreach (Appliance appliance in newList)
        {
            Console.WriteLine(appliance);
        }

    }
    else if (option == "3")
    {
        //INSERT DISPLAY APPLIANCES BY TYPE HERE
        Console.WriteLine("Appliance Types");
        Console.WriteLine("1 - Refrigerators");
        Console.WriteLine("2 - Vacuums");
        Console.WriteLine("3 - Microwaves");
        Console.WriteLine("4 - Dishwashers");
        string applianceOption = Console.ReadLine();

        if (applianceOption == "1")
        {
            Console.WriteLine("Enter number of doors: 2 (double door), 3 (three doors), or 4 (four doors):");
            string numberofDoors = Console.ReadLine();

            Console.WriteLine("Matching refrigerators:");
            var newList = appliances.FindAll(item => item is Refrigerator refrigerator && refrigerator.DoorsNumber == numberofDoors);

            foreach (Appliance appliance in newList)
            {
                Console.WriteLine(appliance);
            }
        }

        else if (applianceOption == "2")
        {
            Console.WriteLine("Enter battery voltage value: 18 V (low) or 24 V (high)");
            string voltageValue = Console.ReadLine();

            Console.WriteLine("Matching vacuums:");
            //var newList = appliances.FindAll(item => item.Voltage == voltageValue);
            var newList = appliances.FindAll(item => item is Vacuum vacuum && vacuum.Voltage == voltageValue);

            foreach (Appliance appliance in newList)
            {
                Console.WriteLine(appliance);
            }
        }

        else if (applianceOption == "3")
        {
            Console.WriteLine("Room where the microwave will be installed: K (kitchen) or W (work site):");
            string microwaveRoom = Console.ReadLine();

            Console.WriteLine("Matching microwaves:");
            var newList = appliances.FindAll(item => item is Microwave microwave && microwave.RoomType == microwaveRoom);

            foreach (Appliance appliance in newList)
            {
                Console.WriteLine(appliance);
            }
        }

        else if (applianceOption == "4")
        {
            Console.WriteLine("Enter the sound rating of the dishwasher: Qt (Quietest), Qr (Quieter), Qu(Quiet) or M (Moderate):");
            string sound = Console.ReadLine();

            Console.WriteLine("Matching dishwashers:");
            var newList = appliances.FindAll(item => item is Dishwasher dishwasher && dishwasher.SoundRating == sound);

            foreach (Appliance appliance in newList)
            {
                Console.WriteLine(appliance);
            }
        }

        else
        {
            Console.WriteLine("Please enter a valid option");
        }
    }
    else if (option == "4")
    {
        //INSERT PRODUCE RANDOM APPLIANCE LIST HERE 
        Console.WriteLine("Enter number of appliances:");
        string length1 = Console.ReadLine();
        int length = Convert.ToInt32(length1);
        Console.WriteLine("Random Appliances:");
        int i = 0;
        while (i < length)
        {
            Random random = new Random();
            Console.WriteLine(appliances[random.Next(1, appliances.Count)].ToString());
            i++;
            
        }
    }
    else if(option == "5")
    {
        // INSERT SAVE LIST TO FILE HERE
        break;
    }
    else
    {
        Console.WriteLine("Please enter valid option");
    }
}

