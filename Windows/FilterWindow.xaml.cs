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

namespace CourseProject.Windows
{
    /// <summary>
    /// Логика взаимодействия для FilterWindow.xaml
    /// </summary>
    public partial class FilterWindow : Window
    {
        bool Filter = false;
        public FilterWindow()
        {
            InitializeComponent();
        }

        void CBCheck(object sender, RoutedEventArgs e)
        {
            Panel.Children.Clear();

            if ((bool)CBCar.IsChecked)
            {
                Panel.Children.Add(new Elements.Filter.CarFilter());
            }
            if ((bool)CBClient.IsChecked)
            {
                Panel.Children.Add(new Elements.Filter.ClientFilter());
            }
            if ((bool)CBEmployee.IsChecked)
            {
                Panel.Children.Add(new Elements.Filter.EmployeeFilter());
            }
            if ((bool)CBSell.IsChecked)
            {
                Panel.Children.Add(new Elements.Filter.SellFilter());
            }
            if ((bool)CBStock.IsChecked)
            {
                Panel.Children.Add(new Elements.Filter.StockFilter());
            }
        }

       public void Settings(MainWindow.tabels x)
        {
            if (!Filter)
            {
                switch (x) {
                    case MainWindow.tabels.cars:
                        {              
                            CBCar.IsChecked = true;
                            break;
                        }
                    case MainWindow.tabels.clients:
                        {                
                            CBClient.IsChecked = true;
                            break;
                        }
                    case MainWindow.tabels.employees:
                        {                
                            CBEmployee.IsChecked = true;
                            break;
                        }
                    case MainWindow.tabels.sales:
                        {                
                            CBSell.IsChecked = true;
                            break;
                        }
                    case MainWindow.tabels.stocks:
                        {                
                            CBStock.IsChecked = true;
                            break;
                        }
                    default:
                        break;
                }
            }

            CBCheck(null, null);
        }

        private void MainWindow_StateChanged(object sender, EventArgs e)
        {
            if (this.WindowState == WindowState.Maximized)
            {
                PanelWindow.Margin = new Thickness(0, 5, 0, 0);
                this.MaxHeight = SystemParameters.WorkArea.Height + 5;
                this.MaxWidth = SystemParameters.WorkArea.Width + 7;
            }
            else if (this.WindowState == WindowState.Normal)
            {
                PanelWindow.Margin = new Thickness(0, 0, 0, 0);
                this.MaxHeight = double.PositiveInfinity;
                this.MaxWidth = double.PositiveInfinity;
            }
        }
        private void Window_MouseDown(object sender, MouseButtonEventArgs e)
        {
            if (e.ChangedButton == MouseButton.Left)
                this.DragMove();
        }
        private void State_Click(object sender, RoutedEventArgs e)
        {
            this.WindowState = this.WindowState == WindowState.Maximized ? WindowState.Normal : WindowState.Maximized;
        }
        private void Minimize_Click(object sender, RoutedEventArgs e) => Application.Current.MainWindow.WindowState = WindowState.Minimized;
        private void Close_Click(object sender, RoutedEventArgs e) => this.Hide();

        private void Reset_Click(object sender, RoutedEventArgs e)
        {
            CBCar.IsChecked = false;
            CBClient.IsChecked = false;
            CBEmployee.IsChecked = false;
            CBSell.IsChecked = false;
            CBStock.IsChecked = false;

            CBCheck(null, null);
            Filter = false;
        }

        private void Apply_Click(object sender, RoutedEventArgs e)
        {
            Filter = true;
            this.Hide();
        }
    }
}
