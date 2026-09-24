using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography;
using System.Text;
using System.Threading.Tasks;

namespace Einstieg1.OOP
{
    internal class Enumerationen
    {
        static void Main(string[] args)
        {
            /*Aufgabe 1
            Schreiben Sie eine Klasse Person, die aus den Attributen FirstName, LastName, Gender und
            Birthdate besteht. Diese müssen der Klasse als Konstruktorparameter übergeben werden. 
            Gender muss ein Enum mit den gültigen Werten Male, Female und Diverse sein. FirstName, 
            LastName und Gender müssen lesbar und schreibbar sein. BirthDate soll nur lesbar sein.Es
            muss eine GetFullName Methode geben, um den vollständigen Namen(FirstName +
            LastName) zu erhalten. */

            /*Klassendiagramm:
             * 
             * Person:
             * -------------------
             * + FirstName: string
             * + LastName: string 
             * + Gender: string 
             * - Birthdate: Date
             * -------------------
             * + Konstruktor: Person 
             * 
             * + GetFullName: void */

            Person P1 = new Person("King", "Kong", Gender.Male, DateTime.Parse("1992-11-22"));
            P1.GetFullName();
            Console.WriteLine(P1.Gender);
            P1.Gender = Gender.Diverse;
            Console.WriteLine(P1.Birthdate);
              

        }
    }
    public enum Gender
    {
        Male,
        Female,
        Diverse
    }
    class Person
    {
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public Gender Gender { get; set; }
       public DateTime Birthdate { get; }

        public Person (string firstName, string lastName, Gender gender, DateTime birthdate)
        {
            FirstName = firstName;
            LastName = lastName;
            Gender = gender;
            Birthdate = birthdate;
        }
        
        public void GetFullName()
        {
            Console.WriteLine(FirstName + " " +  LastName);
        }
         
        

    }
}
