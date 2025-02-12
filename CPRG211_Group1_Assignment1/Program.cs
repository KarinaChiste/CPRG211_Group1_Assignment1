using CPRG211_Group1_Assignment1;
// INSERT APPLIANCES.TXT TO LIST HERE


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
        // add appliance objects into list
        List<Appliance> applianceList = new List<Appliance>();
        //INSERT FIND APPLIANCES BY BRAND HERE
        Console.WriteLine("Enter brand to search for:");
        string brand = Console.ReadLine();
        Console.WriteLine("Matching Appliances:");
        var newList = applianceList.FindAll(item => item.brand == brand);

        foreach (Appliance appliance in newList)
        {
            Console.WriteLine(appliance);
        }

    }
    else if (option == "3")
    {
       //INSERT DISPLAY APPLIANCES BY TYPE HERE
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

