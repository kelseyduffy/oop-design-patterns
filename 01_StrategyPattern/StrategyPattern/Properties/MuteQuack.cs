namespace StrategyPattern.Properties;

public class MuteQuack : IQuackBehavior
{
    public void quack()
    {
        Console.WriteLine("<< Silence >>");
    }
}