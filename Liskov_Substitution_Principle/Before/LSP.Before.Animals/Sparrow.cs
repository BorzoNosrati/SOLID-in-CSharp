namespace LSP.Before.Animals;

public class Sparrow : BirdBase
{
    public override void Eat() => Console.WriteLine($"Sparrow is eatting ...");
    public override void Fly() => Console.WriteLine($"Sparrow is flying ...");
}
