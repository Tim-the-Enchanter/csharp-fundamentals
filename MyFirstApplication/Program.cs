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
// Exercise5();
// Lesson6Examples();
// Exercise6();
// BottlesOfBeerSong();
// Lesson7Example();
// Exercise7();
// Lesson8Example();
// Exercise8a();
// Lesson9Example();
// Lesson10Example();
// HouseUpdated();
// HorseObj();
// EngineState();
// Lesson11Example();
// StallionChild();
// YachtChild();
// CondoExample();
// Lesson12Example();
// Lesson13Example();
// Exercise13OP();
// Lesson14Example();
// Exercise14();
// Lesson15Example();
// Exercise15();
// Lesson16Example();
// Exercise16();
// Lesson17Example();
Exercise17();

void Lesson17Example()
{
    Lesson17 myLesson17 = new Lesson17();
    House testhouse = null;
    // myLesson17.MyThrowExample(testhouse);
    myLesson17.MyExceptionExample(testhouse);
}


void Lesson16Example()
{
    Lesson16 myLesson16 = new Lesson16();
    myLesson16.MyListExample();
    myLesson16.MyDictionaryExample();
}

void Lesson15Example()
{
    Lesson15 myLesson15 = new Lesson15();
    myLesson15.EnumExample();
    string flavor = myLesson15.FavoriteIceCream(IceCreamFlavors.Chocolate);
    //Console.WriteLine(flavor);
    // myLesson15.TupleExample();
    (int val1, int val2, int val3) = myLesson15.TupleReturnExample(11, 35);
    // Console.WriteLine($"Answers are {val1}, {val2}, {val3}");
}

void Lesson14Example()
{
    Lesson14 myLesson14 = new Lesson14();
    // myLesson14.SingleIntArray();
    // myLesson14.SingleHouseArray();
    // myLesson14.MultiIntArray();
    // myLesson14.MultiStringArray();
    myLesson14.JaggedArraySample();
}

void Lesson13Example()
{
    Lesson13Derived myLesson13 = new Lesson13Derived(3);
    int total1 = myLesson13.ConvertFeetToInches();
    int total2 = myLesson13.ConvertYardstoFeet();

    Console.WriteLine($"Converting feet to inches {total1}");
    Console.WriteLine($"Converting yards to feet {total2}");

    // These are from the interface
    int total3 = myLesson13.ConvertMilesToYards();
    Console.WriteLine($"Converting Miles to Yards {total3}");
}

void CondoExample()
{
    Condo myCondo = new Condo();
    myCondo.Maintenance();
    myCondo.DoorOpenClose();
    Console.WriteLine(myCondo.RoofType);
}

void Lesson12Example()
{
    Fruit myFruit = new Fruit();
    myFruit.EatFruit();
    myFruit.EatFruit(3);

    Apple myApple = new Apple();
    myApple.EatFruit();
}

void YachtChild()
{
    Yacht myYacht = new Yacht();
    myYacht.YachtChild();
}

void StallionChild()
{
    Stallion myStallion = new Stallion();
    myStallion.HorseState();
}

void Lesson11Example()
{
    Square square = new Square();
    double total = square.CalculateInteriorAngle();
    Console.WriteLine(total);

    Triangle triangle = new Triangle();
    double total2 = triangle.CalculateInteriorAngle();
    Console.WriteLine(total2);

}

void EngineState()
{    
    Boat myBoat = new Boat("white", "sail");
    Console.WriteLine(myBoat.Color);
}

void HouseUpdated()
{
    // Calling Default
    House myHouse = new House();
    Console.WriteLine(myHouse.RoofType);
    myHouse.DoorOpenClose();

    // Calling Constructor with 2 parameters
    House mySecond = new House("straw", "bamboo");
    Console.WriteLine(mySecond.WindowSize);
    mySecond.DoorOpenClose();

    // Calling Constructor with 4 parameters
    House myThird = new House("dirt", "plastic", "green", 40);
    Console.WriteLine(myThird.Foundation);
    myThird.DoorOpenClose();
}


void Lesson10Example()
{
    Lesson10 myLesson10 = new Lesson10();

    // Using this to call another constructor
    Console.WriteLine(myLesson10.FirstName);

    // Normal property
    myLesson10.FirstName = "Paul";
    Console.WriteLine(myLesson10.FirstName);

    // Calling Auto Property
    // myLesson10.LastName = "Smith"; // only works in Lesson10 constructor
    Console.WriteLine(myLesson10.Id); // default value
    myLesson10.Id = 1500;
    Console.WriteLine(myLesson10.Id); // get 1500

    // Expression Body Property
    myLesson10.Address = "123 Main St.";
    Console.WriteLine(myLesson10.Address);

    // Second constructor
    Lesson10 myOther10 = new Lesson10("Ben", "Franklin", 64119);
    Console.WriteLine(myOther10.ZipCode);

}


void Lesson9Example()
{
    Lesson9 myLesson9 = new Lesson9();
    Lesson9.Nested nested = new Lesson9.Nested(myLesson9);

    // Access Modifiers
    myLesson9.SampleInternal();
    // myLesson9.SamplePrivate(); inaccessible as private
    myLesson9.SampleProtectedInternal();
}

