
# Liskov Substitution Principle

>Liskov substitution principle is named after Barbara Liskov,
who first formulated it in 1988.

The Liskov substitution principle states 
that all classes should be 
substitutable for their base classes.

## Example

In this example we have the [Base Bird class](before/LSP.Before.Animals/BirdBase.cs) with two abstract method.
``` c#
public abstract class BirdBase
{
    public abstract void Eat();
    public abstract void Fly();
}
```

And there are three classes derived from the BirdBase Class.


``` c#
public class Sparrow : BirdBase
{
    public override void Eat() => Console.WriteLine($"Sparrow is eatting ...");
    public override void Fly() => Console.WriteLine($"Sparrow is flying ...");
}

public class Eagle : BirdBase
{
    public override void Eat() => Console.WriteLine($"Eagle is eatting ...");
    public override void Fly() => Console.WriteLine($"Eagle is flying ...");
}

public class Chicken : BirdBase
{
    public override void Eat() => Console.WriteLine($"Chicken is eatting ...");
    public override void Fly() => throw new Exception("A chicken cannot fly");
}
```

Now let's have a look at [Program.cs](before/LSP.Before.App/Program.cs)

```c#
BirdBase bird = new Sparrow();
bird.Eat();
bird.Fly();

bird = new Chicken();
bird.Eat();
bird.Fly(); // throw exception : A chicken cannot fly

bird = new Eagle();
bird.Eat();
bird.Fly();
```

As you see app break when a chicken wants to fly!

### Solution

We need to seperate the base class to two base classes and use the correct 
base class for derived classes.

``` c#
public abstract class BirdBase
{
    public abstract void Eat();
}
public abstract class FlyableBirdBase : BirdBase
{
    public abstract void Fly();
}
```

Now we should use  base Flyable class for flyable birds
and use base bird class for birds that cannot fly.

``` c#
public class Chicken : BirdBase
{
    public override void Eat() => Console.WriteLine($"Chicken is eatting ...");
}

public class Sparrow : FlyableBirdBase
{
    public override void Eat() => Console.WriteLine($"Sparrow is eatting ...");
    public override void Fly() => Console.WriteLine($"Sparrow is flying ...");
}

public class Eagle : FlyableBirdBase
{
    public override void Eat() => Console.WriteLine($"Eagle is eatting ...");
    public override void Fly() => Console.WriteLine($"Eagle is flying ...");
}
```

And in [Program.cs](before/LSP.After.App/Program.cs) we get alert when a chicken wants to fly!

```c#
FlyableBirdBase bird = new Sparrow();
bird.Eat();
bird.Fly();

bird = new Eagle();
bird.Eat();
bird.Fly();

//bird = new Chicken();  // alert : Chicken is not FlyableBirdBase class!!.

var chicken  = new Chicken();
chicken.Eat();
//chicken.Fly();  // alert : Chicken does not contains a method for Fly;
```

