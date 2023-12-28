using System;

// Создаем структуру "Книга"
struct Book
{
    public string Author;
    public int PageCount;
    public int Edition;
    public int YearPublished;
}

class Program
{
    static void Main(string[] args)
    {
        Book[] books = new Book[3];
        books[0] = new Book { Author = "Автор 1", PageCount = 100, Edition = 1, YearPublished = 2020 };
        books[1] = new Book { Author = "Автор 2", PageCount = 200, Edition = 2, YearPublished = 2019 };
        books[2] = new Book { Author = "Автор 3", PageCount = 300, Edition = 3, YearPublished = 2018 };
        for (int i = 0; i < books.Length; i++)
        {
            if (books[i].PageCount > 150)
            {
                Console.WriteLine("Автор: " + books[i].Author);
                Console.WriteLine("Количество страниц: " + books[i].PageCount);
                Console.WriteLine("Тираж: " + books[i].Edition);
                Console.WriteLine("Год издания: " + books[i].YearPublished);
                Console.WriteLine();
            }
        }

        Console.ReadKey();
    }
}
