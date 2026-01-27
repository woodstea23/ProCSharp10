namespace SimpleClassExample;

class Car
{
    // The 'state' of the Car.
    public string petName;
    public int currSpeed;

    // Default constructor.
    public Car() {}

    // Constructor with only petName, uses
    // default int value for currSpeed
    public Car(string pn)
    {
        petName = pn;
    }

    // Let caller set both fields.
    public Car(string pn, int cs)
    {
        petName = pn;
        currSpeed = cs;
    }

    // The 'behavior' of the Car.
    public void PrintState()
        => Console.WriteLine($"{petName} is going {currSpeed} MPH.");

    public void SpeedUp(int delta)
        => currSpeed += delta;
}