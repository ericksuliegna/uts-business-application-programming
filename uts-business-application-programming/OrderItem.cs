using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace uts_business_application_programming
{
    public class OrderItem
    {
        public int OrderID { get; set; }
        public int FoodID { get; set; }
        public int Quantity { get; set; }
        public int TotalHarga { get; set; }

        public OrderItem() { }
        public OrderItem(int orderID, int foodID, int qty, int totalHarga)
        {
            this.OrderID = orderID;
            this.FoodID = foodID;
            this.Quantity = qty;
            this.TotalHarga = totalHarga;
        }


    }
}
