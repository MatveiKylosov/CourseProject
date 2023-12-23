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

        Button[] buttons;

        public MainWindow()
        {
            InitializeComponent();
            this.MouseDown += Window_MouseDown;
            buttons = new Button[] { ButtonCar, ButtonClient, ButtonPromotion, ButtonSell, ButtonStaff };
        }
        private void MainWindow_StateChanged(object sender, EventArgs e)
        {
            if (this.WindowState == WindowState.Maximized)
            {
                Panel.Margin = new Thickness(0,5,0,0);
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

        private void State_Click(object sender, RoutedEventArgs e) =>  Application.Current.MainWindow.WindowState = Application.Current.MainWindow.WindowState == WindowState.Maximized ? WindowState.Normal : WindowState.Maximized;

        private void Minimize_Click(object sender, RoutedEventArgs e) => Application.Current.MainWindow.WindowState = WindowState.Minimized;
        private void Close_Click(object sender, RoutedEventArgs e) => this.Close();


        private void SearchActive(object sender, TextChangedEventArgs e)
        {

        }

        private void OpenClient(object sender, RoutedEventArgs e)
        {
            PanelOut.Children.Clear();
            for (int i = 0; i < 10; i++)
                PanelOut.Children.Add(new Elements.Client());
        }

        private void OpenStaff(object sender, RoutedEventArgs e)
        {
            PanelOut.Children.Clear();
            for (int i = 0; i < 10; i++)
                PanelOut.Children.Add(new Elements.Employee());
        }

        private void OpenCar(object sender, RoutedEventArgs e)
        {
            PanelOut.Children.Clear();
            for (int i = 0; i < 10; i++)
                PanelOut.Children.Add(new Elements.Car());
        }

        private void OpenPromotion(object sender, RoutedEventArgs e)
        {

        }

        private void OpenSell(object sender, RoutedEventArgs e)
        {
            PanelOut.Children.Clear();
            for (int i = 0; i < 10; i++)
                PanelOut.Children.Add(new Elements.Sell());
        }

        private void OpenFilter(object sender, RoutedEventArgs e)
        {

        }
    }
}
