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
    public partial class FormUser : Form
    {
        BindingList<OrderItem> cartList = new BindingList<OrderItem>();
        BindingList<OrderItem> orderedList = new BindingList<OrderItem>();

        private int selectedFoodID;
        private int selectedHarga;
        private int selectedQty;

        private int orderID = 1;
        private int totalPrice;
        private int billingID = 1;

        public FormUser()
        {
            InitializeComponent();

            this.dgvMenu.AutoGenerateColumns = false;
            this.dgvMenu.DataError += new System.Windows.Forms.DataGridViewDataErrorEventHandler(this.dgvMenu_DataError);
        }

        private void LoadMenu(string query)
        {
            this.dgvMenu.Rows.Clear();
            try
            {
                using (var conn = new Connection().CreateAndOpenConnection())
                {
                    using (var cmd = new SqlCommand())
                    {
                        cmd.Connection = conn;
                        if (query == null)
                        {
                            cmd.CommandText = @"Select * From Food Where Status = 'Aktif'";
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
                                    if (!Convert.IsDBNull(reader["Gambar"]))
                                    {
                                        byte[] imgData = (byte[])reader["Gambar"];

                                        this.dgvMenu.Rows.Add(
                                            reader["FoodID"].ToString(),
                                            reader["Nama"].ToString(),
                                            reader["Harga"].ToString(),
                                            reader["Kategori"].ToString(),
                                            imgData
                                            );
                                    }
                                }
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

        private void dgvMenu_DataError(object sender, DataGridViewDataErrorEventArgs e)
        {
            e.Cancel = true;
        }


        private void FormUser_Load(object sender, EventArgs e)
        {
            try
            {
                lblMejaText.Text = FormLogin.mejaID.ToString().Trim(); //ambil mejaID dari login
                lblDate.Text = DateTime.Now.ToString("yyyy - MM - dd");
                LoadMenu(null);
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, this.Text, MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }
        private void dgvMenu_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (dgvMenu.SelectedRows.Count == 0)
            {
                return;
            }
            else
            {
                numQuantity.Enabled = true;
                selectedFoodID = int.Parse(dgvMenu.SelectedRows[0].Cells[0].Value.ToString().Trim());
                selectedHarga = int.Parse(dgvMenu.SelectedRows[0].Cells[2].Value.ToString().Trim());

            }
        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            selectedQty = int.Parse(numQuantity.Value.ToString().Trim());
            selectedHarga = selectedQty * selectedHarga;

            numQuantity.Value = numQuantity.Minimum;
            numQuantity.Enabled = false;

            if (dgvCart == null || dgvCart.Rows.Count == 0)
            {
                //utk cek orderID pesanan, jika belum ada pesanan maka cek
                checkOrderID();
            }

            dgvCart.DataSource = cartList;

            OrderItem item = new OrderItem(orderID, selectedFoodID, selectedQty, selectedHarga);
            cartList.Add(item);

            totalPrice += selectedHarga;
            txtBoxTotal.Text = totalPrice.ToString().Trim();

            //rowOrderItem += 1;
        }

        private void btnRemove_Click(object sender, EventArgs e)
        {
            DialogResult dialogResult = MessageBox.Show("Apakah Anda yakin ingin hapus?", this.Text, MessageBoxButtons.YesNo);
            if (dialogResult == DialogResult.Yes)
            {
                foreach (DataGridViewRow row in dgvCart.SelectedRows)
                {
                    totalPrice -= int.Parse(dgvCart[3, row.Index].Value.ToString().Trim());
                    dgvCart.Rows.RemoveAt(row.Index);
                }
                txtBoxTotal.Text = totalPrice.ToString().Trim();
            }
            else
            {
                return;
            }
        }

        private void checkOrderID()
        {
            try
            {
                using (var conn = new Connection().CreateAndOpenConnection())
                {
                    using (var cmd = new SqlCommand())
                    {
                        cmd.Connection = conn;
                        cmd.CommandText = @"Select OrderID From OrderItem Order By OrderID ASC";

                        using (var reader = cmd.ExecuteReader())
                        {
                            if (reader.HasRows)
                            {
                                while (reader.Read())
                                {
                                    if (!DBNull.Value.Equals(reader["OrderID"]))
                                    {
                                        //jika column orderID di database tidak null maka orderID = orderID di database + 1
                                        orderID = int.Parse(reader["OrderID"].ToString()) + 1;
                                    }
                                }
                            }
                        }
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, this.Text, MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }

        private void btnShowAll_Click(object sender, EventArgs e)
        {
            LoadMenu(null);
        }

        private void btnShowRecommended_Click(object sender, EventArgs e)
        {
            string query = @"Select * From Food Where Kategori = 'Recommended'";
            LoadMenu(query);
        }

        private void btnShowFood_Click(object sender, EventArgs e)
        {
            string query = @"Select * From Food Where Kategori = 'Food'";
            LoadMenu(query);
        }

        private void btnShowBeverages_Click(object sender, EventArgs e)
        {
            string query = @"Select * From Food Where Kategori = 'Beverages'";
            LoadMenu(query);
        }

        private void checkBillingID()
        {
            try
            {
                using (var conn = new Connection().CreateAndOpenConnection())
                {
                    using (var cmd = new SqlCommand())
                    {
                        cmd.Connection = conn;
                        cmd.CommandText = @"Select BillingID From Billing";

                        using (var reader = cmd.ExecuteReader())
                        {
                            if (reader.HasRows)
                            {
                                while (reader.Read())
                                {
                                    if (!DBNull.Value.Equals(reader["BillingID"]))
                                    {
                                        //jika column orderID di database tidak null maka orderID + 1
                                        billingID = int.Parse(reader["BillingID"].ToString()) + 1;

                                        Console.WriteLine(billingID);
                                    }
                                }
                            }
                        }
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, this.Text, MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }

        private void btnPay_Click(object sender, EventArgs e)
        {
            try
            {
                DialogResult dialogResult = MessageBox.Show("Apakah Anda yakin sudah mau bayar?", this.Text, MessageBoxButtons.YesNo);
                if (dialogResult == DialogResult.Yes)
                {
                    using (var conn = new Connection().CreateAndOpenConnection())
                    {
                        using (var cmd = new SqlCommand())
                        {
                            foreach (DataGridViewRow Datarow in dgvOrdered.Rows)
                            {
                                if (Datarow != null)
                                {
                                    addOrderItem(Datarow.Index);
                                }
                            }

                            checkBillingID();
                            cmd.Connection = conn;
                            cmd.CommandText = @"Insert Into Billing(BillingID, MejaID, OrderID, Tanggal, Total) 
                                    Values(@BillingID, @MejaID, @OrderID, @Tanggal, @Total)";
                            cmd.Parameters.Clear();
                            cmd.Parameters.AddWithValue("@BillingID", billingID);
                            cmd.Parameters.AddWithValue("@MejaID", int.Parse(lblMejaText.Text.ToString().Trim()));
                            cmd.Parameters.AddWithValue("@OrderID", orderID);
                            cmd.Parameters.AddWithValue("@Tanggal", lblDate.Text);
                            cmd.Parameters.AddWithValue("@Total", int.Parse(txtBoxTotal.Text.ToString().Trim()));
                            cmd.ExecuteNonQuery();

                            MessageBox.Show("Billing sedang diproses di Kasir", this.Text, MessageBoxButtons.OK, MessageBoxIcon.Information);
                            
                            totalPrice = 0;
                            txtBoxTotal.Clear();
                            checkOrderID();
                            dgvOrdered.Rows.Clear();
                            dgvOrdered.Refresh();
                            dgvCart.Rows.Clear();
                            dgvCart.Refresh();
                        }
                    }
                }
                else if (dialogResult == DialogResult.No)
                {
                    return;
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, this.Text, MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }

        private void addOrderItem(int row)
        {
            try
            {
                using (var conn = new Connection().CreateAndOpenConnection())
                {
                    using (var cmd = new SqlCommand())
                    {
                        cmd.Connection = conn;
                        cmd.CommandText = @"Insert Into OrderItem(OrderID, FoodID, Quantity, TotalHarga) 
                                Values(@OrderID, @FoodID, @Quantity, @TotalHarga)";
                        cmd.Parameters.Clear();
                        cmd.Parameters.AddWithValue("@OrderID", int.Parse(dgvOrdered[0, row].Value.ToString().Trim()));
                        cmd.Parameters.AddWithValue("@FoodID", int.Parse(dgvOrdered[1, row].Value.ToString().Trim()));
                        cmd.Parameters.AddWithValue("@Quantity", int.Parse(dgvOrdered[2, row].Value.ToString().Trim()));
                        cmd.Parameters.AddWithValue("@TotalHarga", int.Parse(dgvOrdered[3, row].Value.ToString().Trim()));
                        cmd.ExecuteNonQuery();
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, this.Text, MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }

        private void addOrder()
        {
            try
            {
                using (var conn = new Connection().CreateAndOpenConnection())
                {
                    using (var cmd = new SqlCommand())
                    {
                        cmd.Connection = conn;
                        cmd.CommandText = @"Insert Into [Order](OrderID, MejaID, Tanggal) 
                            Values(@OrderID, @MejaID, @Tanggal)";
                        cmd.Parameters.Clear();
                        cmd.Parameters.AddWithValue("@OrderID", orderID);
                        cmd.Parameters.AddWithValue("@MejaID", int.Parse(lblMejaText.Text.ToString().Trim()));
                        cmd.Parameters.AddWithValue("@Tanggal", lblDate.Text);
                        cmd.ExecuteNonQuery();
                        
                    }
                }
        }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, this.Text, MessageBoxButtons.OK, MessageBoxIcon.Information);
        }
    }

        private void btnOrder_Click(object sender, EventArgs e)
        {
            try
            {
                DialogResult dialogResult = MessageBox.Show(@"Pesanan anda sudah tepat?" + Environment.NewLine + "Setelah diorder orderan tidak bisa dihapus lagi.", this.Text, MessageBoxButtons.YesNo);
                if (dialogResult == DialogResult.Yes)
                {
                    if (dgvOrdered.Rows.Count == 0)
                    {
                        addOrder();
                    }

                    dgvOrdered.DataSource = orderedList;

                    foreach (OrderItem item in cartList)
                    {
                        orderedList.Add(item);
                    }
                    cartList.Clear();


                }
                else if (dialogResult == DialogResult.No)
                {
                    return;
                }

            }catch(Exception ex)
            {
                MessageBox.Show(ex.Message, this.Text, MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }

    }

}
