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
        bool edit = false;
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
            else
            {
                surname.Visibility = first_name.Visibility = patronymic.Visibility = post.Visibility = phone.Visibility = email.Visibility = Visibility.Hidden;
                TBsurname.Visibility = TBfirst_name.Visibility = TBpatronymic.Visibility = TBpost.Visibility = TBphone.Visibility = TBemail.Visibility = Visibility.Visible;
            }
        }

        private void Add(object sender, MouseButtonEventArgs e)
        {
            AddGrid.Visibility = Visibility.Hidden;

            AddEdit.Content = "Добавить";
            DeleteCancel.Content = "Отмена";
        }

        private void AddEdit_Click(object sender, RoutedEventArgs e)
        {
            if (employee != null)
            {
                //Изменение
                if (edit)
                {
                    //Добавление SQL

                    surname.Visibility = first_name.Visibility = patronymic.Visibility = post.Visibility = phone.Visibility = email.Visibility = Visibility.Visible;
                    TBsurname.Visibility = TBfirst_name.Visibility = TBpatronymic.Visibility = TBpost.Visibility = TBphone.Visibility = TBemail.Visibility = Visibility.Hidden;

                    surname.Text = TBsurname.Text;
                    first_name.Text = TBfirst_name.Text;
                    patronymic.Text = TBpatronymic.Text;
                    post.Text = TBpost.Text;
                    phone.Text = TBphone.Text;
                    email.Text = TBemail.Text;

                    edit = false;
                }
                else
                {
                    surname.Visibility = first_name.Visibility = patronymic.Visibility = post.Visibility = phone.Visibility = email.Visibility = Visibility.Hidden;
                    TBsurname.Visibility = TBfirst_name.Visibility = TBpatronymic.Visibility = TBpost.Visibility = TBphone.Visibility = TBemail.Visibility = Visibility.Visible;

                    TBsurname.Text = surname.Text;
                    TBfirst_name.Text = first_name.Text;
                    TBpatronymic.Text = patronymic.Text;
                    TBpost.Text = post.Text;
                    TBphone.Text = phone.Text;
                    TBemail.Text = email.Text;

                    DeleteCancel.Content = "Отмена";
                    edit = true;
                }
            }
            else
            {
                //Добавление SQL
                MainWindow.mainWindow.OpenStaff(null, null);
            }
            //Добавление
        }

        private void DeleteCancel_Click(object sender, RoutedEventArgs e)
        {
            if (employee != null)
            {
                if (edit)
                {
                    surname.Visibility = first_name.Visibility = patronymic.Visibility = post.Visibility = phone.Visibility = email.Visibility = Visibility.Visible;
                    TBsurname.Visibility = TBfirst_name.Visibility = TBpatronymic.Visibility = TBpost.Visibility = TBphone.Visibility = TBemail.Visibility = Visibility.Hidden;


                    TBsurname.Text = surname.Text;
                    TBfirst_name.Text = first_name.Text;
                    TBpatronymic.Text = patronymic.Text;
                    TBpost.Text = post.Text;
                    TBphone.Text = phone.Text;
                    TBemail.Text = email.Text;

                    DeleteCancel.Content = "Удаление";

                    edit = false;
                }
                else
                {
                    //Удаление SQL
                    MessageBox.Show("Удаление");
                    MainWindow.mainWindow.OpenCar(null, null);
                }
            }
            else
            {
                TBsurname.Text = TBfirst_name.Text = TBpatronymic.Text = TBpost.Text = TBphone.Text = TBemail.Text = "";
                AddGrid.Visibility = Visibility.Visible;
            }
        }

    }
}
