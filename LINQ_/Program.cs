// LINQ - Lanquage Integrated Query

// LINQ To Object
// LINQ To Dataset
// LINQ To SQL
// LINQ To Xml
// LINQ To Entities
// PLINQ - Paralel LINQ

using System.Collections;

int[] array =
    { 7, 9, 8, 80, 12, 84, 52, 48, 0, 10, 21, 6, 5, 3, 19, 46, 6, 7, 8, -36, -987, -31 };

IEnumerable<int> query = from i in array select i;
foreach (var item in query)
{
    Console.Write($"{item} ");
}
Console.WriteLine();

//array[5] = 1244244;

// where
//query = from i in array
//        where i < 0
//        select i;


// orderby ascending descending
//query = from i in array 
//        where i < 0
//        orderby i descending
//        select i;


// group

//var group = from i in array
//        where i > 0
//        group i by i % 2;

//foreach (var item in group)
//{
//    Console.WriteLine(item.Key);


//    foreach (var i in item)
//    {
//        Console.WriteLine($"    {i}");
//    }
//}


// into
//var query1 = from i in array
//             where i > 0
//             group i by i % 2 into result
//             from j in result
//             where j % 3 == 0
//             group j by j % 2;


//foreach (var item in query1)

//{
//    Console.WriteLine(item.Key);


//    foreach (var i in item)
//    {
//        Console.WriteLine($"    {i}");
//    }
//}



//foreach (var item in query)
//{
//    Console.Write($"{item} ");
//}
//Console.WriteLine();

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


// join

var result = from c in countries
             join e in employees on c.Id equals e.CountryId
             orderby c.Name ascending             
             select new {Name = e.Name, Country = c.Name }
             ;


//foreach (var em in result)
//{
//    Console.WriteLine($"{em.Name} - {em.Country}");
    
//}


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