namespace CustomInterfaces;
// Circle does not override the Draw() method, 
// so it inherits the base class implementation.
class Circle : Shape
{
    public Circle() { }
    public Circle(string name) : base(name) { }

    public override void Draw()
    {
        Console.WriteLine($"Drawing {PetName} the Circle");
    }
}