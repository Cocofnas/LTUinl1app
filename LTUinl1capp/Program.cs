using System;

class Program
{
    static void Main(string[] args)
    {
        int pris, betalt;

        //Add welcome message
        Console.Write("Hej och välkommen!: ");
        Console.WriteLine(); //add a blank line

        // Ask for price and what the customer paid
        Console.Write("Ange priset: ");
        while (!int.TryParse(Console.ReadLine(), out pris))
        {
            Console.WriteLine("Inga decimaler är tillåtna. Ange ett heltal för priset.");
            Console.Write("Ange priset: ");
        }

        Console.Write("Betalt: ");
        while (!int.TryParse(Console.ReadLine(), out betalt))
        {
            Console.WriteLine("Inga decimaler är tillåtna. Ange ett heltal för priset..");
            Console.Write("Betalt: ");
        }

        // Check if the costumer has paid to little
        if (betalt < pris)
        {
            Console.WriteLine("Kunden har betalt för lite. Be om rätt betalning.");
        }
        else
        {
            // Beräkna växel
            int vaxel = betalt - pris;
            Console.WriteLine($"Du får tillbaka: {vaxel} kr");

            // Definiera valörerna
            int[] valorer = { 500, 200, 100, 50, 20, 10, 5, 1 };
            string[] singular = { "femhundralapp", "tvåhundralapp", "hundralapp", "femtiolapp", "tjugolapp", "tiokrona", "femkrona", "enkrona" };
            string[] plural = { "femhundralappar", "tvåhundralappar", "hundralappar", "femtiolappar", "tjugolappar", "tiokronor", "femkronor", "enkronor" };

            // Walk through loop to see money exchange
            for (int i = 0; i < valorer.Length; i++)
            {
                int antal = vaxel / valorer[i];  // Antal av denna valör
                if (antal > 0)
                {
                    // Använd singular eller plural beroende på antal
                    if (antal == 1)
                    {
                        Console.WriteLine($"{antal} {singular[i]}");
                    }
                    else
                    {
                        Console.WriteLine($"{antal} {plural[i]}");
                    }

                    vaxel %= valorer[i];  // Minska växel med det som redan getts ut
                }
            }
        }
    }
}
