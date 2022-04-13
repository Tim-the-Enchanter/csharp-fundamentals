// CAC-103 Exercise 4 Lab Control Flow Statements
namespace MyFirstApplication;

internal class Exercise4
{
    /*
     1.Write a method that takes 2 string arguments and a void return type. 
    Using and if-else statement, compare the two strings to each other. 
    Using a Console WriteLine statement, print out the results of whether the strings are equal.
    Provide a comment inside the method that says what strings you used during testing.     
     */
    public void BasicEqualsTest(string arg1, string arg2)
    {

        if (arg1 == arg2)
        {
            Console.WriteLine("Both args are equal.");
        }
        else 
        {
            Console.WriteLine("Both args are not equal.");
        } 

    } // End Method

    /*
     2. Write a method that will take 1 char argument and a string return type. Using a switch and the table below,
    return the description. If the value does not match the grade, return the default message, “Not a valid grade”
    Grade Description
    E       Excellent
    V       Very Good
    G       Good
    A       Average
    F       Fail
     */
    public string MyValidGrade(char gradearg)
    {
        switch (gradearg)
        {
            case 'E':
                return "E - Excellent!";
            case 'V':
                return "V - Very Good!";
            case 'G':
                return "G - Good!";
            case 'A':
                return "A - Average";
            case 'F':
                return "F - FAIL!";

            default:
                return "Not a valid grade";
                
        }
    } // End Method


    /*
    3.Write a method that takes no arguments and a void return type. Using an iteration statement, 
    display all the numbers divisible by 3 from 0 to 30. Utilize a modulus to obtain your results.
    */
    public void MyIteration()
    {
        for (int i = 0; i < 30; i++)
        {
            if (i % 3 == 0)
            { 
                Console.WriteLine(i);
            }
        }
    } // End Method    
} // End Class