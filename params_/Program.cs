Console.WriteLine(Summ(new int[] { 1, 6, 9, 4, 5, 45, 54, 54, 5, 78, 4 }));
Console.WriteLine(SummParams(1, 6, 9, 4, 5, 45, 54, 54, 5, 78, 4));

int Summ(int[] ints)
{
    int summ = default;
    foreach (int i in ints)
    {
        summ += i;
    }
    return summ;
}

int SummParams(params int[] ints)
{
    int summ = default;
    foreach (int i in ints)
    {
        summ += i;
    }
    return summ;
}