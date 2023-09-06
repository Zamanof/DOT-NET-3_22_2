//Base myBase = new();
//myBase.Show();
//Console.WriteLine(myBase.Field1);
//Derived derived = new();
//Console.WriteLine(derived.Field1);
//derived.Show();


Base derive = new Derived();
Console.WriteLine(derive.Field1);
((Derived)derive).Show();

//Foo(myBase);
Foo(derive);
//Foo(derived);
//Foo(new Child());
//derived.Print();
//Console.WriteLine(derive.ToString());

Human atilla = new("Atilla", "Ismail", 14);
Human nadir = new("Nadir", "Zaanov", 42);
Console.WriteLine(atilla.ToString());
var value = atilla.ToString();
Console.WriteLine(value);
Console.WriteLine(nadir);


void Foo(Base @base)
{
    #region V1
    // version 1
    //if (@base.GetType() == new Derived().GetType())
    //{
    //    ((Derived)@base).Show();
    //}
    //else if (@base.GetType() == new Child().GetType())
    //{
    //    ((Child)@base).Show();
    //}
    //else
    //{
    //    @base.Show();
    //}
    #endregion

    #region V2
    //try
    //{
    //    ((Derived)@base).Show();
    //}
    //catch (Exception)
    //{
    //}

    //try
    //{
    //    ((Child)@base).Show();
    //}
    //catch (Exception)
    //{
    //}

    //try
    //{
    //    @base.Show();
    //}
    //catch (Exception)
    //{
    //}
    #endregion

    #region V3
    //if (@base is Derived)
    //{
    //    ((Derived)@base).Show();
    //}
    //else if (@base is Child)
    //{
    //    ((Child)@base).Show();
    //}
    //else
    //{
    //    @base.Show();
    //}
    #endregion

    #region V4
    //var value = @base as Derived;
    //var value1 = @base as Child;
    //var value2 = @base as Base;
    //if (value != null) value.Show();
    //if (value1 != null) value1.Show();
    //if (value2 != null) value2.Show();
    #endregion

    @base.Show();
}

class Base
{
    public string Field1 { get; set; } = "Salam";
    public virtual void Show()
    {
        Console.WriteLine("Base class show");
    }
}

class Derived : Base
{
    public new string Field1 { get; set; } = "Popalam";
    public override void Show()
    {
        Console.WriteLine("Derived class show");
    }

    public void Print()
    {
        Console.WriteLine(Field1);
        base.Show();
    }
    public override string ToString()
    {
        return "Atilla v Tursii";
    }
}

class Child : Base
{

    public override void Show()
    {
        Console.WriteLine("Child class show");
    }
}


class Human
{
    public string Name { get; set; }
    public string Surname { get; set; }
    public int Age { get; set; }

    public Human(string name, string surname, int age)
    {
        Name = name;
        Surname = surname;
        Age = age;
    }
    public override string ToString()
    {
        return $@"Name: {Name}
Surname: {Surname}
Age: {Age}
";
    }

}

// Abstarct Interface