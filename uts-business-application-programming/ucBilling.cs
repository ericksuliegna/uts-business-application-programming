using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace uts_business_application_programming
{
    public partial class ucBilling : UserControl
    {
        BindingList<Billing> billingList = new BindingList<Billing>();
        Billing selectedBilling = new Billing();

        BindingList<OrderItem> orderList = new BindingList<OrderItem>();

        public ucBilling()
        {
            InitializeComponent();
        }

        private void LoadData(string query)
        {
            this.dgvBilling.Rows.Clear();
            try
            {
                using (var conn = new Connection().CreateAndOpenConnection())
                {
                    using (var cmd = new SqlCommand())
                    {
                        cmd.Connection = conn;
                        if (query == null)
                        {
                            cmd.CommandText = @"Select * From Billing";
                        }
                        else
                        {
                            cmd.CommandText = query;
                        }
                        using (var reader = cmd.ExecuteReader())
                        {
                            if (reader.HasRows)
                            {
                                while (reader.Read())
                                {
                                    int billingID = int.Parse(reader["BillingID"].ToString().Trim());
                                    int mejaID = int.Parse(reader["MejaID"].ToString().Trim());
                                    int orderID = int.Parse(reader["OrderID"].ToString().Trim());
                                    string tanggal = reader["Tanggal"].ToString().Trim();
                                    int total = int.Parse(reader["Total"].ToString().Trim());


                                    Billing billing = new Billing(billingID, mejaID, orderID, tanggal, total);
                                    billingList.Add(billing);
                                }
                                dgvBilling.DataSource = billingList;
                            }
                        }
                    }
                }
            }
            catch (Exception ex)
            {
                throw;
            }
        }

        private void ucBilling_Load(object sender, EventArgs e)
        {
            try
            {
                LoadData(null);
                dtPicker.Format = DateTimePickerFormat.Custom;
                dtPicker.CustomFormat = "yyyy - MM - dd";

            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, this.Text, MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }

        private void dgvBilling_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (dgvBilling.SelectedRows.Count == 0)
            {
                return;
            }
            else
            {
                int selectedBillingID = int.Parse(dgvBilling.SelectedRows[0].Cells[0].Value.ToString().Trim());
                int selectedMejaID = int.Parse(dgvBilling.SelectedRows[0].Cells[1].Value.ToString().Trim());
                int selectedOrderID = int.Parse(dgvBilling.SelectedRows[0].Cells[2].Value.ToString().Trim());
                string selectedTanggal = dgvBilling.SelectedRows[0].Cells[3].Value.ToString().Trim();
                int selectedTotal = int.Parse(dgvBilling.SelectedRows[0].Cells[4].Value.ToString().Trim());

                selectedBilling.BillingID = selectedBillingID;
                selectedBilling.MejaID = selectedMejaID;
                selectedBilling.OrderID = selectedOrderID;
                selectedBilling.Tanggal = selectedTanggal;
                selectedBilling.Total = selectedTotal;

                LoadOrder();
            }
        }

        private void LoadOrder()
        {
            this.dgvOrderItem.Rows.Clear();
            try
            {
                using (var conn = new Connection().CreateAndOpenConnection())
                {
                    using (var cmd = new SqlCommand())
                    {
                        cmd.Connection = conn;
                        cmd.CommandText = @"Select * From OrderItem Where OrderID = '" + selectedBilling.OrderID + "'";
                        using (var reader = cmd.ExecuteReader())
                        {
                            if (reader.HasRows)
                            {
                                while (reader.Read())
                                {
                                    int orderID = int.Parse(reader["OrderID"].ToString().Trim());
                                    int foodID = int.Parse(reader["FoodID"].ToString().Trim());
                                    int quantity = int.Parse(reader["Quantity"].ToString().Trim());
                                    int harga = int.Parse(reader["TotalHarga"].ToString().Trim());


                                    OrderItem orderItem = new OrderItem(orderID, foodID, quantity, harga);
                                    orderList.Add(orderItem);
                                }
                                dgvOrderItem.DataSource = orderList;
                            }
                        }
                    }
                }
            }
            catch (Exception ex)
            {
                throw;
            }
        }

        private void btnCetak_Click(object sender, EventArgs e)
        {
            Report.billingID = selectedBilling.BillingID;
            new Report().Show();
        }

        private void btnSearch_Click(object sender, EventArgs e)
        {
            LoadData(@"Select * From Billing Where Tanggal = '" + dtPicker.Value.ToString().Trim() + "'");
        }

        private void btnShow_Click(object sender, EventArgs e)
        {
            LoadData(null);
        }
    }
}
