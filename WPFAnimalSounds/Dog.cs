using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Controls;
using System.Windows.Media;
using System.Windows.Media.Imaging;

namespace WPFAnimalSounds
{
    public class Dog : IAnimal
    {
        MediaPlayer mp = new MediaPlayer();
        private Image img = new Image();

        public string Specie { get; set; }
        public string Name { get; set; }
        public int NumberOfLegs { get; set; }
        public Image ImgAnimal
        {
            get { return img; }
            set { img = value; }
        }

        public Dog()
        {
            img.Source = new BitmapImage(new Uri(@"/images/animals/dog2.jpg", UriKind.RelativeOrAbsolute));
        }

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
