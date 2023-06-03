// See https://aka.ms/new-console-template for more information
using LSP.After.Animals;

Console.WriteLine("Hello, World!");


FlyableBirdBase bird = new Sparrow();
bird.Eat();
bird.Fly();


bird = new Eagle();
bird.Eat();
bird.Fly();
//bird = new Chicken();  // alert : Chicken is not FlyableBirdBase class!! YOU CAN REPLACE IT.
//
var chicken  = new Chicken();

chicken.Eat();
//chicken.Fly();  // alert : Chicken does not contains a method for Fly;


// The app did not break 

Console.ReadKey();