using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Media;

namespace WPFAnimalSounds
{
    public class Dog : IAnimal
    {
        MediaPlayer mp = new MediaPlayer();

        public string Specie { get; set; }
        public string Name { get; set; }
        public int NumberOfLegs { get; set; }

        public void MakeSomeNoise()
        {
            mp.Open(new Uri("sounds/dogs.mp3", UriKind.Relative));
            mp.Play();
        }

        public string Says()
        {
            return "Woof";
        }
    }
}
