// CAC-103 Lesson 2 Lab Exercise Strings & More

namespace MyFirstApplication;

/*
 This Is Exercise 1 through 4 from Lesson 1.
 */
/*
   1. Write a method that takes a string argument parameter and void return type.
   Using string concatenation and the below string methods, write a Console WriteLine statement for each of them.
   Inside the string concatenation will be the name of each string method.When testing this method use the following
   string " EXERCISE two Lab ". Do not copy and paste this in Visual Studio. It will not paste correctly.
   a. Trim()
   b. ToLower()
   c. Contains(“tow”)
   d. Length()
   e. IndexOf(‘C’)
   */
internal class Exercise2
{
    string myString = " EXERCISE two lab ";

    public void MyJoinedStrings(string value1)
    {
        Console.WriteLine("This Is Exercise 1 from Lesson 2 Lab.");

        string myTrim = myString.Trim();
        Console.WriteLine("Trim() =" + myString.Trim());

        string myLower = myString.ToLower();
        Console.WriteLine("Lower() =" + myString.ToLower());

        Console.WriteLine("Contains() =" + myString.Contains("tow"));

        string myLength = " EXERCISE two lab ";
        Console.WriteLine("Length() =" + myString.Length);

        string myString2 = " Exercise two lab ";
        Console.WriteLine("IndexOf() =" + myString2.IndexOf('C'));


    } // End Method

        /*
        2. Write a method that takes no arguments and a void return type.
       Using the Unicode table resource link, assign the Unicode value of the Pilcrow Sign
       to a variable. Use the Console WriteLine to print that variable. This variable should 
       utilize the type that takes 1 character.
        */

        // char myUni = '\u00b6';

    public void MyExampleChar()
    {
        char myChar = '\u00b6';
        
        Console.WriteLine(myChar);
    } // End Method

    /*
    3. Write a method that takes no arguments and a void return type. Use1 string variable and
    1 Console WriteLine to complete this task. Use escape sequences to achieve the below results.
    Output:Jack and Jill went up the hill to fetch a pail of water.
    Jack fell down and broke his crownand Jill came tumbling after.
    */

    public string MyNurseryRhyme()
    {
        return "Jack and Jill \nwent up the hill \nto fetch a pail of water \nJack fell down and broke his crown" +
            "\nand Jill came tumbling after.";
    }

    /*
    4. Write a method that takes no arguments but does have a string return type.
    You will utilize Interpolation to complete this task. Create variables for each provided data below.
    Using Interpolation return a string that includes the variables in a sentence.
    a.Name
    b.Favorite movie
    c.Favorite movie snack
    d.Favorite movie drink
    */

    public string MyMovieInfo(string food, int amount)
    {
    void MyMovieInfo()
    Console.WriteLine(MyMovieInfo("Tim", "5th Element", "Mike n Ikes", "Coke"));
    MyMovieInfo();
    }


} // END Class

