namespace Kotikirjasto;

class Program
{

    static void Main(string[] args)
    {

        Book.LoadList();
        Book.AllBooks();
        Console.WriteLine("Paina Enter jatkaaksesi...");
        Console.ReadLine(); // odottaa käyttäjää ennen silmukkaa

        {

            while (true)

            {
                Console.Clear();
                Console.WriteLine("Tervetuloa Kotikirjastoosi. Mitä haluat tehdä?\n1. Lisää kirja.\n2. Poista Kirja"
            + "\n3. Näytä kaikki kirjat\n4. Näytä kirjat genren mukaan\n5. Etsi kirjoja kirjoittajan tai nimen perusteella." +
            "\n6. Tallenna lista.\n7. Poistu kirjastosta");

                string? input = Console.ReadLine();

                switch (input)
                {
                    case "1":
                        Console.Clear();
                        Book.AddBook();
                        break;

                    case "2":
                        Console.Clear();
                        Book.RemoveBook();
                        break;

                    case "3":
                        Console.Clear();
                        Book.AllBooks();
                        Console.WriteLine("Paina Enter jatkaaksesi...");
                        Console.ReadLine(); // odottaa käyttäjää ennen silmukkaa
                        break;

                    case "4":
                        Console.Clear();
                        Book.SearchGenre();
                        Console.WriteLine("Paina Enter jatkaaksesi...");
                        Console.ReadLine(); // odottaa käyttäjää ennen silmukkaa
                        break;

                    case "5":
                        Console.Clear();
                        Book.SearchName();
                        Console.WriteLine("Paina Enter jatkaaksesi...");
                        Console.ReadLine(); // odottaa käyttäjää ennen silmukkaa
                        break;

                    case "6":
                        Console.Clear();
                        Book.SaveList();
                        break;

                    case "7":
                        Console.Clear();
                        Console.WriteLine("Heippa!");
                        return;

                    default:
                        Console.Clear();
                        Console.WriteLine("Virheellinen valinta, yritä uudelleen.");
                        break;
                }
            }


        }
    }   
        
}
