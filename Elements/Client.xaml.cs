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
        Table_classes.Client client;
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
                email.Text= client.email;
            }
        }
    }
}
