using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CourseProject.Table_classes
{
    public class Sale
    {
        public int ID_sale { get; set; }
        public int ID_client { get; set; }
        public int ID_employee { get; set; }
        public int ID_car { get; set; }
        public int ID_offer { get; set; }
        public int ID_stock { get; set; }
        public double finally_price { get; set; }
        public DateTime sale_date_time { get; set; }

        public Sale(int id, int clientId, int employeeId, int carId, int offerId, int stockId, double finalPrice, DateTime saleDateTime)
        {
            ID_sale = id;
            ID_client = clientId;
            ID_employee = employeeId;
            ID_car = carId;
            ID_offer = offerId;
            ID_stock = stockId;
            finally_price = finalPrice;
            sale_date_time = saleDateTime;
        }
    }
}
