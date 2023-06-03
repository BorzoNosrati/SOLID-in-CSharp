namespace LSP.Before.Animals;

public class Eagle : BirdBase
{
    public override void Eat() => Console.WriteLine($"Eagle is eatting ...");
    public override void Fly() => Console.WriteLine($"Eagle is flying ...");
}
