namespace Lab04.Classes;

/// <summary>
/// P2: Наследник от базового.
/// </summary>
internal class WindInstrument : Instrument
{
    private readonly string _material;

    public WindInstrument(string n, string m) : base(n)
    {
        _material = m;
        Console.WriteLine($"Constructor WindInstrument: {Name}, material: {_material}");
    }

    public override void PlaySound()
    {
        Console.WriteLine($"WindInstrument plays: Blowing through {_material}");
    }

    public override void PrintInfo()
    {
        Console.WriteLine($"WindInstrument - Name: {Name}, Material: {_material}");
    }

    ~WindInstrument()
    {
        Console.WriteLine($"Destructor WindInstrument: {Name}");
    }
}