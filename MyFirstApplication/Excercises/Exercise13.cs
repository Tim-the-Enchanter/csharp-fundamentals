namespace MyFirstApplication;

internal interface IMovement //changed class to interface
{
    int Speed { get; init; }
} // end interface
internal abstract class WaterBirds : IMovement
{
    // Abstract Property
    public abstract int Speed { get; init; }

    // Abstract Methods
    public abstract void StateOfMotion();
    public abstract void GenderOfBird();

    // Constructor
    public WaterBirds(int speed)
    {
        this.Speed = speed;
    }
} // end interface

internal class LandBird : WaterBirds // derived class
{
    public LandBird(int speed) : base(speed) // constructor
    {
        Console.WriteLine($"Land birds move at {Speed} feet per second and are always {StateOfMotion}.");
        Console.WriteLine($"{GenderOfBird} land birds are vibrantly colored specemins.");
    }

    public override int Speed { get; init; } = 10; // implementation of property
    public override void StateOfMotion() // implementation of method
    {
        Console.WriteLine($"Land birds move at {Speed} feet per second and are always {StateOfMotion}.");
    }
    public override void GenderOfBird() // implementation of method
    {
        Console.WriteLine($"{GenderOfBird} land birds are vibrantly colored specemins.");
    }
}