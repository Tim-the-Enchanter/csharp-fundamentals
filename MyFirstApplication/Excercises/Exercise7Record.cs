internal record Boat(string Color, string Type);


// MyBoat Record

public record struct BoatRecord(string color, string type)
{

    public void BoatRec()
    {
        Console.WriteLine(color, type);
    }
} // End Record