using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Media;

namespace WPFAnimalSounds
{
    public class Cow : IAnimal
    {
        MediaPlayer mp = new MediaPlayer();

        public string Specie { get; set; }
        public string Name { get; set; }
        public int NumberOfLegs { get; set; }

        public event EventHandler SoundEnded;

        public void MakeSomeNoise()
        {
            mp.MediaEnded += Mp_MediaEnded;
            mp.Open(new Uri("sounds/cow.mp3", UriKind.Relative));
            mp.Play();
        }

        private void Mp_MediaEnded(object sender, EventArgs e)
        {
            SoundEnded?.Invoke(this, null);
        }

        public string Says()
        {
            return "Moeuuuhhh";
        }
    }
}
