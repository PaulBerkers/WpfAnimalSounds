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
using System.Windows.Threading;

namespace WPFAnimalSounds
{
    /// <summary>
    /// Interaction logic for Window4.xaml
    /// </summary>
    public partial class Window4 : Window
    {
        DispatcherTimer dt = new DispatcherTimer();

        public Window4()
        {
            InitializeComponent();
        }

        private void BtnStart_Click(object sender, RoutedEventArgs e)
        {
            dt.Interval = TimeSpan.FromMilliseconds(50);
            dt.Tick += Dt_Tick;
            dt.Start();
        }

        private void Dt_Tick(object sender, EventArgs e)
        {
            Random rnd = new Random();
            int iNumber = rnd.Next(1, 5);

            Image mySelectedImage = new Image();
                
            mySelectedImage.FindName("img" + iNumber.ToString()).ToString();

            double left = mySelectedImage.Margin.Left;
            double top = mySelectedImage.Margin.Top;
            mySelectedImage.Margin = new Thickness(left + 5, top, 0, 0);
        }
    }
}
