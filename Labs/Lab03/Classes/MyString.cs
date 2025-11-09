namespace Lab03.Classes;

internal class MyString
{
    private char[] _data;
    private int _length;

    public MyString(string s = "")
    {
        _data = s.ToCharArray();
        _length = _data.Length;
    }

    /// <summary>
    /// Перегрузка функций.
    /// </summary>
    public void Set(string s)
    {
        _data = s.ToCharArray();
        _length = _data.Length;
    }

    /// <summary>
    /// С параметром по умолчанию.
    /// </summary>
    public void Set(char c, int len = 5)
    {
        _data = new char[len];
        for (var i = 0; i < len; i++)
        {
            _data[i] = c;
        }

        _length = len;
    }

    /// <summary>
    /// Симуляция присвоения =.
    /// </summary>
    public void Copy(MyString other)
    {
        _data = (char[])other._data.Clone();
        _length = other._length;
    }

    /// <summary>
    /// Индексация [].
    /// </summary>
    public char this[int index]
    {
        get
        {
            if (index < 0 || index >= _length) throw new IndexOutOfRangeException();
            return _data[index];
        }
        set
        {
            if (index < 0 || index >= _length) throw new IndexOutOfRangeException();
            _data[index] = value;
        }
    }

    /// <summary>
    /// Унарный ++ (увеличивает каждый символ на 1 по ASCII).
    /// </summary>
    public static MyString operator ++(MyString s)
    {
        for (var i = 0; i < s._length; i++)
        {
            s._data[i] = (char)(s._data[i] + 1);
        }

        return s;
    }

    /// <summary>
    /// Бинарный + для однотипных.
    /// </summary>
    public static MyString operator +(MyString a, MyString b)
    {
        var newData = new char[a._length + b._length];
        Array.Copy(a._data, newData, a._length);
        Array.Copy(b._data, 0, newData, a._length, b._length);
        return new MyString(new string(newData));
    }

    /// <summary>
    /// Сравнения для однотипных.
    /// </summary>
    public static bool operator >(MyString a, MyString b)
        => string.Compare(new string(a._data), new string(b._data)) > 0;

    public static bool operator <(MyString a, MyString b)
        => string.Compare(new string(a._data), new string(b._data)) < 0;

    public static bool operator ==(MyString a, MyString b)
    {
        if (ReferenceEquals(a, null)) return ReferenceEquals(b, null);
        return string.Compare(new string(a._data), new string(b._data)) == 0;
    }

    public static bool operator !=(MyString a, MyString b) => !(a == b);

    /// <summary>
    /// Унарный --.
    /// </summary>
    public static MyString operator --(MyString s)
    {
        for (var i = 0; i < s._length; i++)
        {
            s._data[i] = (char)(s._data[i] - 1);
        }

        return s;
    }

    /// <summary>
    /// Бинарный - с string (конкатенация с '-').
    /// </summary>
    public static MyString operator -(MyString a, string b) => a + new MyString("-" + b);

    /// <summary>
    /// Сравнение > с string.
    /// </summary>
    public static bool operator >(MyString a, string b) => string.Compare(new string(a._data), b) > 0;

    public static bool operator <(MyString a, string b) => string.Compare(new string(a._data), b) < 0;

    /// <summary>
    /// Вывод <<.
    /// </summary>
    public override string ToString() => new string(_data);

    /// <summary>
    /// Преобразование в int (длина).
    /// </summary>
    public static explicit operator int(MyString s) => s._length;

    /// <summary>
    /// В double (средний ASCII).
    /// </summary>
    public static explicit operator double(MyString s)
    {
        if (s._length == 0) return 0;
        var sum = 0;
        for (var i = 0; i < s._length; i++)
        {
            sum += (int)s._data[i];
        }

        return (double)sum / s._length;
    }

    /// <summary>
    /// В пользовательский тип Size.
    /// </summary>
    public static explicit operator Size(MyString s) => new Size(s._length);
}