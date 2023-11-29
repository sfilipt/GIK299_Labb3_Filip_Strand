using System;
using System.Xml.Linq;

namespace Laboration3
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string eyeColor = "Brun";
            DateOnly birthDate = new DateOnly(1993,2,8);
            Gender personGender = Gender.Man;
            Hair personHair = new Hair ("Kort", "Brun");
            Person personX = new Person(eyeColor, birthDate, personHair, personGender);
            Console.WriteLine(personX.ToString());
        }
    }
}