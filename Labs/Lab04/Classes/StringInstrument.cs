namespace Lab04.Classes;

/// <summary>
/// P1: Наследник от базового.
/// </summary>
internal class StringInstrument : Instrument
{
    protected readonly int StringsCount;

    public StringInstrument(string n, int sc) : base(n)
    {
        StringsCount = sc;
        Console.WriteLine($"Constructor StringInstrument: {Name}, strings: {StringsCount}");
    }

    public override void PlaySound()
    {
        Console.WriteLine($"StringInstrument plays: Strumming {StringsCount} strings");
    }

    public override void PrintInfo()
    {
        Console.WriteLine($"StringInstrument - Name: {Name}, Strings: {StringsCount}");
    }

    ~StringInstrument()
    {
        Console.WriteLine($"Destructor StringInstrument: {Name}");
    }
}