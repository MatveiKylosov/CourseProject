using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Tasks;

namespace CourseProject.Table_classes
{
    public class Sale
    {
        public int ID_sale { get; set; }
        public Table_classes.Client client { get; set; }
        public Table_classes.Employee employee { get; set; }
        public Table_classes.Car car { get; set; }
        public Table_classes.Stock stock { get; set; }
        public double finally_price { get; set; }
        public DateTime sale_date_time { get; set; }

        public Sale(int id, Table_classes.Client client, Table_classes.Employee employee, Table_classes.Car car, Table_classes.Stock stock, double finalPrice, DateTime saleDateTime)
        {
            ID_sale = id;
            this.client = client;
            this.employee = employee;
            this.car = car;
            this.stock = stock;
            finally_price = finalPrice;
            sale_date_time = saleDateTime;
        }
    }
}
