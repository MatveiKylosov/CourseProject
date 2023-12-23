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
    /// Логика взаимодействия для Stock.xaml
    /// </summary>
    public partial class Stock : UserControl
    {
        Table_classes.Stock stock;
        bool edit = false;
        public Stock(Table_classes.Stock stock = null)
        {
            InitializeComponent();
            this.stock = stock;

            if (stock != null)
            {
                name.Text = stock.name;
                description.Text = stock.description;
                price.Text = stock.price.ToString();
                start_date.Text = stock.start_date.ToString();
                end_date.Text = stock.end_date.ToString();

                AddGrid.Visibility = Visibility.Hidden;
            }
            else
            {
                name.Visibility = description.Visibility = price.Visibility = start_date.Visibility = end_date.Visibility = Visibility.Hidden;
                TBname.Visibility = TBdescription.Visibility = TBprice.Visibility = TBstart_date.Visibility = TBend_date.Visibility = Visibility.Visible;
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
            if (stock != null)
            {
                //Изменение
                if (edit)
                {
                    //Добавление SQL

                    name.Visibility = description.Visibility = price.Visibility = start_date.Visibility = end_date.Visibility = Visibility.Visible;
                    TBname.Visibility = TBdescription.Visibility = TBprice.Visibility = TBstart_date.Visibility = TBend_date.Visibility = Visibility.Hidden;

                    name.Text = TBname.Text;
                    description.Text = TBdescription.Text;
                    price.Text = TBprice.Text;
                    start_date.Text = TBstart_date.Text;
                    end_date.Text = TBend_date.Text;

                    edit = false;
                }
                else
                {
                    name.Visibility = description.Visibility = price.Visibility = start_date.Visibility = end_date.Visibility = Visibility.Hidden;
                    TBname.Visibility = TBdescription.Visibility = TBprice.Visibility = TBstart_date.Visibility = TBend_date.Visibility = Visibility.Visible;

                    TBname.Text = name.Text;
                    TBdescription.Text = description.Text;
                    TBprice.Text = price.Text;
                    TBstart_date.Text = start_date.Text;
                    TBend_date.Text = end_date.Text;

                    DeleteCancel.Content = "Отмена";
                    edit = true;
                }
            }
            else
            {
                //Добавление SQL
                MainWindow.mainWindow.OpenPromotion(null, null);
            }
            //Добавление
        }

        private void DeleteCancel_Click(object sender, RoutedEventArgs e)
        {
            if (stock != null)
            {
                if (edit)
                {
                    name.Visibility = description.Visibility = price.Visibility = start_date.Visibility = end_date.Visibility = Visibility.Visible;
                    TBname.Visibility = TBdescription.Visibility = TBprice.Visibility = TBstart_date.Visibility = TBend_date.Visibility = Visibility.Hidden;

                    TBname.Text = name.Text;
                    TBdescription.Text = description.Text;
                    TBprice.Text = price.Text;
                    TBstart_date.Text = start_date.Text;
                    TBend_date.Text = end_date.Text;

                    DeleteCancel.Content = "Удалить";

                    edit = false;
                }
                else
                {
                    //Удаление SQL
                    MessageBox.Show("Удаление");
                    MainWindow.mainWindow.OpenPromotion(null, null);
                }
            }
            else
            {
                TBname.Text = TBdescription.Text = TBprice.Text = TBstart_date.Text = TBend_date.Text = "";
                AddGrid.Visibility = Visibility.Visible;
            }
        }

    }
}
