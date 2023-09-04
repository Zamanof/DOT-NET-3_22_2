//Derived derived = new Derived("Salam", 13, 46);
// BD, BP, DD, DP
//derived.Show();
//derived.DerivedFoo();

class Derived : Base
{
    public Derived()
    {
        Console.WriteLine("Derived default constructor");
    }
    public Derived(string some, int field1, int field2)
        : base(field1, field2)
    {
        SomeProperty = some;
        Console.WriteLine("Derived parametrized constructor");
    }

    public string SomeProperty { get; set; }


    public void DerivedFoo()
    {
        Foo();
    }

}
