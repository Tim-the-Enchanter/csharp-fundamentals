namespace MyFirstApplication;

/*
 1.Create a child class based on your Horse object. Include one child attribute as an auto property. 
Create 3 constructors. The first constructor should have 4 parameters with 3 of them from Horse and your child property.

Using the keyword :base(),you will put the four horse parameters in the parenthesis. In the body of the constructor 
you will assign your child parameter to your property. 

The second constructor should have 2 parameters, 2 based on the 
horse and 1 from your child. Using the :this()keyword, you will pass 2 of the parent attributes and your child 
attribute information to the first constructor. Include default values to represent the 2 remaining horse parameters.
For the last constructor, you will create the default constructor. Using the :this()keyword, you will pass 2default 
valuesin that will pass to the 2ndconstructor. Also include in the class, your method for your child class.

 */
internal class Stallion : Horse
{
    // auto property
    public string Rigging { get; init; }

    // 1st constructor
    public Stallion(int horseSize, string horseMane, string horseMotion, string riggingType)
        : base(horseSize, horseMane, horseMotion)
    {
        Rigging = riggingType;
    }

    // 2nd constructor
    public Stallion(int horseSize, string horseMane, string horseMotion)
        : this(horseSize, horseMane, horseMotion, "bareback") { }

    public Stallion()
    {
    }

    // Default constructor
    /*
    public Stallion()
        : this(9, "flowing", "bareback") { }

    public void StallionChild()
    {
        Console.WriteLine($"My Stallion only enjoys {Rigging} and his mane {HorseMane} in the wind.");
    }
    */
    /*
   2.	In your child class of Horse, using the override keyword create a method that has the same name 
   as the virtual method from Horse. Add a Console WriteLine that provides a different message from the Horse.   
   */

    // Method with override keyword
    public override void HorseState()
    {
        Console.WriteLine("The stallion is grazing.");

    }
} // End Class
