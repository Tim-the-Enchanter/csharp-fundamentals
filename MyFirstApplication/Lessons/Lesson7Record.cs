
namespace MyFirstApplication;

/*
 A Record is a reference type that provides built-in functionality
for encapsulating data
 */

internal record Person(string FirstName, string LastName);

/*
 A Record struct is a value type with similar functionality as a record class
*/
public record struct Resolution(int width, int height)
{

    public void CalculateRes()
    {
        Console.WriteLine(width * height);
    }
} // End Record


// internal record Person(int ID, string Name);

/*
 MyBoat Record
*/
/*public record struct BoatRecord(int length, string color)
{

    public void BoatRec()
    {
        Console.WriteLine("length" * color);
    }
} // End Record
*/