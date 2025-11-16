using Lab04.Classes;

namespace Lab04;

internal static class Program
{
    private static void Main(string[] args)
    {
        var instruments = new Instrument[3];

        instruments[0] = new StringInstrument("Violin", 4);
        instruments[1] = new Guitar("Stratocaster", 6, true);
        instruments[2] = new WindInstrument("Flute", "Wood");

        foreach (var inst in instruments)
        {
            inst.PrintInfo();
            inst.PlaySound();
            Console.WriteLine();
        }

        instruments = null;
        GC.Collect();
        GC.WaitForPendingFinalizers();

        Console.ReadKey();
    }
}