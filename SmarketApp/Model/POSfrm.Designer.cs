namespace SmarketApp.Model
{
    partial class POSfrm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(POSfrm));
            this.panel1 = new System.Windows.Forms.Panel();
            this.btnclose = new System.Windows.Forms.PictureBox();
            this.label2 = new System.Windows.Forms.Label();
            this.panel2 = new System.Windows.Forms.Panel();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.label1 = new System.Windows.Forms.Label();
            this.btnNew = new System.Windows.Forms.Button();
            this.btnHold = new System.Windows.Forms.Button();
            this.btnBill = new System.Windows.Forms.Button();
            this.btnDeliv = new System.Windows.Forms.Button();
            this.btnTway = new System.Windows.Forms.Button();
            this.button6 = new System.Windows.Forms.Button();
            this.lblOrder = new System.Windows.Forms.Label();
            this.lblCust = new System.Windows.Forms.Label();
            this.CategoryPanel = new System.Windows.Forms.FlowLayoutPanel();
            this.ProductPanel = new System.Windows.Forms.FlowLayoutPanel();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.dgvSno = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dgvId = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dgvName = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dgvqty = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dgvprice = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dgvAmount = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.btnclose)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.LightSkyBlue;
            this.panel1.Controls.Add(this.btnclose);
            this.panel1.Controls.Add(this.label2);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(1073, 33);
            this.panel1.TabIndex = 0;
            // 
            // btnclose
            // 
            this.btnclose.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnclose.Image = ((System.Drawing.Image)(resources.GetObject("btnclose.Image")));
            this.btnclose.Location = new System.Drawing.Point(1041, 2);
            this.btnclose.Name = "btnclose";
            this.btnclose.Size = new System.Drawing.Size(30, 30);
            this.btnclose.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.btnclose.TabIndex = 10;
            this.btnclose.TabStop = false;
            this.btnclose.Click += new System.EventHandler(this.btnclose_Click);
            // 
            // label2
            // 
            this.label2.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(364, 4);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(316, 25);
            this.label2.TabIndex = 4;
            this.label2.Text = "UrbanMarket Management System";
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.Color.LightSteelBlue;
            this.panel2.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.panel2.Location = new System.Drawing.Point(0, 554);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(1073, 71);
            this.panel2.TabIndex = 0;
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(2, 32);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(97, 84);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox1.TabIndex = 0;
            this.pictureBox1.TabStop = false;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(105, 63);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(55, 25);
            this.label1.TabIndex = 1;
            this.label1.Text = "POS";
            // 
            // btnNew
            // 
            this.btnNew.BackColor = System.Drawing.Color.IndianRed;
            this.btnNew.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnNew.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnNew.Location = new System.Drawing.Point(29, 173);
            this.btnNew.Name = "btnNew";
            this.btnNew.Size = new System.Drawing.Size(100, 40);
            this.btnNew.TabIndex = 2;
            this.btnNew.Text = "New";
            this.btnNew.UseVisualStyleBackColor = false;
            // 
            // btnHold
            // 
            this.btnHold.BackColor = System.Drawing.Color.IndianRed;
            this.btnHold.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnHold.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnHold.Location = new System.Drawing.Point(29, 233);
            this.btnHold.Name = "btnHold";
            this.btnHold.Size = new System.Drawing.Size(100, 40);
            this.btnHold.TabIndex = 3;
            this.btnHold.Text = "Hold";
            this.btnHold.UseVisualStyleBackColor = false;
            // 
            // btnBill
            // 
            this.btnBill.BackColor = System.Drawing.Color.IndianRed;
            this.btnBill.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnBill.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnBill.Location = new System.Drawing.Point(29, 293);
            this.btnBill.Name = "btnBill";
            this.btnBill.Size = new System.Drawing.Size(100, 40);
            this.btnBill.TabIndex = 4;
            this.btnBill.Text = "Bill List";
            this.btnBill.UseVisualStyleBackColor = false;
            // 
            // btnDeliv
            // 
            this.btnDeliv.BackColor = System.Drawing.Color.IndianRed;
            this.btnDeliv.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnDeliv.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnDeliv.Location = new System.Drawing.Point(29, 353);
            this.btnDeliv.Name = "btnDeliv";
            this.btnDeliv.Size = new System.Drawing.Size(100, 40);
            this.btnDeliv.TabIndex = 5;
            this.btnDeliv.Text = "Delivery";
            this.btnDeliv.UseVisualStyleBackColor = false;
            // 
            // btnTway
            // 
            this.btnTway.BackColor = System.Drawing.Color.IndianRed;
            this.btnTway.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnTway.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnTway.Location = new System.Drawing.Point(29, 409);
            this.btnTway.Name = "btnTway";
            this.btnTway.Size = new System.Drawing.Size(100, 40);
            this.btnTway.TabIndex = 6;
            this.btnTway.Text = "Take away";
            this.btnTway.UseVisualStyleBackColor = false;
            // 
            // button6
            // 
            this.button6.BackColor = System.Drawing.Color.IndianRed;
            this.button6.Cursor = System.Windows.Forms.Cursors.Hand;
            this.button6.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.button6.Location = new System.Drawing.Point(29, 469);
            this.button6.Name = "button6";
            this.button6.Size = new System.Drawing.Size(100, 40);
            this.button6.TabIndex = 7;
            this.button6.Text = "button6";
            this.button6.UseVisualStyleBackColor = false;
            // 
            // lblOrder
            // 
            this.lblOrder.AutoSize = true;
            this.lblOrder.Location = new System.Drawing.Point(786, 38);
            this.lblOrder.Name = "lblOrder";
            this.lblOrder.Size = new System.Drawing.Size(49, 20);
            this.lblOrder.TabIndex = 8;
            this.lblOrder.Text = "Order";
            this.lblOrder.Visible = false;
            // 
            // lblCust
            // 
            this.lblCust.AutoSize = true;
            this.lblCust.Location = new System.Drawing.Point(786, 71);
            this.lblCust.Name = "lblCust";
            this.lblCust.Size = new System.Drawing.Size(78, 20);
            this.lblCust.TabIndex = 9;
            this.lblCust.Text = "Customer\r\n";
            this.lblCust.Visible = false;
            // 
            // CategoryPanel
            // 
            this.CategoryPanel.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left)));
            this.CategoryPanel.Location = new System.Drawing.Point(166, 116);
            this.CategoryPanel.Name = "CategoryPanel";
            this.CategoryPanel.Size = new System.Drawing.Size(129, 412);
            this.CategoryPanel.TabIndex = 10;
            // 
            // ProductPanel
            // 
            this.ProductPanel.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.ProductPanel.Location = new System.Drawing.Point(301, 116);
            this.ProductPanel.Name = "ProductPanel";
            this.ProductPanel.Size = new System.Drawing.Size(382, 412);
            this.ProductPanel.TabIndex = 0;
            // 
            // dataGridView1
            // 
            this.dataGridView1.AllowUserToAddRows = false;
            this.dataGridView1.AllowUserToDeleteRows = false;
            this.dataGridView1.AllowUserToResizeColumns = false;
            this.dataGridView1.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.dgvSno,
            this.dgvId,
            this.dgvName,
            this.dgvqty,
            this.dgvprice,
            this.dgvAmount});
            this.dataGridView1.Location = new System.Drawing.Point(689, 116);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.RowHeadersVisible = false;
            this.dataGridView1.RowHeadersWidth = 62;
            this.dataGridView1.RowTemplate.Height = 28;
            this.dataGridView1.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dataGridView1.Size = new System.Drawing.Size(372, 412);
            this.dataGridView1.TabIndex = 11;
            // 
            // dgvSno
            // 
            this.dgvSno.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.None;
            this.dgvSno.HeaderText = "Sr#";
            this.dgvSno.MinimumWidth = 8;
            this.dgvSno.Name = "dgvSno";
            this.dgvSno.Width = 50;
            // 
            // dgvId
            // 
            this.dgvId.HeaderText = "ID";
            this.dgvId.MinimumWidth = 8;
            this.dgvId.Name = "dgvId";
            this.dgvId.Visible = false;
            this.dgvId.Width = 80;
            // 
            // dgvName
            // 
            this.dgvName.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells;
            this.dgvName.HeaderText = "Name";
            this.dgvName.MinimumWidth = 8;
            this.dgvName.Name = "dgvName";
            this.dgvName.Width = 87;
            // 
            // dgvqty
            // 
            this.dgvqty.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.None;
            this.dgvqty.HeaderText = "Qty";
            this.dgvqty.MinimumWidth = 8;
            this.dgvqty.Name = "dgvqty";
            this.dgvqty.Width = 50;
            // 
            // dgvprice
            // 
            this.dgvprice.HeaderText = "Price";
            this.dgvprice.MinimumWidth = 8;
            this.dgvprice.Name = "dgvprice";
            this.dgvprice.Width = 150;
            // 
            // dgvAmount
            // 
            this.dgvAmount.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.None;
            this.dgvAmount.HeaderText = "Amount";
            this.dgvAmount.MinimumWidth = 8;
            this.dgvAmount.Name = "dgvAmount";
            this.dgvAmount.Width = 150;
            // 
            // POSfrm
            // 
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.None;
            this.BackColor = System.Drawing.Color.Lavender;
            this.ClientSize = new System.Drawing.Size(1073, 625);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.ProductPanel);
            this.Controls.Add(this.CategoryPanel);
            this.Controls.Add(this.lblCust);
            this.Controls.Add(this.lblOrder);
            this.Controls.Add(this.button6);
            this.Controls.Add(this.btnTway);
            this.Controls.Add(this.btnDeliv);
            this.Controls.Add(this.btnBill);
            this.Controls.Add(this.btnHold);
            this.Controls.Add(this.btnNew);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.panel1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "POSfrm";
            this.Text = "POSfrm";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.Load += new System.EventHandler(this.POSfrm_Load);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.btnclose)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Label label1;
        public System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button btnNew;
        private System.Windows.Forms.Button btnHold;
        private System.Windows.Forms.Button btnBill;
        private System.Windows.Forms.Button btnDeliv;
        private System.Windows.Forms.Button btnTway;
        private System.Windows.Forms.Button button6;
        private System.Windows.Forms.Label lblOrder;
        private System.Windows.Forms.Label lblCust;
        private System.Windows.Forms.PictureBox btnclose;
        private System.Windows.Forms.FlowLayoutPanel CategoryPanel;
        private System.Windows.Forms.FlowLayoutPanel ProductPanel;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.DataGridViewTextBoxColumn dgvSno;
        private System.Windows.Forms.DataGridViewTextBoxColumn dgvId;
        private System.Windows.Forms.DataGridViewTextBoxColumn dgvName;
        private System.Windows.Forms.DataGridViewTextBoxColumn dgvqty;
        private System.Windows.Forms.DataGridViewTextBoxColumn dgvprice;
        private System.Windows.Forms.DataGridViewTextBoxColumn dgvAmount;
    }
}