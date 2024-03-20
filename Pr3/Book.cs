using System;

class Book
{
    private Title title;
    private Author author;
    private Content content;

    public Book(Title t, Author a, Content c)
    {
        title = t;
        author = a;
        content = c;
    }

    public void Show()
    {
        Console.WriteLine("Назва книги:");
        title.Show();
        Console.WriteLine("Автор:");
        author.Show();
        Console.WriteLine("Опис:");
        content.Show();
    }
}