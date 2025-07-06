using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Classes
{
    public class Cat : Animal
    {
        public Cat(string nombre) : base(nombre)
        {
        }

        public override string MakeSound()
        {
            return "→ MiauMiau!";
        }

        public override string Presentation()
        {
            return $"\r\n→ I am a {Name} and i make {MakeSound()}";
        }
    }
}
