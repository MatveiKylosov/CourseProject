using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CourseProject.Table_classes
{
    public class Car
    {
        public int ID_car { get; set; }
        public string brand { get; set; }
        public string model { get; set; }
        public int year_issue { get; set; }
        public double price { get; set; }
        public int quantity { get; set; }

        public Car(int id, string brand, string model, int yearIssue, double price, int quantity)
        {
            ID_car = id;
            this.brand = brand;
            this.model = model;
            year_issue = yearIssue;
            this.price = price;
            this.quantity = quantity;
        }
    }
}
