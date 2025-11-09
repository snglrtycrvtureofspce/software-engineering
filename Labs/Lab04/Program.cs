using Lab04.Classes;

namespace Lab04;

internal static class Program
{
    private static void Main(string[] args)
    {
        // Массив указателей (ссылок) на базовый класс
        var instruments = new Instrument[3];

        // Динамическое создание объектов наследников
        instruments[0] = new StringInstrument("Violin", 4);
        instruments[1] = new Guitar("Stratocaster", 6, true);
        instruments[2] = new WindInstrument("Flute", "Wood");

        // Вызов виртуальных функций (динамический полиморфизм)
        foreach (var inst in instruments)
        {
            inst.PrintInfo();
            inst.PlaySound();
            Console.WriteLine();
        }

        // Удаление объектов (GC для демонстрации деструкторов)
        instruments = null;
        GC.Collect();
        GC.WaitForPendingFinalizers();

        Console.ReadKey();
    }
}