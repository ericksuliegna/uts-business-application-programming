
namespace uts_business_application_programming
{
    partial class FormUser
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
            this.pnlMenuCart = new System.Windows.Forms.Panel();
            this.lblMejaText = new System.Windows.Forms.Label();
            this.lblMeja = new System.Windows.Forms.Label();
            this.lblDate = new System.Windows.Forms.Label();
            this.txtBoxTotal = new System.Windows.Forms.TextBox();
            this.lblTotal = new System.Windows.Forms.Label();
            this.btnPay = new System.Windows.Forms.Button();
            this.btnShowAll = new System.Windows.Forms.Button();
            this.btnShowBeverages = new System.Windows.Forms.Button();
            this.btnShowFood = new System.Windows.Forms.Button();
            this.btnShowRecommended = new System.Windows.Forms.Button();
            this.btnOrder = new System.Windows.Forms.Button();
            this.numQuantity = new System.Windows.Forms.NumericUpDown();
            this.lblQty = new System.Windows.Forms.Label();
            this.btnRemove = new System.Windows.Forms.Button();
            this.btnAdd = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.dgvMenu = new System.Windows.Forms.DataGridView();
            this.dataGridViewTextBoxColumn1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Nama = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Harga = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Kategori = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Gambar = new System.Windows.Forms.DataGridViewImageColumn();
            this.lblMenu = new System.Windows.Forms.Label();
            this.dgvCart = new System.Windows.Forms.DataGridView();
            this.dgvOrdered = new System.Windows.Forms.DataGridView();
            this.lblOrdered = new System.Windows.Forms.Label();
            this.pnlMenuCart.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.numQuantity)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvMenu)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvCart)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvOrdered)).BeginInit();
            this.SuspendLayout();
            // 
            // pnlMenuCart
            // 
            this.pnlMenuCart.Controls.Add(this.lblOrdered);
            this.pnlMenuCart.Controls.Add(this.dgvOrdered);
            this.pnlMenuCart.Controls.Add(this.lblMejaText);
            this.pnlMenuCart.Controls.Add(this.lblMeja);
            this.pnlMenuCart.Controls.Add(this.lblDate);
            this.pnlMenuCart.Controls.Add(this.txtBoxTotal);
            this.pnlMenuCart.Controls.Add(this.lblTotal);
            this.pnlMenuCart.Controls.Add(this.btnPay);
            this.pnlMenuCart.Controls.Add(this.btnShowAll);
            this.pnlMenuCart.Controls.Add(this.btnShowBeverages);
            this.pnlMenuCart.Controls.Add(this.btnShowFood);
            this.pnlMenuCart.Controls.Add(this.btnShowRecommended);
            this.pnlMenuCart.Controls.Add(this.btnOrder);
            this.pnlMenuCart.Controls.Add(this.numQuantity);
            this.pnlMenuCart.Controls.Add(this.lblQty);
            this.pnlMenuCart.Controls.Add(this.btnRemove);
            this.pnlMenuCart.Controls.Add(this.btnAdd);
            this.pnlMenuCart.Controls.Add(this.label1);
            this.pnlMenuCart.Controls.Add(this.dgvMenu);
            this.pnlMenuCart.Controls.Add(this.lblMenu);
            this.pnlMenuCart.Controls.Add(this.dgvCart);
            this.pnlMenuCart.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pnlMenuCart.Location = new System.Drawing.Point(0, 0);
            this.pnlMenuCart.Name = "pnlMenuCart";
            this.pnlMenuCart.Size = new System.Drawing.Size(1161, 828);
            this.pnlMenuCart.TabIndex = 8;
            // 
            // lblMejaText
            // 
            this.lblMejaText.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblMejaText.Location = new System.Drawing.Point(1076, 37);
            this.lblMejaText.Name = "lblMejaText";
            this.lblMejaText.Size = new System.Drawing.Size(50, 20);
            this.lblMejaText.TabIndex = 42;
            // 
            // lblMeja
            // 
            this.lblMeja.AutoSize = true;
            this.lblMeja.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblMeja.Location = new System.Drawing.Point(932, 37);
            this.lblMeja.Name = "lblMeja";
            this.lblMeja.Size = new System.Drawing.Size(50, 20);
            this.lblMeja.TabIndex = 41;
            this.lblMeja.Text = "Meja:";
            // 
            // lblDate
            // 
            this.lblDate.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblDate.Location = new System.Drawing.Point(754, 436);
            this.lblDate.Name = "lblDate";
            this.lblDate.Size = new System.Drawing.Size(144, 25);
            this.lblDate.TabIndex = 40;
            this.lblDate.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // txtBoxTotal
            // 
            this.txtBoxTotal.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtBoxTotal.Location = new System.Drawing.Point(1009, 480);
            this.txtBoxTotal.Name = "txtBoxTotal";
            this.txtBoxTotal.ReadOnly = true;
            this.txtBoxTotal.Size = new System.Drawing.Size(117, 27);
            this.txtBoxTotal.TabIndex = 36;
            this.txtBoxTotal.Text = "0";
            this.txtBoxTotal.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // lblTotal
            // 
            this.lblTotal.AutoSize = true;
            this.lblTotal.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTotal.Location = new System.Drawing.Point(932, 483);
            this.lblTotal.Name = "lblTotal";
            this.lblTotal.Size = new System.Drawing.Size(51, 20);
            this.lblTotal.TabIndex = 34;
            this.lblTotal.Text = "Total:";
            // 
            // btnPay
            // 
            this.btnPay.BackColor = System.Drawing.Color.Crimson;
            this.btnPay.ForeColor = System.Drawing.Color.White;
            this.btnPay.Location = new System.Drawing.Point(936, 696);
            this.btnPay.Name = "btnPay";
            this.btnPay.Size = new System.Drawing.Size(190, 35);
            this.btnPay.TabIndex = 33;
            this.btnPay.Text = "Check Out";
            this.btnPay.UseVisualStyleBackColor = false;
            this.btnPay.Click += new System.EventHandler(this.btnPay_Click);
            // 
            // btnShowAll
            // 
            this.btnShowAll.Location = new System.Drawing.Point(936, 148);
            this.btnShowAll.Name = "btnShowAll";
            this.btnShowAll.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.btnShowAll.Size = new System.Drawing.Size(190, 33);
            this.btnShowAll.TabIndex = 32;
            this.btnShowAll.Text = "Show All";
            this.btnShowAll.UseVisualStyleBackColor = true;
            this.btnShowAll.Click += new System.EventHandler(this.btnShowAll_Click);
            // 
            // btnShowBeverages
            // 
            this.btnShowBeverages.Location = new System.Drawing.Point(936, 265);
            this.btnShowBeverages.Name = "btnShowBeverages";
            this.btnShowBeverages.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.btnShowBeverages.Size = new System.Drawing.Size(190, 33);
            this.btnShowBeverages.TabIndex = 31;
            this.btnShowBeverages.Text = "Show Beverages";
            this.btnShowBeverages.UseVisualStyleBackColor = true;
            this.btnShowBeverages.Click += new System.EventHandler(this.btnShowBeverages_Click);
            // 
            // btnShowFood
            // 
            this.btnShowFood.Location = new System.Drawing.Point(936, 226);
            this.btnShowFood.Name = "btnShowFood";
            this.btnShowFood.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.btnShowFood.Size = new System.Drawing.Size(190, 33);
            this.btnShowFood.TabIndex = 30;
            this.btnShowFood.Text = "Show Food";
            this.btnShowFood.UseVisualStyleBackColor = true;
            this.btnShowFood.Click += new System.EventHandler(this.btnShowFood_Click);
            // 
            // btnShowRecommended
            // 
            this.btnShowRecommended.Location = new System.Drawing.Point(936, 187);
            this.btnShowRecommended.Name = "btnShowRecommended";
            this.btnShowRecommended.Size = new System.Drawing.Size(190, 33);
            this.btnShowRecommended.TabIndex = 29;
            this.btnShowRecommended.Text = "Show Recommended";
            this.btnShowRecommended.UseVisualStyleBackColor = true;
            this.btnShowRecommended.Click += new System.EventHandler(this.btnShowRecommended_Click);
            // 
            // btnOrder
            // 
            this.btnOrder.BackColor = System.Drawing.Color.Crimson;
            this.btnOrder.ForeColor = System.Drawing.Color.White;
            this.btnOrder.Location = new System.Drawing.Point(936, 644);
            this.btnOrder.Name = "btnOrder";
            this.btnOrder.Size = new System.Drawing.Size(190, 35);
            this.btnOrder.TabIndex = 28;
            this.btnOrder.Text = "Order";
            this.btnOrder.UseVisualStyleBackColor = false;
            this.btnOrder.Click += new System.EventHandler(this.btnOrder_Click);
            // 
            // numQuantity
            // 
            this.numQuantity.Enabled = false;
            this.numQuantity.Location = new System.Drawing.Point(253, 394);
            this.numQuantity.Maximum = new decimal(new int[] {
            20,
            0,
            0,
            0});
            this.numQuantity.Minimum = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.numQuantity.Name = "numQuantity";
            this.numQuantity.Size = new System.Drawing.Size(63, 22);
            this.numQuantity.TabIndex = 27;
            this.numQuantity.Value = new decimal(new int[] {
            1,
            0,
            0,
            0});
            // 
            // lblQty
            // 
            this.lblQty.AutoSize = true;
            this.lblQty.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblQty.Location = new System.Drawing.Point(163, 394);
            this.lblQty.Name = "lblQty";
            this.lblQty.Size = new System.Drawing.Size(71, 20);
            this.lblQty.TabIndex = 26;
            this.lblQty.Text = "Quantity";
            // 
            // btnRemove
            // 
            this.btnRemove.Location = new System.Drawing.Point(608, 389);
            this.btnRemove.Name = "btnRemove";
            this.btnRemove.Size = new System.Drawing.Size(138, 33);
            this.btnRemove.TabIndex = 25;
            this.btnRemove.Text = "Remove from Cart";
            this.btnRemove.UseVisualStyleBackColor = true;
            this.btnRemove.Click += new System.EventHandler(this.btnRemove_Click);
            // 
            // btnAdd
            // 
            this.btnAdd.Location = new System.Drawing.Point(444, 389);
            this.btnAdd.Name = "btnAdd";
            this.btnAdd.Size = new System.Drawing.Size(138, 33);
            this.btnAdd.TabIndex = 24;
            this.btnAdd.Text = "Add to Cart";
            this.btnAdd.UseVisualStyleBackColor = true;
            this.btnAdd.Click += new System.EventHandler(this.btnAdd_Click);
            // 
            // label1
            // 
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(26, 436);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(151, 25);
            this.label1.TabIndex = 23;
            this.label1.Text = "Cart";
            // 
            // dgvMenu
            // 
            this.dgvMenu.AllowUserToAddRows = false;
            this.dgvMenu.AllowUserToDeleteRows = false;
            this.dgvMenu.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgvMenu.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvMenu.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.dataGridViewTextBoxColumn1,
            this.Nama,
            this.Harga,
            this.Kategori,
            this.Gambar});
            this.dgvMenu.Location = new System.Drawing.Point(26, 37);
            this.dgvMenu.Name = "dgvMenu";
            this.dgvMenu.ReadOnly = true;
            this.dgvMenu.RowHeadersWidth = 51;
            this.dgvMenu.RowTemplate.Height = 115;
            this.dgvMenu.Size = new System.Drawing.Size(872, 331);
            this.dgvMenu.TabIndex = 22;
            this.dgvMenu.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvMenu_CellClick);
            this.dgvMenu.DataError += new System.Windows.Forms.DataGridViewDataErrorEventHandler(this.dgvMenu_DataError);
            // 
            // dataGridViewTextBoxColumn1
            // 
            this.dataGridViewTextBoxColumn1.HeaderText = "Food ID";
            this.dataGridViewTextBoxColumn1.MinimumWidth = 6;
            this.dataGridViewTextBoxColumn1.Name = "dataGridViewTextBoxColumn1";
            this.dataGridViewTextBoxColumn1.ReadOnly = true;
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
            // lblMenu
            // 
            this.lblMenu.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblMenu.Location = new System.Drawing.Point(26, 12);
            this.lblMenu.Name = "lblMenu";
            this.lblMenu.Size = new System.Drawing.Size(872, 25);
            this.lblMenu.TabIndex = 21;
            this.lblMenu.Text = "Menu";
            // 
            // dgvCart
            // 
            this.dgvCart.AllowUserToAddRows = false;
            this.dgvCart.AllowUserToDeleteRows = false;
            this.dgvCart.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgvCart.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvCart.Location = new System.Drawing.Point(26, 461);
            this.dgvCart.Name = "dgvCart";
            this.dgvCart.ReadOnly = true;
            this.dgvCart.RowHeadersWidth = 51;
            this.dgvCart.RowTemplate.Height = 24;
            this.dgvCart.Size = new System.Drawing.Size(421, 270);
            this.dgvCart.TabIndex = 19;
            // 
            // dgvOrdered
            // 
            this.dgvOrdered.AllowUserToAddRows = false;
            this.dgvOrdered.AllowUserToDeleteRows = false;
            this.dgvOrdered.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgvOrdered.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvOrdered.Location = new System.Drawing.Point(466, 461);
            this.dgvOrdered.Name = "dgvOrdered";
            this.dgvOrdered.ReadOnly = true;
            this.dgvOrdered.RowHeadersWidth = 51;
            this.dgvOrdered.RowTemplate.Height = 24;
            this.dgvOrdered.Size = new System.Drawing.Size(432, 270);
            this.dgvOrdered.TabIndex = 43;
            // 
            // lblOrdered
            // 
            this.lblOrdered.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblOrdered.Location = new System.Drawing.Point(461, 433);
            this.lblOrdered.Name = "lblOrdered";
            this.lblOrdered.Size = new System.Drawing.Size(151, 25);
            this.lblOrdered.TabIndex = 44;
            this.lblOrdered.Text = "Ordered";
            // 
            // FormUser
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1161, 828);
            this.Controls.Add(this.pnlMenuCart);
            this.Name = "FormUser";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "FormUser";
            this.Load += new System.EventHandler(this.FormUser_Load);
            this.pnlMenuCart.ResumeLayout(false);
            this.pnlMenuCart.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.numQuantity)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvMenu)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvCart)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvOrdered)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.Panel pnlMenuCart;
        private System.Windows.Forms.Button btnOrder;
        private System.Windows.Forms.NumericUpDown numQuantity;
        private System.Windows.Forms.Label lblQty;
        private System.Windows.Forms.Button btnRemove;
        private System.Windows.Forms.Button btnAdd;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.DataGridView dgvMenu;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn1;
        private System.Windows.Forms.DataGridViewTextBoxColumn Nama;
        private System.Windows.Forms.DataGridViewTextBoxColumn Harga;
        private System.Windows.Forms.DataGridViewTextBoxColumn Kategori;
        private System.Windows.Forms.DataGridViewImageColumn Gambar;
        private System.Windows.Forms.Label lblMenu;
        private System.Windows.Forms.DataGridView dgvCart;
        private System.Windows.Forms.Button btnPay;
        private System.Windows.Forms.Button btnShowAll;
        private System.Windows.Forms.Button btnShowBeverages;
        private System.Windows.Forms.Button btnShowFood;
        private System.Windows.Forms.Button btnShowRecommended;
        private System.Windows.Forms.TextBox txtBoxTotal;
        private System.Windows.Forms.Label lblTotal;
        private System.Windows.Forms.Label lblDate;
        private System.Windows.Forms.Label lblMejaText;
        private System.Windows.Forms.Label lblMeja;
        private System.Windows.Forms.DataGridView dgvOrdered;
        private System.Windows.Forms.Label lblOrdered;
    }
}