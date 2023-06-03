namespace LSP.After.Animals;

public class Eagle : FlyableBirdBase
{
    public override void Eat() => Console.WriteLine($"Eagle is eatting ...");
    public override void Fly() => Console.WriteLine($"Eagle is flying ...");
}