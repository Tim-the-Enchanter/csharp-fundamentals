namespace MyFirstApplication;
// CAC-103 Exercise 8 Constant & Static
/*
Before you turn in your exercise lab, create an object of your class in Program.cs and test each exercise below.
You do not have to provide your Program.cs link during your turn in process.Your HouseExample should provide the
correct way to create your object.You will utilize the examples we did together in Lesson8 and Lesson8Static to
complete the exercises below.
*/

internal class Exercise8
/*
1.Write a constant at the class level. The constant should be Foot with a value of 12 to represent the number
of inches in a foot. Write a method that takes 1 int parameter and a void return type. This method will convert
feet to inches. The formula that you would use will be the parameter * Foot. Your parameter will represent the 
number of feet to convert to inches. Using a ConsoleWriteLine statement, print the results. Test your method 
using the number 3 to see if you get 36.
*/
{
    public const int Foot = 12; // 12 inches in a foot

    public void FeetToInches(int value)
    {
        int total = value * Foot;
        Console.WriteLine($"The total of {value} inches x {Foot} (inches per foot) is {total} inches.");
    }

    /*
 2.Write a static method that takes 2 int parameters and a void return type. This method will be used to calculate
the length and width of a rectangle/square. This formula is length x width. The first parameter should represent 
the length and the second parameter should be the width. Using a Console WriteLinestatement, print the results. 
Test your method and add what you used to test as a comment either before the method or after.
 */

    public static void LgthXWdth(int length, int width)
    {
        int total = length * width;
        Console.WriteLine($"The box area is {total} and is calculated from length of {length} x width of {width}.");
    }

} // End Class

/* Output with this code in Program.cs
   void Exercise8a()
{
    Exercise8 myExercise8 = new Exercise8();
myExercise8.FeetToInches(3);
    Exercise8.LgthXWdth(7, 7);
}
*/
