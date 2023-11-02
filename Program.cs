// See https://aka.ms/new-console-template for more information

class Phone : IComparable<Phone>
{
    public string brand;
    public string color;
    public int price;
    public int memory;

    public Phone (string brand, string color, int price, int memory)
    {
        this.brand = brand;
        this.color = color;
        this.price = price;
        this.memory = memory;
    }
    
    // public int CompareTo(Phone? p)
    // {
    //     if (p is null) throw new ArgumentException("Некорректный параметр");
    //     return memory - p.memory;
    // }

    public int CompareTo(Phone? p)
    {
        if (p is null) throw new ArgumentException("Некорректный параметр");
        return p.price - price;
    }
}

class Program
{
    public static void Main(string[] args)
    {
        var phone1 = new Phone("Samsung", "red", 1942, 4321);
        var phone2 = new Phone("Apple", "white", 2323, 23313);
        var phone3 = new Phone("Xiaomi", "black", 321, 543);

        Phone[] phones = {phone1, phone2, phone3};

        Array.Sort(phones);

        foreach(Phone phone in phones)
        {
            Console.WriteLine($"{phone.brand} - {phone.memory}");
        }
    }
}