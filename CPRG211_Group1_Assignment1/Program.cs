using CPRG211_Group1_Assignment1;
// INSERT APPLIANCES.TXT TO LIST HERE

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

    return appliances;
}

List<Appliance> appliances = ReadFile();

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
        var newList = applianceList.FindAll(item => item.Brand == brand);

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

