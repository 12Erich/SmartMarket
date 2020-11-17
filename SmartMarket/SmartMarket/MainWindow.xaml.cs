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
using System.Windows.Media.Animation;
using System.Windows.Media.Imaging;
using System.Windows.Navigation;
using System.Windows.Shapes;

namespace SmartMarket
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

        private void btnLogout_Click(object sender, RoutedEventArgs e)
        {
            Application.Current.Shutdown();
        }

        private void btnCloseMenu_Click(object sender, RoutedEventArgs e)
        {
            //btnOpenMenu.Visibility = Visibility.Visible;
            //btnCloseMenu.Visibility = Visibility.Collapsed;
        }

        private void btnOpenMenu_Click(object sender, RoutedEventArgs e)
        {
            //btnCloseMenu.Visibility = Visibility.Visible;
            //btnOpenMenu.Visibility = Visibility.Collapsed;
        }

        bool MenuClosed = false;

        private void Button_Click(object sender, RoutedEventArgs e)
        {
            if (MenuClosed)
            {
                Storyboard openMenu = (Storyboard)button.FindResource("OpenMenu");
                openMenu.Begin();
            }
            else
            {
               Storyboard closeMenu = (Storyboard)button.FindResource("CloseMenu");
               closeMenu.Begin();
            }

            MenuClosed = !MenuClosed;
        }

        private void ButtonCloseMenu_Click(object sender, RoutedEventArgs e)
        {
            //ButtonOpenMenu.Visibility = Visibility.Visible;
            //ButtonCloseMenu.Visibility = Visibility.Collapsed;
        }

        private void listHome_PreviewMouseLeftButtonUp(object sender, MouseButtonEventArgs e)
        {

        }

        private void listBusca_PreviewMouseLeftButtonUp(object sender, MouseButtonEventArgs e)
        {

        }

        private void listCadastro_PreviewMouseLeftButtonUp(object sender, MouseButtonEventArgs e)
        {
            //txTitle.Text = "Cadastro";
            Frame.Source = new Uri("/Cadastro.xaml", UriKind.Relative);
        }

        private void listCaixa_PreviewMouseLeftButtonUp(object sender, MouseButtonEventArgs e)
        {

        }

        private void btnMenu_Click(object sender, RoutedEventArgs e)
        {
            //btnMenu.IsChecked
        }

        private void ButtonAlerta_Click(object sender, RoutedEventArgs e)
        {

        }

        private void ButtonClose_Click(object sender, RoutedEventArgs e)
        {
            Application.Current.Shutdown();
        }
    }
}
