namespace Cw01.Classes;

/// <summary>
/// Класс, представляющий квартиру с характеристиками: количество комнат, площадь, этаж, район.
/// </summary>
public class Apartment
{
    /// <summary>
    /// Количество комнат (≥1).
    /// </summary>
    public int Rooms { get; set; }

    /// <summary>
    /// Общая площадь в м² (>0).
    /// </summary>
    public double Area { get; set; }

    /// <summary>
    /// Этаж (≥1).
    /// </summary>
    public int Floor { get; set; }

    /// <summary>
    /// Район города (строка, не пустая).
    /// </summary>
    public string District { get; set; }

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
    public override string ToString() => $"Комнат: {Rooms}, Площадь: {Area:F2} м², Этаж: {Floor}, Район: {District}";
}