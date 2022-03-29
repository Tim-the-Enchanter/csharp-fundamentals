// CAC-103 Lesson 1 Lab Exercise

namespace MyFirstApplication;

/*
 This Is Exercise 1 through 4 from Lesson 1.
 */

public class Exercise1
{

    // Exercise 1. print the output of the number 35 based on the number systems decimal, hexadecimal and binary
    public void ExerciseOutput()
    {
        // value of 35
        int value1 = 35; // decimal
        int value2 = 0x23; //hexadecimal
        int value3 = 0b100_011; // binary
        Console.WriteLine(value1);
        Console.WriteLine(value2);
        Console.WriteLine(value3);
    }

    /*
    Exercise 2. Write a method that will accept 3 argument parameters and a void return type.
    // Parameters are byte, short and int. Use Implicit conversion with variables converted
    from byte to int, from short to long and int to float
    */
    public void ImplicitConvert(byte myByte, short myShort, int myInt2)
    {

        int myInt = myByte;
        Console.WriteLine(myInt);

        long myLong = myShort;
        Console.WriteLine(myLong);

        float myFloat = myInt2;
        Console.WriteLine(myFloat);
    }

    /*
    Exercise 3.Write a method that will accept 3 argument parameters and a void return type.
    The first argument should be of type double. The second argument should be of type float.
    The third argument should be of type long. Using Explicit conversion, create variables to
    convert tousingthe below information.Use the argumentparameters as the values to convert from.
    Print each converted variable using Console WriteLine. 
    a.From double to long
    b.From float to int
    c.From long to short
    */

    public void ExplicitConvert(double myDouble, float myFloat, long myLong2)
    {        
        long myLong = (long)myDouble;      
        Console.WriteLine(myLong);
       
        int myInt = (int)myFloat;
        Console.WriteLine(myInt);

        short myShort = (short)myLong2;
        Console.WriteLine(myLong2);
    }


    /*
    4. Write a method with no arguments and a void return type. Using the values below,
    assign them to a variable that best suits their value type. Utilize the digit separator
    when assigning them to your variables. Once you have defined your variables, print out
    each one using Console WriteLine.
    Do not use the same value type more than once.
    a.123456.987
    b.-9516248
    c.3500
    d.988562486
    e.-19733.14895
    */
    public void ValueTypes()
    {
        
        float value1 = 123_456.987F; // float
        int value2 = -9_516_248; // 32 bit int
        short value3 = 3_500; // short value
        uint value4 = 988_562_486; // uint value
        double value5 = -19_733.148_95; // double value

        Console.WriteLine(value1);
        Console.WriteLine(value2);
        Console.WriteLine(value3);
        Console.WriteLine(value4);
        Console.WriteLine(value5);

    }
}
