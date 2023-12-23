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
        Table_classes.Car car;
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
            }
        }
    }
}
