namespace Animal;

public class Wolf : Animal
{
    public Wolf(int age, string color, string habitat) : base(age, color, habitat)
    {
    }

    public override void Move()
    {
        Console.WriteLine("Running for a hare");
    }

    public override void Eat()
    {
        Console.WriteLine("Eats tiny animals");
    }
}
