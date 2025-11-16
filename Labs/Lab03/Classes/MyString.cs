namespace Lab03.Classes;

internal class MyString
{
    private char[] _data;
    private int _length;

    public MyString(string s = "")
    {
        SetInternal(s);
    }

    private void SetInternal(string s)
    {
        _data = s.ToCharArray();
        _length = _data.Length;
    }

    public void Set(string s) => SetInternal(s);

    public void Set(char c, int len = 5)
    {
        _data = new char[len];
        Array.Fill(_data, c);
        _length = len;
    }

    public void Copy(MyString other)
    {
        ArgumentNullException.ThrowIfNull(other);
        _data = (char[])other._data.Clone();
        _length = other._length;
    }

    public char this[int index]
    {
        get => (index >= 0 && index < _length) ? _data[index] : throw new IndexOutOfRangeException();
        set
        {
            if (index < 0 || index >= _length) throw new IndexOutOfRangeException();
            _data[index] = value;
        }
    }

    public static MyString operator ++(MyString s) => ModifyAscii(s, 1);

    public static MyString operator --(MyString s) => ModifyAscii(s, -1);

    private static MyString ModifyAscii(MyString s, int delta)
    {
        for (var i = 0; i < s._length; i++)
            s._data[i] = (char)(s._data[i] + delta);
        return s;
    }

    public static MyString operator +(MyString a, MyString b)
    {
        var newData = new char[a._length + b._length];
        Array.Copy(a._data, newData, a._length);
        Array.Copy(b._data, 0, newData, a._length, b._length);
        return new MyString(new string(newData));
    }
    public static bool operator >(MyString a, MyString b) => Compare(a, b) > 0;
    public static bool operator <(MyString a, MyString b) => Compare(a, b) < 0;
    public static bool operator ==(MyString a, MyString b)
    {
        return Compare(a, b) == 0;
    }
    public static bool operator !=(MyString a, MyString b) => !(a == b);

    private static int Compare(MyString a, MyString b)
        => string.Compare(new string(a._data), new string(b._data));
    
    public static MyString operator -(MyString a, string b) => a + new MyString("-" + b);
    
    public static bool operator >(MyString a, string b) => string.Compare(new string(a._data), b) > 0;
    public static bool operator <(MyString a, string b) => string.Compare(new string(a._data), b) < 0;
    
    public override string ToString() => new(_data);
    
    public static explicit operator int(MyString s) => s._length;
    
    public static explicit operator double(MyString s) =>
        s._length == 0 ? 0 : s._data.Average(c => c);
    
    public static explicit operator Size(MyString s) => new Size(s._length);
}