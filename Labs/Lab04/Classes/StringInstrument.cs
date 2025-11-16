namespace Lab04.Classes;

internal class StringInstrument : Instrument
{
    protected readonly int StringsCount;

    public StringInstrument(string n, int stringsCount) : base(n)
    {
        StringsCount = stringsCount;
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