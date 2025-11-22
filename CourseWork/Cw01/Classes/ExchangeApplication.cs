namespace Cw01.Classes;

/// <summary>
/// Класс, представляющий заявку на обмен: фамилия, имеющаяся и требуемая квартиры.
/// </summary>
public class ExchangeApplication
{
    /// <summary>
    /// Фамилия и инициалы заявителя.
    /// </summary>
    public string SurnameInitials { get; set; }

    /// <summary>
    /// Имеющаяся квартира.
    /// </summary>
    public Apartment OwnedApartment { get; set; }

    /// <summary>
    /// Требуемая квартира.
    /// </summary>
    public Apartment RequiredApartment { get; set; }

    /// <summary>
    /// Конструктор для инициализации заявки.
    /// </summary>
    /// <param name="surnameInitials">Фамилия и инициалы.</param>
    /// <param name="owned">Имеющаяся квартира.</param>
    /// <param name="required">Требуемая квартира.</param>
    public ExchangeApplication(string surnameInitials, Apartment owned, Apartment required)
    {
        SurnameInitials = surnameInitials;
        OwnedApartment = owned;
        RequiredApartment = required;
    }

    /// <summary>
    /// Переопределение Equals для сравнения заявок по всем полям.
    /// </summary>
    /// <param name="obj">Объект для сравнения.</param>
    /// <returns>True, если заявки равны.</returns>
    public override bool Equals(object? obj)
    {
        if (obj is ExchangeApplication other)
            return SurnameInitials == other.SurnameInitials &&
                   OwnedApartment.Rooms == other.OwnedApartment.Rooms &&
                   OwnedApartment.Area == other.OwnedApartment.Area &&
                   OwnedApartment.Floor == other.OwnedApartment.Floor &&
                   OwnedApartment.District == other.OwnedApartment.District &&
                   RequiredApartment.Rooms == other.RequiredApartment.Rooms &&
                   RequiredApartment.Area == other.RequiredApartment.Area &&
                   RequiredApartment.Floor == other.RequiredApartment.Floor &&
                   RequiredApartment.District == other.RequiredApartment.District;

        return false;
    }

    /// <summary>
    /// Переопределение GetHashCode для использования в HashSet.
    /// </summary>
    /// <returns>Хэш-код заявки.</returns>
    public override int GetHashCode()
    {
        var hasher = new HashCode();
        hasher.Add(SurnameInitials);
        hasher.Add(OwnedApartment.Rooms);
        hasher.Add(OwnedApartment.Area);
        hasher.Add(OwnedApartment.Floor);
        hasher.Add(OwnedApartment.District);
        hasher.Add(RequiredApartment.Rooms);
        hasher.Add(RequiredApartment.Area);
        hasher.Add(RequiredApartment.Floor);
        hasher.Add(RequiredApartment.District);
        return hasher.ToHashCode();
    }

    /// <summary>
    /// Переопределение ToString для вывода заявки.
    /// </summary>
    /// <returns>Строка с данными заявки.</returns>
    public override string ToString()
        => $"Заявитель: {SurnameInitials}\nИмеющаяся: {OwnedApartment}\nТребуемая: {RequiredApartment}";
}