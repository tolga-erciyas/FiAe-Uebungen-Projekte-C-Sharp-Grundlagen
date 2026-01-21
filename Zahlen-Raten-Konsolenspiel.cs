using System;

class Program
{
    static void Main()
    {
        Random random = new Random();
        int geheimZahl = random.Next(1, 11); // 1 bis 10
        int versuch = 0;
        int versuche = 0;
        bool richtig = false;

        Console.WriteLine(" Zahlen-Raten-Spiel!");
        Console.WriteLine("Rate eine Zahl zwischen 1 und 10");

        while (!richtig)
        {
            Console.Write("Deine Eingabe: ");
            string eingabe = Console.ReadLine();

            if (int.TryParse(eingabe, out versuch))
            {      
                versuche++;
            if (versuch < geheimZahl)
                {
                    Console.WriteLine("Zu niedrig ");
                }
                else if (versuch > geheimZahl)
                {
                    Console.WriteLine("Zu hoch ");
                }
                else
                {
                    Console.WriteLine($"Richtig!  Du hast {versuche} Versuch(e) gebraucht.");
                    richtig = true;
                }
            }
            else
            {
                Console.WriteLine("Bitte gib eine gültige Zahl ein!");
            }
        }

        Console.WriteLine("Spiel beendet.");
    }
}
