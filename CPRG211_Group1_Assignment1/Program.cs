using CPRG211_Group1_Assignment1;


const string PATH = @"..\..\..\res\appliances.txt";
const string SEP = ";";
List<Appliance> ReadFile()
{
    List<Appliance> appliances = new List<Appliance>();
    string line;
    string[] details;
    string itemNum;

    StreamReader read = new StreamReader(PATH);

    while (!read.EndOfStream)
    {
        line = read.ReadLine()!;
        details = line.Split(SEP);
        itemNum = details[0];

        if (itemNum.StartsWith("1"))
        {
            appliances.Add(new Refrigerator(details[0], details[1], int.Parse(details[2]), int.Parse(details[3]), details[4], double.Parse(details[5]), details[6], int.Parse(details[7]), int.Parse(details[8])));
        }
        else if (itemNum.StartsWith("2"))
        {
            appliances.Add(new Vacuum(details[0], details[1], int.Parse(details[2]), int.Parse(details[3]), details[4], double.Parse(details[5]), details[6], int.Parse(details[7])));
        }
        else if (itemNum.StartsWith("3"))
        {
            appliances.Add(new Microwave(details[0], details[1], int.Parse(details[2]), int.Parse(details[3]), details[4], double.Parse(details[5]), double.Parse(details[6]), details[7]));
        }
        else if (itemNum.StartsWith("4") || itemNum.StartsWith("5"))
        {
            appliances.Add(new Dishwasher(details[0], details[1], int.Parse(details[2]), int.Parse(details[3]), details[4], double.Parse(details[5]), details[6], details[7]));
        }

    }
    read.Close();
    return appliances;
}

List<Appliance> appliances = ReadFile();


while (true)
{
    Console.WriteLine("\nWelcome to Modern Appliances!");
    Console.WriteLine("How May We Assist You?");
    Console.WriteLine("1 - Check out appliance \n2 - Find appliances by brand \n3 - Display appliances by type \n4 - Produce random appliance List \n5 - Save & exit");
    Console.WriteLine("Enter option: ");
    string option = Console.ReadLine();

    if (option == "1")
    {
        // takes user input for item number
        Console.Write("Enter the item number of an appliance: ");
        string itemNumber = Console.ReadLine();

        // searches appliances list and compares if user input exists
        Appliance appliance = appliances.Find(a => a.ItemNumber == itemNumber);

        // if statements to validate if the item number exists or not
        if (appliance == null)
        {
            Console.WriteLine("No appliances found with that item number.");
            continue;
        }

        if (appliance.Quantity > 0)
        {
            appliance.Quantity--;
            Console.WriteLine($"Appliance {itemNumber} has been checked out.");
        }
        else
        {
            Console.WriteLine("The appliance is not available to be checked out.");
        }

    }

    else if (option == "2")
    {
        // find appliances by brand method
        // ask user for appliance brand
        Console.WriteLine("Enter brand to search for:");
        string brand = Console.ReadLine();

        Console.WriteLine("Matching Appliances:");

        // create new list with all items from appliance list that match user input
        // make user input case-insensitive by comparing using OrdinalIgnoreCase
        var newList = appliances.FindAll(item => string.Equals(item.Brand, brand, StringComparison.OrdinalIgnoreCase));


        // display appliance information for found items
        foreach (Appliance appliance in newList)
        {
            Console.WriteLine(appliance);
        }
    }
    else if (option == "3")
    {
        // find appliances by type method
        // ask user for appliance type
        Console.WriteLine("Appliance Types");
        Console.WriteLine("1 - Refrigerators\n2 - Vacuums\n3 - Microwaves\n4 - Dishwashers");
        Console.WriteLine("Enter type of appliance:");
        string applianceOption = Console.ReadLine();

        if (applianceOption == "1")
        {
            Console.WriteLine("Enter number of doors - 2 (double door), 3 (three doors), or 4 (four doors):");
            string numberofDoors = Console.ReadLine();

            Console.WriteLine("Matching refrigerators:");
            // create new list with all items from appliance list that match user input (cast Refrigerator class)
            var newList = appliances.FindAll(item => item is Refrigerator refrigerator && refrigerator.door == numberofDoors);

            // display appliance information for found items
            foreach (Appliance appliance in newList)
            {
                Console.WriteLine(appliance);
            }
        }

        else if (applianceOption == "2")
        {
            Console.WriteLine("Enter battery voltage value - 18 V (low) or 24 V (high):");
            string voltageValue = Console.ReadLine();
            if (voltageValue == "18")
            {
                voltageValue = "Low";
            }

            else if (voltageValue == "24")
            {
                voltageValue = "High";
            }

            Console.WriteLine("Matching vacuums:");
            // create new list with all items from appliance list that match user input (cast Vacuum class)
            var newList = appliances.FindAll(item => item is Vacuum vacuum && vacuum.BatteryVoltage == voltageValue);

            // display appliance information for found items
            foreach (Appliance appliance in newList)
            {
                Console.WriteLine(appliance);
            }
        }

        else if (applianceOption == "3")
        {
            Console.WriteLine("Room where the microwave will be installed - K (kitchen) or W (work site):");
            string microwaveRoom = Console.ReadLine();

            Console.WriteLine("Matching microwaves:");
            // create new list with all items from appliance list that match user input (cast Microwave class)
            // make user input case-insensitive by comparing using OrdinalIgnoreCase
            var newList = appliances.FindAll(item => item is Microwave microwave && string.Equals(microwave.room, microwaveRoom, StringComparison.OrdinalIgnoreCase));

            // display appliance information for found items
            foreach (Appliance appliance in newList)
            {
                Console.WriteLine(appliance);
            }
        }

        else if (applianceOption == "4")
        {
            Console.WriteLine("Enter the sound rating of the dishwasher - Qt (Quietest), Qr (Quieter), Qu (Quiet) or M (Moderate):");
            string sound = Console.ReadLine();

            Console.WriteLine("Matching dishwashers:");
            // create new list with all items from appliance list that match user input (cast Dishwasher class)
            // make user input case-insensitive by comparing using OrdinalIgnoreCase
            var newList = appliances.FindAll(item => item is Dishwasher dishwasher && string.Equals(dishwasher.sound, sound, StringComparison.OrdinalIgnoreCase));

            // display appliance information for found items
            foreach (Appliance appliance in newList)
            {
                Console.WriteLine(appliance);
            }
        }

        // display error message if anything other than 1-5 entered
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
    else if (option == "5")
    {
        // INSERT SAVE LIST TO FILE HERE
        using (StreamWriter writer = new StreamWriter(PATH))
        {
            foreach (Appliance appliance in appliances)
            {
                writer.WriteLine(appliance.ToString());
            }
        }
        Console.WriteLine("Appliance list has been saved. Exiting...");
        break;
    }
    else
    {
        Console.WriteLine("Please enter valid option");
    }
}