using Lab02.Classes;

namespace Lab02;

internal static class Program
{
    private static void Main()
    {
        // Использование конструкторов
        var hotel1 = new Hotel();
        var hotel2 = new Hotel("Север", "Улица Ленина");
        var hotel3 = new Hotel("Юг", "Проспект Мира", [2, 0, 3, 1], 1500);

        // Демонстрация ToString
        Console.WriteLine(hotel1);
        Console.WriteLine(hotel2);
        Console.WriteLine(hotel3);

        // Свойства
        hotel1.Address = "Центр города";
        hotel1.GuestsInRooms = [1, 2, 0];
        hotel1.PricePerGuest = 1000;

        // Выручка
        Console.WriteLine($"Выручка hotel1: {hotel1.DailyRevenue()}");

        // Падение рентабельности
        hotel1.AdjustPriceIfLowOccupancy();
        Console.WriteLine($"Цена после проверки рентабельности: {hotel1.PricePerGuest}");

        // Сравнение
        var moreProfitable = hotel3.IsMoreProfitableThan(hotel1);
        Console.WriteLine($"hotel3 более рентабельна, чем hotel1: {moreProfitable}");

        // Статический метод
        var best = Hotel.MostProfitable(hotel1, hotel2, hotel3);
        Console.WriteLine($"Наиболее рентабельная гостиница: {best.Name}");

        // Ссылки на один объект
        var hotel4 = hotel3;
        hotel4.Address = "Новый адрес";
        Console.WriteLine($"hotel3 адрес после изменения hotel4: {hotel3.Address}");
    }
}