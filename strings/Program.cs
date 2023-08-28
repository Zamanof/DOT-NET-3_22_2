#region string
//string str = "Hello";
//string str2 = new string('_',9);
//Console.WriteLine(str2);
//char[] chr = new char[]{ 'S', 'a', 'l','a','m'};
//string str3 = new string(chr);
//Console.WriteLine(str3);
//string newStr = str;
//string othStr = "Hello";
//Console.WriteLine(newStr == str);
//Console.WriteLine(othStr == str);
//Console.WriteLine(othStr.Equals(str));
#endregion

#region string interpolation
//string name = Console.ReadLine();
//// string interpolation $"{variable or value}"
//Console.WriteLine($"Welcome {name}");
#endregion

string name = "Nadir";

Console.WriteLine(name[0]);
// indices
Console.WriteLine(name[^1]);

// ranges
Console.WriteLine(name[1..4]); // adi
Console.WriteLine(name[1..]); // adir
Console.WriteLine(name[..4]); // Nadi
