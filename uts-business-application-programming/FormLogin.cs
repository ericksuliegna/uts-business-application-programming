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
    public partial class FormLogin : Form
    {

        int kesempatan = 0;
        public static int mejaID;

        public FormLogin()
        {
            InitializeComponent();
        }

        private void btnLogin_Click(object sender, EventArgs e)
        {
            if (this.txtBoxUsername.Text.Trim() == "")
            {
                MessageBox.Show("Username belum diisi", this.Text, MessageBoxButtons.OK, MessageBoxIcon.Error);
                this.txtBoxUsername.Focus();
            }
            else if (this.txtBoxPassword.Text.Trim() == "")
            {
                MessageBox.Show("Password belum diisi", this.Text, MessageBoxButtons.OK, MessageBoxIcon.Error);
                this.txtBoxPassword.Focus();
            }
            else
            {
                string username = this.txtBoxUsername.Text.Trim();
                string password = this.txtBoxPassword.Text.Trim();
                try
                {
                    using (var conn = new Connection().CreateAndOpenConnection())
                    {
                        using (var cmd = new SqlCommand())
                        {
                            cmd.Connection = conn;
                            //if yg login akun admin
                            cmd.CommandText = @"Select * From Admin Where Username = '" + txtBoxUsername.Text.Trim() + "' AND AdminPass =  '" + txtBoxPassword.Text.Trim() + "'";
                            SqlDataAdapter da = new SqlDataAdapter(cmd);

                            DataTable dt = new DataTable(); //untuk buat virtual table
                            da.Fill(dt);
                            if (dt.Rows.Count >= 1)
                            {
                                MessageBox.Show("Login Admin Sukses", this.Text, MessageBoxButtons.OK, MessageBoxIcon.Information);
                                this.Hide();
                                new FormAdmin().Show();
                            }
                            else
                            {

                                //if yg login akun user/meja
                                cmd.CommandText = @"select * from meja where nama = '" + txtBoxUsername.Text.Trim() + "' and mejapass =  '" + txtBoxPassword.Text.Trim() + "' AND Status = 'Aktif'";
                                SqlDataAdapter da2 = new SqlDataAdapter(cmd);

                                DataTable dt2 = new DataTable(); 
                                da2.Fill(dt2);
                                if (dt2.Rows.Count >= 1)
                                {
                                    MessageBox.Show("Login User Sukses", this.Text, MessageBoxButtons.OK, MessageBoxIcon.Information);

                                    //pass data mejaID
                                    mejaID = int.Parse(dt2.Rows[0][0].ToString().Trim());

                                    this.Hide();
                                    new FormUser().Show();
                                }
                                else
                                {
                                    kesempatan++;
                                    MessageBox.Show("Invalid username or password", this.Text, MessageBoxButtons.OK, MessageBoxIcon.Error);
                                    this.txtBoxUsername.Clear();
                                    this.txtBoxPassword.Clear();
                                    this.txtBoxUsername.Focus();
                                }
                            }
                        
                    
                            
                            if(kesempatan == 3)
                            {
                                MessageBox.Show("Kesempatan login Anda sudah habis", this.Text, MessageBoxButtons.OK, MessageBoxIcon.Information);
                                this.Close();
                            }
                        }
                    }
                }catch(Exception ex)
                {
                    MessageBox.Show(ex.Message, this.Text, MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
            }
        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
