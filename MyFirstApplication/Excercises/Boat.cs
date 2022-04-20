namespace MyFirstApplication;

internal class Boat
{
    /*
    Create a class based on your Horse object. Include your attributes as auto properties.
    Create 3 constructors. The first constructor should have parameters equal to your properties.
    Assign each parameter to your properties. The second constructor should have 2 parameters.
    Using the :this() keyword, you will pass your information to the first constructor.
    This includes the 2 parameters and default values. For the last constructor, you will create the 
    default constructor. Using the :this() keyword, you will pass 2 default values in that will pass 
    to the 2nd constructor. Also include in the class, your method for Horse.
    Create a class based on your Boatobject. You will follow the same instructions as exercise 1 except for the following.
    Include your attributes as Expression Body Definition Properties.
     */

    // properties 
    public string boatColor;
    public string frameType;
    public string engineType;

    // as expression body definitions
    public string BoatColor
    {
        get => boatColor;
        set => boatColor = value;
    }

    public string FrameType
    {
        get => frameType;
        set => frameType = value;
    }

    public string EngineType
    {
        get => engineType;
        set => engineType = value;
    }


    // first constructor
    public Boat(string boatColor, string frameType, string engineType)
    {
        BoatColor = boatColor;
        FrameType = frameType;
        EngineType = engineType;
    }

    // second constructor
    public Boat(string FrameType, string BoatColor)
        : this(FrameType, BoatColor, "power") { }


    // third constructor
    public Boat()
        : this("white", "sail") { }

    // method for boat
    public void EngineState()
    {
        Console.WriteLine($"My {frameType} boat is {boatColor}.");
    }

} // end class