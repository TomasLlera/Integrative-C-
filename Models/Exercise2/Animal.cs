using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Classes
{
    public abstract class Animal
    {
        public string Name { get; set; }

        public Animal (string name)
        {
            Name = name;
        }

        public virtual string MakeSound()
        {
            return "Sound";
        }
        public virtual string Presentation()
        {
            return $"I am a {Name} and i make {MakeSound()}";
        }
    }
}
