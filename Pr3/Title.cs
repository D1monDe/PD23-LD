using System;

class Title
{
    private string titleName;
    public string TitleName
    {
        get => titleName;
        set => titleName = value;
    }
    public Title(string title)
    {
        titleName = title;
    }
    public void Show()
    {
        Console.ForegroundColor = ConsoleColor.White;
        Console.WriteLine(titleName);
        Console.ResetColor();
    }
}
