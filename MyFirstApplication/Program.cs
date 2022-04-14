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
// Lesson2Example();
// Exercise1Test();
// Exercise2();
// Lesson3Example();
// Exercise3();
// Lesson4Example();
// Exercise4();
// Lesson5Example();
Exercise5();

// Lesson 5 Expressions & Pattern MAtching
void Lesson5Example()
{ 
    Lesson5 mylesson5 = new Lesson5();

    // Call method of myLesson5
    // mylesson5.IsOperatorExample(34);

    Lesson5.Del handler = mylesson5.DelegateMethod;
    // handler("Hello CSharp");

    // Function Delegate
    Func<int, int> add = mylesson5.Sum;
    // Console.WriteLine($"func example = {add(23)}");

    // Lambda Expression
    // mylesson5.LambdaSquare();
    // mylesson5.LamdaGreeting();

    // Switch Expressions
    string value1 = mylesson5.BasicSwitch("red");
    // Console.WriteLine(value1);
    string value2 = mylesson5.FavoriteColor("gray");
    // Console.WriteLine(value2);

    // Relational Pattern
    // mylesson5.DrinkSize(33);

    // Logical Patterns
    // mylesson5.TemperatureGuide(48.6);
    // mylesson5.NumberChoice(3);

}

// Lesson 4 Control Flow
void Lesson4Example()
{
    Lesson4 myLesson4 = new Lesson4();
    // myLesson4.BasicIfStatement(11);
    // myLesson4.BasicIfElseStatement(12);
    // myLesson4.BasicIfElseChainStatement(5);
    // myLesson4.BasicAndOrCondition(20, 20);
    // Console.WriteLine(myLesson4.BasicTernaryExample(25));
    // myLesson4.BasicSwitchStatement(1);
    // myLesson4.BasicWhileStatement();
    // myLesson4.BasicDoStatement();
    // myLesson4.BasicForStatement();
    // myLesson4.BasicForeachStatement();
    // myLesson4.BasicJumpStatement();


    }

// Lesson 3 Operators and Overflow Checking
void Lesson3Example()
{
    Lesson3 myLesson3 = new Lesson3();
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
    // myExercise3.MyModulus(5);
    // myExercise3.MyMathOps();
    // myExercise3.MyCompoundOps(25, 5);
    // myExercise3.MyBoolLogical(true, false);
    // myExercise3.MyBoolLogical(false, false);
    // myExercise3.MyBoolLogical(true, true);
    // myExercise3.MyBoolLogical(false, true);


}

void Exercise4()
{
    Exercise4 myExercise4 = new Exercise4();
    
    // myExercise4.BasicEqualsTest();
    myExercise4.BasicEqualsTest("AAA", "AAA");
    Console.WriteLine(myExercise4.MyValidGrade('E'));
    myExercise4.MyIteration();
    
}

void Exercise5()
{
    Exercise5 myExercise5 = new Exercise5();

    Console.WriteLine(myExercise5.OhmsLaw(55,6));
    Console.WriteLine(myExercise5.ValidCheck("E"));
    myExercise5.PopcornSize(64);
}





