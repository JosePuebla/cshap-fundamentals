namespace MyFirstApplication;

// Base calsswith a method declared virtual for overriding
public class Fruit
{
    public virtual void EatFruit()
    {
        Console.WriteLine("I eat Fruit");
    }
    public void EatFruit(int quantity)
    {
        Console.WriteLine($"I eat {quantity} portions of fruit everyday.");
    }

} // end class


// Derived class overriding the base class method
public class Apple : Fruit
{
    public override void EatFruit()
    {
        base.EatFruit();
        Console.WriteLine("I eat apples");
    }
} // end class