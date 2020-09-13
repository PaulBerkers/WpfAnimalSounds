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
    /// Interaction logic for Window3.xaml
    /// </summary>
    public partial class Window3 : Window
    {
        List<IAnimal> animals = new List<IAnimal>();
        public Window3()
        {
            InitializeComponent();
        }

        private void btnDog_Click(object sender, RoutedEventArgs e)
        {
            btnDog.IsEnabled = false;
            Dog dog = new Dog { Name = "Bartje", NumberOfLegs = 4 };
            animals.Add(dog);
        }

        private void btnCow_Click(object sender, RoutedEventArgs e)
        {
            btnCow.IsEnabled = false;
            Cow cow = new Cow { Name = "Bella", NumberOfLegs = 4 };
            cow.SoundEnded += Cow_SoundEnded; ;
            animals.Add(cow);
        }

        private void Cow_SoundEnded(object sender, EventArgs e)
        {
            btnDog.IsEnabled = true;
            btnCow.IsEnabled = true;
            btnGoat.IsEnabled = true;
            animals.Clear();
        }

        private void btnGoat_Click(object sender, RoutedEventArgs e)
        {
            btnGoat.IsEnabled = false;
            Goat goat = new Goat { Name = "Bertje", NumberOfLegs = 4 };
            animals.Add(goat);
        }

        private void btnPlayNoise_Click(object sender, RoutedEventArgs e)
        {
            foreach (IAnimal animal in animals)
            {
                animal.MakeSomeNoise();
            }
            //Als sound finished dan: enable buttons weer en maak list leeg.
        }
    }
}
