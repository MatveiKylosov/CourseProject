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
    /// Логика взаимодействия для Sell.xaml
    /// </summary>
    public partial class Sell : UserControl
    {
        Table_classes.Sale sale;
        public Sell(Table_classes.Sale sale = null)
        {
            InitializeComponent();
            this.sale = sale;

            if(sale != null )
            {

                FIO_client.Text = $"{sale.client.surname} {sale.client.first_name} {sale.client.patronymic}";
                FIO_employee.Text = $"{sale.employee.surname} {sale.employee.first_name}  {sale.employee.patronymic}";
                Name_car.Text = $"{sale.car.brand} {sale.car.model}";
                Name_stock.Text = sale.stock.name;
                finally_price.Text = sale.finally_price.ToString();
                sale_date_time.Text = sale.sale_date_time.ToString();
            }
        }
    }
}
