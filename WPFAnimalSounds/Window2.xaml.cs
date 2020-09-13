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
    /// Interaction logic for Window2.xaml
    /// </summary>
    public partial class Window2 : Window
    {
        public Window2()
        {
            InitializeComponent();
        }

        private void btnDog_Click(object sender, RoutedEventArgs e)
        {
            Dog d = new Dog();
            d.MakeSomeNoise();
        }

        private void btnCow_Click(object sender, RoutedEventArgs e)
        {
            Cow c = new Cow();
            c.MakeSomeNoise();
        }

        private void btnGoat_Click(object sender, RoutedEventArgs e)
        {
            Goat g = new Goat();
            g.MakeSomeNoise();
        }

        private void btnNext_Click(object sender, RoutedEventArgs e)
        {
            Window3 w3 = new Window3();
            w3.Show();
            this.Close();
        }
    }
}
