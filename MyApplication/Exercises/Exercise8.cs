namespace MyFirstApplication;

internal class Exercise8
{
    // const variable
    public const int Inches = 12;

    public void FeetToInches(int feet)
    {
        int total = feet * Inches;
        Console.WriteLine($"Feet to inches = {total}");
    }

    public static void PolygonArea(int length, int width)
    {
         int area = length * width;
        Console.WriteLine($"The area of our Polygon is - {area}");
    }
} //  end class