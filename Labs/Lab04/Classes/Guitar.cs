namespace Lab04.Classes;

/// <summary>
/// P11: Наследник от P1.
/// </summary>
internal class Guitar : StringInstrument
{
    private readonly bool _isElectric;

    public Guitar(string n, int sc, bool e) : base(n, sc)
    {
        _isElectric = e;
        Console.WriteLine($"Constructor Guitar: {Name}, electric: {_isElectric}");
    }

    public override void PlaySound()
    {
        Console.WriteLine($"Guitar plays: {(_isElectric ? "Electric riff" : "Acoustic strum")}");
    }

    public override void PrintInfo()
    {
        Console.WriteLine($"Guitar - Name: {Name}, Strings: {StringsCount}, Electric: {_isElectric}");
    }

    ~Guitar()
    {
        Console.WriteLine($"Destructor Guitar: {Name}");
    }
}