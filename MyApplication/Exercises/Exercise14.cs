namespace MyFirstApplication;

internal class Exercise14
{
    public void TaskOne()
    {
        string[] iceCream = { "strawberry", "Cookie Dough", "Mint Chocolate Chip", "Vanilla" };

        foreach ( string flavor in iceCream)
        {
            Console.WriteLine(flavor);
        }
    } // end method

    public void TaskTwo()
    {
        int[,] scores = { { 34, 20, 20, 26, 32, 17, 16, 35, 33, 31, 24, 22, 27, 29, 17, 21, 22, 38, 31}, 
            { 20, 23, 34, 10, 40, 26, 43, 9, 31, 35, 27, 16, 33, 32, 14, 38, 17, 24, 9} };

            for(int k = 0; k < scores.GetLength(1); k++) // 0 < 19
                { 
                    Console.WriteLine($"Home: {scores[0, k]} Away: {scores[1, k]}");
                }
        
    }


} // end class
