namespace CustomInterfaces;

// Hexagon does override Draw().
class Hexagon : Shape, IPointy
{
    public Hexagon() { }
    public Hexagon(string name) : base(name) { }

    public byte Points => 6;
    
    public override void Draw()
    {
        Console.WriteLine($"Drawing {PetName} the Hexagon");
    }
}