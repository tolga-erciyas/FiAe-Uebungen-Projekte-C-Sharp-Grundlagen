using System;

namespace Projekt_2
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Wie heißt du ?");
            string name = Console.ReadLine();

            Console.WriteLine("Wie alt bist du ?");
            string ageInput = Console.ReadLine();
            int age;
            if (!int.TryParse(ageInput, out age) || age < 0)
            {
                Console.WriteLine("Ungültige Eingabe für das Alter.");
            }
            else
            {
                int birthYear = DateTime.Now.Year - age;
                Console.WriteLine($"Hallo {name}, schön dich kennenzulernen! Du wurdest ungefähr {birthYear} geboren.");
            }
        }
    }
}
