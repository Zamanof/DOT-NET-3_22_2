// Extension methods

string atilla = "A u Atilli illita u A";
Console.WriteLine(atilla.CountWords(5));



static class StringExtension
{
    public static int CountWords(this string str, int u)
    {
        if (string.IsNullOrEmpty(str))
        {
            return 0;
        }
        return str.Split(' ').Length;
    }
}
