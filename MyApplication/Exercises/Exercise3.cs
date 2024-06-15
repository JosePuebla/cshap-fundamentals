

namespace MyFirstApplication;

internal class Exercise3
{
    public int TaskOne(int arg)
    {
        Console.WriteLine(15 % arg);
        Console.WriteLine(456 % arg);
        return 23 % arg;
    }

    public void TaskTwo()
    {
        int var1 = 10 + 32 * 12 / 3;
        int var2 = (10 + 32) * 12 / 3;
        Console.WriteLine(var1);
        Console.WriteLine(var2);
    }

    /*
     Write a method that take 2 short parameter arguments and a return type of void. 
    You will use the compound assignment operator for this task. 
    Use the first parameter argument as the left operand and the second parameter 
    argument as the right operand. 
    Use a Console WriteLine for each operator below to calculate their results.
    a.+=    b./=    c.*=    d.%=
     */
    public void TaskThree(short arg1, short arg2)
    {
        arg1 += arg2;
        Console.WriteLine(arg1);

        arg1 /= arg2;
        Console.WriteLine(arg1);

        arg1 *= arg2;
        Console.WriteLine(arg1);

        arg1 %= arg2;
        Console.WriteLine(arg1);
    }
}
