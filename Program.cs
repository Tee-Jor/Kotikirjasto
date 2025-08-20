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

            if (input != null && input.Equals("6"))
            {
                break;
            }

            if (input != null && input.Equals("1"))
            {
                AddBook();
            }

            if (input != null && input.Equals("2"))
            {

            }

            if (input != null && input.Equals("3"))
            {

            }

            if (input != null && input.Equals("4"))
            {

            }
            
            if (input != null && input.Equals("5"))
            {
                
            }
        }
    }    
        
}
