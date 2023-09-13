List<Student> students = new()
{
    new Student{Name="A", SurName="B", BirthDay = new DateTime(2020,9,13)},
    new Student{Name="Kalabna", SurName="Embaby", BirthDay = new DateTime(2000,9,13)},
    new Student{Name="Zambina", SurName="Bambina", BirthDay = new DateTime(208,9,13)},
    new Student{Name="Krinda", SurName="Mashalata", BirthDay = new DateTime(1,9,13)},
    new Student{Name="Atilla", SurName="Ismayil", BirthDay = new DateTime(2020,9,13)},
    new Student{Name="Gre", SurName="Ta", BirthDay = new DateTime(2000,9,13)},
    new Student{Name="Ma", SurName="Laxov", BirthDay = new DateTime(1980,9,13)},
    new Student{Name="Sa", SurName="Laxov", BirthDay = new DateTime(1982,9,13)}
};

Teacher teacher1 = new() { Name = "Natiq" };
Teacher teacher2 = new() { Name = "Aleksey" };
Teacher teacher3 = new() { Name = "Nadir" };

teacher1.examEvent += students[4].Exam;
for (int i = 0; i < 4; i++)
{
    teacher2.examEvent += students[i].Exam;
}

for (int i = 5; i < students.Count; i++)
{
    teacher3.examEvent += students[i].Exam;
}

teacher1.Exam(new ExamEventArgs { Task="C#"});
teacher2.Exam(new ExamEventArgs { Task="C++"});
teacher3.Exam(new ExamEventArgs { Task="Skazki"});

class ExamEventArgs : EventArgs
{
    public string Task { get; set; }
}

class Student
{
    public string Name { get; set; }
    public string SurName { get; set; }
    public DateTime BirthDay { get; set; }

    public void Exam(object sender, ExamEventArgs args)
    {
        Console.WriteLine($"{((Teacher)sender).Name} send {args.Task}");
        Console.WriteLine($"{Name} {SurName} solved {args.Task}");
    }
}

class Teacher
{
    public EventHandler<ExamEventArgs> examEvent;
    public string Name { get; set; }
    public void Exam(ExamEventArgs task)
    {
        if (examEvent != null)
        {
            examEvent(this, task);
        }
    }
}

public delegate void ExamDelegate(string task);