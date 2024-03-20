using System;

class Content
{
    private string content;
    public string ContentValue
    {
        get => content;
        set => content = value;
    }
    public Content(string cont)
    {
        content = cont;
    }
    public void Show()
    {
        Console.ForegroundColor = ConsoleColor.Yellow;
        Console.WriteLine(content);
        Console.ResetColor();
    }
}
