namespace LSP.After.Animals;

public class Sparrow : FlyableBirdBase
{
    public override void Eat() => Console.WriteLine($"Sparrow is eatting ...");
    public override void Fly() => Console.WriteLine($"Sparrow is flying ...");
}
