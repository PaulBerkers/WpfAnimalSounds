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
    /// Interaction logic for WinConfirmAnimal.xaml
    /// </summary>
    public partial class WinConfirmAnimal : Window
    {
        public string DisplayAddAnimal { get; set; }
        private string animal;

        public WinConfirmAnimal(List<IAnimal> lstAnimals, string strAnimal)
        {
            InitializeComponent();
            //gaan we iets mee doen
            this.animal = strAnimal;
            DataContext = this;

            PopulateWindow();
        }

        private void PopulateWindow()
        {
            DisplayAddAnimal = $"Voeg '{animal}' toe aan de lijst van kandidaten?";
            switch (animal)
            {
                case "Chicken":
                    CreateCenterImage("chicken.jpg");
                    break;
                case "Cow":
                    CreateCenterImage("cow.jpg");
                    break;
                case "Dog":
                    CreateCenterImage("dog.jpg");
                    break;
                case "Duck":
                    CreateCenterImage("duck.png");
                    break;
                case "Goat":
                    CreateCenterImage("goat.jpg");
                    break;
                case "Horse":
                    CreateCenterImage("horse.jpg");
                    break;
                case "Pig":
                    CreateCenterImage("pig.jpg");
                    break;
                case "Rooster":
                    CreateCenterImage("rooster.jpg");
                    break;
                default:
                    break;
            }
        }

        private void CreateCenterImage(string imgFile)
        {
            //image animal
            Image img = new Image(); //in images/animals
            img.Source = new BitmapImage(new Uri($"images/animals/{imgFile}", UriKind.Relative));
            img.Stretch = Stretch.Fill;
            Grid.SetRow(img, 3);
            Grid.SetColumn(img, 1);
            grdCenter.Children.Add(img);
        }

        private void Image_MouseDown(object sender, MouseButtonEventArgs e)
        {

        }
    }
}
