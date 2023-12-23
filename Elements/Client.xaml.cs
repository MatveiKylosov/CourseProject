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

namespace CourseProject.Elements
{
    /// <summary>
    /// Логика взаимодействия для Client.xaml
    /// </summary>
    public partial class Client : UserControl
    {
        bool edit = false;
        Table_classes.Client client = null;
        public Client(Table_classes.Client client = null)
        {
            InitializeComponent();
            this.client = client;

            if (client != null)
            {
                surname.Text = client.surname;
                first_name.Text = client.first_name;
                patronymic.Text = client.patronymic;
                phone.Text = client.phone;
                email.Text = client.email;

                AddGrid.Visibility = Visibility.Hidden;
            }
            else
            {
                surname.Visibility = first_name.Visibility = patronymic.Visibility = phone.Visibility = email.Visibility = Visibility.Hidden;
                TBsurname.Visibility = TBfirst_name.Visibility = TBpatronymic.Visibility = TBphone.Visibility = TBemail.Visibility = Visibility.Visible;
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
            if (client != null)
            {
                //Изменение
                if (edit)
                {
                    //Добавление SQL

                    surname.Visibility = first_name.Visibility = patronymic.Visibility = phone.Visibility = email.Visibility = Visibility.Visible;
                    TBsurname.Visibility = TBfirst_name.Visibility = TBpatronymic.Visibility = TBphone.Visibility = TBemail.Visibility = Visibility.Hidden;

                    surname.Text = TBsurname.Text;
                    first_name.Text = TBfirst_name.Text;
                    patronymic.Text = TBpatronymic.Text;
                    phone.Text = TBphone.Text;
                    email.Text = TBemail.Text;

                    edit = false;
                }
                else
                {
                    surname.Visibility = first_name.Visibility = patronymic.Visibility = phone.Visibility = email.Visibility = Visibility.Hidden;
                    TBsurname.Visibility = TBfirst_name.Visibility = TBpatronymic.Visibility = TBphone.Visibility = TBemail.Visibility = Visibility.Visible;

                    TBsurname.Text = surname.Text;
                    TBfirst_name.Text = first_name.Text;
                    TBpatronymic.Text = patronymic.Text;
                    TBphone.Text = phone.Text;
                    TBemail.Text = email.Text;

                    edit = true;
                }
            }
            else
            {
                //Добавление SQL
                MainWindow.mainWindow.OpenClient(null, null);
            }
            //Добавление
        }

        private void DeleteCancel_Click(object sender, RoutedEventArgs e)
        {
            if (client != null)
            {
                //Удаление SQL
                MainWindow.mainWindow.OpenClient(null, null);
            }
            else
            {
                TBsurname.Text = TBfirst_name.Text = TBpatronymic.Text = TBphone.Text = TBemail.Text = "";
                AddGrid.Visibility = Visibility.Visible;
            }
        }

    }
}
