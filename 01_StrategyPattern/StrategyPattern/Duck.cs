namespace StrategyPattern;

public abstract class Duck
{
    private IFlyBehavior _flyBehavior;
    private IQuackBehavior _quackBehavior;

    protected Duck()
    {
    }

    public abstract void Display();

    public void performFly()
    {
        _flyBehavior.fly();
    }

    public void performQuack()
    {
        _quackBehavior.quack();
    }

    public void swim()
    {
        Console.WriteLine("All ducks float, even decoys!");
    }
    

}