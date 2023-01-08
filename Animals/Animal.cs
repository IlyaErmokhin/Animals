namespace Animal;
public abstract class Animal
{

    protected int Age { get; set; }
    protected string Color { get; set; }
    protected string Habitat { get; set; }

    protected Animal(int age, string color, string habitat)
    {
        Age = age;
        Color = color;
        Habitat = habitat;
    }

    public abstract void Move();

    public abstract void Eat();
}
