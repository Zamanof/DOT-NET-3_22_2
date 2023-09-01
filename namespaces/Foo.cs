namespace namespaces
{
    public class Foo
    {
        public void  Print() { Console.WriteLine("Foo 1"); }
    }
}


namespace A
{
    public class Foo {
        public void Print() { Console.WriteLine("Foo 2"); }
    }
}

namespace B
{
    public class Foo
    {
        public void Print() { Console.WriteLine("Foo 3"); }
    }
}

namespace C
{
    public class Bar
    {
        public void Print() { Console.WriteLine("Bar"); }
    }
}

namespace Antananarivu
{
    public class Madagascar
    {
        public void Print() { Console.WriteLine("Kowalski"); }
    }
}