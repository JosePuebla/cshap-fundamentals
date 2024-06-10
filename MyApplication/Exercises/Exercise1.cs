
namespace MyFirstApplication;
internal class Exercise1
{
    //int value1 = 35;
    public void NumSysValue()
    {
        // Values of 35
        int value1 = 35; // decimal
        int value2 = 0x23; // hexadecimal
        int value3 = 0b100011; // binary
        Console.WriteLine(value1);
        Console.WriteLine(value2);
        Console.WriteLine(value3);
    }

    // implicit data casting
    public void implicitData(byte value1, short value2, int value3)
    {
        int byteToInt = value1;
        Console.WriteLine(byteToInt);

        long extend = value2;
        Console.WriteLine(extend);

        float intToFloat = value3;
        Console.WriteLine(intToFloat);
    }

    // explicit casting
    public void explicitData(double value1, float value2, long value3)
    {
        long doubleToLong = (long)value1;
        Console.WriteLine(doubleToLong);

        int floatToInt = (int)value2;
        Console.WriteLine(floatToInt);

        short longToShort = (short)value3;
        Console.WriteLine(longToShort);
    }
}
