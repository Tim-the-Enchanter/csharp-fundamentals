namespace MyFirstApplication;

internal class Yacht : Boat
{
   // as expression body definitions
    public int Length
    {
        get => Length;
        set => Length = value;
    }

    // 1st construcor
    public Yacht(string boatColor, string frameType, string engineType, int length)
    {
        Length = length;
    }

    //2nd Constructor
    public Yacht(string boatColor, string frameType, string engineType)
        : this(boatColor, frameType, engineType, 50) { }

    //third Constructor
    public Yacht()
        : this("blue", "composite", "power") { }

    public void YachtChild()
    {
        Console.WriteLine($"My {boatColor} Yacht is made of {frameType} with a {engineType} motor.");
    }    
} // End Class