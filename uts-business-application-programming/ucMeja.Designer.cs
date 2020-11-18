
namespace uts_business_application_programming
{
    partial class ucMeja
    {
        /// <summary> 
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary> 
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Component Designer generated code

        /// <summary> 
        /// Required method for Designer support - do not modify 
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.pnlMeja = new System.Windows.Forms.Panel();
            this.dgvMeja = new System.Windows.Forms.DataGridView();
            this.MejaID = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.NamaMeja = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Password = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Status = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.lblMeja = new System.Windows.Forms.Label();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.btnStatusMeja = new System.Windows.Forms.Button();
            this.btnUpdMeja = new System.Windows.Forms.Button();
            this.btnAddMeja = new System.Windows.Forms.Button();
            this.txtBoxMejaPass = new System.Windows.Forms.TextBox();
            this.txtBoxMejaNama = new System.Windows.Forms.TextBox();
            this.txtBoxMejaID = new System.Windows.Forms.TextBox();
            this.lblMejaPass = new System.Windows.Forms.Label();
            this.lblMejaNama = new System.Windows.Forms.Label();
            this.lblMejaID = new System.Windows.Forms.Label();
            this.btnShowAll = new System.Windows.Forms.Button();
            this.btnShowActive = new System.Windows.Forms.Button();
            this.btnShowNonActive = new System.Windows.Forms.Button();
            this.pnlMeja.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvMeja)).BeginInit();
            this.groupBox2.SuspendLayout();
            this.SuspendLayout();
            // 
            // pnlMeja
            // 
            this.pnlMeja.Controls.Add(this.btnShowNonActive);
            this.pnlMeja.Controls.Add(this.btnShowActive);
            this.pnlMeja.Controls.Add(this.btnShowAll);
            this.pnlMeja.Controls.Add(this.dgvMeja);
            this.pnlMeja.Controls.Add(this.lblMeja);
            this.pnlMeja.Controls.Add(this.groupBox2);
            this.pnlMeja.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pnlMeja.Location = new System.Drawing.Point(0, 0);
            this.pnlMeja.Name = "pnlMeja";
            this.pnlMeja.Size = new System.Drawing.Size(829, 709);
            this.pnlMeja.TabIndex = 20;
            // 
            // dgvMeja
            // 
            this.dgvMeja.AllowUserToAddRows = false;
            this.dgvMeja.AllowUserToDeleteRows = false;
            this.dgvMeja.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgvMeja.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvMeja.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.MejaID,
            this.NamaMeja,
            this.Password,
            this.Status});
            this.dgvMeja.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.dgvMeja.Location = new System.Drawing.Point(0, 378);
            this.dgvMeja.Name = "dgvMeja";
            this.dgvMeja.ReadOnly = true;
            this.dgvMeja.RowHeadersWidth = 51;
            this.dgvMeja.RowTemplate.Height = 26;
            this.dgvMeja.Size = new System.Drawing.Size(829, 331);
            this.dgvMeja.TabIndex = 18;
            this.dgvMeja.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvMeja_CellClick);
            // 
            // MejaID
            // 
            this.MejaID.HeaderText = "Meja ID";
            this.MejaID.MinimumWidth = 6;
            this.MejaID.Name = "MejaID";
            this.MejaID.ReadOnly = true;
            // 
            // NamaMeja
            // 
            this.NamaMeja.HeaderText = "Nama";
            this.NamaMeja.MinimumWidth = 6;
            this.NamaMeja.Name = "NamaMeja";
            this.NamaMeja.ReadOnly = true;
            // 
            // Password
            // 
            this.Password.HeaderText = "Password";
            this.Password.MinimumWidth = 6;
            this.Password.Name = "Password";
            this.Password.ReadOnly = true;
            // 
            // Status
            // 
            this.Status.HeaderText = "Status";
            this.Status.MinimumWidth = 6;
            this.Status.Name = "Status";
            this.Status.ReadOnly = true;
            // 
            // lblMeja
            // 
            this.lblMeja.AutoSize = true;
            this.lblMeja.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblMeja.Location = new System.Drawing.Point(20, 20);
            this.lblMeja.Name = "lblMeja";
            this.lblMeja.Size = new System.Drawing.Size(175, 25);
            this.lblMeja.TabIndex = 2;
            this.lblMeja.Text = "Meja Management";
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.btnStatusMeja);
            this.groupBox2.Controls.Add(this.btnUpdMeja);
            this.groupBox2.Controls.Add(this.btnAddMeja);
            this.groupBox2.Controls.Add(this.txtBoxMejaPass);
            this.groupBox2.Controls.Add(this.txtBoxMejaNama);
            this.groupBox2.Controls.Add(this.txtBoxMejaID);
            this.groupBox2.Controls.Add(this.lblMejaPass);
            this.groupBox2.Controls.Add(this.lblMejaNama);
            this.groupBox2.Controls.Add(this.lblMejaID);
            this.groupBox2.Location = new System.Drawing.Point(25, 57);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(740, 253);
            this.groupBox2.TabIndex = 1;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Meja Data";
            // 
            // btnStatusMeja
            // 
            this.btnStatusMeja.Enabled = false;
            this.btnStatusMeja.Location = new System.Drawing.Point(310, 186);
            this.btnStatusMeja.Name = "btnStatusMeja";
            this.btnStatusMeja.Size = new System.Drawing.Size(80, 44);
            this.btnStatusMeja.TabIndex = 12;
            this.btnStatusMeja.Text = "Change Status";
            this.btnStatusMeja.UseVisualStyleBackColor = true;
            this.btnStatusMeja.Click += new System.EventHandler(this.btnStatusMeja_Click);
            // 
            // btnUpdMeja
            // 
            this.btnUpdMeja.Enabled = false;
            this.btnUpdMeja.Location = new System.Drawing.Point(214, 186);
            this.btnUpdMeja.Name = "btnUpdMeja";
            this.btnUpdMeja.Size = new System.Drawing.Size(80, 44);
            this.btnUpdMeja.TabIndex = 11;
            this.btnUpdMeja.Text = "Update";
            this.btnUpdMeja.UseVisualStyleBackColor = true;
            this.btnUpdMeja.Click += new System.EventHandler(this.btnUpdMeja_Click);
            // 
            // btnAddMeja
            // 
            this.btnAddMeja.Location = new System.Drawing.Point(119, 186);
            this.btnAddMeja.Name = "btnAddMeja";
            this.btnAddMeja.Size = new System.Drawing.Size(80, 44);
            this.btnAddMeja.TabIndex = 10;
            this.btnAddMeja.Text = "Add";
            this.btnAddMeja.UseVisualStyleBackColor = true;
            this.btnAddMeja.Click += new System.EventHandler(this.btnAddMeja_Click);
            // 
            // txtBoxMejaPass
            // 
            this.txtBoxMejaPass.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtBoxMejaPass.Location = new System.Drawing.Point(119, 139);
            this.txtBoxMejaPass.Multiline = true;
            this.txtBoxMejaPass.Name = "txtBoxMejaPass";
            this.txtBoxMejaPass.PasswordChar = '*';
            this.txtBoxMejaPass.Size = new System.Drawing.Size(271, 28);
            this.txtBoxMejaPass.TabIndex = 7;
            // 
            // txtBoxMejaNama
            // 
            this.txtBoxMejaNama.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtBoxMejaNama.Location = new System.Drawing.Point(119, 92);
            this.txtBoxMejaNama.Multiline = true;
            this.txtBoxMejaNama.Name = "txtBoxMejaNama";
            this.txtBoxMejaNama.Size = new System.Drawing.Size(271, 28);
            this.txtBoxMejaNama.TabIndex = 6;
            // 
            // txtBoxMejaID
            // 
            this.txtBoxMejaID.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtBoxMejaID.Location = new System.Drawing.Point(119, 44);
            this.txtBoxMejaID.Multiline = true;
            this.txtBoxMejaID.Name = "txtBoxMejaID";
            this.txtBoxMejaID.Size = new System.Drawing.Size(271, 28);
            this.txtBoxMejaID.TabIndex = 5;
            // 
            // lblMejaPass
            // 
            this.lblMejaPass.Location = new System.Drawing.Point(20, 139);
            this.lblMejaPass.Name = "lblMejaPass";
            this.lblMejaPass.Size = new System.Drawing.Size(79, 17);
            this.lblMejaPass.TabIndex = 2;
            this.lblMejaPass.Text = "Password";
            // 
            // lblMejaNama
            // 
            this.lblMejaNama.Location = new System.Drawing.Point(20, 92);
            this.lblMejaNama.Name = "lblMejaNama";
            this.lblMejaNama.Size = new System.Drawing.Size(79, 17);
            this.lblMejaNama.TabIndex = 1;
            this.lblMejaNama.Text = "Nama";
            // 
            // lblMejaID
            // 
            this.lblMejaID.Location = new System.Drawing.Point(20, 44);
            this.lblMejaID.Name = "lblMejaID";
            this.lblMejaID.Size = new System.Drawing.Size(79, 17);
            this.lblMejaID.TabIndex = 0;
            this.lblMejaID.Text = "MejaID";
            // 
            // btnShowAll
            // 
            this.btnShowAll.Location = new System.Drawing.Point(144, 316);
            this.btnShowAll.Name = "btnShowAll";
            this.btnShowAll.Size = new System.Drawing.Size(80, 44);
            this.btnShowAll.TabIndex = 13;
            this.btnShowAll.Text = "Show All";
            this.btnShowAll.UseVisualStyleBackColor = true;
            this.btnShowAll.Click += new System.EventHandler(this.btnShowAll_Click);
            // 
            // btnShowActive
            // 
            this.btnShowActive.Location = new System.Drawing.Point(239, 316);
            this.btnShowActive.Name = "btnShowActive";
            this.btnShowActive.Size = new System.Drawing.Size(80, 44);
            this.btnShowActive.TabIndex = 19;
            this.btnShowActive.Text = "Show Active";
            this.btnShowActive.UseVisualStyleBackColor = true;
            this.btnShowActive.Click += new System.EventHandler(this.btnShowActive_Click);
            // 
            // btnShowNonActive
            // 
            this.btnShowNonActive.Location = new System.Drawing.Point(335, 316);
            this.btnShowNonActive.Name = "btnShowNonActive";
            this.btnShowNonActive.Size = new System.Drawing.Size(80, 44);
            this.btnShowNonActive.TabIndex = 20;
            this.btnShowNonActive.Text = "Show Non Active";
            this.btnShowNonActive.UseVisualStyleBackColor = true;
            this.btnShowNonActive.Click += new System.EventHandler(this.btnShowNonActive_Click);
            // 
            // ucMeja
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.pnlMeja);
            this.Name = "ucMeja";
            this.Size = new System.Drawing.Size(829, 709);
            this.Load += new System.EventHandler(this.ucMeja_Load);
            this.pnlMeja.ResumeLayout(false);
            this.pnlMeja.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvMeja)).EndInit();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel pnlMeja;
        private System.Windows.Forms.DataGridView dgvMeja;
        private System.Windows.Forms.Label lblMeja;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.Button btnStatusMeja;
        private System.Windows.Forms.Button btnUpdMeja;
        private System.Windows.Forms.Button btnAddMeja;
        private System.Windows.Forms.TextBox txtBoxMejaPass;
        private System.Windows.Forms.TextBox txtBoxMejaNama;
        private System.Windows.Forms.TextBox txtBoxMejaID;
        private System.Windows.Forms.Label lblMejaPass;
        private System.Windows.Forms.Label lblMejaNama;
        private System.Windows.Forms.Label lblMejaID;
        private System.Windows.Forms.DataGridViewTextBoxColumn MejaID;
        private System.Windows.Forms.DataGridViewTextBoxColumn NamaMeja;
        private System.Windows.Forms.DataGridViewTextBoxColumn Password;
        private System.Windows.Forms.DataGridViewTextBoxColumn Status;
        private System.Windows.Forms.Button btnShowNonActive;
        private System.Windows.Forms.Button btnShowActive;
        private System.Windows.Forms.Button btnShowAll;
    }
}
