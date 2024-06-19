namespace MyFirstApplication;

/*
 Constants and Static
 */
internal class Lesson8
{
    //Constant variables
    public const int Months = 12;
    public const int Weeks = 52; // per year
    public const int Days = 365; // per year
    public const int Hours = 60; // per day

    public const double DaysPerMonth = (double)Days / (double)Months;

    public static int DayCount;
    private int _days;

    public Lesson8(int calDays)
    {
        _days = calDays;
    }

    public static int CalculateDayCount()
    {
        return ++DayCount;
    }

    public void CalculateHours()
    {
        int total = Hours * _days;
        Console.WriteLine($"The total hours for {_days} days is {total}");
        CalculateDayCount();
    }

    public void CalculateHoursV2()
    {
        // int, int, what goes in, what goes out
        Func<int, int> totalhours = static value => Hours * value; // hours is a const which is implicitly static
        Console.WriteLine($"The total version2 hours for {_days} is " + 
            $"{totalhours(_days)}");
        // why we can use instance value _days here is because it is already made (constant value
        //CalculateDayCount()
    }

} //  end class
