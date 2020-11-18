
namespace uts_business_application_programming
{
    partial class ucBilling
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
            this.btnShow = new System.Windows.Forms.Button();
            this.btnSearch = new System.Windows.Forms.Button();
            this.dtPicker = new System.Windows.Forms.DateTimePicker();
            this.dgvOrderItem = new System.Windows.Forms.DataGridView();
            this.btnCetak = new System.Windows.Forms.Button();
            this.dgvBilling = new System.Windows.Forms.DataGridView();
            this.lblBilling = new System.Windows.Forms.Label();
            this.pnlMeja.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvOrderItem)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvBilling)).BeginInit();
            this.SuspendLayout();
            // 
            // pnlMeja
            // 
            this.pnlMeja.Controls.Add(this.btnShow);
            this.pnlMeja.Controls.Add(this.btnSearch);
            this.pnlMeja.Controls.Add(this.dtPicker);
            this.pnlMeja.Controls.Add(this.dgvOrderItem);
            this.pnlMeja.Controls.Add(this.btnCetak);
            this.pnlMeja.Controls.Add(this.dgvBilling);
            this.pnlMeja.Controls.Add(this.lblBilling);
            this.pnlMeja.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pnlMeja.Location = new System.Drawing.Point(0, 0);
            this.pnlMeja.Name = "pnlMeja";
            this.pnlMeja.Size = new System.Drawing.Size(829, 709);
            this.pnlMeja.TabIndex = 21;
            // 
            // btnShow
            // 
            this.btnShow.Location = new System.Drawing.Point(415, 364);
            this.btnShow.Name = "btnShow";
            this.btnShow.Size = new System.Drawing.Size(137, 38);
            this.btnShow.TabIndex = 23;
            this.btnShow.Text = "Show All";
            this.btnShow.UseVisualStyleBackColor = true;
            this.btnShow.Click += new System.EventHandler(this.btnShow_Click);
            // 
            // btnSearch
            // 
            this.btnSearch.Location = new System.Drawing.Point(272, 364);
            this.btnSearch.Name = "btnSearch";
            this.btnSearch.Size = new System.Drawing.Size(137, 38);
            this.btnSearch.TabIndex = 22;
            this.btnSearch.Text = "Search Billing";
            this.btnSearch.UseVisualStyleBackColor = true;
            this.btnSearch.Click += new System.EventHandler(this.btnSearch_Click);
            // 
            // dtPicker
            // 
            this.dtPicker.Location = new System.Drawing.Point(43, 372);
            this.dtPicker.Name = "dtPicker";
            this.dtPicker.Size = new System.Drawing.Size(200, 22);
            this.dtPicker.TabIndex = 21;
            // 
            // dgvOrderItem
            // 
            this.dgvOrderItem.AllowUserToAddRows = false;
            this.dgvOrderItem.AllowUserToDeleteRows = false;
            this.dgvOrderItem.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgvOrderItem.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvOrderItem.Location = new System.Drawing.Point(0, 429);
            this.dgvOrderItem.Name = "dgvOrderItem";
            this.dgvOrderItem.ReadOnly = true;
            this.dgvOrderItem.RowHeadersWidth = 51;
            this.dgvOrderItem.RowTemplate.Height = 26;
            this.dgvOrderItem.Size = new System.Drawing.Size(829, 280);
            this.dgvOrderItem.TabIndex = 20;
            // 
            // btnCetak
            // 
            this.btnCetak.BackColor = System.Drawing.SystemColors.Highlight;
            this.btnCetak.Location = new System.Drawing.Point(614, 364);
            this.btnCetak.Name = "btnCetak";
            this.btnCetak.Size = new System.Drawing.Size(137, 38);
            this.btnCetak.TabIndex = 19;
            this.btnCetak.Text = "Cetak Billing";
            this.btnCetak.UseVisualStyleBackColor = false;
            this.btnCetak.Click += new System.EventHandler(this.btnCetak_Click);
            // 
            // dgvBilling
            // 
            this.dgvBilling.AllowUserToAddRows = false;
            this.dgvBilling.AllowUserToDeleteRows = false;
            this.dgvBilling.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgvBilling.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvBilling.Location = new System.Drawing.Point(0, 64);
            this.dgvBilling.Name = "dgvBilling";
            this.dgvBilling.ReadOnly = true;
            this.dgvBilling.RowHeadersWidth = 51;
            this.dgvBilling.RowTemplate.Height = 26;
            this.dgvBilling.Size = new System.Drawing.Size(829, 280);
            this.dgvBilling.TabIndex = 18;
            this.dgvBilling.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvBilling_CellClick);
            // 
            // lblBilling
            // 
            this.lblBilling.AutoSize = true;
            this.lblBilling.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblBilling.Location = new System.Drawing.Point(20, 20);
            this.lblBilling.Name = "lblBilling";
            this.lblBilling.Size = new System.Drawing.Size(183, 25);
            this.lblBilling.TabIndex = 2;
            this.lblBilling.Text = "Billing Management";
            // 
            // ucBilling
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.pnlMeja);
            this.Name = "ucBilling";
            this.Size = new System.Drawing.Size(829, 709);
            this.Load += new System.EventHandler(this.ucBilling_Load);
            this.pnlMeja.ResumeLayout(false);
            this.pnlMeja.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvOrderItem)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvBilling)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel pnlMeja;
        private System.Windows.Forms.DataGridView dgvBilling;
        private System.Windows.Forms.Label lblBilling;
        private System.Windows.Forms.Button btnCetak;
        private System.Windows.Forms.DataGridView dgvOrderItem;
        private System.Windows.Forms.DateTimePicker dtPicker;
        private System.Windows.Forms.Button btnSearch;
        private System.Windows.Forms.Button btnShow;
    }
}
