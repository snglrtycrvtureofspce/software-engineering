namespace Lab02.Classes;

public class Hotel
{
    private int[] _guestsInRooms;
    
    private double _pricePerGuest;
    
    public string Name { get; }
    
    public string Address { get; set; }

    public int[] GuestsInRooms
    {
        get => _guestsInRooms;
        set
        {
            if (value == null || value.Any(x => x < 0))
                throw new ArgumentException("The number of occupants cannot be negative.");
            _guestsInRooms = value;
        }
    }

    public double PricePerGuest
    {
        get => _pricePerGuest;
        set
        {
            if (value < 0)
                throw new ArgumentException("The price can't be negative.");
            _pricePerGuest = value;
        }
    }
    
    public Hotel() : this("Empty", "Unknown", [], 0.0)
    {
    }

    public Hotel(string name, string address) : this(name, address, [], 0.0)
    {
    }

    public Hotel(string name, string address, int[] guestsInRooms, double pricePerGuest)
    {
        Name = name;
        Address = address;
        GuestsInRooms = guestsInRooms;
        PricePerGuest = pricePerGuest;
    }
    
    public double DailyRevenue() => GuestsInRooms.Sum() * PricePerGuest;
    
    public void AdjustPriceIfLowOccupancy()
    {
        var totalRooms = GuestsInRooms.Length;
        var emptyRooms = GuestsInRooms.Count(g => g == 0);

        if (emptyRooms > totalRooms / 2)
        {
            PricePerGuest *= 0.8;
        }
    }
    
    public bool IsMoreProfitableThan(Hotel other)
    {
        var thisOccupancy = (double)GuestsInRooms.Count(g => g > 0) / GuestsInRooms.Length;
        var otherOccupancy = (double)other.GuestsInRooms.Count(g => g > 0) / other.GuestsInRooms.Length;

        return thisOccupancy > otherOccupancy;
    }
    
    public static Hotel MostProfitable(Hotel h1, Hotel h2, Hotel h3)
    {
        Hotel[] hotels = [h1, h2, h3];

        return hotels.OrderByDescending(h =>
            (double)h.GuestsInRooms.Count(g => g > 0) / h.GuestsInRooms.Length).First();
    }
    
    public override string ToString()
        => $"Hotel: {Name}\nAddress: {Address}\nRooms: {string.Join(", ", GuestsInRooms)}\nPrice per occupant: {PricePerGuest:F2}";
}