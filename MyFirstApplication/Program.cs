using MyFirstApplication;

// See https://aka.ms/new-console-template for more information
// Console.WriteLine("Hello, World!");

// The below statement calls a local function   
// single line comment


/*
 Multi-line comment
The below statement is a local function. Local functions
are inside of members and are private by default. This means
They are specific to that member and can only be called
inside that member.
 */

// Lesson Examples
// HouseExample();
// Lesson1Example();
// MyLocalFunction();
// ExerciseOutput();
// ImplicitConvert();
// ExplicitConvert();
// ValueTypes();
Lesson2Example();


// Lesson 2 Strings
void Lesson2Example()
{
    Lesson2 myLesson2 = new Lesson2();
    myLesson2.MyTrimExample();
    int able = myLesson2.MyStringLength();
    Console.WriteLine(able);
    myLesson2.MyEqualsExample("Hello World");
    myLesson2.MyExampleChar();
    Console.WriteLine(myLesson2.MyEscapeExample());
    myLesson2.MyJoinedStrings("CSharp", "Rules");
    Console.WriteLine(myLesson2.MyInterpolationExample("pizza", 3));
    myLesson2.MyOtherInterpolation();

}


void HouseExample()
{
    House myHouse = new House();
    myHouse.DoorOpenClose();
}

// Lesson 1 Value Types

void Lesson1Example()
{
    Lesson1 myLesson = new Lesson1();
    myLesson.IntMinMax();
    myLesson.IntegralExample();
    myLesson.ConvertFloatToInt();
    myLesson.LongFromInt();
}

/*
 This local function is 
for my first exercise lab.
*/

void MyLocalFunction()
{
    Console.WriteLine("This is my first sentence");
    Console.WriteLine("I am new to CSharp");
    Console.WriteLine("This CSharp course is cool");
    Console.WriteLine("I am learning stuff every day.");
}

/*
 This local function is 
for exercise 1. lesson 1.
*/

/*
 This Is Exercise 1 through 4 from Lesson 1.
 */

 
// Exercise 1. print the output of the number 35 based on the number systems decimal, hexadecimal and binary
    
void ExerciseOutput()
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
void ImplicitConvert()
{

   byte myByte = 4;
   int myInt = myByte;
    Console.WriteLine(myInt);

   short myShort = 32;
   long myLong = myShort;
    Console.WriteLine(myLong);

   int myInt2 = 777;
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
    
void ExplicitConvert()
{

   double myDouble = 7.77;
   long myLong = (long)(double)myDouble;

   Console.WriteLine(myDouble);
   Console.WriteLine(myLong);

   float myFloat = 77.89F;
   int myInt = (int)myFloat;

   Console.WriteLine(myFloat);
   Console.WriteLine(myInt);

   long myLong2 = 777;
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
void ValueTypes()
{

    double value1 = 123_456.987; // double
    int value2 = -9_516_248; // 32 bit int
    short value3 = 3_500; // short value
    uint value4 = 988_562_486; // uint value
    decimal value5 = (decimal)-19_733.148_95; // long value

    Console.WriteLine(value1);
    Console.WriteLine(value2);
    Console.WriteLine(value3);
    Console.WriteLine(value4);
    Console.WriteLine(value5);
}