void Lesson8Example()
{
    Lesson8 myLesson8 = new Lesson8(3);
    // Calling constant directly
    Console.WriteLine(Lesson8.DaysPerMonth);

    // Calculate temperature
    Console.WriteLine(Lesson8Static.CelsiusToFahrenheit(45.6));

    // Static methods
    Lesson8.DayCount = 10;
    myLesson8.CalculateHours();
    // Lesson8.CalculateDayCount();
    Console.WriteLine($"The calculation has been done {Lesson8.DayCount} times");

    // Static Lambda
    myLesson8.CalculateHoursV2();
}


void Lesson7Example()
{
    Location myLocation = new Location(34.5, 47.8);
    Console.WriteLine(myLocation.Latitude);
    Console.WriteLine(myLocation);

    // Readonly Struct
    Student myStudent = new Student(777, "Tim");
    Console.WriteLine(myStudent);
    Console.WriteLine(myStudent.StudentName);

    // Record
    Person person = new Person("Nancy", "Drew");
    Console.WriteLine(person);
    Console.WriteLine(person.LastName);

    // Struct Record
    Resolution res = new Resolution(1920, 1080);
    res.CalculateRes();
    Console.WriteLine(res);
}

void Lesson6Examples()
{
    // Default Constructor
    Lesson6 mylesson6 = new Lesson6();
    Lesson6 myLessonHats = new Lesson6("Cowboy", 7);
    Lesson6.TryOn theHat = myLessonHats.TryOnHat;
    theHat($"I tried on a {myLessonHats.HatType} hat that was size { mylesson6.HatSize}");

    Console.WriteLine();

    // Constructor with 1 parameter
    Lesson6 myOther6 = new Lesson6(22);

    // Constructor with 2 parameters
    Lesson6 myHats = new Lesson6("Cowboy", 7);
    Console.WriteLine(myHats.HatSize); // getting value
    myHats.HatSize = 6; // setting value

    // Method Parameter Modifiers
    int able = 33, beta = 22, charlie;

    mylesson6.InExample(able);
    mylesson6.RefExample(ref beta);
    Console.WriteLine(beta);
    mylesson6.OutExample(out charlie);
    Console.WriteLine(charlie);
    
    Console.WriteLine();

        // Multi-cast Delegate
    Lesson6.TryOn theNewHat, hangTheHat, multiHat;

    theNewHat = mylesson6.TryOnHat;
    hangTheHat = mylesson6.HangUpHat;
    multiHat = theNewHat + hangTheHat;

    theNewHat($"Trying a {myLessonHats.HatType} hat");
    hangTheHat($"Hanging up my {myLessonHats.HatType} hat");
    multiHat($"My {myLessonHats.HatType} hat");
}

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

// Lesson 1 Value Types

void Lesson1Example()
{
    Lesson1 myLesson = new Lesson1();
    myLesson.IntMinMax();
    myLesson.IntegralExample();
    myLesson.ConvertFloatToInt();
    myLesson.LongFromInt();
}

void HouseExample()
{
    House myHouse = new House();
    myHouse.DoorOpenClose();
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
void Exercise6()
{
    // Constructor
    Exercise6 myexercise6 = new Exercise6(11, "Running");
    Exercise6.TryOn shoe = myexercise6.TryOnShoe;
    shoe($"I tried on a {myexercise6.ShoeType} shoe that was a size {myexercise6.ShoeSize}");

    Console.WriteLine();
}

void BottlesOfBeerSong()
{
    BottlesOfBeer myBottlesOfBeer = new BottlesOfBeer();
    myBottlesOfBeer.LetsSing();
}

void Exercise7()
{
    // Readonly Struct
    Employee myEmployee = new Employee(78, "Tim");
    Console.WriteLine(myEmployee.EmployeeName);

    // Struct Record
    BoatRecord myBoat = new BoatRecord("White", "Yacht");
    myBoat.BoatRec();
    Console.WriteLine(myBoat);
}

void Exercise8a()
{
    Exercise8 myExercise8 = new Exercise8();
    myExercise8.FeetToInches(3);
    Exercise8.LgthXWdth(7, 7);
}

void HorseObj()
{
    Horse myHorse = new Horse();
    myHorse.HorseState();
    Console.WriteLine(myHorse.HorseMane);
    myHorse.HorseState();
    myHorse.HorseState("psycho");

    Stallion myStallion = new Stallion();
    myStallion.HorseState();
}

void Exercise13OP()
{
    LandBird myLandBird = new LandBird(10);
}

void Exercise14()
{
    Exercise14 myExercise14 = new Exercise14();
    // myExercise14.IceCreamFlavors();
    myExercise14.RegSeasonScores();
}

void Exercise15()
{
    Exercise15 myExercise15 = new Exercise15();
    string movie = myExercise15.MyFavorite(favoriteMovies.DeadPool);
    Console.WriteLine(movie);
    (int val1, string val2 )= myExercise15.MyMovie(0);
}
void Exercise16()
{
    Exercise16 myExercise16 = new Exercise16();
    myExercise16.MyHorseList();
    myExercise16.MyMovieDictionary();
}

void Exercise17()
{   
    Exercise17 myExercise17 = new Exercise17();
    myExercise17.DivByZeroTest(5, 0);
    Horse testHorse = null;
    myExercise17.NullTest(testHorse);
}
