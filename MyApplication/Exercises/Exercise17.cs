namespace MyFirstApplication;

internal class Exercise17
{
    public void DivisionTask(int value1, int value2)
    {
        try
        {
            int division = value1 / value2;
            Console.WriteLine($"Division results of {value1} divided by {value2}: {division}");
        }
        catch (DivideByZeroException ex)
        {
            Console.WriteLine($"Cannot Divide by Zero: {ex.Message}");
        }
        //int division = value1 / value2;
    }

    public void TaskTwo(Horse horses)
    {
        if (horses == null)
        {
            throw new NullReferenceException("Horse object is null");
        }
        else
        {
            Console.WriteLine(horses.ManeStyle);
        }
    }


}
