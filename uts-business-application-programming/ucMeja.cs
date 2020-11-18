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
    public partial class ucMeja : UserControl
    {
        public ucMeja()
        {
            InitializeComponent();
            this.dgvMeja.AutoGenerateColumns = false;
        }

        private void LoadData(string query)
        {
            this.dgvMeja.Rows.Clear();
            try
            {
                using (var conn = new Connection().CreateAndOpenConnection())
                {
                    using (var cmd = new SqlCommand())
                    {
                        cmd.Connection = conn;
                        if (query == null)
                        {
                            cmd.CommandText = @"Select * From Meja";
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
                                    this.dgvMeja.Rows.Add(
                                    reader["MejaID"].ToString(),
                                    reader["Nama"].ToString(),
                                    reader["MejaPass"].ToString(),
                                    reader["Status"].ToString()
                                    );
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


        private void ucMeja_Load(object sender, EventArgs e)
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

        private void btnAddMeja_Click(object sender, EventArgs e)
        {
            if (this.txtBoxMejaID.Text.Trim() == "")
            {
                MessageBox.Show("Maaf, MejaID belum diisi.", this.Text, MessageBoxButtons.OK, MessageBoxIcon.Error);
                this.txtBoxMejaID.Focus();
            }
            else if (this.txtBoxMejaNama.Text.Trim() == "")
            {
                MessageBox.Show("Maaf, Nama belum diisi.", this.Text, MessageBoxButtons.OK, MessageBoxIcon.Error);
                this.txtBoxMejaNama.Focus();
            }
            else if (this.txtBoxMejaPass.Text.Trim() == "")
            {
                MessageBox.Show("Maaf, Password belum diisi.", this.Text, MessageBoxButtons.OK, MessageBoxIcon.Error);
                this.txtBoxMejaPass.Focus();
            }
            else
            {
                try
                {
                    using (var conn = new Connection().CreateAndOpenConnection())
                    {
                        using (var cmd = new SqlCommand())
                        {
                            cmd.Connection = conn;
                            cmd.CommandText = @"Insert Into Meja(MejaID, Nama, MejaPass, Status) 
                                Values(@MejaID, @Nama, @Password, @Status)";
                            cmd.Parameters.Clear();
                            cmd.Parameters.AddWithValue("@MejaID", this.txtBoxMejaID.Text.Trim());
                            cmd.Parameters.AddWithValue("@Nama", this.txtBoxMejaNama.Text.Trim());
                            cmd.Parameters.AddWithValue("@Password", this.txtBoxMejaPass.Text.Trim());
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
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message, this.Text, MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
            }
        }
        private void clearInput()
        {
            this.txtBoxMejaID.Clear();
            this.txtBoxMejaNama.Clear();
            this.txtBoxMejaPass.Clear();
        }

        private void dgvMeja_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (dgvMeja.SelectedRows.Count == 0)
            {
                return;
            }
            else
            {
                this.txtBoxMejaID.Text = dgvMeja.SelectedRows[0].Cells[0].Value.ToString();
                this.txtBoxMejaNama.Text = dgvMeja.SelectedRows[0].Cells[1].Value.ToString();
                this.txtBoxMejaPass.Text = dgvMeja.SelectedRows[0].Cells[2].Value.ToString();

                btnUpdMeja.Enabled = true;
                btnStatusMeja.Enabled = true;
            }
        }

        private void btnStatusMeja_Click(object sender, EventArgs e)
        {
            if (dgvMeja.SelectedRows.Count == 0)
            {
                return;
            }
            else
            {
                int selected = dgvMeja.SelectedRows[0].Index;
                int rowID = int.Parse(dgvMeja[0, selected].Value.ToString().Trim());
                // string sql = "DELETE FROM MEJA WHERE MejaID = @rowID";

                string msg = "";
                string sql = "";
                string currentStatus = dgvMeja[3, selected].Value.ToString().Trim();
                if (currentStatus == "Aktif")
                {
                    sql = "UPDATE Meja SET Status = 'Non Aktif' Where MejaID = @rowID";
                    msg = "Record is set to Non Aktif";
                }
                else if (currentStatus == "Non Aktif")
                {
                    sql = "UPDATE Meja SET Status = 'Aktif' Where MejaID = @rowID";
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
                btnUpdMeja.Enabled = false;
                btnStatusMeja.Enabled = false;

               
            }
        }

        private void btnUpdMeja_Click(object sender, EventArgs e)
        {
            if (dgvMeja.SelectedRows.Count == 0)
            {
                return;
            }
            else
            {
                string sql = "UPDATE MEJA SET Nama = @Nama, MejaPass = @Password WHERE MejaID = @MejaID";

                SqlCommand update = new SqlCommand();
                update.Connection = new Connection().CreateAndOpenConnection();
                update.CommandText = sql;

                update.Parameters.Clear();
                update.Parameters.AddWithValue("@MejaID", this.txtBoxMejaID.Text.Trim());
                update.Parameters.AddWithValue("@Nama", this.txtBoxMejaNama.Text.Trim());
                update.Parameters.AddWithValue("@Password", this.txtBoxMejaPass.Text.Trim());

                update.ExecuteNonQuery();
                update.Connection.Close();
                MessageBox.Show("Record Updated Successfully");

                LoadData(null);
                clearInput();
                btnUpdMeja.Enabled = false;
                btnStatusMeja.Enabled = false;
            }
        }

        private void btnShowActive_Click(object sender, EventArgs e)
        {
            string query = @"Select * From Meja Where Status = 'Aktif'";
            LoadData(query);
        }
             
        private void btnShowNonActive_Click(object sender, EventArgs e)
        {
            string query = @"Select * From Meja Where Status = 'Non Aktif'";
            LoadData(query);
        }

        private void btnShowAll_Click(object sender, EventArgs e)
        {
            LoadData(null);
        }
    }
}
