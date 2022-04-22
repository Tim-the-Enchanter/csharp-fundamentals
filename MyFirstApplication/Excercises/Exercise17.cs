namespace MyFirstApplication;
// CAC-103 Exercise 17 Exception Handling
internal class Exercise17
{
    /*
        1.Write a method that has two int parameters and no return type. You will use a try/catch for this method.
    Create a division problem in the try block. The catch block will utilize the DivideByZeroException.
    Provide a Console WriteLine message for both the try block and the catch block. The one in the try block 
    should display the answer to the division problem. The one in the catch block should have a message using 
    Interpolation along with a variable Messagesyntax. Test the method with different numbers, including 0 so
    you can ensure the catch executes.
     */

    // A method has two int parameters
    public void DivByZeroTest(int pram1, int pram2)
    {
        // try block that has Console.Writeline for divsion problem. 
        try
        {
            Console.WriteLine(pram1 / pram2);
        }
        /*
         creating a catch using DivideByZero with interpolation that displays a
         message via a Console.Writeline statement.
        */
        catch (DivideByZeroException exc)
        {
            Console.WriteLine($"You can't divide by 0: {exc.Message}");
            /*
             Output when enter int 0 as pram2:
            You can't divide by 0: Attempted to divide by zero.
             */
        }
    } // end method
    /*
     2.Write a method that has a horse parameter and no return type. Using and if statement, determine if your 
    horse is null. If it is null, use the throw keyword and a message to indicate it is null. If the horse is
    not null, use a Console WriteLine statement to print out one of your horse properties.
     */

    // A method with horse paramenter
    public void NullTest(Horse horse)
    {
        if (horse == null)
        {
            // creating the throw with NullReferenceException
            throw new NullReferenceException("The horse is null");
        }
        else
        {
            // To print horse properties
            Console.WriteLine(horse.HorseMotion);
        }
       
    } // end method
    // results from output
    /*You can't divide by 0: Attempted to divide by zero.
    Unhandled exception.System.NullReferenceException: The horse is null

       at MyFirstApplication.Exercise17.NullTest(Horse horse) in C:\MyRepository\csharp-fundamentals\MyFirstApplication\Excercises\Exercise17.cs:line 47

       at Program.<<Main>$>g__Exercise17|0_38() in C:\MyRepository\csharp-fundamentals\MyFirstApplication\Program.cs:line 561

       at Program.<Main>$(String[] args) in C:\MyRepository\csharp-fundamentals\MyFirstApplication\Program.cs:line 57


    C:\MyRepository\csharp-fundamentals\MyFirstApplication\bin\Debug\net6.0\MyFirstApplication.exe (process 92380) exited with code -532462766.
Press any key to close this window. . .
    */
}
