Human human = new Human();
human.name = "Nadir";
human.Foo();
Human human2 = human;
Console.WriteLine($"{human.name} {human2.name}");
human2.name = "A-tilla";
Console.WriteLine($"{human.name} {human2.name}");

Console.WriteLine(Human.count);

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

    public Human()
        :this("Empty", "Empty", 0)
    {}

    public Human(string name, string surname, int age)
    {
        this.name = name;
        this.surname = surname;
        this.age = age;
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

