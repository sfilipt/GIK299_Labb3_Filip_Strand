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
        public string Name { get; set; }
        public string EyeColor { get; set; }
        public DateOnly BirthDate { get; set; }
        public Hair PersonHair { get; set; }
        public Gender PersonGender { get; set; }

        //constructor
        public Person(string name, string eyeColor, DateOnly birthDate, Hair personHair, Gender personGender)
            {
            Name = name;
            EyeColor = eyeColor;
            BirthDate = birthDate;
            PersonHair = personHair;
            PersonGender = personGender;
            }

        public override string ToString()
        {
            return $"Namn: {Name}" +
            $"\nÖgonfärg: {EyeColor}" +
            $"\nFödelsdag: {BirthDate}" +
            $"\nHårlängd: {PersonHair.Length} " +
            $"\nHårfärg: {PersonHair.Color}" +
            $"\nKön: {PersonGender}";
        }

    }
} 
