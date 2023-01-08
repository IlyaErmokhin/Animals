namespace Animal;

public class Jerry : Animal
{
    public Jerry(int age, string color, string habitat) : base(age, color, habitat)
    {
    }

    public override void Move()
    {
        Console.WriteLine("Running from the Tom");
    }

    public override void Eat()
    {
        Console.WriteLine("Eats cheese");
    }
}
