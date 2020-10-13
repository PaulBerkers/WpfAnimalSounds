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
    /// Interaction logic for WinBet.xaml
    /// </summary>
    public partial class WinBet : Window
    {
        MediaPlayer mp = new MediaPlayer();
        List<IAnimal> listAnimals = new List<IAnimal>();
        public WinBet(List<IAnimal> lstAnimals)
        {
            InitializeComponent();

            this.listAnimals = lstAnimals;

            CreateImageTiles();

            mp.Open(new Uri(@"sounds/cheer.wav", UriKind.Relative));
            mp.Play();
        }

        private void CreateImageTiles()
        {
            for (int i = 0; i < listAnimals.Count; i++)
            {
                switch (i)
                {
                    case 0:
                        imgAnimal1.Source = listAnimals[i].ImgAnimal.Source;
                        break;
                    case 1:
                        imgAnimal2.Source = listAnimals[i].ImgAnimal.Source;
                        break;
                    case 2:
                        imgAnimal3.Source = listAnimals[i].ImgAnimal.Source;
                        break;
                    case 3:
                        imgAnimal4.Source = listAnimals[i].ImgAnimal.Source;
                        break;
                }

            }
        }

        private void rbWin1_Checked(object sender, RoutedEventArgs e)
        {

        }

        private void rbWin2_Checked(object sender, RoutedEventArgs e)
        {

        }

        private void rbWin3_Checked(object sender, RoutedEventArgs e)
        {

        }

        private void rbWin4_Checked(object sender, RoutedEventArgs e)
        {

        }

        private void cmdMoneyUp_Click(object sender, RoutedEventArgs e)
        {

        }

        private void cmdMoneDown_Click(object sender, RoutedEventArgs e)
        {

        }

        private void btnStartRace_Click(object sender, RoutedEventArgs e)
        {

        }
    }
}
