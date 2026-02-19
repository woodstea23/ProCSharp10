namespace CustomInterfaces;

class ThreeDCircle : Circle
{
    // Hides the Circle.Draw() method.
    public new void Draw()
    {
        Console.WriteLine($"Drawing {PetName} the 3D Circle");
    }
}