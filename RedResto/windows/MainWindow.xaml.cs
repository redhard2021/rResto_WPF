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

namespace RedResto
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

        private void MoveWindow(object sender, MouseButtonEventArgs e)
        {
            if(e.ChangedButton == MouseButton.Left )
                this.DragMove();
        }

        private void Login(object sender, RoutedEventArgs e)
        {
            if (PasswordBox.Password == "tn23")
            {
                Home home = new Home();
                home.Show();
                this.Close();
            }
            else
            {
                MessageBox.Show("Ingrese una contraseña valida para continuar", "Tiendas Naturales");
            }
        }

        private void EnterPressed(object sender, KeyEventArgs e)
        {
            if(e.Key == Key.Enter) Login(sender, e);
        }
    }
}
