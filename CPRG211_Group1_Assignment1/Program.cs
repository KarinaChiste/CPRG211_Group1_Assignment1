
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
        //INSERT FIND APPLIANCES BY BRAND HERE
    }
    else if (option == "3")
    {
       //INSERT DISPLAY APPLIANCES BY TYPE HERE
    }
    else if (option == "4")
    {
        //INSERT PRODUCE RANDOM APPLIANCE LIST HERE 

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
