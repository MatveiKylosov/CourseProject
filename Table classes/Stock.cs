using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CourseProject.Table_classes
{
    public class Stock
    {
        public int ID_stock { get; set; }
        public string name { get; set; }
        public string description { get; set; }
        public double price { get; set; }
        public DateTime start_date { get; set; }
        public DateTime end_date { get; set; }

        public Stock(int id, string name, string description, double price, DateTime startDate, DateTime endDate)
        {
            ID_stock = id;
            this.name = name;
            this.description = description;
            this.price = price;
            start_date = startDate;
            end_date = endDate;
        }
    }
}
