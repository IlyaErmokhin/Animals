namespace Animal;

public class Tom : Animal
{
    public Tom(int age, string color, string habitat) : base(age, color, habitat)
    {
    }

    public override void Move()
    {
        Console.WriteLine("Running for a Jerry");
    }

    public override void Eat()
    {
        Console.WriteLine("Eats mouse");
    }
}
