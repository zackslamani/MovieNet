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

using MovieNet.ViewModels;
namespace MovieNet
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        MovieViewModel ViewModel;
        public MainWindow()
        {
            InitializeComponent();
            ViewModel = new MovieViewModel();
            this.DataContext = ViewModel;
        }

        private void MovieView_Loaded(object sender, RoutedEventArgs e)
        {

        }
    }
}
