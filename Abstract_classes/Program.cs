//Lamina lamina = new();
using System.Security.Cryptography;

Farij jiraf = new Farij();



Lamina liraf = new Farij();
Foo(jiraf);
Foo(liraf);

void Foo(Lamina laminat)
{
    laminat.Walk();
}
abstract class Lamina
{
    public abstract void Walk();
    public void Think()
    {
        Console.WriteLine("Da mi umeeyem dumat. Mi je ni kakiye nibud jivotniye");
    }
}

class Farij: Lamina
{
    public override void Walk()
    {
        Console.WriteLine("Salam poplam");
    }
}