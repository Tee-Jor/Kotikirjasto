namespace Book;

public class Book
{
    List<Book> Booklist;
    public string Title { get; set; }
    public string Author { get; set; }
    public string Genre { get; set; }
    public int Year { get; set; }

    


    public Book(string title, string author, string genre, int year)
    {
        this.Booklist = new List<Book>();
        this.Title = title;
        this.Author = author;
        this.Genre = genre;
        this.Year = year;

    }

    public void AddBook()
    {

    }

    public void RemoveBook()
    {

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
