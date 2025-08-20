namespace Book;

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

    public void AddBook()
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

    public void RemoveBook()
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
                Booklist.RemoveAt(i);
                Console.WriteLine($"{title}: {author} has been deleted from the book list");
            }
        }

    }

    public void SearchGenre()
    {

    }

    public void SearchName()
    {

    }

    public void AllBooks()
    {
        
    }


}
