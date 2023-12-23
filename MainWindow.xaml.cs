using CourseProject.Table_classes;
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

namespace CourseProject
{
    /// <summary>
    /// Логика взаимодействия для MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public List<Table_classes.Car> cars;
        public List<Table_classes.Client> clients;
        public List<Table_classes.Employee> employees;
        public List<Table_classes.Sale> sales;
        public List<Table_classes.Stock> stocks;
        public static MainWindow mainWindow;

        enum tabels { 
            cars = 0,
            clients = 1,
            employees = 2,
            sales = 3,
            stocks = 4,
        }
        tabels ActiveTabels;
        public MainWindow()
        {
            InitializeComponent();
            this.MouseDown += Window_MouseDown;
            mainWindow = this;
            Random random = new Random();
            string[] brands = { "Toyota", "Honda", "Ford", "Chevrolet", "Mercedes" };
            string[] models = { "Model1", "Model2", "Model3", "Model4", "Model5" };
            string[] names = { "Иван", "Алексей", "Михаил", "Сергей", "Владимир" };
            string[] surnames = { "Иванов", "Петров", "Сидоров", "Кузнецов", "Смирнов" };
            string[] patronymics = { "Иванович", "Алексеевич", "Михайлович", "Сергеевич", "Владимирович" };
            string[] posts = { "Менеджер", "Продавец", "Консультант", "Администратор", "Директор" };
            string[] emails = { "email1@example.com", "email2@example.com", "email3@example.com", "email4@example.com", "email5@example.com" };

            for (int i = 0; i < 10; i++)
            {
                cars.Add(new Car(i, brands[random.Next(brands.Length)], models[random.Next(models.Length)], random.Next(2000, 2022), random.Next(50000, 100000), random.Next(1, 5)));
                clients.Add(new Client(i, surnames[random.Next(surnames.Length)], names[random.Next(names.Length)], patronymics[random.Next(patronymics.Length)], "+7" + random.Next(100000000, 999999999).ToString(), emails[random.Next(emails.Length)]));
                employees.Add(new Employee(i, surnames[random.Next(surnames.Length)], names[random.Next(names.Length)], patronymics[random.Next(patronymics.Length)], posts[random.Next(posts.Length)], "+7" + random.Next(100000000, 999999999).ToString(), emails[random.Next(emails.Length)]));
                sales.Add(new Sale(i, random.Next(10), random.Next(10), random.Next(10), random.Next(10), random.Next(10), random.Next(50000, 100000), DateTime.Now.AddDays(random.Next(-365, 365))));
                stocks.Add(new Stock(i, "Stock" + i.ToString(), "Description" + i.ToString(), random.Next(1000, 5000), DateTime.Now.AddDays(random.Next(-365, 365)), DateTime.Now.AddDays(random.Next(-365, 365))));
            }

        }


        private void SearchActive(object sender, TextChangedEventArgs e)
        {
            if (Search.Text.Length == Search.Text.Count(x => x == ' '))
                return;

            switch (ActiveTabels)
            {
                case tabels.cars:
                    {
                        PanelOut.Children.Clear();
                        foreach (Table_classes.Car x in cars)
                        {
                            if (x.brand.Contains(Search.Text) ||
                               x.model.Contains(Search.Text) ||
                               x.year_issue.ToString().Contains(Search.Text) ||
                               x.price.ToString().Contains(Search.Text) ||
                               x.quantity.ToString().Contains(Search.Text)
                               )
                                PanelOut.Children.Add(new Elements.Car(x));
                                
                        }
                        break;
                    }
                case tabels.clients:
                    break;
                case tabels.employees:
                    break;
                case tabels.sales:
                    break;
                case tabels.stocks:
                    break;
            }

            
        }

        private void OpenFilter(object sender, RoutedEventArgs e)
        {

        }

        private void OpenClient(object sender, RoutedEventArgs e)
        {
            ActiveTabels = tabels.clients;
            PanelOut.Children.Clear();
            for (int i = 0; i < 10; i++)
                PanelOut.Children.Add(new Elements.Client());
        }

        private void OpenStaff(object sender, RoutedEventArgs e)
        {
            ActiveTabels = tabels.employees;
            PanelOut.Children.Clear();
            for (int i = 0; i < 10; i++)
                PanelOut.Children.Add(new Elements.Employee());
        }

        private void OpenCar(object sender, RoutedEventArgs e)
        {
            ActiveTabels = tabels.cars;
            PanelOut.Children.Clear();
            for (int i = 0; i < 10; i++)
                PanelOut.Children.Add(new Elements.Car());
        }

        private void OpenPromotion(object sender, RoutedEventArgs e)
        {
            ActiveTabels = tabels.stocks;
            PanelOut.Children.Clear();
            for (int i = 0; i < 10; i++)
                PanelOut.Children.Add(new Elements.Stock());
        }

        private void OpenSell(object sender, RoutedEventArgs e)
        {
            ActiveTabels = tabels.sales;
            PanelOut.Children.Clear();
            for (int i = 0; i < 10; i++)
                PanelOut.Children.Add(new Elements.Sell());
        }


        //Windows methods
        private void MainWindow_StateChanged(object sender, EventArgs e)
        {
            if (this.WindowState == WindowState.Maximized)
            {
                Panel.Margin = new Thickness(0, 5, 0, 0);
                this.MaxHeight = SystemParameters.WorkArea.Height + 7;
                this.MaxWidth = SystemParameters.WorkArea.Width + 7;
            }
            else if (this.WindowState == WindowState.Normal)
            {
                Panel.Margin = new Thickness(0, 0, 0, 0);
                this.MaxHeight = double.PositiveInfinity;
                this.MaxWidth = double.PositiveInfinity;
            }
        }

        private void Window_MouseDown(object sender, MouseButtonEventArgs e)
        {
            if (e.ChangedButton == MouseButton.Left)
                this.DragMove();
        }

        private void State_Click(object sender, RoutedEventArgs e) => Application.Current.MainWindow.WindowState = Application.Current.MainWindow.WindowState == WindowState.Maximized ? WindowState.Normal : WindowState.Maximized;

        private void Minimize_Click(object sender, RoutedEventArgs e) => Application.Current.MainWindow.WindowState = WindowState.Minimized;
        private void Close_Click(object sender, RoutedEventArgs e) => this.Close();
    }
}
