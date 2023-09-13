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

Teacher teacher = new();

foreach (Student student in students)
{
    teacher.examEvent += student.Exam;
}

teacher.examEvent -= students[4].Exam;

teacher.Exam("Kak ya provel leto");


class Student
{
    public string Name { get; set; }
    public string SurName { get; set; }
    public DateTime BirthDay { get; set; }

    public void Exam(string task)
    {
        Console.WriteLine($"{Name} {SurName} solved {task}");
    }
}

class Teacher
{
    public event ExamDelegate examEvent;
    public void Exam(string task)
    {
        examEvent(task);
    }
}

public delegate void ExamDelegate(string task);