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
        public Stock(Table_classes.Stock stock = null)
        {
            InitializeComponent();
            this.stock = stock;

            if(stock != null )
            {
            //вставка данных
            }
        }
    }
}
