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

namespace Frontend_aplikacja_o_jedzeniu
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

        private void Grid_MouseLeftButtonDown(object sender, MouseButtonEventArgs e)
        {
            this.DragMove();
        }

        private void Button_Click(object sender, RoutedEventArgs e)
        {

        }

        private void BtnclickP1(object sender, RoutedEventArgs e)
        {
            Main.Content = new Stronaschowel();
        }

        private void BtnclickP2(object sender, RoutedEventArgs e)
        {
            Main.Content = new StronakalkulatorBMI();
        }

        private void BtnclickP3(object sender, RoutedEventArgs e)
        {
            Main.Content = new Stronakalkulatorkalori();
        }

        private void BtnclickP4(object sender, RoutedEventArgs e)
        {
            Main.Content = new wyszukiwarka();
        }

        private void Btnclick5(object sender, RoutedEventArgs e)
        {
            Main.Content = new stronaużytkownik();
        }
    }
}
