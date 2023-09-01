#region get set
//Human human = new();
//human.SetAge(15);
//Console.WriteLine(human.GetAge());
//class Human
//{
//    public string name;
//    public string surname;
//    private int _age;

//    public int GetAge()
//    {
//        return _age;
//    }

//    public void SetAge(int age)
//    {
//        if(age < 0 || age > 150)
//        {
//            throw new ArgumentOutOfRangeException("0 ~ 150");
//        }
//        _age = age;
//    }
//}
#endregion

#region properties (full, auto)
Human human = new();
human.Age = 25;
Console.WriteLine(human.Age);
Console.WriteLine(human.Name);
human.Name = "Foo";
Console.WriteLine(human.Name);
human.BirthDate = DateTime.Now;
partial class Human
{
   
    public string Name { get; set; } = "Empty";
    // propfull

    private int age;
    public int Age
    {
        get { return age; }
        set
        {
            if (age < 0 || age > 150)
            {
                throw new ArgumentOutOfRangeException("0 ~ 150");
            }
            age = value;
        }
    }
}
#endregion

