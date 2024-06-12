using MyFirstApplication;
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
//Lesson2Example();

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

// Exercise 2 Lab



// Exercise1Example();
Exercise2Lab();
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