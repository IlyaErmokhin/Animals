using Animal;

var hare = new Hare(2, "white", "forest");
var wolf = new Wolf(2, "gray", "forest");
var cat = new Tom(3, "gray-white", "house");
var mouse = new Jerry(3, "brown", "house");

Console.WriteLine("Hare:");
hare.Move();
hare.Eat();

Console.WriteLine();
Console.WriteLine("Wolf:");
wolf.Move();
wolf.Eat();

Console.WriteLine();
Console.WriteLine("Tom:");
cat.Move();
cat.Eat();

Console.WriteLine();
Console.WriteLine("Jerry:");
mouse.Move();
mouse.Eat();