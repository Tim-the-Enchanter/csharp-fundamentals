namespace MyFirstApplication;

internal class Yacht : Boat
{
    // as expression body definitions
    public int Length;
    
    // 1st constructor
    public Yacht(string boatColor, string frameType, string engineType, int length)
        : base(boatColor, frameType, engineType)
    {
        Length = length;
    }

    // 2nd constructor
    public Yacht(string boatColor, string frameType, string engineType)
        : this(boatColor, frameType, engineType, 50) { }

    // 3rd constructor
    public Yacht()
        : this("blue", "composite", "power") { }

    // method
    public void YachtChild()
    {
        Console.WriteLine($"My {boatColor} yacht is made of {frameType} with a {engineType} motor and is {50}' long.");
    }

    /* 
     4.	In your child class of Boat, using the override keyword create a method that has the same name as
    the virtual method from Boat. Add a Console WriteLine that provides a different message from the Boat.
     */
    // override method from parent - boat.cs exercise 12
    public virtual void EngineState()
    {
        Console.WriteLine($"My {boatColor} boat is my favorite.");
    }
} // End Class