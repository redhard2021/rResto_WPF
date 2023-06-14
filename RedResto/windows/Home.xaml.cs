using RedResto.pages;
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

namespace RedResto
{
    /// <summary>
    /// Interaction logic for Home.xaml
    /// </summary>
    public partial class Home : Window
    {
        public Home()
        {
            InitializeComponent();
            frame.NavigationService.Navigate(new MainMenuPage());
        }

        private void MoveWindow(object sender, MouseButtonEventArgs e)
        {
            if (e.ChangedButton == MouseButton.Left)
                this.DragMove();
        }

        private void ExitProgram(object sender, RoutedEventArgs e)
        {
            this.Close();
        }

        //TODO = See this in the future, change this long code for Buttons
        private void MainMenuEvent(object sender, RoutedEventArgs e)
        {

            SwitchPages("MainMenuBtn");
        }

        private void ProvidersEvent(object sender, RoutedEventArgs e)
        {
            SwitchPages("ProvidersBtn");
        }

        private void EmployeesEvent(object sender, RoutedEventArgs e)
        {
            SwitchPages("EmployeesBtn");
        }

        private void InvoiceEvent(object sender, RoutedEventArgs e)
        {
            SwitchPages("InvoiceBtn");
        }

        private void ReceiptsEvent(object sender, RoutedEventArgs e)
        {
            SwitchPages("ReceiptsBtn");
        }

        private void Button_Click(object sender, RoutedEventArgs e)
        {
            try
            {
                frame.NavigationService.GoBack();
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.ToString());
                frame.NavigationService.Navigate(new MainMenuPage());
            }
        }


        private void SwitchPages(string buttonPage)
        {
            frame.NavigationService.RemoveBackEntry();
            switch (buttonPage)
            {
                case "MainMenuBtn":
                    frame.NavigationService.Navigate(new MainMenuPage());
                    break;
                case "ProvidersBtn":
                    frame.NavigationService.Navigate(new ProvidersPage());
                    break;
                case "EmployeesBtn":
                    frame.NavigationService.Navigate(new EmployeesPage());
                    break;
                case "InvoiceBtn":
                    frame.NavigationService.Navigate(new InvoicePage());
                    break;
                case "ReceiptsBtn":
                    frame.NavigationService.Navigate(new ReceiptsPage());
                    break;
            }
        }

    }
}
