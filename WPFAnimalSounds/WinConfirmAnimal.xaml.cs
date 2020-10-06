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
    public delegate void Notify();
    /// <summary>
    /// Interaction logic for WinConfirmAnimal.xaml
    /// </summary>
    public partial class WinConfirmAnimal : Window
    {
        public string DisplayAddAnimal { get; set; }
        private string animal;
        private List<IAnimal> listAnimals;

        public event Notify Confirmed;

        public WinConfirmAnimal(List<IAnimal> lstAnimals, string strAnimal)
        {
            InitializeComponent();
            //gaan we iets mee doen
            this.animal = strAnimal;
            this.listAnimals = lstAnimals;
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

            //create images from list, confirmed earlier
            int indexList = 0;
            foreach (IAnimal listedAnimal in listAnimals)
            {
                switch (listedAnimal.ToString())
                {
                    case "WPFAnimalSounds.Chicken":
                        CreateImagePosition("chicken.jpg", indexList);
                        break;
                    case "WPFAnimalSounds.Cow":
                        CreateImagePosition("cow.jpg", indexList);
                        break;
                    case "WPFAnimalSounds.Dog":
                        CreateImagePosition("dog.jpg", indexList);
                        break;
                    case "WPFAnimalSounds.Duck":
                        CreateImagePosition("duck.png", indexList);
                        break;
                    case "WPFAnimalSounds.Goat":
                        CreateImagePosition("goat.jpg", indexList);
                        break;
                    case "WPFAnimalSounds.Horse":
                        CreateImagePosition("horse.jpg", indexList);
                        break;
                    case "WPFAnimalSounds.Pig":
                        CreateImagePosition("pig.jpg", indexList);
                        break;
                    case "WPFAnimalSounds.Rooster":
                        CreateImagePosition("rooster.jpg", indexList);
                        break;
                    default:
                        break;
                }
                indexList++;
            }
        }

        private void CreateImagePosition(string fileName, int index)
        {
            //column positie van image in grid.row
            int pos = 0;
            switch (index)
            {
                case 0: pos = 1; break;
                case 1: pos = 3; break;
                case 2: pos = 5; break;
                case 3: pos = 7; break;
            }

            //image animal
            Image img = new Image(); //in images/animals
            img.Name = $"imgAnimal{index}";
            img.Source = new BitmapImage(new Uri($"/WPFAnimalSounds;component/images/animals/{fileName}", UriKind.Relative));
            img.Stretch = Stretch.Fill;
            Grid.SetRow(img, 1);
            Grid.SetColumn(img, pos);
            grdConfirmedList.Children.Add(img);


            Image imgDel = new Image(); //in images/animals
            imgDel.Name = $"imgRemove{index}";
            imgDel.Tag = index;
            imgDel.Source = new BitmapImage(new Uri($"/WPFAnimalSounds;component/images/err.png", UriKind.Relative));
            imgDel.Height = 20;
            imgDel.Width = 20;
            imgDel.ToolTip = "Remove";
            imgDel.MouseDown += ImgDel_MouseDown1; ;
            Grid.SetRow(imgDel, 2);
            Grid.SetColumn(imgDel, pos);
            grdConfirmedList.Children.Add(imgDel);
        }

        private void ImgDel_MouseDown1(object sender, MouseButtonEventArgs e)
        {
            //waardes aanpassen in dit scherm en teruggeven aan hoofdscherm

            //1. alle plaatjes verwijderen van scherm
            IEnumerable<Image> someImgs = grdConfirmedList.Children.OfType<Image>();
            List<Image> tmpList = someImgs.ToList();
            foreach (Image item in tmpList)
            {
                grdConfirmedList.Children.Remove(item);
            }

            //2. plaatje verwijderen uit List<Animals>
            int indexTag = Convert.ToInt32(((Image)sender).Tag);
            listAnimals.RemoveAt(indexTag);

            //3. scherm opbouwen
            PopulateWindow();
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
            //Voer event uit
            Confirmed();
            this.Close();
        }

        private void ImgDel_MouseDown(object sender, MouseButtonEventArgs e)
        {
            //Geen confirm
            this.Close();
        }
    }
}
