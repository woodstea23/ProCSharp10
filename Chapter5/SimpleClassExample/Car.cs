namespace SimpleClassExample;

class Car
{
    // The 'state' of the Car.
    public string petName;
    public int currSpeed;

    // The 'behavior' of the Car.
    public void PrintState()
        => Console.WriteLine($"{petName} is going {currSpeed} MPH.");

    public void SpeedUp(int delta)
        => currSpeed += delta;
}