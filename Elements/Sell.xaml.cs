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
                FIO_client.Text = MainWindow.mainWindow.clients.Find(x => x.ID_client == sale.ID_client).first_name;
                FIO_employee.Text = MainWindow.mainWindow.employees.Find(x => x.ID_employee == sale.ID_employee).first_name;
                Table_classes.Car car = MainWindow.mainWindow.cars.Find(x => x.ID_car == sale.ID_car);
                Name_car.Text = $"{car.brand} {car.model}";

                if (sale.ID_stock == -1)
                    Name_stock.Text = "Отсутствует";
                else 
                    Name_stock.Text = MainWindow.mainWindow.stocks.Find(x => x.ID_stock == sale.ID_stock).ToString();

                finally_price.Text = sale.finally_price.ToString();
                sale_date_time.Text = sale.sale_date_time.ToString();
            }
        }
    }
}
