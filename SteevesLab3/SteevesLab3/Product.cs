namespace SteevesLab3;


//Product base class
public class Product
{

    //Auto-implemented Properties
    public int ProductID { get; }
    public string Name { get; set; }
    public decimal Price { get; set; }
    public int Quantity { get; set; }
    private static decimal HighestPriceEver { get; set; }

    //Constructor
    public Product(int inProductID, string inName, decimal inPrice, int inQuantity)
    {
        ProductID = inProductID;
        Name = inName;
        Price = inPrice;
        Quantity = inQuantity;

        if (Price > HighestPriceEver)
        {
            HighestPriceEver = Price;
        }
    }

    //Override method for displaying product details
    public override string ToString()
    {
        return $"ProductID: {ProductID}  |  Name: {Name}  |  " + "Price: " + Price.ToString("C") + $"  |  Quantity: {Quantity}";
    }

    //Overload method for the + operator
    public static Product operator +(Product p1, Product p2)
    {
        if (p1.ProductID == p2.ProductID)
        {
            //Assuming that the instructions are not asking for the other product-specific propeties
            return new Product(p1.ProductID, p1.Name, p1.Price, p1.Quantity + p2.Quantity);
        }
           

        return p1; // Return the first product if IDs don't match
    }

    //Static method to return HighestPriceEver
    public static decimal GetHighestPriceEver()
    {
        return HighestPriceEver;
    }
}

//Class derived from product class
public class Laptop : Product
{
    //Properties
    public string Processor { get; set; }
    public int Ram { get; set; }

    //Constructor for laptop class
    public Laptop(int inProductID, string inName, decimal inPrice, int inQuantity, string inProcessor, int inRam)
        : base(inProductID, inName, inPrice, inQuantity) //values derived from the base class
    {
        Processor = inProcessor;
        Ram = inRam;
    }

    //Overriden ToString() method for displaying laptop-specific data
    public override string ToString()
    {
        return base.ToString() + $"  |  Processor: {Processor}  |  Ram: {Ram}";
    }
}

//Inherited class from Product base class
public class Smartphone : Product
{
    //Properties
    public string OperatingSystem { get; set; }
    public int Storage { get; set; }

    //Constructor for Smartphone class
    public Smartphone(int inProductID, string inName, decimal inPrice, int inQuantity, string inOperatingSystem, int inStorage)
        : base(inProductID, inName, inPrice, inQuantity) //values derived from base Product class
    {
        OperatingSystem = inOperatingSystem;
        Storage = inStorage;
    }

    //Overriden ToString() method to display smartphone-specific details
    public override string ToString()
    {
        return base.ToString() + $"  |  OS: {OperatingSystem}  |  Storage: {Storage}";
    }
}

//Inherited Accessory class from base Product class
public class Accessory : Product
{
    //Auto-implemented Property
    public string AccessoryType { get; set; }

    //Constructor for Accessory class
    public Accessory(int inProductID, string inName, decimal inPrice, int inQuantity, string inAccessoryType)
        : base(inProductID, inName, inPrice, inQuantity)
    {
        AccessoryType = inAccessoryType;
    }

    public override string ToString()
    {
        return base.ToString() + $"  |  Accessory Type: {AccessoryType}";
    }
}
