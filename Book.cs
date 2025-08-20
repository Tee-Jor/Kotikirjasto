namespace Kotikirjasto;

using System.Text.Json;


public class Book
{

    private const string SavedBookList = "currentList.json";
    public static List<Book> BookList = new List<Book>();
    public string Title { get; set; }
    public string Author { get; set; }
    public string Genre { get; set; }
    public int Year { get; set; }


    public Book() { }

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
        string? title = Console.ReadLine() ?? string.Empty;

        Console.WriteLine("Anna kirjan tekijän nimi");
        string? author = Console.ReadLine() ?? string.Empty;

        Console.WriteLine("Anna kirjan genre");
        string? genre = Console.ReadLine() ?? string.Empty;

        Console.WriteLine("Anna kirjan julkaisuvuosi");
        int year = Convert.ToInt32(Console.ReadLine());

        Book newBook = new Book(title, author, genre, year);

        bool found = false;

        foreach (Book addBook in BookList)
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

            BookList.Add(newBook);
        }


    }

    public static void RemoveBook()
    {
        AllBooks();

        Console.WriteLine("Anna seuraavat poistettavan kirjan tiedot");

        Console.WriteLine("Anna kirjan nimi");

        string? title = Console.ReadLine() ?? string.Empty;

        Console.WriteLine("Anna kirjan tekijä");

        string? author = Console.ReadLine() ?? string.Empty;

        for (int i = BookList.Count - 1; i >= 0; i--)
        {
            if (BookList[i].Title.Equals(title, StringComparison.CurrentCultureIgnoreCase) && BookList[i].Author.Equals(author, StringComparison.CurrentCultureIgnoreCase))
            {
                Console.WriteLine($"{title}: {author} has been deleted from the book list");

                BookList.RemoveAt(i);

            }
        }

    }

    public static void SearchGenre()
    {

        Console.Write("Anna genre jonka mukaan haluat etsiä kirjoja -");

        string? genre = Console.ReadLine() ?? string.Empty;
        bool found = false;
        foreach (var book in BookList)
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

        Console.WriteLine("Haluatko\n1. Etsiä kirjan nimen mukaan\n2. Kirjan tekijän mukaan?");

        string? input = Console.ReadLine() ?? string.Empty;

        if (input != null && input.Equals("1"))
        {
            Console.Write("Anna kirjan nimi  -");
            string? name = Console.ReadLine();

            bool found = false;
            foreach (var book in BookList)
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
            Console.Write("Anna kirjoittajan nimi  -");
            string? writer = Console.ReadLine() ?? string.Empty;

            bool found = false;
            foreach (var book in BookList)
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

        foreach (Book book in BookList)
        {
            Console.WriteLine($"Nimi: {book.Title}, Kirjoittaja: {book.Author}, Genre: {book.Genre}, Julkaisuvuosi {book.Year}\n-----------------------------------------------------------------------------------------------------------------");
        }
    }

    public static void SaveList()
    {
        AllBooks();

        Console.WriteLine("Haluatko tallentaa avoinna olevan listan? Kyllä/Ei?");

        string choice = Console.ReadLine() ?? string.Empty;
        if (choice.Equals("Kyllä", StringComparison.CurrentCultureIgnoreCase))
        {
            string json = JsonSerializer.Serialize(BookList);
            File.WriteAllText(SavedBookList, json);
            Console.WriteLine("Lista tallennettu onnistuneesti.");

        }
        if (choice != null && choice.Equals("Ei", StringComparison.CurrentCultureIgnoreCase))
        {
            return;
        }



    }
    public static void LoadList()
    {

        if (File.Exists(SavedBookList))
        {
            string json = File.ReadAllText(SavedBookList);
            var loadedList = JsonSerializer.Deserialize<List<Book>>(json);

            if (loadedList != null)
            {
                BookList = loadedList;
                Console.WriteLine("Viimeksi avoinna ollut lista ladattu onnistuneesti.");
            }

        }
        else
        {
            Console.WriteLine("Olemassa olevaa listaa ei löytynyt");

        }


        foreach (Book book in BookList)
        {
            Console.WriteLine($"Nimi: {book.Title}, Kirjoittaja: {book.Author}, Genre: {book.Genre}, Julkaisuvuosi {book.Year}");
        }

    }




}
