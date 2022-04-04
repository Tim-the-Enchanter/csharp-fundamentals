// CAC-103 Lesson 3 Lab Exercise Operators
namespace MyFirstApplication;

internal class Exercise3
{
    /*
     1.Write a method that takes 1 int argument and an int return type. Utilize the modulus operator to complete this task.
    Assign the data values below to their own variables. Use the Console WriteLine state mention the first 4 variables 
    listed below and calculate the modulus with the passed in argument parameter. Using the last variable below, calculate
    the modulus with the passed in argument parameter and return it. 
    a.15
    b.456
    c.23
    d.89
    e.245
    */
    int total1 = 15;
    int total2 = 456;
    int total3 = 23;
    int total4 = 89;


    public void MyModulus(in int arg)
    {
        // int total1 = 15 % total1;
        Console.WriteLine(total1);

        // int total2 = 456 % total2;
        Console.WriteLine(total2);

        // int total3 = 23 % total3;
        Console.WriteLine(total3);

        // int total4 = 89 % total4;
        Console.WriteLine(total4);
    } // End Method

    /*
     2. Write a method that takes no arguments and a void return type. Utilizing the math problem in this task, 
    fill in any missing pieces to get the output. 10 + 32 * 12 / 3. Write a Console.WriteLine to solve each output.
    a.Output: 138
    b.Output: 168
    c.Output: 131
    */
    public void MyMathOps()
    {
        int able = 32, beta = 12, delta = 10, echo = 3;


        int addTotal = delta + beta;
        int multiplyTotal = able * beta;
        int divideTotal = able / beta;

        Console.WriteLine($"Addition = {addTotal}");
        Console.WriteLine($"Multiplication = {multiplyTotal}, Division = {divideTotal}");
    } // End Method

    /* 
     3.Write a method that takes two short type arguments and a void return type. Using the Compound Assignment 
    operators below, use the first argument parameter as the left operand to get the result. Print each one using
    the Console WriteLine statement.
    a.+=
    b./=
    c.*=
    d.%=
    */

    public void MyCompoundOps(int val1, int val2)
    {
        val1 += val2;
        Console.WriteLine(val1);

        val1 /= (val2 + val1);
        Console.WriteLine(val1);

        val1 *= val2;
        Console.WriteLine(val1);

        val1 %= (val2 + val1);
        Console.WriteLine(val1);
    } // End Method

    /*
     Write a method that takes two bool type arguments and a void return type. Using Boolean Logical 
    operators &, |, ^, and || to complete this task. Use a Console.WriteLine statement to calculate each result
    using the operators. The second argument is the left operand. Use the below values when testing your method.
    Using comments, provide your output results inside the method after your statements.
    a.Argument1= true, Argument2 = false
    b.Argument1= false, Argument2 = false
    c.Argument1= true, Argument2 = true
    d.Argument1= false, Argument2 = true
     */

    public void MyBoolLogical(bool arg, bool arg2)
    {
        // And
        Console.WriteLine(arg & arg2);
        // Or
        Console.WriteLine(arg | arg2);
        //Exclusive Or
        Console.WriteLine(arg ^ arg2);
        // &&
        Console.WriteLine(23 > 10 && 10 < 5);
        // ||
        Console.WriteLine(23 > 10 || 10 < 7);
    } // End Method

} // End Class
