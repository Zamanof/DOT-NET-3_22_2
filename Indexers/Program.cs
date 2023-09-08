// data_type this[argument_type] {get; set;}

//Garage garage = new Garage(2);
//garage[0] = new Car { Model = "Alfa Romeo", Price = 78000 };
//garage[1] = new Car { Model = "Toyota Prius", Price=53};
////for (int i = 0; i < garage.Count; i++)
////{
////    Console.WriteLine(garage[i]);
////}

//Console.WriteLine(garage["AlfaRomeo"]);
//Console.WriteLine(garage["Prius"]);

MultiArray multiArray = new(3, 3);

for (int i = 0; i < 3; i++)
{
    for (int j = 0; j < 3; j++)
    {
        multiArray[i, j] = i * 3 + j;
    }
}

for (int i = 0; i < 3; i++)
{
    for (int j = 0; j < 3; j++)
    {
        Console.Write($"{multiArray[i, j]} "); 
    }
    Console.WriteLine();
}

class Car
{
    public string? Model { get; set; }
    public double Price { get; set; }

    public override string ToString()
    {
        return $"{Model} - {Price}$";
    }
}

class Garage
{
    Car[] cars;

    public Garage(int count)
    {
        cars = new Car[count];
    }

    public int Count
    {
        get { return cars.Length; }
    }

    public Car this[int index]
    {
        get
        {
            if(index >= 0 && index < cars.Length)
            {
                return cars[index];
            }
            throw new IndexOutOfRangeException();
        }
        set { cars[index] = value; }
    }

    public Car this[string model]
    {
        get
        {
            if(Enum.IsDefined(typeof(Models), model))
            {
                return cars[(int)Enum.Parse(typeof(Models), model)];
            }
            return new Car();
        }

        set { cars[(int)Enum.Parse(typeof(Models), model)] = value; }
    }
}


class MultiArray
{
    private int[,] array;
    public int Rows { get; set; }
    public int Columns { get; set; }

    public MultiArray(int rows, int columns)
    {
        Rows = rows;
        Columns = columns;
        array = new int[rows, columns];
    }

    public int this[int row, int columns]
    {
        get { return array[row, columns]; }
        set { array[row, columns] = value; }
    }
}

enum Models { AlfaRomeo, Prius, NAZ, Lamborghini};
