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

        // перегружаем функцию
        s1.Set("Hi");
        Console.WriteLine("После Set(string): " + s1);

        s1.Set('A');
        Console.WriteLine("После Set(char, default len=5): " + s1);

        // присваисваем в новую переменную
        var s3 = new MyString();
        s3.Copy(s1);
        Console.WriteLine("s3 после Copy: " + s3);

        // простая индексация
        Console.WriteLine("s1[0]: " + s1[0]);
        s1[0] = 'B';
        Console.WriteLine("После изменения s1[0]: " + s1);

        // ++
        ++s1;
        Console.WriteLine("После ++s1: " + s1);

        // +
        var s4 = s1 + s2;
        Console.WriteLine("s1 + s2: " + s4);

        // сравнвием
        Console.WriteLine("s1 > s2: " + (s1 > s2));
        Console.WriteLine("s1 == s1: " + (s1 == s1));

        // уменьшает
        --s1;
        Console.WriteLine("После --s1: " + s1);

        // минус строка
        var s5 = s1 - "Test";
        Console.WriteLine("s1 - \"Test\": " + s5);

        // сравниваем со строкой
        Console.WriteLine("s1 > \"AAA\": " + (s1 > "AAA"));

        // excplicit 
        var len = (int)s1;
        Console.WriteLine("Длина (int): " + len);

        var avg = (double)s1;
        Console.WriteLine("Средний ASCII (double): " + avg);

        var size = (Size)s1;
        Console.WriteLine("Преобразование в Size: " + size);

        Console.ReadKey();
    }
}