using MyFirstApplication;
using MyFirstApplication.Lessons;

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
// Lesson2Example();
// Exercise1Test();
// Exercise2();
// Lesson3Example();
Exercise3();




// Lesson 3 Operators and Overflow Checking
void Lesson3Example()
{
    // Lesson3 myLesson3 = new Lesson3();
    // myLesson3.BasicCheckedOperator(14);
    // myLesson3.BasicCheckedExample2();
    // int alpha = 2147483647;
    // int total = alpha + 10;
    // Console.WriteLine(total);
    // -2147483639
    // myLesson3.BasicUncheckedExample();
    // myLesson3.BasicMath();
    // myLesson3.BasicModulus(783);
    // myLesson3.basicBooleanLogical(true, false);
    // myLesson3.BasicCompoundExample(12, 35, 9);
    // myLesson3.BasicRelationalExample("Tom", "Tim");
    // myLesson3.MyIncrDecrExample();

}



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

void Exercise1Test()
{
    Exercise1 myExercise1 = new Exercise1();
    myExercise1.ExerciseOutput();
    myExercise1.ImplicitConvert(10, 10, 10);
    myExercise1.ExplicitConvert(123.999, 456.5F, 789_712);
    myExercise1.ValueTypes();
}

/*
 This is to test Exercise 2. Lab Output
 */

void Exercise2()
{
    Exercise2 myExercise2 = new Exercise2();
    myExercise2.MyJoinedStrings(" EXERCISE two lab ");
    
    Console.WriteLine(myExercise2.MyMovieInfo());
    myExercise2.MyExampleChar();
    Console.WriteLine(myExercise2.MyNurseryRhyme());

    

}
// Exercise 3 lab test output

void Exercise3()
{
    Exercise3 myExercise3 = new Exercise3();
    Console.WriteLine(myExercise3.MyMathOps);

    myExercise3.MyCompoundOps(77, 69);


}





