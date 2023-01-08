namespace Animal;

public class Hare : Animal
{
    public Hare(int age, string color, string habitat) : base(age, color, habitat)
    {
    }

    public override void Move()
    {
        Console.WriteLine("Running from the wolf");
    }

    public override void Eat()
    {
        Console.WriteLine("Eats carrot");
    }
}
