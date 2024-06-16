namespace MyFirstApplication;

internal class Exercise4
{

    // uses if else statement to compare two strings 
    public void TaskOne(string val1, string val2)
    {
        if (val1 == val2)
        {
            Console.Write($"Val1: {val1} is the same as val2: {val2}");
        }
        else
        {
            Console.WriteLine($"Val1: {val1} is not the same as Val2: {val2}");
        }
    } // end method

    public string TaskTwo(char arg)
    {
        switch (arg)
        {
            case 'E':
                return "Excellent";
            case 'V':
                return "Very Good";
            case 'G':
                return "Good";
            case 'A':
                return "Average";
            case 'F':
                return "Fail";
            default:
                return "Not a valid grade.";
        }
    }

    public void TaskThree()
    {
        for (int i = 0; i <= 15; i++)
        {
            if ((i % 3) == 0)
            {
                Console.WriteLine($"{i}");
            }
        }
    }

} // end method
