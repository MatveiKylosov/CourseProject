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
        bool edit = false;
        Table_classes.Sale sale = null;
        public Sell(Table_classes.Sale sale = null)
        {
            InitializeComponent();
            this.sale = sale;

            if (sale != null)
            {
                FIO_client.Text = $"{sale.client.surname} {sale.client.first_name} {sale.client.patronymic}";
                FIO_employee.Text = $"{sale.employee.surname} {sale.employee.first_name}  {sale.employee.patronymic}";
                Name_car.Text = $"{sale.car.brand} {sale.car.model}";
                Name_stock.Text = sale.stock.name;
                finally_price.Text = sale.finally_price.ToString();
                sale_date_time.Text = sale.sale_date_time.ToString();

                AddGrid.Visibility = Visibility.Hidden;
            }
            else
            {
                FIO_client.Visibility = FIO_employee.Visibility = Name_car.Visibility = Name_stock.Visibility = finally_price.Visibility = sale_date_time.Visibility = Visibility.Hidden;
                TBFIO_client.Visibility = TBFIO_employee.Visibility = TBName_car.Visibility = TBName_stock.Visibility = TBfinally_price.Visibility = TBsale_date_time.Visibility = Visibility.Visible;
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
            if (sale != null)
            {
                //Изменение
                if (edit)
                {
                    //Добавление SQL

                    FIO_client.Visibility = FIO_employee.Visibility = Name_car.Visibility = Name_stock.Visibility = finally_price.Visibility = sale_date_time.Visibility = Visibility.Visible;
                    TBFIO_client.Visibility = TBFIO_employee.Visibility = TBName_car.Visibility = TBName_stock.Visibility = TBfinally_price.Visibility = TBsale_date_time.Visibility = Visibility.Hidden;

                    FIO_client.Text = TBFIO_client.Text;
                    FIO_employee.Text = TBFIO_employee.Text;
                    Name_car.Text = TBName_car.Text;
                    Name_stock.Text = TBName_stock.Text;
                    finally_price.Text = TBfinally_price.Text;
                    sale_date_time.Text = TBsale_date_time.Text;

                    edit = false;
                }
                else
                {
                    FIO_client.Visibility = FIO_employee.Visibility = Name_car.Visibility = Name_stock.Visibility = finally_price.Visibility = sale_date_time.Visibility = Visibility.Hidden;
                    TBFIO_client.Visibility = TBFIO_employee.Visibility = TBName_car.Visibility = TBName_stock.Visibility = TBfinally_price.Visibility = TBsale_date_time.Visibility = Visibility.Visible;

                    TBFIO_client.Text = FIO_client.Text;
                    TBFIO_employee.Text = FIO_employee.Text;
                    TBName_car.Text = Name_car.Text;
                    TBName_stock.Text = Name_stock.Text;
                    TBfinally_price.Text = finally_price.Text;
                    TBsale_date_time.Text = sale_date_time.Text;

                    edit = true;
                }
            }
            else
            {
                //Добавление SQL
                MainWindow.mainWindow.OpenSell(null, null);
            }
            //Добавление
        }

        private void DeleteCancel_Click(object sender, RoutedEventArgs e)
        {
            if (sale != null)
            {
                if (edit)
                {
                    FIO_client.Visibility = FIO_employee.Visibility = Name_car.Visibility = Name_stock.Visibility = finally_price.Visibility = sale_date_time.Visibility = Visibility.Visible;
                    TBFIO_client.Visibility = TBFIO_employee.Visibility = TBName_car.Visibility = TBName_stock.Visibility = TBfinally_price.Visibility = TBsale_date_time.Visibility = Visibility.Hidden;

                    TBFIO_client.Text = FIO_client.Text;
                    TBFIO_employee.Text = FIO_employee.Text;
                    TBName_car.Text = Name_car.Text;
                    TBName_stock.Text = Name_stock.Text;
                    TBfinally_price.Text = finally_price.Text;
                    TBsale_date_time.Text = sale_date_time.Text;

                    DeleteCancel.Content = "Удалить";

                    edit = false;
                }
                else
                {
                    //Удаление SQL
                    MessageBox.Show("Удаление");
                    MainWindow.mainWindow.OpenSell(null, null);
                }
            }
            else
            {
                TBFIO_client.Text = TBFIO_employee.Text = TBName_car.Text = TBName_stock.Text = TBfinally_price.Text = TBsale_date_time.Text = "";
                AddGrid.Visibility = Visibility.Visible;
            }
        }

    }
}
