//task1
//Website website = new();
//website.InputData();
//Console.WriteLine();
//Console.WriteLine("\tThe information:");
//website.OutputData();

//task2


//Journal journal = new ();
//journal.InputData();
//Console.WriteLine();
//Console.WriteLine("\tThe information:");
//journal.OutputData();



//task3
Shop shop = new();
shop.InputData();
Console.WriteLine();
Console.WriteLine("\tThe information:");
shop.OutputData();

class Website
{
    private string name;
    private string url;
    private string description;
    private string ipAddress;


    public void InputData()
    {
        Console.Write("Enter the name: ");
        name = Console.ReadLine();

        Console.Write("Enter the url: ");
        url = Console.ReadLine();

        Console.Write("Add description: ");
        description = Console.ReadLine();

        Console.Write("Add IP adress: ");
        ipAddress = Console.ReadLine();
    }

    public void OutputData()
    {
        Console.WriteLine("Name: " + name);
        Console.WriteLine("Url: " + url);
        Console.WriteLine("Description: " + description);
        Console.WriteLine("IP adress: " + ipAddress);
    }

  
    public string GetName()
    {
        return name;
    }

    public string GetUrl()
    {
        return url;
    }

    public string GetDescription()
    {
        return description;
    }

    public string GetIpAddress()
    {
        return ipAddress;
    }
}



class Journal
{
    private string name;
    private int foundationYear;
    private string description;
    private string contactPhone;
    private string contactEmail;


    public void InputData()
    {
        Console.Write("Enter the name of the journal: ");
        name = Console.ReadLine();

        Console.Write("Year of foundation: ");
        int.TryParse(Console.ReadLine(),out foundationYear);

        Console.Write("Add description: ");
        description = Console.ReadLine();

        Console.Write("Enter the contact number: ");
        contactPhone = Console.ReadLine();

        Console.Write("Enter e-mail: ");
        contactEmail = Console.ReadLine();
    }

   
    public void OutputData()
    {
        Console.WriteLine("The name of the journal: " + name);
        Console.WriteLine("Year of foundation: " + foundationYear);
        Console.WriteLine("Description: " + description);
        Console.WriteLine("Contact number: " + contactPhone);
        Console.WriteLine("E-mail: " + contactEmail);
    }

    public string GetName()
    {
        return name;
    }

    public int GetFoundationYear()
    {
        return foundationYear;
    }

    public string GetDescription()
    {
        return description;
    }

    public string GetContactPhone()
    {
        return contactPhone;
    }

    public string GetContactEmail()
    {
        return contactEmail;
    }
}



class Shop
{
    private string name;
    private string address;
    private string profileDescription;
    private string contactPhone;
    private string contactEmail;

    public void InputData()
    {
        Console.Write("Enter the name: ");
        name = Console.ReadLine();

        Console.Write("Enter the adress: ");
        address = Console.ReadLine();

        Console.Write("Add description: ");
        profileDescription = Console.ReadLine();

        Console.Write("Contact number: ");
        contactPhone = Console.ReadLine();

        Console.Write("Add e-mail: ");
        contactEmail = Console.ReadLine();
    }

 
    public void OutputData()
    {
        Console.WriteLine("The name: " + name);
        Console.WriteLine("Adress: " + address);
        Console.WriteLine("Description: " + profileDescription);
        Console.WriteLine("Contact phone: " + contactPhone);
        Console.WriteLine("E-mail: " + contactEmail);
    }


    public string GetName()
    {
        return name;
    }

    public string GetAddress()
    {
        return address;
    }

    public string GetProfileDescription()
    {
        return profileDescription;
    }

    public string GetContactPhone()
    {
        return contactPhone;
    }

    public string GetContactEmail()
    {
        return contactEmail;
    }
}
