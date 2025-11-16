namespace Lab04.Classes;

internal abstract class Instrument
{
    protected readonly string Name;

    protected Instrument(string n)
    {
        Name = n;
        Console.WriteLine($"Constructor Instrument: {Name}");
    }

    public abstract void PlaySound();

    public abstract void PrintInfo();

    ~Instrument()
    {
        Console.WriteLine($"Destructor Instrument: {Name}");
    }
}