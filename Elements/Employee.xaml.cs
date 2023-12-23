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
    /// Логика взаимодействия для Employee.xaml
    /// </summary>
    public partial class Employee : UserControl
    {
        Table_classes.Employee employee = null;
        public Employee(Table_classes.Employee employee = null)
        {
            InitializeComponent();
            this.employee = employee;

            if (employee != null)
            {
                surname.Text = employee.surname;
                first_name.Text = employee.first_name;
                patronymic.Text = employee.patronymic;
                post.Text = employee.post;
                phone.Text = employee.phone;
                email.Text = employee.email;

                AddGrid.Visibility = Visibility.Hidden;
            }
        }

        private void Add(object sender, MouseButtonEventArgs e)
        {

        }
    }
}
