namespace Kotikirjasto;

class Program
{
    static void Main(string[] args)
    {
        while (true)
        {
            Console.WriteLine("Tervetuloa Kotikirjastoosi. Mitä haluat tehdä?\n1. Lisää kirja.\n2. Poista Kirja"
        + "\n3. Näytä kaikki kirjat\n4. Näytä kirjat genren mukaan\n5. Etsi kirjoja kirjoittajan tai nimen perusteella." +
        "\n6. Poistu kirjastosta.");

            string? input = Console.ReadLine();

            switch (input)
            {
                case "1":
                    Book.AddBook();
                    break;

                case "2":
                    Book.RemoveBook();
                    break;

                case "3":
                    Book.AllBooks();
                    break;

                case "4":
                    Book.SearchGenre();
                    break;

                case "5":
                    Book.SearchName();
                    break;

                case "6":
                    Console.WriteLine("Heippa!");
                    return;

                default:
                    Console.WriteLine("Virheellinen valinta, yritä uudelleen.");
                    break;    
            }
        }    

            
    }    
        
}
