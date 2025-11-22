namespace Cw01.Classes;

/// <summary>
/// Класс, представляющий квартиру с характеристиками: количество комнат, площадь, этаж, район.
/// </summary>
public class Apartment
{
    public int Rooms { get; set; } // Количество комнат
    public double Area { get; set; } // Площадь в м²
    public int Floor { get; set; } // Этаж
    public string District { get; set; } // Район

    /// <summary>
    /// Конструктор для инициализации квартиры.
    /// </summary>
    /// <param name="rooms">Количество комнат.</param>
    /// <param name="area">Площадь.</param>
    /// <param name="floor">Этаж.</param>
    /// <param name="district">Район.</param>
    public Apartment(int rooms, double area, int floor, string district)
    {
        Rooms = rooms;
        Area = area;
        Floor = floor;
        District = district;
    }

    /// <summary>
    /// Переопределение ToString для вывода характеристик квартиры.
    /// </summary>
    /// <returns>Строка с данными квартиры.</returns>
    public override string ToString() => $"Комнат: {Rooms}, Площадь: {Area} м², Этаж: {Floor}, Район: {District}";
}