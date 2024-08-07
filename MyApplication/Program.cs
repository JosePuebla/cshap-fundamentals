﻿using MyFirstApplication;
//using MyFirstApplication.Exercise1;

// See https://aka.ms/new-console-template for more information
// Console.WriteLine("Hello, World!");

// puts local function to use
// single line comment
// HouseExample(); 

/*
multi-line comment
the below statement is a local functoin. Local functions
are inside of members and are private by default. This means
They are specific to that member and can only be called 
inside that member. 
*/

// Lesson Examples 
// HouseExample();
// Lesson1Example();
// Lesson2Example();
// Lesson3Example();
// Lesson4Example();
// Lesson5Example();
// Lesson6Examples();
// Lesson7Example();
// Lesson8Example();
// Lesson9Example();
// Lesson10Example();
// HouseUpdate();
// Lesson11Example();
// Lesson12Example();
// CondoExample();
// Lesson13Example();
// Lesson14Example();
// Lesson15Example();
// Lesson16Example();
// Lesson17Example();

void Lesson17Example()
{
    Lesson17 myLesson17 = new Lesson17();
   House testHouse = null;
   House testhouse2 = new House();

   myLesson17.MyThrowExample(testhouse2);
   myLesson17.MyThrowExample(testHouse);

    //myLesson17.MyExceptionExample(testHouse);

    //myLesson17.MyArrayException();

}

void Lesson16Example()
{
    Lesson16 myLesson16 = new Lesson16();
    // myLesson16.MyListExample();
    myLesson16.MyDictionaryExample();
}

void Lesson15Example()
{
    Lesson15 myLesson15 = new Lesson15();
    //myLesson15.EnumExample();
    string flavor = myLesson15.FavoriteIceCream(IceCreamFlavors.Chocolate);
    //Console.WriteLine(flavor);

    //myLesson15.TupleExample();

    (int val1, int val2, int val3) = myLesson15.TupleReturnExample(11, 35);
    Console.WriteLine($"Answers are {val1}, {val2}, {val3}");
}

void Lesson14Example()
{
    Lesson14 myLesson14 = new Lesson14();
    // myLesson14.SingleIntArray();
    //myLesson14.SingleHouseArray();

    //myLesson14.MultiIntArray();
     myLesson14.MultiStringArray();

//    myLesson14.JaggedArraySample();
}


void Lesson13Example()
{
    Lesson13Derived myLesson13 = new Lesson13Derived(3);
    int total1 = myLesson13.ConvertFeetToInches();
    int total2 = myLesson13.ConvertYardsToFeet();

    Console.WriteLine($"Converting feet to inches {total1}");
    Console.WriteLine($"Converting yards to feet {total2}");

    // These are from the interface
    int total3 = myLesson13.ConvertMilesToYards();
    Console.WriteLine($"Converting Miles to Yards {total3}");
}

