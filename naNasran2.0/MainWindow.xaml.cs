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

namespace naNasran2._0
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();
        }
        
        int NumberClicks = 0;

        private void NasratSe_Click(object sender, RoutedEventArgs e)
        {
            NumberClicks++;
            Random random = new Random();
            NasratSe.Margin = new Thickness(random.Next(0, 1900), random.Next(0, 900), 0, 0);
            if (NumberClicks == 3)
            {
                Queen.Visibility = Visibility.Visible;
            }
            else if (NumberClicks == 6)
            {
                Queen.Visibility = Visibility.Hidden;
            }
        }
    }
}
