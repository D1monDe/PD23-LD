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

        Console.WriteLine("Хочете змінити автора? (так/ні)");
        string response = Console.ReadLine();

        if (response.ToLower() == "так")
        {
            Console.WriteLine("Введіть нове ім'я автора:");
            string newAuthorName = Console.ReadLine();
            authorName.AuthorFullName = newAuthorName;
            Console.WriteLine("Ім'я автора змінено.");
            book.Show();
        }
        else
        {
            Console.WriteLine("Ім'я автора не було змінено");
        }
    }
}