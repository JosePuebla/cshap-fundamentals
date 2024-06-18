namespace MyFirstApplication;
internal class Exercise5
{
    public int TaskOne(int current, int resistance)
     {
        Func<int, int, int> Voltage = volts;

        int volts(int current, int resistance) => current * resistance;
        return Voltage(current, resistance);
    }

    public string TaskTwo(char grade)
    {
        string result = grade switch
        {
            /*"blue" => "Favorite color is blue",
            "red" => "Favorite color is red",
            "green" => "Favorite color is green",
            _ => "Not Sure" */
            'E' => "Excellent",
            'V' => "Very Good",
            'G' => "Good",
            'A' => "Average",
            'F' => "Fail",
            _ => "Not a valid grade"
        };
        return result;
    }

    public void TaskThree(int size)
    {
        string sizeValue = size switch
        {
            <= 3 => "Microwave Bag",
            <= 16 => "Movie Sack",
            <= 32 => "Movie Cup",
            <= 64 => "Movie Tub",
            _ => "We dont have that size"
        };
        Console.WriteLine(sizeValue);
    }
}
