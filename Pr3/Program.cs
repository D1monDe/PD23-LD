using System;

class Program
{
    static void Main(string[] args)
    {
        Title bookTitle = new Title("Гаррі Поттер");
        Author authorName = new Author("Джоан Роулинг");
        Content bookContent = new Content("Опис");

        Book book = new Book(bookTitle, authorName, bookContent);
        book.Show();

        Console.WriteLine("Хотите изменить имя автора? (да/нет)");
        string response = Console.ReadLine();

        if (response.ToLower() == "да")
        {
            Console.WriteLine("Введите новое имя автора:");
            string newAuthorName = Console.ReadLine();
            authorName.AuthorFullName = newAuthorName;
            Console.WriteLine("Имя автора изменено успешно.");
            book.Show();
        }
        else
        {
            Console.WriteLine("Имя автора осталось без изменений.");
        }
    }
}