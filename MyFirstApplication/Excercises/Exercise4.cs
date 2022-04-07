﻿// CAC-103 Exercise 4 Lab Control Flow Statements
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

        string AAA = arg1;
        string ZZZ = arg2;

        if (arg1 == AAA)
        {
            Console.WriteLine($"This is string {arg1}.");
        }
        else 
        {
            Console.WriteLine($"This is string {arg2}.");
        }

     



    } // End Method

    /*
     Write a method that will take 1 char argument and a string return type. Using a switch and the table below,
    return the description. If the value does not match the grade, return the default message, “Not a valid grade”     
     */

    public void MyValidGrade(int /*char?*/ arg3)
    {
        switch (arg3)
        {
            case 1:
                Console.WriteLine($"{arg3} is ");
                break;
            case 2:
                Console.WriteLine($"{arg3 is 1 or 2}");
                break;
            case 3:
                Console.WriteLine($"{arg3} is 3");
                break;
            case 4:
                Console.WriteLine($"{arg3} is 4");
                break;
            default:
                Console.WriteLine($"{arg3} was not in the list");
                break;
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
            if (i == 2)
            {
                Console.WriteLine($"The {i} was skipped");
                continue;
            }
            if (i == 4)
            {
                Console.WriteLine($"THe Loop breaks at {i}");
                break;
            }
            Console.WriteLine($"Number = {i}");
        }

    } // End Method    
} // End Class