using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using CrystalDecisions.CrystalReports.Engine;
using System.Data.SqlClient;

namespace uts_business_application_programming
{
    public partial class Report : Form
    {
        ReportDocument cryrpt = new ReportDocument();
        //SqlConnection conn = new Connection().CreateAndOpenConnection();
        SqlConnection conn = new SqlConnection(@"Data Source=LAPTOP-5EV16MV1\SQL2019EXPRESS;Initial Catalog=DB_DATA;Integrated Security=True");
        public static int billingID;

        public Report()
        {
            InitializeComponent();
        }

        private void Report_Load(object sender, EventArgs e)
        {
            conn.Open();
            string query = "SELECT Billing.BillingID, Billing.OrderID, Billing.MejaID, Billing.Total, Food.Nama, Food.Harga, OrderItem.FoodID, OrderItem.Quantity, OrderItem.TotalHarga " +
                "FROM Billing LEFT JOIN OrderItem ON Billing.OrderID = OrderItem.OrderID LEFT JOIN Food ON Food.FoodID = OrderItem.FoodID  " +
                "WHERE Billing.BIllingID = '" + billingID + "'";
            SqlDataAdapter da = new SqlDataAdapter(query, conn);

            DataSet dataReport = new DataSet();
            da.Fill(dataReport, "Billing");

            //cryrpt.Load("CrystalReport1.rpt");
            //cryrpt.SetDataSource(dataReport);
            //crystalReportViewer1.ReportSource = cryrpt;

            CrystalReport1 myReport = new CrystalReport1();
            myReport.SetDataSource(dataReport);
            crystalReportViewer1.ReportSource = myReport;

        }
    }
}
