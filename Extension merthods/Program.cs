// Extension methods

string atilla = "A u Atilli illita u A";
Console.WriteLine(atilla.CountWords());


static class StringExtension
{
    public static int CountWords(this string str)
    {
        if (string.IsNullOrEmpty(str))
        {
            return 0;
        }
        return str.Split(' ').Length;
    }
}
