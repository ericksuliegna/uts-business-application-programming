using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Drawing.Imaging;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace uts_business_application_programming
{
    public partial class FormAdmin : Form
    {

        public FormAdmin()
        {
            InitializeComponent();
            this.dgvFood.AutoGenerateColumns = false;
            this.dgvFood.DataError += new System.Windows.Forms.DataGridViewDataErrorEventHandler(this.dgvFood_DataError);
            pnlBilling.Hide();
            pnlMeja.Hide();
        }

        private void LoadData(string query)
        {
            this.dgvFood.Rows.Clear();
            try
            {
                using(var conn = new Connection().CreateAndOpenConnection())
                {
                    using(var cmd = new SqlCommand())
                    {
                        cmd.Connection = conn;
                        if(query == null)
                        {
                            cmd.CommandText = @"Select * From Food";
                        }
                        else
                        {
                            cmd.CommandText = query;
                        }
                        
                        using(var reader = cmd.ExecuteReader())
                        {
                            if (reader.HasRows)
                            {
                                while (reader.Read())
                                {
                                    if (!Convert.IsDBNull(reader["Gambar"]))
                                    {
                                        byte[] imgData = (byte[])reader["Gambar"];

                                        this.dgvFood.Rows.Add(
                                            reader["FoodID"].ToString(),
                                            reader["Nama"].ToString(),
                                            reader["Harga"].ToString(),
                                            reader["Kategori"].ToString(),
                                            imgData,
                                            reader["Status"].ToString()
                                            );
                                    }
                                }
                            }
                        }
                    }
                }
            }catch(Exception ex)
            {
                throw;
            }
        }

        private void dgvFood_DataError(object sender, DataGridViewDataErrorEventArgs e)
        {
            e.Cancel = true;
        }

        private void FormAdmin_Load(object sender, EventArgs e)
        {
            try
            {
                LoadData(null);
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, this.Text, MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }
      
        private void btnAdd_Click(object sender, EventArgs e)
        {
            if(this.txtBoxFoodID.Text.Trim() == "")
            {
                MessageBox.Show("Maaf, FoodID belum diisi.", this.Text, MessageBoxButtons.OK, MessageBoxIcon.Error);
                this.txtBoxFoodID.Focus();
            }
            else if (this.txtBoxNama.Text.Trim() == "")
            {
                MessageBox.Show("Maaf, Nama belum diisi.", this.Text, MessageBoxButtons.OK, MessageBoxIcon.Error);
                this.txtBoxNama.Focus();
            }
            else if (this.txtBoxHarga.Text.Trim() == "")
            {
                MessageBox.Show("Maaf, Harga belum diisi.", this.Text, MessageBoxButtons.OK, MessageBoxIcon.Error);
                this.txtBoxHarga.Focus();
            }
            else if (this.cmbBoxKategori.SelectedItem == null)
            {
                MessageBox.Show("Maaf, Kategori belum diisi.", this.Text, MessageBoxButtons.OK, MessageBoxIcon.Error);
                this.cmbBoxKategori.Focus();
            }
            else if (this.picBoxGambar.Image == null)
            {
                MessageBox.Show("Maaf, Gambar belum diisi.", this.Text, MessageBoxButtons.OK, MessageBoxIcon.Error);
                this.btnBrowse.Focus();
            }
            else
            {
                try
                {
                    using(var conn = new Connection().CreateAndOpenConnection())
                    {
                        using(var cmd = new SqlCommand())
                        {
                            MemoryStream stream = new MemoryStream();
                            picBoxGambar.Image.Save(stream, ImageFormat.Jpeg);

                            byte[] pic = stream.ToArray();

                            cmd.Connection = conn;
                            cmd.CommandText = @"Insert Into Food(FoodID, Nama, Harga, Kategori, Gambar, Status) 
                                Values(@FoodID, @Nama, @Harga, @Kategori, @Gambar, @Status)";
                            cmd.Parameters.Clear();
                            cmd.Parameters.AddWithValue("@FoodID", this.txtBoxFoodID.Text.Trim());
                            cmd.Parameters.AddWithValue("@Nama", this.txtBoxNama.Text.Trim());
                            cmd.Parameters.AddWithValue("@Harga", this.txtBoxHarga.Text.Trim());
                            cmd.Parameters.AddWithValue("@Kategori", this.cmbBoxKategori.SelectedItem.ToString().Trim());
                            cmd.Parameters.AddWithValue("@Gambar", pic);
                            cmd.Parameters.AddWithValue("@Status", "Aktif");
                            int recAffected = cmd.ExecuteNonQuery();
                            if (recAffected > 0)
                            {
                                LoadData(null);
                            }
                            clearInput();
                        }
                    }
                }
                catch(Exception ex)
                {
                    MessageBox.Show(ex.Message, this.Text, MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
            }

        }

        private void btnBrowse_Click(object sender, EventArgs e)
        {
            using(var OpenFileDialog = new OpenFileDialog())
            {
                OpenFileDialog.Title = "Choose Image";
                OpenFileDialog.Filter = "Image files | *.jpg";
                OpenFileDialog.CheckPathExists = true;
                OpenFileDialog.CheckFileExists = true;
                OpenFileDialog.Multiselect = false;
                OpenFileDialog.FileName = "";
                if(OpenFileDialog.ShowDialog() == DialogResult.OK)
                {
                    this.picBoxGambar.Load(OpenFileDialog.FileName);
                    this.picBoxGambar.Tag = OpenFileDialog.FileName;
                }
            }
        }

        private void clearInput()
        {
            this.txtBoxFoodID.Clear();
            this.txtBoxNama.Clear();
            this.txtBoxHarga.Clear();
            this.cmbBoxKategori.SelectedIndex = -1;
            this.picBoxGambar.Image = null;
        }

        private void dgvFood_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (dgvFood.SelectedRows.Count == 0)
            {
                return;
            }
            else
            {
                this.txtBoxFoodID.Text = dgvFood.SelectedRows[0].Cells[0].Value.ToString();
                this.txtBoxNama.Text = dgvFood.SelectedRows[0].Cells[1].Value.ToString();
                this.txtBoxHarga.Text = dgvFood.SelectedRows[0].Cells[2].Value.ToString();
                this.cmbBoxKategori.SelectedIndex = this.cmbBoxKategori.FindString(this.dgvFood.SelectedRows[0].Cells[3].Value.ToString());
                Byte[] data = new Byte[0];
                data = (Byte[])dgvFood.SelectedRows[0].Cells[4].Value;
                MemoryStream ms = new MemoryStream(data);
                picBoxGambar.Image = Image.FromStream(ms);

                btnUpdate.Enabled = true;
                btnStatus.Enabled = true;

            }
        }

        private void btnStatus_Click(object sender, EventArgs e)
        {
            if (dgvFood.SelectedRows.Count == 0)
            {
                return;
            }
            else
            {
                int selected = dgvFood.SelectedRows[0].Index;
                int rowID = int.Parse(dgvFood[0, selected].Value.ToString().Trim());
                string sql = "";
                string currentStatus = dgvFood[5, selected].Value.ToString().Trim();
                string msg = "";

                if (currentStatus == "Aktif")
                {
                    sql = "UPDATE FOOD SET Status = 'Non Aktif' Where FOODID = @rowID";
                    msg = "Record is set to Non Aktif";
                }
                else if (currentStatus == "Non Aktif")
                {
                    sql = "UPDATE FOOD SET Status = 'Aktif' Where FOODID = @rowID";
                    msg = "Record is set to Aktif";
                }

                SqlCommand status = new SqlCommand();
                status.Connection = new Connection().CreateAndOpenConnection();
                status.CommandText = sql;

                SqlParameter rowParameter = new SqlParameter();
                rowParameter.ParameterName = "@rowID";
                rowParameter.SqlDbType = SqlDbType.Int;
                rowParameter.IsNullable = false;
                rowParameter.Value = rowID;

                status.Parameters.Add(rowParameter);
                status.ExecuteNonQuery();
                status.Connection.Close();
                MessageBox.Show(msg);

                LoadData(null);
                clearInput();
                btnUpdate.Enabled = false;
                btnStatus.Enabled = false;

            }
        }

        private void btnUpdate_Click(object sender, EventArgs e)
        {
            if (dgvFood.SelectedRows.Count == 0)
            {
                return;
            }
            else
            {
                MemoryStream stream = new MemoryStream();
                picBoxGambar.Image.Save(stream, ImageFormat.Jpeg);

                byte[] pic = stream.ToArray();

                string sql = "UPDATE FOOD SET Nama = @Nama, Harga = @Harga, Kategori = @Kategori, Gambar = @Gambar WHERE FoodID = @FoodID";

                SqlCommand update = new SqlCommand();
                update.Connection = new Connection().CreateAndOpenConnection();
                update.CommandText = sql;

                update.Parameters.Clear();
                update.Parameters.AddWithValue("@FoodID", this.txtBoxFoodID.Text.Trim());
                update.Parameters.AddWithValue("@Nama", this.txtBoxNama.Text.Trim());
                update.Parameters.AddWithValue("@Harga", this.txtBoxHarga.Text.Trim());
                update.Parameters.AddWithValue("@Kategori", this.cmbBoxKategori.SelectedItem.ToString().Trim());
                update.Parameters.AddWithValue("@Gambar", pic);

                update.ExecuteNonQuery();
                update.Connection.Close();
                MessageBox.Show("Record Updated Successfully");

                LoadData(null);
                clearInput();
                btnUpdate.Enabled = false;
                btnStatus.Enabled = false;
            }
        }

        private void btnShowAll_Click(object sender, EventArgs e)
        {
            LoadData(null);
        }

        private void btnShowRecommended_Click(object sender, EventArgs e)
        {
            string query = @"Select * From Food Where Kategori = 'Recommended'";
            LoadData(query);
        }

        private void btnShowFood_Click(object sender, EventArgs e)
        {
            string query = @"Select * From Food Where Kategori = 'Food'";
            LoadData(query);
        }

        private void btnShowBeverages_Click(object sender, EventArgs e)
        {
            string query = @"Select * From Food Where Kategori = 'Beverages'";
            LoadData(query);
        }

        private void btnShowActive_Click(object sender, EventArgs e)
        {
            string query = @"Select * From Food Where Status = 'Aktif'";
            LoadData(query);
        }

        private void btnShowNonActive_Click(object sender, EventArgs e)
        {
            string query = @"Select * From Food Where Status = 'Non Aktif'";
            LoadData(query);
        }

        private void tsMeja_Click(object sender, EventArgs e)
        {
            pnlFood.Hide();
            pnlBilling.Hide();

            pnlMeja.Show();
            pnlMeja.BringToFront();
        }

        private void tsFood_Click(object sender, EventArgs e)
        {
            pnlMeja.Hide();
            pnlBilling.Hide();

            pnlFood.Show();
            pnlFood.BringToFront();
        }

        private void tsBilling_Click(object sender, EventArgs e)
        {
            pnlFood.Hide();
            pnlMeja.Hide();

            pnlBilling.Show();
            pnlBilling.BringToFront();
        }

    }
}
