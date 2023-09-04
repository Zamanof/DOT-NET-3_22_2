sealed class GrandChild : Derived
{
    public GrandChild()
        : base("Hi", 36, 89)
    {
        Console.WriteLine("GrandChild Default constructor");
    }

    public GrandChild(string some, int field1, int field2)
        : base(some, field1, field2)
    {
        Console.WriteLine("GrandChild Parametrize constructor");
    }
}

class Kolbas
{

}