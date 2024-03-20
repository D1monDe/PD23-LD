using System;

class Author
{
    private string authorFullName;
    public string AuthorFullName
    {
        get => authorFullName;
        set => authorFullName = value;
    }
     
    public Author(string name)
    {
        authorFullName = name;
    }
    public void Show()
    {
        Console.ForegroundColor = ConsoleColor.DarkCyan;
        Console.WriteLine(authorFullName);
        Console.ResetColor();
    }
}
