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
                //заполнение данных
            }
        }
    }
}
