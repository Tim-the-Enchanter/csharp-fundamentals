namespace MyFirstApplication;
// CAC-103 Exercise 6 Constructors and Methods
/*
 * *** Here is my program.cs that produced "TryOnShoe = I tried on a Running shoe that was a size 11"
 Exercise6();

void Exercise6()
{
    // Constructor
    Exercise6 myexercise6 = new Exercise6(11, "Running");
    Exercise6.TryOn shoe = myexercise6.TryOnShoe;
    shoe($"I tried on a {myexercise6.ShoeType} shoe that was a size {myexercise6.ShoeSize}");

    Console.WriteLine();
}
 */

internal class Exercise6
{
    /*
     1.Write a constructor for your exercise file that takes 2 parameters.The first parameter should have an int type
    and a variable name of shoeSize. The second parameter should have a string type and a variable name of shoeType. 
    Create private class variables for these types and use an underscore when defining them. Inside the constructor 
    associate the class variables with the constructor parameters. 
    */
    // private class variables
    private int _shoeSize;
    private string _shoeType;

    public Exercise6(int size, string type)
    {
        _shoeSize = size;
        _shoeType = type;
    }

    /* 
     2.Write the properties for the class variables defined in exercise 1. Ensure they are labeled as public and are
    spelled using a capital letter.
    */
    // properties
    public string ShoeType
    {
        get { return _shoeType; }
        set { _shoeType = value; }
    }

    public int ShoeSize
    {
        get { return _shoeSize; }
        set { _shoeSize = value; }
    }

    /*
    3.Write a delegate that takes a string parameter. This delegate should be named TryOn. 
    Write a method that takes a string argument and void return type. 
    In the method body include a Console WriteLinestatement that will print the message. 
    Test your delegate in Program.cs to ensure everything works properly. Using a mult-line comment on your Exercise6.cs file, 
    provide the information you used to test the delegate.
    */
    // Delegates
    public delegate void TryOn(string type);

    public Exercise6(string type, int size)
    {
        _shoeType = type;
        _shoeSize = size;
    }
    public void TryOnShoe(string message)
    {
        Console.WriteLine($"TryOnShoe = {message}");
    }

} // End Class
