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
using System.Windows.Navigation;
using System.Windows.Shapes;

namespace WPFAnimalSounds
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        MediaPlayer mp = new MediaPlayer();

        public MainWindow()
        {
            InitializeComponent();
        }

        private void btnDog_Click(object sender, RoutedEventArgs e)
        {
            //mp.Open(new Uri(@"C:\Users\paulb\source\repos\WPFAnimalSounds\WPFAnimalSounds\sounds\dogs.mp3"));
            //mp.Open(new Uri(@"../../sounds/dogs.mp3", UriKind.Relative));
            mp.Open(new Uri(@"sounds/dogs.mp3", UriKind.Relative));
            mp.Play();
        }

        private void btnCow_Click(object sender, RoutedEventArgs e)
        {
            mp.Open(new Uri(@"sounds/cow.mp3", UriKind.Relative));
            mp.Play();
        }

        private void btnGoat_Click(object sender, RoutedEventArgs e)
        {
            mp.Open(new Uri(@"sounds/Goat-noise.mp3", UriKind.Relative));
            mp.Play();
        }

        private void btnNext_Click(object sender, RoutedEventArgs e)
        {
            Window2 w2 = new Window2();
            w2.Show();
            this.Close();
        }
    }
}
