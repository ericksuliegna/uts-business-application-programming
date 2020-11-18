using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace uts_business_application_programming
{
    class Billing
    {
        public int BillingID { get; set; }
        public int MejaID { get; set; }
        public int OrderID { get; set; }
        public string Tanggal { get; set; }
        public int Total { get; set; }

        public Billing() { }
        public Billing(int billingID, int mejaID, int orderID, string tanggal, int total)
        {
            this.BillingID = billingID;
            this.MejaID = mejaID;
            this.OrderID = orderID;
            this.Tanggal = tanggal;
            this.Total = total;
        }

    }
}
