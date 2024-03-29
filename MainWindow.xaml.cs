﻿using CourseProject.Elements;
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
        Windows.FilterWindow filterWindow = new Windows.FilterWindow();
        
        public List<Table_classes.Car> cars = new List<Table_classes.Car>();
        public List<Table_classes.Client> clients = new List<Table_classes.Client>();
        public List<Table_classes.Employee> employees = new List<Table_classes.Employee>();

        public List<Table_classes.Sale> sales = new List<Table_classes.Sale>();
        public List<Table_classes.Stock> stocks = new List<Table_classes.Stock>();

        public static MainWindow mainWindow;

        public enum tabels { 
            cars = 0,
            clients = 1,
            employees = 2,
            sales = 3,
            stocks = 4,
            nothing
        }
        
        tabels ActiveTabels = tabels.nothing;

        public MainWindow()
        {
            InitializeComponent();

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
                Table_classes.Car car = new Table_classes.Car(i, brands[random.Next(brands.Length)], models[random.Next(models.Length)], random.Next(2000, 2022), random.Next(50000, 100000), random.Next(1, 5));
                cars.Add(car);

                Table_classes.Client client = new Table_classes.Client(i, surnames[random.Next(surnames.Length)], names[random.Next(names.Length)], patronymics[random.Next(patronymics.Length)], "+7" + random.Next(100000000, 999999999).ToString(), emails[random.Next(emails.Length)]);
                clients.Add(client);

                Table_classes.Employee employee = new Table_classes.Employee(i, surnames[random.Next(surnames.Length)], names[random.Next(names.Length)], patronymics[random.Next(patronymics.Length)], posts[random.Next(posts.Length)], "+7" + random.Next(100000000, 999999999).ToString(), emails[random.Next(emails.Length)]);
                employees.Add(employee);

                Table_classes.Stock stock = new Table_classes.Stock(i, "Stock" + i.ToString(), "Description" + i.ToString(), random.Next(1000, 5000), DateTime.Now.AddDays(random.Next(-365, 365)), DateTime.Now.AddDays(random.Next(-365, 365)));
                stocks.Add(stock);

                Table_classes.Sale sale = new Table_classes.Sale(i, client, employee, car, stock, random.Next(50000, 100000), DateTime.Now.AddDays(random.Next(-365, 365)));
                sales.Add(sale);
            }
        }

        public void OpenFilter(object sender, RoutedEventArgs e)
        {
            filterWindow.Settings(ActiveTabels);
            filterWindow.ShowDialog();           
        }

        public void OpenClient(object sender, RoutedEventArgs e)
        {
            if (ActiveTabels != tabels.clients)
                scroll_main.ScrollToTop();

            ActiveTabels = tabels.clients;
            PanelOut.Children.Clear();

            PanelOut.Children.Add(new Elements.Client());
            foreach (Table_classes.Client x in clients)
                PanelOut.Children.Add(new Elements.Client(x));
            
        }

        public void OpenStaff(object sender, RoutedEventArgs e)
        {
            if(ActiveTabels != tabels.employees)
                scroll_main.ScrollToTop();
            ActiveTabels = tabels.employees;
            PanelOut.Children.Clear();

            PanelOut.Children.Add(new Elements.Employee());
            foreach (Table_classes.Employee x in employees)
                PanelOut.Children.Add(new Elements.Employee(x));

        }

        public void OpenCar(object sender, RoutedEventArgs e)
        {
            if(ActiveTabels != tabels.cars)
                scroll_main.ScrollToTop();

            ActiveTabels = tabels.cars;
            PanelOut.Children.Clear();

            PanelOut.Children.Add(new Elements.Car());
            foreach (Table_classes.Car x in cars)
                PanelOut.Children.Add(new Elements.Car(x));
        }

        public void OpenPromotion(object sender, RoutedEventArgs e)
        {
            if(ActiveTabels != tabels.stocks)
                scroll_main.ScrollToTop();

            ActiveTabels = tabels.stocks;
            PanelOut.Children.Clear();

            PanelOut.Children.Add(new Elements.Stock());
            foreach (Table_classes.Stock x in stocks)
                PanelOut.Children.Add(new Elements.Stock(x));
        }

        public void OpenSell(object sender, RoutedEventArgs e)
        {
            if(ActiveTabels != tabels.sales)
                scroll_main.ScrollToTop();

            ActiveTabels = tabels.sales;
            PanelOut.Children.Clear();

            PanelOut.Children.Add(new Elements.Sell());
            foreach (Table_classes.Sale x in sales)
                PanelOut.Children.Add(new Elements.Sell(x));
        }

        private void LogB_Click(object sender, RoutedEventArgs e)
        {
            if (Login.Text == "Matvei" && Password.Password.ToString() == "Asdfg123")
                LogRegGrid.Visibility = Visibility.Hidden;
            
            else
                MessageBox.Show("Не правильные данные");
        }

        private void RegB_Click(object sender, RoutedEventArgs e)
        {
            if (string.IsNullOrEmpty(Login.Text) || string.IsNullOrEmpty(Password.Password.ToString()))
            {
                MessageBox.Show("Заполните все поля.");
                return;
            }
            else
            {
                LogRegButton.Content = "Войти";
                LogRegButton.Click -= RegB_Click;
                LogRegButton.Click += LogB_Click;
            }
        }

        private void Reg_Click(object sender, MouseButtonEventArgs e)
        {
            LogRegButton.Content = "Зарегистрироваться";
            LogRegLabel.Content = "Войти";

            LogRegButton.Click -= LogB_Click;
            LogRegButton.Click += RegB_Click;
            LogRegLabel.MouseLeftButtonDown -= Reg_Click;
            LogRegLabel.MouseLeftButtonDown += Log_Click;
        }

        private void Log_Click(object sender, MouseButtonEventArgs e)
        {
            LogRegButton.Content = "Войти";
            LogRegLabel.Content = "Зарегистрироваться";

            LogRegButton.Click += LogB_Click;
            LogRegButton.Click -= RegB_Click;
            LogRegLabel.MouseLeftButtonDown += Reg_Click;
            LogRegLabel.MouseLeftButtonDown -= Log_Click;
        }
    }
}
