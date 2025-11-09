namespace Lab04.Classes;

/// <summary>
/// Абстрактный базовый класс.
/// </summary>
internal abstract class Instrument
{
    /// <summary>
    /// Protected для доступа в наследниках.
    /// </summary>
    protected readonly string Name;

    protected Instrument(string n)
    {
        Name = n;
        Console.WriteLine($"Constructor Instrument: {Name}");
    }

    /// <summary>
    /// Чисто виртуальные (abstract).
    /// </summary>
    public abstract void PlaySound();
    
    /// <summary>
    /// Чисто виртуальные (abstract).
    /// </summary>
    public abstract void PrintInfo();

    /// <summary>
    /// Виртуальный деструктор (финализатор).
    /// </summary>
    ~Instrument()
    {
        Console.WriteLine($"Destructor Instrument: {Name}");
    }
}