namespace LSP.Before.Animals;

public class Chicken : BirdBase
{
    public override void Eat() => Console.WriteLine($"Chicken is eatting ...");
    public override void Fly() => throw new Exception("A chicken cannot fly");
}