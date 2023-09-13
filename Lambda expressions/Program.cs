List<int> ints = new() { 1, 3, 6, 5, 8, 4, 5, 6, 98 };
//var evens = ints.Where(delegate (int numb) { return numb < 5; }).ToList();

var evens = ints.Where(n => n % 2 == 0).ToList();
evens.ForEach(Console.WriteLine);

