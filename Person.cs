using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Laboration3
{
    public class Person
    {
        //class properties
        public string EyeColor { get; set; }
        public DateOnly BirthDate { get; set; }
        public Hair PersonHair { get; set; }
        public Gender PersonGender { get; set; }

        //constructor
        public Person(string eyeColor, DateOnly birthDate, Hair personHair, Gender personGender)
            {
            EyeColor = eyeColor;
            BirthDate = birthDate;
            PersonHair = personHair;
            PersonGender = personGender;
            }

        //ToString metod som gör om datan till string och formatterar den för utskrift.
        public override string ToString()
        {
            return 
            $"\nÖgonfärg: {EyeColor}" +
            $"\nFödelsdag: {BirthDate}" +
            $"\nHårlängd: {PersonHair.Length} " +
            $"\nHårfärg: {PersonHair.Color}" +
            $"\nKön: {PersonGender}";
        }

    }
} 
