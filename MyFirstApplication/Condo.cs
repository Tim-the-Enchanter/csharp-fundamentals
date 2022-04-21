namespace MyFirstApplication;
            // Condo - child of house
internal class Condo : House
{
    private string _balcony;

    public string Balcony
    {
        get { return _balcony; }
        set { _balcony = value; }
    }
    // default constructor
    public Condo()
        : this("second floor")
    { }
    // Constructors
    public Condo(string balcony)
        : this("concrete", "steel", "Blue", 35, balcony)
    { }
    // Constructors
    public Condo(string foundation, string roofType, string doorColor,
        int windowSize, string balcony)
        : base(foundation, roofType, doorColor, windowSize)
    {
        _balcony = balcony;
    }


     public override void DoorOpenClose()
    {                           // DoorColor - parent property
        Console.WriteLine($"The {DoorColor} door is creaking.");
    }

    public void Maintenance()
    {
        Console.WriteLine($"Fixing the {_balcony} on appartment 2.");
    }
    
} // end class
