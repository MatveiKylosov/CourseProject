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

namespace CourseProject.Elements
{
    /// <summary>
    /// Логика взаимодействия для Car.xaml
    /// </summary>
    public partial class Car : UserControl
    {
        Table_classes.Car car = null;
        bool edit = false;
        public Car(Table_classes.Car car = null)
        {
            InitializeComponent();
            this.car = car;

            if(car != null)
            {
                brand.Text = car.brand;
                model.Text = car.model;
                year_issue.Text = car.year_issue.ToString();
                price.Text = car.price.ToString();
                quantity.Text = car.quantity.ToString();
                AddGrid.Visibility = Visibility.Hidden;
            }
            else
            {
                brand.Visibility = model.Visibility = year_issue.Visibility = price.Visibility = quantity.Visibility = Visibility.Hidden;
                TBbrand.Visibility = TBmodel.Visibility = TByear_issue.Visibility = TBprice.Visibility = TBquantity.Visibility = Visibility.Visible;
            }
        }

        private void Add(object sender, MouseButtonEventArgs e)
        {
            AddGrid.Visibility = Visibility.Hidden;

            AddEdit.Content = "Добавить";
            DeleteCancel.Content = "Cancel";
        }

        private void AddEdit_Click(object sender, RoutedEventArgs e)
        {
            if(car != null)
            {
                //Изменение
                if (edit)
                {
                    //Добавление SQL

                    brand.Visibility = model.Visibility = year_issue.Visibility = price.Visibility = quantity.Visibility = Visibility.Visible;
                    TBbrand.Visibility = TBmodel.Visibility = TByear_issue.Visibility = TBprice.Visibility = TBquantity.Visibility = Visibility.Hidden;

                    brand.Text = TBbrand.Text;
                    model.Text = TBmodel.Text;
                    year_issue.Text = TByear_issue.Text;
                    brand.Text = TBprice.Text;
                    brand.Text = TBquantity.Text;
                    brand.Text = TBprice.Text;

                    edit = false;
                }
                else
                {
                    brand.Visibility = model.Visibility = year_issue.Visibility = price.Visibility = quantity.Visibility = Visibility.Hidden;
                    TBbrand.Visibility = TBmodel.Visibility = TByear_issue.Visibility = TBprice.Visibility = TBquantity.Visibility = Visibility.Visible;

                    TBbrand.Text = brand.Text;
                    TBmodel.Text = model.Text;
                    TByear_issue.Text = year_issue.Text;
                    TBprice.Text = brand.Text;
                    TBquantity.Text = brand.Text;
                    TBprice.Text = brand.Text;

                    edit = true;
                }
            }
            else
            {
                //Добавление SQL
                MainWindow.mainWindow.OpenCar(null, null);
            }
            //Добавление
        }

        private void DeleteCancel_Click(object sender, RoutedEventArgs e)
        {
            if(car != null)
            {
                //Удаление SQL
                MainWindow.mainWindow.OpenCar(null, null);
            }
            else
            {
                TBbrand.Text = TBmodel.Text = TByear_issue.Text = TBprice.Text = TBquantity.Text = "";
                AddGrid.Visibility = Visibility.Visible;
            }
        }
    }
}
