// The abstract base class of the hierarchy.
namespace CustomInterfaces;
abstract class Shape
{
    // "protected" means that only this class and derived classes 
    // can access this constructor.
    protected Shape(string name = "NoName")
    {
        PetName = name;
    }

    public string PetName { get; set; }

    // A single abstract method.
    public abstract void Draw();
}