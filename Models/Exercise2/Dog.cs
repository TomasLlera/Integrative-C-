using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Classes;
using System.Xml.Linq;

namespace Classes
{
    public class Dog : Animal
    {
        public Dog(string nombre) : base(nombre)
        {
        }

        public override string MakeSound()
        {
            return "Guafguaf!";
        }

        public override string Presentation()
        {
            return $"\r\nI am a {Name} and i make {MakeSound()}";
        }
    }
}
