using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Shapes;

namespace WPFAnimalSounds
{
    /// <summary>
    /// Interaction logic for WinBetAnimal.xaml
    /// </summary>
    public partial class WinBetAnimal : Window
    {
        MediaPlayer mp = new MediaPlayer();
        public string SelectedAnimal { get; set; }
        public string SoundToPlay { get; set; }

        List<IAnimal> animals = new List<IAnimal>();

        public WinBetAnimal()
        {
            InitializeComponent();
        }

        private void Image_MouseEnter(object sender, MouseEventArgs e)
        {
            Image i = (Image)sender;
            i.Height = i.ActualHeight + 20;
            i.Width = i.ActualWidth + 20;

            //selected animal from sender: play that sound
            SelectedAnimal = ((Image)sender).Tag.ToString();
            switch (SelectedAnimal.ToLower())
            {
                case "imgdog":
                    SoundToPlay = "dogs.mp3";
                    SelectedAnimal = "Dog";
                    break;
                case "imgcow":
                    SoundToPlay = "cow.mp3";
                    SelectedAnimal = "Cow";
                    break;
                case "imgchicken":
                    SoundToPlay = "chicken.mp3";
                    SelectedAnimal = "Chicken";
                    break;
                case "imggoat":
                    SoundToPlay = "Goat-noise.mp3";
                    SelectedAnimal = "Goat";
                    break;
                case "imghorse":
                    SoundToPlay = "horse.mp3";
                    SelectedAnimal = "Horse";
                    break;
                case "imgrooster":
                    SoundToPlay = "rooster.mp3";
                    SelectedAnimal = "Rooster";
                    break;
                case "imgduck1":
                    SoundToPlay = "duck.mp3";
                    SelectedAnimal = "Duck";
                    break;
                case "imgpig":
                    SoundToPlay = "pigs.mp3";
                    SelectedAnimal = "Pig";
                    break;
            }

            //make noise
            mp.Open(new Uri($"sounds/{SoundToPlay}", UriKind.Relative));
            mp.Play();
        }

        private void Image_MouseLeave(object sender, MouseEventArgs e)
        {
            Image i = (Image)sender;
            i.Height = i.ActualHeight - 20;
            i.Width = i.ActualWidth - 20;
            mp.Stop();
        }

        private void Animal_Clicked(object sender, MouseButtonEventArgs e)
        {
            //confirmation screen: bouwen
            //nodig: Plaatje waarop ik heb geklikt
            //ook nodig: lijst van eerder geslecteerde animals
            //scherm bouwen: WinConfimAnimal

            this.Hide();
            WinConfirmAnimal winConf = new WinConfirmAnimal(animals, SelectedAnimal);
            winConf.Confirmed += WinConf_Confirmed;
            winConf.ShowDialog();

            this.Show();
        }

        private void WinConf_Confirmed()
        {
            //De lijst opbouwen dmv plaatje
            //Reflection: maak class van string en voeg deze class toe aan de lijst
            Type animalType = Type.GetType($"WPFAnimalSounds.{SelectedAnimal}, WPFAnimalSounds");
            IAnimal instanceObject = (IAnimal)(Activator.CreateInstance(animalType));

            animals.Add(instanceObject);
            
        }
    }
}
