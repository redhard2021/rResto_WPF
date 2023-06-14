using RedResto.models;
using System.Collections.Generic;
using System.Windows.Controls;

namespace RedResto.pages
{
    /// <summary>
    /// Interaction logic for MainMenuPage.xaml
    /// </summary>
    public partial class MainMenuPage : Page
    {
        List<Provider> providers;
        List<Employee> employees;
        public MainMenuPage()
        {

            InitializeComponent();
            providers = new List<Provider>
            {
                new Provider()
                {
                    Name = "Mister Huevo",
                    Address = "Carlos Cazares 2350",
                    CUIT = "30-70388343-3",
                    Contact = "Martin",
                    Phone = "11 60189217"

                },
                new Provider()
                {
                    Name = "Healthy Depot",
                    Address = "Av Griveo 7000, CABA",
                    CUIT = "30-388573555-3",
                    Contact = "Paula",
                    Phone = "11 802344223"

                },
                new Provider()
                {
                    Name = "Lechugator3000",
                    Address = "Av Siempre Viva",
                    CUIT = "30-44353453-3",
                    Contact = "Fabricio",
                    Phone = "11 2342323445"

                }
            };
            employees = new List<Employee> {
                new Employee() {
                    Id = 1,
                    Name = "Carlos Mejia",
                    DNI = "3999999",
                    Address = "Abc 123",
                    Phone = "11 119595949"
                   },
                new Employee() {
                    Id = 2,
                    Name = "Alberto Fernandez",
                    DNI = "3999999",
                    Address = "Abc 123",
                    Phone = "11 23234234"
                   },
                new Employee() {
                    Id = 3,
                    Name = "Cristina Fernandez",
                    DNI = "3999999",
                    Address = "Abc 123",
                    Phone = "11 23443234"
                   },
                new Employee() {
                    Id = 3,
                    Name = "Mauricio Macri",
                    DNI = "3999999",
                    Address = "Abc 123",
                    Phone = "11 23443234"
                   },
            };
            EmployeesData.ItemsSource = employees;
            ProviderData.ItemsSource = providers;
            DataContext = this;
        }
    }
}
