List<Country> countries = new()
{
    new Country(){ Id = 1, Name="USA", Capital="Washington" },
    new Country(){ Id = 2, Name="Azerbaijan", Capital="Baku" },
    new Country(){ Id = 3, Name="Germany", Capital="Berlin" },
    new Country(){ Id = 4, Name="Ireland", Capital="Dublin" },
    new Country(){ Id = 5, Name="Sweden", Capital="Stockholm" },
    new Country(){ Id = 6, Name="Wales", Capital="Cardiff" },
    new Country(){ Id = 7, Name="Neverland", Capital="Never" }
};


List<Employee> employees = new() {
    new Employee(){ Id = 1, Name= "Atilla", Age=12, CountryId=4},
    new Employee(){ Id = 2, Name= "Teymur", Age=16, CountryId=5},
    new Employee(){ Id = 3, Name= "Nadir", Age=42, CountryId=7},
    new Employee(){ Id = 4, Name= "Tatyana", Age=24, CountryId=6},
    new Employee(){ Id = 5, Name= "Allita", Age=12, CountryId=2},
    new Employee(){ Id = 6, Name= "Klavdiya", Age=123, CountryId=6},
    new Employee(){ Id = 7, Name= "Ayxan", Age=112, CountryId=6},
    new Employee(){ Id = 8, Name= "Atilla", Age=11, CountryId=2},
    new Employee(){ Id = 9, Name= "ASU", Age=31, CountryId=1},
    new Employee(){ Id = 10, Name= "Adol", Age=31, CountryId=3},
    new Employee(){ Id = 11, Name= "Geri", Age=36, CountryId=3},
    new Employee(){ Id = 12, Name= "Atilla", Age=14, CountryId=2}
};

// LINQ methods
// First, FirstOrDefault

//var emp = employees.First(e=> e.Id == 13);
//Console.WriteLine(emp);

//var emp1 = employees.FirstOrDefault(x => x.Id == 10);
//if (emp1 is not null)
//{
//    Console.WriteLine(emp1);
//}
//else
//{
//    Console.WriteLine("Not found");
//}



// Single, SingleOrDefault
//var emp = employees.Single(e => e.Name == "Nadir");
//Console.WriteLine(emp);

//var emp1 = employees.SingleOrDefault(e => e.Name == "Atil");
//if (emp1 != null) Console.WriteLine(emp1);
//else Console.WriteLine("Not Found!");

// Contains
//var a = employees.Contains(employees[11]);
//Console.WriteLine(a);

// Where
//var emp = employees.Where(x=> x.Age > 40).ToList();
//emp.ForEach(Console.WriteLine);

// Max Min

//var result = employees.Max(e => e.Age);
//Console.WriteLine(result);

//var emp = employees.FirstOrDefault(e => e.Age == employees.Min(x => x.Age));
//Console.WriteLine(emp);


// Average, Sum

//var sumAge = employees.Sum(x => x.Age);
//Console.WriteLine(sumAge);
//var count = employees.Count();
//Console.WriteLine(sumAge / (double)count);
//var aver = employees.Average(x=> x.Age);
//Console.WriteLine(aver);

// OrderBy

//var empA = employees.OrderBy(e=>e.Age).ToList();
//empA.ForEach(Console.WriteLine);
//Console.WriteLine();
//var empD = employees.OrderByDescending(e=>e.Age).ToList();
//empD.ForEach(Console.WriteLine);
//Console.WriteLine();
//var empThen = employees.OrderBy(e => e.Name).ThenByDescending(e=>e.Age).ToList();
//empThen.ForEach(Console.WriteLine);


// Take, Skip
//var emp = employees.Take(2).ToList();
//emp.ForEach(Console.WriteLine);

//var emp1 = employees.TakeWhile(x=> x.Age < 112).ToList();
//emp1.ForEach(Console.WriteLine);

//var emp2 = employees.Skip(2).Take(4).ToList();
//emp2.ForEach(Console.WriteLine);

// All, Any

//var check = employees.All(e => e.Age > 10);
//Console.WriteLine(check);

var check = employees.Any(e => e.Age == 113);
Console.WriteLine(check);
class Country
{
    public int Id { get; set; }
    public string Name { get; set; }
    public string Capital { get; set; }

    public override string ToString()
    {
        return $"{Name}: {Capital}";
    }
}

class Employee
{
    public int Id { get; set; }
    public string Name { get; set; }
    public int Age { get; set; }
    public int CountryId { get; set; }

    public override string ToString()
    {
        return $"{Id}. {Name} - {Age}";
    }
}