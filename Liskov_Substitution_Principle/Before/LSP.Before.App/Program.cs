// See https://aka.ms/new-console-template for more information
using LSP.Before.Animals;

Console.WriteLine("Hello, World!");


BirdBase bird = new Sparrow();
bird.Eat();
bird.Fly();

bird = new Chicken();
bird.Eat();
bird.Fly(); // throw exception 

bird = new Eagle();
bird.Eat();
bird.Fly();


Console.ReadKey();
