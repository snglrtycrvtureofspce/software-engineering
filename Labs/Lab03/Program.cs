using Lab03.Classes;

namespace Lab03;

internal static class Program
{
    private static void Main(string[] args)
    {
        var s1 = new MyString("Hello");
        var s2 = new MyString("World");
        Console.WriteLine("s1: " + s1);
        Console.WriteLine("s2: " + s2);

        // Перегрузка функций
        s1.Set("Hi");
        Console.WriteLine("После Set(string): " + s1);

        s1.Set('A');
        Console.WriteLine("После Set(char, default len=5): " + s1);

        // Симуляция присвоения
        var s3 = new MyString();
        s3.Copy(s1);
        Console.WriteLine("s3 после Copy: " + s3);

        // Индексация
        Console.WriteLine("s1[0]: " + s1[0]);
        s1[0] = 'B';
        Console.WriteLine("После изменения s1[0]: " + s1);

        // Унарный ++
        ++s1;
        Console.WriteLine("После ++s1: " + s1);

        // Бинарный +
        var s4 = s1 + s2;
        Console.WriteLine("s1 + s2: " + s4);

        // Сравнения
        Console.WriteLine("s1 > s2: " + (s1 > s2));
        Console.WriteLine("s1 == s1: " + (s1 == s1));

        // Унарный --
        --s1;
        Console.WriteLine("После --s1: " + s1);

        // Бинарный - с string
        var s5 = s1 - "Test";
        Console.WriteLine("s1 - \"Test\": " + s5);

        // Сравнение с string
        Console.WriteLine("s1 > \"AAA\": " + (s1 > "AAA"));

        // Преобразования
        var len = (int)s1;
        Console.WriteLine("Длина (int): " + len);

        var avg = (double)s1;
        Console.WriteLine("Средний ASCII (double): " + avg);

        var size = (Size)s1;
        Console.WriteLine("Преобразование в Size: " + size);

        Console.ReadKey();
    }
}