void CondoExample()
{
    Condo myCondo = new Condo();
    myCondo.Mainenance();
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

void Lesson11Example()
{
    Square square = new Square();
    double total = square.CalculateInteriorAngle();
    Console.WriteLine(total);

    Triangle triangle = new Triangle();
    double total2 = triangle.CalculateInteriorAngle();
    Console.WriteLine(total2);
}


void HouseUpdate()
{
    // Calling Default
    House myHouse = new House();
    Console.WriteLine(myHouse.RoofType);
    myHouse.DoorOpenClose();
    Console.WriteLine();

    // Calling Constructor with 2 parameters
    House mySecond = new House("Straw", "bamboo");
    Console.WriteLine(mySecond.WindowSize);
    mySecond.DoorOpenClose();
    Console.WriteLine();

    // Calling Constructor with 4 parameters
    House myThird = new House("dirt", "plastic", "green", 40);
    Console.WriteLine(myThird.Foundation);
    myThird.DoorOpenClose();

}

void Lesson10Example()
{
    Lesson10 myLesson10 = new Lesson10();
    // Normal property
    myLesson10.FirstName = "Paul";
    Console.WriteLine(myLesson10.FirstName);

    // Calling Auto(bots) Property
    // myLesson10.LastName = "Smith";  // only workds in Lesson10 constructor
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
    myLesson9.SampleProtectedInternal();
}

void Lesson8Example()
{
    Lesson8 myLesson8 = new Lesson8(3);
    // Calling constant directly (line 33)
    Console.WriteLine(Lesson8.DaysPerMonth);

    // Calculate Temperature
    Console.WriteLine(Lesson8Static.CelsiusToFahrenheit(45.6));

    // Static Methods
    Lesson8.DayCount = 10;
    myLesson8.CalculateHours();
    Lesson8.CalculateDayCount();
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
    Student myStudent = new Student(10, "Roger");
    Console.WriteLine(myStudent);
    Console.WriteLine(myStudent.StudentName);
    Console.WriteLine();

    // Record 
    Person person = new Person("Nancy", "Drew");
    Console.WriteLine(person);
    Console.WriteLine(person.lastName);

    // Struct Record
    Resolution res = new Resolution(1920, 1080);
    res.CalculateRes();
    Console.WriteLine(res);

}

// Lesson 6 
void Lesson6Examples()
{
    // Default Constructor
    Lesson6 myLesson6 = new Lesson6();
    Lesson6 myLessonHats = new Lesson6("Cowboy", 7);
    Lesson6.TryOn theHat = myLessonHats.TryOnHat;
    theHat($"I tried on a {myLessonHats.HatType} hat that was size {myLessonHats.HatSize}");

    Console.WriteLine();
/*
    // Constructor with 1 parameter
    Lesson6 myOther6 = new Lesson6(22);

    // Constructor with 2 parameters
    Lesson6 myHats = new Lesson6("Cowboy", 7);
    Console.WriteLine(myHats.HatSize); // getting value
    myHats.HatSize = 6; // setting value

    // Method parameter modifiers
    int able = 33, beta = 22, charlie; // in, ref, out

    myLesson6.InExample(able);
    myLesson6.RefExample(ref beta);
    Console.WriteLine(beta); // this is now 27 because it changed the value on the outside with the pas by reference
    myLesson6.OutExample(out charlie); // initializes the variable charlie
    Console.WriteLine(charlie);

    Console.WriteLine();

    // Multi-cast delegate
    Lesson6.TryOn theNewHat, hangTheHat, multiHat;
    theNewHat = myLesson6.TryOnHat;
    hangTheHat = myLesson6.HangUpHat;
    multiHat = theNewHat + hangTheHat;

    theNewHat($"Trying a {myLessonHats.HatType} hat");
    hangTheHat($"Hanging up my {myLessonHats.HatType} hat");
    multiHat($"My {myLessonHats.HatType} hat");
    */
}


// Lesson 5 expressions and pattern matching
void Lesson5Example()
{
    Lesson5 myLesson5 = new Lesson5();
    myLesson5.IsOperatorExample(34);

    Lesson5.Del handler = myLesson5.DelegateMethod;
    handler("Hello CSharp");

    // Func delegate
    Func<int, int> add = myLesson5.Sum;
    Console.WriteLine($"Func example = {add(23)}");

    //Lambda Expression
    myLesson5.LambdaSquare();
    myLesson5.LambdaGreeting();

    // Switch Expressions
    string value1 = myLesson5.BasicSwtich("red");
    string value2 = myLesson5.FavoriteColor("green");
    Console.WriteLine(value1);
    Console.WriteLine(value2);

    // Relational Pattern 
    myLesson5.DrinkSize(33);

    // logical patterns
    myLesson5.TemperatureGuide(48.6);
    myLesson5.NumberChoice(3);

}

// Lesson 4 Control Flow

void Lesson4Example()
{
    Lesson4 myLesson4 = new Lesson4();
    // myLesson4.BasicIfStatement(8);
    //myLesson4.BasicIfElseStatement(12);
    //myLesson4.BasicIfElseChainStatement(5);
    //myLesson4.BasicAndOrCondition(20, 20);
    //Console.WriteLine(myLesson4.BasicTernaryExample(35));
    //myLesson4.BasicSwitchStatement(5);
    //myLesson4.BasicWhileStatement();
    //myLesson4.BasicDoStatement();
    //myLesson4.BasicForStatement();
    //myLesson4.BasicForEachStatement();
    myLesson4.BasicJumpStatement();

}

// Lesson 3 Operators
void Lesson3Example()
{
    Lesson3 myLesson3 = new Lesson3();
    // myLesson3.BasicCheckedOperator(14);
    // myLesson3.BasicCheckdExample2();
    //int alpha = 2147483647;
    /*int total = alpha + 10;
    Console.WriteLine(total);
     -2147483639 : 9 spots away, happens because we are going out of range 
    */
    // myLesson3.BasicUncheckedExample();
    // myLesson3.BasicMath();
    // myLesson3.BasicModulus(783);
    // myLesson3.BasicBooleanLogical(true, false);
    // myLesson3.BasicCompoundExample(12, 35, 9);
    // myLesson3.BasicRelationalExample("Tom", "Tim");
    myLesson3.MyIncrDecrExample();
}



// Lesson 2 Strings
void Lesson2Example()
{
    Lesson2 myLesson2 = new Lesson2();
    myLesson2.MyTrimExample();
    int able = myLesson2.MyStringLength();
    Console.WriteLine(able);
    myLesson2.MyEqualsExample("Hello world");
    myLesson2.MyExampleChar();
    Console.WriteLine(myLesson2.MyEscapeExample());
    // either assign to a variable then console.write line or do this ^^
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

 This local function is for my first exercise lab
 
myLocalFunction();

void myLocalFunction()
{
    Console.WriteLine("This is my first sentence");
    Console.WriteLine("I am new to CSharp");
    Console.WriteLine("This CSharp course is cool");
    Console.WriteLine("I am learning new stuff everyday");
} */


// Exercises / labs

//Exercise17Labs();
void Exercise17Labs()
{
    Exercise17 errors = new Exercise17();
    //errors.DivisionTask(15, 0);

    Horse nullType = null;
    //errors.TaskTwo(nullType);

    Horse nonNull = new Horse();
    errors.TaskTwo(nonNull);

}


// Exercise 16 Collections
// Exercise16Collections();

void Exercise16Collections()
{
    Exercise16 collections = new Exercise16();
    //collections.TaskOne();
    collections.TaskTwo();
}



// Exercise 15 Enums & Tuples
//Exercise15Enums();

void Exercise15Enums()
{
    Exercise15 enumTuples = new Exercise15();
    string movies = enumTuples.TaskOneEnums(FavoriteMovies.Brave);
    //Console.WriteLine(movies);

    (int val1, string val2) = enumTuples.TaskTwo(FavoriteMovies.HowlsMovingCastle);
    //Console.WriteLine(val1);
    //Console.WriteLine();
    //Console.WriteLine(val2);
    Console.WriteLine($"My favorite movie is {val2}, and it is in position {val1}");
}

// Exercise 14 Arrays
// Exercise14Arrays();

void Exercise14Arrays()
{
    Exercise14 arrays = new Exercise14();
    //arrays.TaskOne();
    arrays.TaskTwo();
}

// Exercise 13 lab test
//Lab13Test();

void Lab13Test()
{
    DerivedBirds waterBird = new DerivedBirds(4);
    Console.WriteLine(waterBird.Speed);
    waterBird.Fly();
    waterBird.Swim();

}

// Exercise 10 Lab

// HorseExample();
// BoatExample();

void HorseExample()
{
    
    // Calling Default
    Horse myHorse = new Horse();
    Console.WriteLine(myHorse.HorseSpecies);
    Console.WriteLine(myHorse.ManeStyle);
    myHorse.RunWalk("Quarter Horse");
    Console.WriteLine();

    // Calling Constructor with 2 parameters
    Horse secondHorse = new Horse("short" , "Quarter Horse");
    Console.WriteLine(secondHorse.HorseSpecies);
    Console.WriteLine(secondHorse.ManeStyle);
    Console.WriteLine();

    // Calling Constructor with all 3 parameters
    Horse thirdHorse = new Horse("Long mane", "Zerba", "Zoo Animal");
    Console.WriteLine(thirdHorse.HorseSpecies);
    Console.WriteLine(thirdHorse.ManeStyle);
    Console.WriteLine(secondHorse.HorseJob);
    Console.WriteLine();
    
    Pony pony = new Pony();
    Console.WriteLine(pony.PonySizeHands);
    Console.WriteLine(pony.HorseJob);
    Console.WriteLine(pony.Gender);
    Console.WriteLine(pony.ManeStyle);
    pony.RunWalk();
    pony.EatSleep();
    Console.WriteLine();

    Pony secondPony = new Pony("Short", "Show Pony", "Female");
    Console.WriteLine(secondPony.HorseJob);
    Console.WriteLine(secondPony.Gender);
    Console.WriteLine(secondPony.HorseSpecies);
}

void BoatExample()
{
    // Calling Default
    Boat myBoat = new Boat();
    Console.WriteLine(myBoat.BoatSizeFeet);
    myBoat.MotorOnOff("Speedboat");
    Console.WriteLine();

    // Calling Constructor with 2 parameters
    Boat secondBoat = new Boat("Red", 35);
    Console.WriteLine(secondBoat.BoatSizeFeet);
    Console.WriteLine(secondBoat.BoatBuild);
    Console.WriteLine();

    // Calling Constructor with 3 parameters
    Boat thirdBoat = new Boat("blue", "sailboat", 40);
    Console.WriteLine(thirdBoat.BoatColor);
    Console.WriteLine(thirdBoat.BoatBuild); // using to test
    Console.WriteLine(thirdBoat.BoatSizeFeet);

    Sailboat sailboat = new Sailboat();
    sailboat.MotorOnOff();
    sailboat.RaiseLowerSails();

}

// Exercise 8 Lab
//Exercise8Lab();

void Exercise8Lab()
{
    Exercise8 conversion = new Exercise8();
    conversion.FeetToInches(3);

    // Task Two Static Method
    Exercise8.PolygonArea(2, 3);

}

// Exercise 7 Lab (demo may not be needed but doing it as practice)
// Exercise7Lab();

void Exercise7Lab()
{
    Exercise7.Boat boat = new Exercise7.Boat("Red", "S.S. Sandy");
    Console.WriteLine(boat.boatColor);
    Console.WriteLine(boat.boatName);
    Console.WriteLine(boat);
}
// Exercise 6 Lab
// Exercise6Lab();

void Exercise6Lab()
{
    Exercise6 shoeExample = new Exercise6(9, "Nike");
    Exercise6.TryOn theShoe = shoeExample.TaskThree;
    theShoe($"I tried on a {shoeExample.ShoeType} shoe that was size {shoeExample.ShowSize}");

}

// Exercise 5 Lab 
//Exercise5Lab();

void Exercise5Lab()
{
    Exercise5 myExercise = new Exercise5();

    Console.WriteLine(myExercise.TaskOne(23, 35));

    Console.WriteLine(myExercise.TaskTwo('B'));

    myExercise.TaskThree(20);
}

// Exercise 4 Lab
// Exercise4Lab();

void Exercise4Lab()
{
    Exercise4 myExercise = new Exercise4();
    myExercise.TaskOne("word", "Word");
    Console.WriteLine(myExercise.TaskTwo('F'));
    myExercise.TaskThree();
}


// Exercise 3 Lab
// Exercise3Lab();

void Exercise3Lab()
{
    Exercise3 myExercise = new Exercise3();
    Console.WriteLine(myExercise.TaskOne(4));
    myExercise.TaskTwo();
    myExercise.TaskThree(4, 5);
}

// Exercise 2 Lab
// Exercise2Lab();
void Exercise2Lab()
{
    Exercise2 myExercise = new Exercise2();
    myExercise.TaskOne();
    myExercise.TaskTwo();
    myExercise.TaskThree();
}
void Exercise1Example()
{
    Exercise1 myExercise = new Exercise1();
    myExercise.NumSysValue();
}

