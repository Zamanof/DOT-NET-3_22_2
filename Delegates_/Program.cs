//public delegate int MyIntDelegate(int numb1, int numb2);

//public delegate void MyVoidDelegate(double number);


#region delegates
//double numb1 = default, numb2 = default;
//Console.WriteLine("Enter first number: ");
//double.TryParse(Console.ReadLine(), out numb1);

//Console.WriteLine("Enter second number: ");
//double.TryParse(Console.ReadLine(), out numb2);

//char operation = default;
//Console.WriteLine("Enter operation +, -, / or *: ");
//char.TryParse(Console.ReadLine(), out operation);
//CalculatorDelegate @delegate = null;

//switch ((operations)operation)
//{
//    case operations.ADD:
//        @delegate = Sum;
//        break;
//    case operations.SUB:
//        @delegate = Subtract;
//        break;
//    case operations.DIVIDE:
//        @delegate = Divide;
//        break;
//    case operations.MULT:
//        @delegate = Multiple;
//        break;

//}
//if (@delegate is not null)
//    Console.WriteLine(Calculator(numb1, numb2, @delegate));


//double Calculator(double numb1, double numb2, CalculatorDelegate calculator)
//{
//    return calculator(numb1, numb2);
//}

//double Sum(double left, double right)
//{
//    return left + right;
//}

//double Subtract(double left, double right)
//{
//    return left - right;
//}


//double Divide(double left, double right)
//{
//    if (right != 0) return left / right;
//    throw new DivideByZeroException();
//}

//double Multiple(double left, double right)
//{
//    return left * right;

//}

//public delegate double CalculatorDelegate(double left, double right);
//enum operations { ADD = '+', SUB = '-', DIVIDE = '/', MULT = '*' };
#endregion

#region multicast delegate
//double numb1 = 5, numb2 = 3.5;

////CalculatorDelegate calculators = Sum;
//GenericDelegate<double> calculators = Sum;

//calculators += Subtract;
//calculators += Divide;
//calculators += Multiple;


////foreach (CalculatorDelegate calculator in calculators.GetInvocationList())
////{
////    Console.WriteLine(calculator(numb1, numb2));
////}

//foreach (GenericDelegate<double> calculator in calculators.GetInvocationList())
//{
//    Console.WriteLine(calculator(numb1, numb2));
//}

//double Sum(double left, double right)
//{
//    return left + right;
//}

//double Subtract(double left, double right)
//{
//    return left - right;
//}


//double Divide(double left, double right)
//{
//    if (right != 0) return left / right;
//    throw new DivideByZeroException();
//}

//double Multiple(double left, double right)
//{
//    return left * right;

//}
//public delegate double CalculatorDelegate(double left, double right);

//// Generic delegate
//public delegate T GenericDelegate<T>(T left, T right);
#endregion



// Action<T>, Func<T>, Predicate<T>, Comparison<T>
List<int> ints = new() { 1, 3, 6, 5, 8, 4, 5, 6, 98 };
#region Action
// Action<T>

//int[] arr = new int[20];
//Random random = new Random();
//for (int i = 0; i < arr.Length; i++)
//{
//    arr[i] = random.Next(10, 99);
//}

//foreach (int i in arr)
//{
//    Console.Write($"{i} ");
//}
//Console.WriteLine();
//Foo(arr, ShowNegative);
//Console.WriteLine();
//void Foo(int[] arr, Action<int> action)
//{
//    foreach (var item in arr)
//    {
//        action(item);
//    }
//}

//void ShowSquare(int numb)
//{
//    Console.Write($"{numb * numb} ");
//}

//void ShowCube(int numb)
//{
//    Console.Write($"{numb * numb * numb} ");
//}

//void ShowNegative(int numb)
//{
//    Console.Write($"{-numb} ");
//}


//public delegate void Del(int a);
#endregion

#region Func
// Func<T>



//var evens = ints.Where(Even).ToList();

//evens.ForEach(Console.WriteLine);

//bool Even (int numb)
//{
//    return numb %2 == 0;
//}
#endregion


#region Predicate


//var grearterFive = ints.FindAll(GraeterThanFive).ToList();

//grearterFive.ForEach(Console.WriteLine);

//bool GraeterThanFive(int numb)
//{
//    return numb > 5;
//}
#endregion

#region Comparison
//List<Human> humans = new() {
//    new Human { Name ="Lla", Age=17},
//    new Human { Name ="Ati", Age=12},
//    new Human { Name ="Allita", Age=25},
//    new Human { Name ="Talila", Age=32}
    
//};

//humans.ForEach(Console.WriteLine);
//Console.WriteLine();
//humans.Sort(NameComp);

//humans.ForEach(Console.WriteLine);
//Console.WriteLine();

//humans.Sort(AgeComp);

//humans.ForEach(Console.WriteLine);
//Console.WriteLine();
//int NameComp(Human a, Human b)
//{
//    return a.Name.CompareTo(b.Name);
//}

//int AgeComp(Human a, Human b)
//{
//    return a.Age.CompareTo(b.Age);
//}

//class Human
//{
//    public string Name { get; set; }
//    public int Age { get; set; }
//    public override string ToString()
//    {
//        return $"{Name} - {Age}";
//    }
//}
#endregion
