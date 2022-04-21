namespace MyFirstApplication;

internal class Horse
{
    /*
    1.	In your Horse class, add the virtual keyword to your method created in Lesson 10.Create a second 
    version of the same method and add a parameter. Include a Console WriteLine method in the new method 
    that uses the parameter. This parameter needs to be based on one of your properties.
     
     Create a class based on your Horse object. Include your attributes as auto properties.
    Create 3 constructors. The first constructor should have parameters equal to your properties.
    Assign each parameter to your properties. The second constructor should have 2 parameters.
    Using the :this() keyword, you will pass your information to the first constructor.
    This includes the 2 parameters and default values. For the last constructor, you will create the 
    default constructor. Using the :this() keyword, you will pass 2 default values in that will pass 
    to the 2nd constructor. Also include in the class, your method for Horse.
     */

    // Properties
    public int HorseSize { get; init; }
    public string HorseMane { get; init; }
    public string HorseMotion { get; init; }

    // 1st constructor
    public Horse(int horseSize, string horseMane, string horseMotion)
    {
        HorseSize = horseSize;
        HorseMane = horseMane;
        HorseMotion = horseMotion;
    }

    // 2nd constructor
    public Horse(string HorseMane, string HorseMotion)
        : this(9, HorseMane, HorseMotion) { }

    // 3rd constructor
    public Horse()
        : this("9 hands", "grazing") { }

    // method
    // changed to virtual for  exercise 12
    public virtual void HorseState()
    {
        Console.WriteLine($"My horse is {HorseSize} hands tall and is {HorseMotion}");
    }
    /*
    1.	In your Horse class, add the virtual keyword to your method created in Lesson 10.Create a second 
    version of the same method and add a parameter. Include a Console WriteLine method in the new method 
    that uses the parameter. This parameter needs to be based on one of your properties.
    */
    // method with parameters for Exercise 12
    public virtual void HorseState(string HorseMane)
    {
        Console.WriteLine($"My {HorseMane} horse is {HorseSize} hands tall and is {HorseMotion}");
    }
} // End Class