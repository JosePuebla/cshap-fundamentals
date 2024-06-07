using MyFirstApplication;

// See https://aka.ms/new-console-template for more information
Console.WriteLine("Hello, World!");

//puts local function to use
//single line comment
HouseExample(); 

/*
multi-line comment
the below statement is a local functoin. Local functions
are inside of members and are private by default. This means
They are specific to that member and can only be called 
inside that member. 
*/
void HouseExample() //declares local function
{
    //this inner part can be done without the outer function
    House myHouse = new House();
    myHouse.DoorOpenClose();
}


/*
 This local function is for my first exercise lab
 */
myLocalFunction();

void myLocalFunction()
{
    Console.WriteLine("This is my first sentence");
    Console.WriteLine("I am new to CSharp");
    Console.WriteLine("This CSharp course is cool");
    Console.WriteLine("I am learning new stuff everyday");
}