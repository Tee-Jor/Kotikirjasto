namespace Kotikirjasto;

public class Book
{
    public static List<Book> Booklist = new List<Book>();
    public string Title { get; set; }
    public string Author { get; set; }
    public string Genre { get; set; }
    public int Year { get; set; }




    public Book(string title, string author, string genre, int year)
    {

        this.Title = title;
        this.Author = author;
        this.Genre = genre;
        this.Year = year;

    }

    public static void AddBook()
    {
        Console.WriteLine("Lisää kirja antamalla seuraavat tiedot");

        Console.WriteLine("Anna kirjan nimi");
        string? title = Console.ReadLine() ?? "";

        Console.WriteLine("Anna kirjan tekijän nimi");
        string? author = Console.ReadLine() ?? "";

        Console.WriteLine("Anna kirjan genre");
        string? genre = Console.ReadLine() ?? "";

        Console.WriteLine("Anna kirjan julkaisuvuosi");
        int year = Convert.ToInt32(Console.ReadLine());

        Book newBook = new Book(title, author, genre, year);

        bool found = false;

        foreach (Book addBook in Booklist)
        {
            if (addBook.Title.Equals(newBook.Title, StringComparison.CurrentCultureIgnoreCase) && addBook.Author.Equals(newBook.Author, StringComparison.CurrentCultureIgnoreCase))
            {
                found = true;
                break;
            }

        }
        if (found)
        {
            Console.WriteLine($"{title}: {author} can already be found on the book list");
        }
        else
        {
            Console.WriteLine($"{title}: {author} is added to the book list");
            Booklist.Add(newBook);
        }


    }

    public static void RemoveBook()
    {
        Console.WriteLine("Anna seuraavat poistettavan kirjan tiedot");

        Console.WriteLine("Anna kirjan nimi");

        string? title = Console.ReadLine() ?? "";

        Console.WriteLine("Anna kirjan tekijä");

        string? author = Console.ReadLine() ?? "";

        for (int i = Booklist.Count - 1; i >= 0; i--)
        {
            if (Booklist[i].Title.Equals(title, StringComparison.CurrentCultureIgnoreCase) && Booklist[i].Author.Equals(author, StringComparison.CurrentCultureIgnoreCase))
            {
                Console.WriteLine($"{title}: {author} has been deleted from the book list");
                Booklist.RemoveAt(i);
               
            }
        }

    }

    public static void SearchGenre()
    {
        Console.WriteLine("Anna genre jonka mukaan haluat etsiä kirjoja");

        string? genre = Console.ReadLine();
        bool found = false;
        foreach (var book in Booklist)
        {
            if (book.Genre.Equals(genre, StringComparison.CurrentCultureIgnoreCase))
            {
                Console.WriteLine($"{book.Title}");
                found = true;

            }
        }
        if (found == false)
        {
            Console.WriteLine($"Genrestä {genre} ei löytynyt yhtään kirjaa");
        }
    }

    public static void SearchName()
    {
        Console.WriteLine("Haluatko 1. Etsiä kirjan nimen mukaan\n2. Kirjan tekijän mukaan?");

        string? input = Console.ReadLine();

        if (input != null && input.Equals("1"))
        {
            Console.WriteLine("Anna kirjan nimi");
            string? name = Console.ReadLine();

            bool found = false;
            foreach (var book in Booklist)
            {
                if (book.Title.Equals(name, StringComparison.CurrentCultureIgnoreCase))
                {
                    Console.WriteLine($"{book.Title}");
                    found = true;

                }
            }
            if (found == false)
            {
                Console.WriteLine($"Nimellä {name} ei löytynyt yhtään kirjaa");
            }
        }
        if (input != null && input.Equals("2"))
        {
            Console.WriteLine("Anna kirjoittajan nimi");
            string? writer = Console.ReadLine();

            bool found = false;
            foreach (var book in Booklist)
            {
                if (book.Author.Equals(writer, StringComparison.CurrentCultureIgnoreCase))
                {
                    Console.WriteLine($"{book.Title}");
                    found = true;

                }
            }
            if (found == false)
            {
                Console.WriteLine($"Kirjoittajalla {writer} ei löytynyt yhtään kirjaa");
            }

        }
    }

    public static void AllBooks()
    {
        Console.WriteLine("Listataan kaikki kirjat");
        foreach (Book book in Booklist)
        {
            Console.WriteLine($"Nimi: {book.Title}, Kirjoittaja: {book.Author}, Genre: {book.Genre}, Julkaisuvuosi {book.Year}");
        }
    }

   


}
