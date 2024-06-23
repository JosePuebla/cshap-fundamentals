namespace MyFirstApplication;

public interface IMovement
{
    int Speed { get; init; }
}

internal abstract class WaterBirds : IMovement
{
    public abstract int Speed { get; init; }

    public abstract void Swim();
    public abstract void Fly();

    protected WaterBirds(int speed)
    {
        Speed = speed;
    }

}


internal class DerivedBirds : WaterBirds
{
    public override int Speed { get; init; }

    public override void Fly()
    {
        Console.WriteLine("WaterBirds going to fly");
    }

    public override void Swim()
    {
        Console.WriteLine("Waterbirds will now Swim");
    }

    public DerivedBirds(int value) 
    :base(value)
    { }
}