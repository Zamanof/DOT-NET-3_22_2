FrontEndDeveloper frontEnd = new FrontEndDeveloper 
{ 
    Name = "John", 
    Surname="Doe" 
};

BackEndDeveloper backEnd = new BackEndDeveloper
{ 
    Name = "Moye", 
    Surname = "Imya" 
};

FullStackDeveloper fullStack = new FullStackDeveloper
{
    Name = "Atilla",
    Surname = "Ismayil"
};


BackEndAnnouncement(backEnd, new string[] {"C#", "Python", "PHP" });
Console.WriteLine();
BackEndAnnouncement(fullStack, new string[] {"C#", "C++", "NodeJS" });
Console.WriteLine();
FrontEndAnnouncement(frontEnd);
Console.WriteLine();
FrontEndAnnouncement(fullStack);
Console.WriteLine();
FullStackAnnouncement(fullStack, new string[] { "C", "Perl", "Laravel" });
Console.WriteLine();



void BackEndAnnouncement(IBackEndDevolper devolper, string[] languages)
{
    devolper.knowBackEndLanguage(languages);
}

void FrontEndAnnouncement(IFrontEndDeveloper frontEnd)
{
    frontEnd.KnowCSS();
    frontEnd.KnowHTML();
    frontEnd.KnowJS();
}

void FullStackAnnouncement(IFullStackDeveloper fullStackDeveloper, string[] languages)
{
    fullStackDeveloper.knowBackEndLanguage(languages);
    fullStackDeveloper.KnowCSS();
    fullStackDeveloper.KnowHTML();
    fullStackDeveloper.KnowJS();

}

class FrontEndDeveloper :Human, IFrontEndDeveloper
{
    public void KnowCSS()
    {
        Console.WriteLine("I know CSS");
    }

    public void KnowHTML()
    {
        Console.WriteLine("I know HTML");
    }

    public void KnowJS()
    {
        Console.WriteLine("I know JS");
    }
}

class BackEndDeveloper :Human, IBackEndDevolper
{
    public void knowBackEndLanguage(string[] langauges)
    {
        Console.WriteLine("I know: ");
        foreach (var language in langauges)
        {
            Console.WriteLine($"    {language}");
        };
    }
}


class FullStackDeveloper :Human, IFullStackDeveloper
{
    public void knowBackEndLanguage(string[] langauges)
    {
        Console.WriteLine("I know: ");
        foreach (var language in langauges)
        {
            Console.WriteLine($"    {language}");
        };
    }

    public void KnowCSS()
    {
        Console.WriteLine("I know CSS");
    }

    public void KnowHTML()
    {
        Console.WriteLine("I know HTML");
    }

    public void KnowJS()
    {
        Console.WriteLine("I know JS");
    }
}

interface IFrontEndDeveloper
{
    void KnowHTML();
    void KnowCSS();
    void KnowJS();
}

interface IBackEndDevolper
{
    void knowBackEndLanguage(string[] langauges);
}


interface IFullStackDeveloper: IFrontEndDeveloper, IBackEndDevolper 
{ }
abstract class Human
{
    public string Name { get; set; }
    public string Surname { get; set; }
}
