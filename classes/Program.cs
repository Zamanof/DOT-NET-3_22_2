Human human = new Human();
human.name = "Nadir";
human.Foo();
Human human2 = human;
Console.WriteLine($"{human.name} {human2.name}");
human2.name = "A-tilla";
Console.WriteLine($"{human.name} {human2.name}");

Console.WriteLine(Human.count);
Console.WriteLine(Human.field1);

void Bar()
{
    Console.WriteLine("Salam");
}
public class Human
{
    // public, private, internal, protected internal
    public string name; 
    public string surname;
    public int age;

    public static int count;
    public const int field1 = 25;
    public readonly int field2;

    static Human()
    { 
        count = 0;
        
    }
    public Human()
        :this("Empty", "Empty", 0)
    {}

    public Human(string name, string surname, int age, int field2 = 0)
    {
        this.name = name;
        this.surname = surname;
        this.age = age;
        this.field2 = field2;
    }

    public void Foo()
    {
        Bambarbiya.Method(this);
    }

    //public void Bar(int a, double b) { }
    //public void Bar(double a, int b) { }
    //public void Bar(int a, int b) { }
    //public void Bar(int a) { }
}

class Bambarbiya
{
    public static void Method(Human human){
        Console.WriteLine(human.name);
    }
}

// obfuscator, ref, out