using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Homework6
{
    public class Dog
    {
        public string Name { get; set; }
        public string Breed { get; set; }
        public string Color { get; set; }  
        
        public Dog(string nameInput, string breedInput, string colorInput) {
        
            Name = nameInput;
            Breed = breedInput;
            Color = colorInput;
        }

        public string Eat () {

            return $"The {Name} is now eating";

        }

        public string Play()
        {
            return $"The {Name} is now playing.";

        }

        public string ChaseTail()
        {

            return $"The {Name} is now chasing it's tail.";
        }
    }

}
