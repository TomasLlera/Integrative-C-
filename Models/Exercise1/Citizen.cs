using System;
using System.Xml.Schema;

namespace Classes
{
    public class Citizen
    {
        public string CompleteName { get; }
        public string Dni { get; }
        public int Age { get; }

        public Citizen(string completeName, string dni, int age)
        {
            if (this.Age < 0)
                throw new ArgumentException("[ERROR] The age can´t be negative.");

            CompleteName = completeName;
            Dni = dni;
            Age = age;
        }

        public string Greet()
        {
            return $"Hello, i am {CompleteName} and i have {Age} years old.";
        }

        public string IsAdult()
        {
            if (Age >= 18)
            {
                return"\r\nThe age is biggest than 18";
            } 
            else
            {
                return "\r\nThe age cannot be less than 18";
            }
        }
    }
}
