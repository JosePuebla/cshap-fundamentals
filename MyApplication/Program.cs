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
// Lesson2Example();
// Lesson3Example();
// Lesson4Example();

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

// Exercise 4 Lab
Exercise4Lab();

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

