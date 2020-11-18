
namespace uts_business_application_programming
{
    partial class FormAdmin
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

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.tsFood = new System.Windows.Forms.ToolStripMenuItem();
            this.tsBilling = new System.Windows.Forms.ToolStripMenuItem();
            this.tsMeja = new System.Windows.Forms.ToolStripMenuItem();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.btnBrowse = new System.Windows.Forms.Button();
            this.btnStatus = new System.Windows.Forms.Button();
            this.btnUpdate = new System.Windows.Forms.Button();
            this.btnAdd = new System.Windows.Forms.Button();
            this.picBoxGambar = new System.Windows.Forms.PictureBox();
            this.cmbBoxKategori = new System.Windows.Forms.ComboBox();
            this.txtBoxHarga = new System.Windows.Forms.TextBox();
            this.txtBoxNama = new System.Windows.Forms.TextBox();
            this.txtBoxFoodID = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.btnShowRecommended = new System.Windows.Forms.Button();
            this.btnShowFood = new System.Windows.Forms.Button();
            this.btnShowBeverages = new System.Windows.Forms.Button();
            this.btnShowAll = new System.Windows.Forms.Button();
            this.dgvFood = new System.Windows.Forms.DataGridView();
            this.FoodID = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Nama = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Harga = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Kategori = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Gambar = new System.Windows.Forms.DataGridViewImageColumn();
            this.Status = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.pnlFood = new System.Windows.Forms.Panel();
            this.btnShowNonActive = new System.Windows.Forms.Button();
            this.btnShowActive = new System.Windows.Forms.Button();
            this.pnlBilling = new System.Windows.Forms.Panel();
            this.pnlMeja = new System.Windows.Forms.Panel();
            this.ucMeja1 = new uts_business_application_programming.ucMeja();
            this.ucBilling1 = new uts_business_application_programming.ucBilling();
            this.menuStrip1.SuspendLayout();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.picBoxGambar)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvFood)).BeginInit();
            this.pnlFood.SuspendLayout();
            this.pnlBilling.SuspendLayout();
            this.pnlMeja.SuspendLayout();
            this.SuspendLayout();
            // 
            // menuStrip1
            // 
            this.menuStrip1.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.menuStrip1.Dock = System.Windows.Forms.DockStyle.Left;
            this.menuStrip1.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.tsFood,
            this.tsBilling,
            this.tsMeja});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(156, 709);
            this.menuStrip1.TabIndex = 2;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // tsFood
            // 
            this.tsFood.AutoSize = false;
            this.tsFood.Name = "tsFood";
            this.tsFood.Size = new System.Drawing.Size(119, 40);
            this.tsFood.Text = "Food";
            this.tsFood.Click += new System.EventHandler(this.tsFood_Click);
            // 
            // tsBilling
            // 
            this.tsBilling.AutoSize = false;
            this.tsBilling.Name = "tsBilling";
            this.tsBilling.Size = new System.Drawing.Size(119, 40);
            this.tsBilling.Text = "Billing";
            this.tsBilling.Click += new System.EventHandler(this.tsBilling_Click);
            // 
            // tsMeja
            // 
            this.tsMeja.AutoSize = false;
            this.tsMeja.Name = "tsMeja";
            this.tsMeja.Size = new System.Drawing.Size(119, 40);
            this.tsMeja.Text = "Meja";
            this.tsMeja.Click += new System.EventHandler(this.tsMeja_Click);
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.btnBrowse);
            this.groupBox1.Controls.Add(this.btnStatus);
            this.groupBox1.Controls.Add(this.btnUpdate);
            this.groupBox1.Controls.Add(this.btnAdd);
            this.groupBox1.Controls.Add(this.picBoxGambar);
            this.groupBox1.Controls.Add(this.cmbBoxKategori);
            this.groupBox1.Controls.Add(this.txtBoxHarga);
            this.groupBox1.Controls.Add(this.txtBoxNama);
            this.groupBox1.Controls.Add(this.txtBoxFoodID);
            this.groupBox1.Controls.Add(this.label5);
            this.groupBox1.Controls.Add(this.label4);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Location = new System.Drawing.Point(25, 57);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(740, 253);
            this.groupBox1.TabIndex = 1;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Food Data";
            // 
            // btnBrowse
            // 
            this.btnBrowse.Location = new System.Drawing.Point(533, 190);
            this.btnBrowse.Name = "btnBrowse";
            this.btnBrowse.Size = new System.Drawing.Size(80, 49);
            this.btnBrowse.TabIndex = 13;
            this.btnBrowse.Text = "Browse";
            this.btnBrowse.UseVisualStyleBackColor = true;
            this.btnBrowse.Click += new System.EventHandler(this.btnBrowse_Click);
            // 
            // btnStatus
            // 
            this.btnStatus.Enabled = false;
            this.btnStatus.Location = new System.Drawing.Point(310, 190);
            this.btnStatus.Name = "btnStatus";
            this.btnStatus.Size = new System.Drawing.Size(80, 49);
            this.btnStatus.TabIndex = 12;
            this.btnStatus.Text = "Change Status";
            this.btnStatus.UseVisualStyleBackColor = true;
            this.btnStatus.Click += new System.EventHandler(this.btnStatus_Click);
            // 
            // btnUpdate
            // 
            this.btnUpdate.Enabled = false;
            this.btnUpdate.Location = new System.Drawing.Point(215, 190);
            this.btnUpdate.Name = "btnUpdate";
            this.btnUpdate.Size = new System.Drawing.Size(80, 49);
            this.btnUpdate.TabIndex = 11;
            this.btnUpdate.Text = "Update";
            this.btnUpdate.UseVisualStyleBackColor = true;
            this.btnUpdate.Click += new System.EventHandler(this.btnUpdate_Click);
            // 
            // btnAdd
            // 
            this.btnAdd.Location = new System.Drawing.Point(119, 190);
            this.btnAdd.Name = "btnAdd";
            this.btnAdd.Size = new System.Drawing.Size(80, 49);
            this.btnAdd.TabIndex = 10;
            this.btnAdd.Text = "Add";
            this.btnAdd.UseVisualStyleBackColor = true;
            this.btnAdd.Click += new System.EventHandler(this.btnAdd_Click);
            // 
            // picBoxGambar
            // 
            this.picBoxGambar.Location = new System.Drawing.Point(533, 44);
            this.picBoxGambar.Name = "picBoxGambar";
            this.picBoxGambar.Size = new System.Drawing.Size(156, 130);
            this.picBoxGambar.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.picBoxGambar.TabIndex = 9;
            this.picBoxGambar.TabStop = false;
            // 
            // cmbBoxKategori
            // 
            this.cmbBoxKategori.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cmbBoxKategori.FormattingEnabled = true;
            this.cmbBoxKategori.Items.AddRange(new object[] {
            "Recommended",
            "Food",
            "Beverages"});
            this.cmbBoxKategori.Location = new System.Drawing.Point(119, 146);
            this.cmbBoxKategori.Name = "cmbBoxKategori";
            this.cmbBoxKategori.Size = new System.Drawing.Size(271, 28);
            this.cmbBoxKategori.TabIndex = 8;
            // 
            // txtBoxHarga
            // 
            this.txtBoxHarga.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtBoxHarga.Location = new System.Drawing.Point(119, 112);
            this.txtBoxHarga.Multiline = true;
            this.txtBoxHarga.Name = "txtBoxHarga";
            this.txtBoxHarga.Size = new System.Drawing.Size(271, 28);
            this.txtBoxHarga.TabIndex = 7;
            // 
            // txtBoxNama
            // 
            this.txtBoxNama.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtBoxNama.Location = new System.Drawing.Point(119, 78);
            this.txtBoxNama.Multiline = true;
            this.txtBoxNama.Name = "txtBoxNama";
            this.txtBoxNama.Size = new System.Drawing.Size(271, 28);
            this.txtBoxNama.TabIndex = 6;
            // 
            // txtBoxFoodID
            // 
            this.txtBoxFoodID.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtBoxFoodID.Location = new System.Drawing.Point(119, 44);
            this.txtBoxFoodID.Multiline = true;
            this.txtBoxFoodID.Name = "txtBoxFoodID";
            this.txtBoxFoodID.Size = new System.Drawing.Size(271, 28);
            this.txtBoxFoodID.TabIndex = 5;
            // 
            // label5
            // 
            this.label5.Location = new System.Drawing.Point(443, 44);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(61, 17);
            this.label5.TabIndex = 4;
            this.label5.Text = "Gambar";
            // 
            // label4
            // 
            this.label4.Location = new System.Drawing.Point(20, 146);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(61, 17);
            this.label4.TabIndex = 3;
            this.label4.Text = "Kategori";
            // 
            // label3
            // 
            this.label3.Location = new System.Drawing.Point(20, 112);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(61, 17);
            this.label3.TabIndex = 2;
            this.label3.Text = "Harga";
            // 
            // label2
            // 
            this.label2.Location = new System.Drawing.Point(20, 78);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(61, 17);
            this.label2.TabIndex = 1;
            this.label2.Text = "Nama";
            // 
            // label1
            // 
            this.label1.Location = new System.Drawing.Point(20, 44);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(61, 17);
            this.label1.TabIndex = 0;
            this.label1.Text = "FoodID";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(20, 20);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(177, 25);
            this.label6.TabIndex = 2;
            this.label6.Text = "Food Management";
            // 
            // btnShowRecommended
            // 
            this.btnShowRecommended.Location = new System.Drawing.Point(25, 345);
            this.btnShowRecommended.Name = "btnShowRecommended";
            this.btnShowRecommended.Size = new System.Drawing.Size(161, 27);
            this.btnShowRecommended.TabIndex = 14;
            this.btnShowRecommended.Text = "Show Recommended";
            this.btnShowRecommended.UseVisualStyleBackColor = true;
            this.btnShowRecommended.Click += new System.EventHandler(this.btnShowRecommended_Click);
            // 
            // btnShowFood
            // 
            this.btnShowFood.Location = new System.Drawing.Point(189, 316);
            this.btnShowFood.Name = "btnShowFood";
            this.btnShowFood.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.btnShowFood.Size = new System.Drawing.Size(161, 27);
            this.btnShowFood.TabIndex = 15;
            this.btnShowFood.Text = "Show Food";
            this.btnShowFood.UseVisualStyleBackColor = true;
            this.btnShowFood.Click += new System.EventHandler(this.btnShowFood_Click);
            // 
            // btnShowBeverages
            // 
            this.btnShowBeverages.Location = new System.Drawing.Point(189, 345);
            this.btnShowBeverages.Name = "btnShowBeverages";
            this.btnShowBeverages.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.btnShowBeverages.Size = new System.Drawing.Size(161, 27);
            this.btnShowBeverages.TabIndex = 16;
            this.btnShowBeverages.Text = "Show Beverages";
            this.btnShowBeverages.UseVisualStyleBackColor = true;
            this.btnShowBeverages.Click += new System.EventHandler(this.btnShowBeverages_Click);
            // 
            // btnShowAll
            // 
            this.btnShowAll.Location = new System.Drawing.Point(25, 316);
            this.btnShowAll.Name = "btnShowAll";
            this.btnShowAll.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.btnShowAll.Size = new System.Drawing.Size(161, 27);
            this.btnShowAll.TabIndex = 17;
            this.btnShowAll.Text = "Show All";
            this.btnShowAll.UseVisualStyleBackColor = true;
            this.btnShowAll.Click += new System.EventHandler(this.btnShowAll_Click);
            // 
            // dgvFood
            // 
            this.dgvFood.AllowUserToAddRows = false;
            this.dgvFood.AllowUserToDeleteRows = false;
            this.dgvFood.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgvFood.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvFood.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.FoodID,
            this.Nama,
            this.Harga,
            this.Kategori,
            this.Gambar,
            this.Status});
            this.dgvFood.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.dgvFood.Location = new System.Drawing.Point(0, 378);
            this.dgvFood.Name = "dgvFood";
            this.dgvFood.ReadOnly = true;
            this.dgvFood.RowHeadersWidth = 51;
            this.dgvFood.RowTemplate.Height = 115;
            this.dgvFood.Size = new System.Drawing.Size(798, 331);
            this.dgvFood.TabIndex = 18;
            this.dgvFood.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvFood_CellClick);
            // 
            // FoodID
            // 
            this.FoodID.HeaderText = "Food ID";
            this.FoodID.MinimumWidth = 6;
            this.FoodID.Name = "FoodID";
            this.FoodID.ReadOnly = true;
            // 
            // Nama
            // 
            this.Nama.HeaderText = "Nama";
            this.Nama.MinimumWidth = 6;
            this.Nama.Name = "Nama";
            this.Nama.ReadOnly = true;
            // 
            // Harga
            // 
            this.Harga.HeaderText = "Harga";
            this.Harga.MinimumWidth = 6;
            this.Harga.Name = "Harga";
            this.Harga.ReadOnly = true;
            // 
            // Kategori
            // 
            this.Kategori.HeaderText = "Kategori";
            this.Kategori.MinimumWidth = 6;
            this.Kategori.Name = "Kategori";
            this.Kategori.ReadOnly = true;
            // 
            // Gambar
            // 
            this.Gambar.HeaderText = "Gambar";
            this.Gambar.ImageLayout = System.Windows.Forms.DataGridViewImageCellLayout.Stretch;
            this.Gambar.MinimumWidth = 6;
            this.Gambar.Name = "Gambar";
            this.Gambar.ReadOnly = true;
            // 
            // Status
            // 
            this.Status.HeaderText = "Status";
            this.Status.MinimumWidth = 6;
            this.Status.Name = "Status";
            this.Status.ReadOnly = true;
            // 
            // pnlFood
            // 
            this.pnlFood.Controls.Add(this.btnShowNonActive);
            this.pnlFood.Controls.Add(this.btnShowActive);
            this.pnlFood.Controls.Add(this.dgvFood);
            this.pnlFood.Controls.Add(this.btnShowAll);
            this.pnlFood.Controls.Add(this.btnShowBeverages);
            this.pnlFood.Controls.Add(this.btnShowFood);
            this.pnlFood.Controls.Add(this.btnShowRecommended);
            this.pnlFood.Controls.Add(this.label6);
            this.pnlFood.Controls.Add(this.groupBox1);
            this.pnlFood.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pnlFood.Location = new System.Drawing.Point(156, 0);
            this.pnlFood.Name = "pnlFood";
            this.pnlFood.Size = new System.Drawing.Size(798, 709);
            this.pnlFood.TabIndex = 3;
            // 
            // btnShowNonActive
            // 
            this.btnShowNonActive.Location = new System.Drawing.Point(356, 345);
            this.btnShowNonActive.Name = "btnShowNonActive";
            this.btnShowNonActive.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.btnShowNonActive.Size = new System.Drawing.Size(161, 27);
            this.btnShowNonActive.TabIndex = 20;
            this.btnShowNonActive.Text = "Show Non Active";
            this.btnShowNonActive.UseVisualStyleBackColor = true;
            this.btnShowNonActive.Click += new System.EventHandler(this.btnShowNonActive_Click);
            // 
            // btnShowActive
            // 
            this.btnShowActive.Location = new System.Drawing.Point(356, 316);
            this.btnShowActive.Name = "btnShowActive";
            this.btnShowActive.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.btnShowActive.Size = new System.Drawing.Size(161, 27);
            this.btnShowActive.TabIndex = 19;
            this.btnShowActive.Text = "Show Active";
            this.btnShowActive.UseVisualStyleBackColor = true;
            this.btnShowActive.Click += new System.EventHandler(this.btnShowActive_Click);
            // 
            // pnlBilling
            // 
            this.pnlBilling.Controls.Add(this.ucBilling1);
            this.pnlBilling.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pnlBilling.Location = new System.Drawing.Point(156, 0);
            this.pnlBilling.Name = "pnlBilling";
            this.pnlBilling.Size = new System.Drawing.Size(798, 709);
            this.pnlBilling.TabIndex = 5;
            // 
            // pnlMeja
            // 
            this.pnlMeja.Controls.Add(this.ucMeja1);
            this.pnlMeja.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pnlMeja.Location = new System.Drawing.Point(156, 0);
            this.pnlMeja.Name = "pnlMeja";
            this.pnlMeja.Size = new System.Drawing.Size(798, 709);
            this.pnlMeja.TabIndex = 4;
            // 
            // ucMeja1
            // 
            this.ucMeja1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.ucMeja1.Location = new System.Drawing.Point(0, 0);
            this.ucMeja1.Name = "ucMeja1";
            this.ucMeja1.Size = new System.Drawing.Size(798, 709);
            this.ucMeja1.TabIndex = 0;
            // 
            // ucBilling1
            // 
            this.ucBilling1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.ucBilling1.Location = new System.Drawing.Point(0, 0);
            this.ucBilling1.Name = "ucBilling1";
            this.ucBilling1.Size = new System.Drawing.Size(798, 709);
            this.ucBilling1.TabIndex = 0;
            // 
            // FormAdmin
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(954, 709);
            this.Controls.Add(this.pnlMeja);
            this.Controls.Add(this.pnlBilling);
            this.Controls.Add(this.pnlFood);
            this.Controls.Add(this.menuStrip1);
            this.MainMenuStrip = this.menuStrip1;
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "FormAdmin";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "FormAdmin";
            this.Load += new System.EventHandler(this.FormAdmin_Load);
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.picBoxGambar)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvFood)).EndInit();
            this.pnlFood.ResumeLayout(false);
            this.pnlFood.PerformLayout();
            this.pnlBilling.ResumeLayout(false);
            this.pnlMeja.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem tsMeja;
        private System.Windows.Forms.ToolStripMenuItem tsFood;
        private System.Windows.Forms.ToolStripMenuItem tsBilling;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Button btnBrowse;
        private System.Windows.Forms.Button btnStatus;
        private System.Windows.Forms.Button btnUpdate;
        private System.Windows.Forms.Button btnAdd;
        private System.Windows.Forms.PictureBox picBoxGambar;
        private System.Windows.Forms.ComboBox cmbBoxKategori;
        private System.Windows.Forms.TextBox txtBoxHarga;
        private System.Windows.Forms.TextBox txtBoxNama;
        private System.Windows.Forms.TextBox txtBoxFoodID;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Button btnShowRecommended;
        private System.Windows.Forms.Button btnShowFood;
        private System.Windows.Forms.Button btnShowBeverages;
        private System.Windows.Forms.Button btnShowAll;
        private System.Windows.Forms.DataGridView dgvFood;
        private System.Windows.Forms.Panel pnlFood;
        private System.Windows.Forms.Panel pnlMeja;
        private ucMeja ucMeja1;
        private System.Windows.Forms.Panel pnlBilling;
        private ucBilling ucBilling1;
        private System.Windows.Forms.DataGridViewTextBoxColumn FoodID;
        private System.Windows.Forms.DataGridViewTextBoxColumn Nama;
        private System.Windows.Forms.DataGridViewTextBoxColumn Harga;
        private System.Windows.Forms.DataGridViewTextBoxColumn Kategori;
        private System.Windows.Forms.DataGridViewImageColumn Gambar;
        private System.Windows.Forms.DataGridViewTextBoxColumn Status;
        private System.Windows.Forms.Button btnShowNonActive;
        private System.Windows.Forms.Button btnShowActive;
    }
}