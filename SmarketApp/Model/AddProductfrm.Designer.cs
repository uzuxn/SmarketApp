namespace SmarketApp.Model
{
    partial class AddProductfrm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(AddProductfrm));
            this.cmbCate = new System.Windows.Forms.ComboBox();
            this.label5 = new System.Windows.Forms.Label();
            this.txtPrice = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.txtName = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.btnbrowseimg = new System.Windows.Forms.Button();
            this.txtImg = new System.Windows.Forms.PictureBox();
            this.label2 = new System.Windows.Forms.Label();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.btnclose)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.panel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.txtImg)).BeginInit();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.Size = new System.Drawing.Size(1242, 38);
            // 
            // btnclose
            // 
            this.btnclose.Location = new System.Drawing.Point(1198, 3);
            this.btnclose.Click += new System.EventHandler(this.btnclose_Click);
            // 
            // label1
            // 
            this.label1.Location = new System.Drawing.Point(453, 6);
            // 
            // cmbCate
            // 
            this.cmbCate.FormattingEnabled = true;
            this.cmbCate.Location = new System.Drawing.Point(273, 275);
            this.cmbCate.Name = "cmbCate";
            this.cmbCate.Size = new System.Drawing.Size(559, 28);
            this.cmbCate.TabIndex = 19;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(106, 276);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(166, 22);
            this.label5.TabIndex = 18;
            this.label5.Text = "Product Category :-";
            // 
            // txtPrice
            // 
            this.txtPrice.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.txtPrice.Location = new System.Drawing.Point(273, 220);
            this.txtPrice.Name = "txtPrice";
            this.txtPrice.Size = new System.Drawing.Size(559, 26);
            this.txtPrice.TabIndex = 15;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(106, 221);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(134, 22);
            this.label4.TabIndex = 17;
            this.label4.Text = "Product Price :-";
            // 
            // txtName
            // 
            this.txtName.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.txtName.Location = new System.Drawing.Point(273, 165);
            this.txtName.Name = "txtName";
            this.txtName.Size = new System.Drawing.Size(559, 26);
            this.txtName.TabIndex = 14;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(106, 166);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(140, 22);
            this.label3.TabIndex = 16;
            this.label3.Text = "Product Name :-";
            // 
            // btnbrowseimg
            // 
            this.btnbrowseimg.BackColor = System.Drawing.Color.LavenderBlush;
            this.btnbrowseimg.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnbrowseimg.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnbrowseimg.Location = new System.Drawing.Point(1085, 192);
            this.btnbrowseimg.Name = "btnbrowseimg";
            this.btnbrowseimg.Size = new System.Drawing.Size(85, 70);
            this.btnbrowseimg.TabIndex = 20;
            this.btnbrowseimg.Text = "Browse Image";
            this.btnbrowseimg.UseVisualStyleBackColor = false;
            this.btnbrowseimg.Click += new System.EventHandler(this.btnbrowseimg_Click);
            // 
            // txtImg
            // 
            this.txtImg.Image = ((System.Drawing.Image)(resources.GetObject("txtImg.Image")));
            this.txtImg.Location = new System.Drawing.Point(889, 140);
            this.txtImg.Name = "txtImg";
            this.txtImg.Size = new System.Drawing.Size(163, 176);
            this.txtImg.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.txtImg.TabIndex = 21;
            this.txtImg.TabStop = false;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(78, 57);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(109, 22);
            this.label2.TabIndex = 22;
            this.label2.Text = "Add Product";
            // 
            // AddProductfrm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1242, 519);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.txtImg);
            this.Controls.Add(this.btnbrowseimg);
            this.Controls.Add(this.cmbCate);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.txtPrice);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.txtName);
            this.Controls.Add(this.label3);
            this.Name = "AddProductfrm";
            this.Text = "AddProductfrm";
            this.Load += new System.EventHandler(this.AddProductfrm_Load);
            this.Controls.SetChildIndex(this.panel1, 0);
            this.Controls.SetChildIndex(this.pictureBox1, 0);
            this.Controls.SetChildIndex(this.panel2, 0);
            this.Controls.SetChildIndex(this.label3, 0);
            this.Controls.SetChildIndex(this.txtName, 0);
            this.Controls.SetChildIndex(this.label4, 0);
            this.Controls.SetChildIndex(this.txtPrice, 0);
            this.Controls.SetChildIndex(this.label5, 0);
            this.Controls.SetChildIndex(this.cmbCate, 0);
            this.Controls.SetChildIndex(this.btnbrowseimg, 0);
            this.Controls.SetChildIndex(this.txtImg, 0);
            this.Controls.SetChildIndex(this.label2, 0);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.btnclose)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.txtImg)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        public System.Windows.Forms.ComboBox cmbCate;
        private System.Windows.Forms.Label label5;
        public System.Windows.Forms.TextBox txtPrice;
        private System.Windows.Forms.Label label4;
        public System.Windows.Forms.TextBox txtName;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Button btnbrowseimg;
        private System.Windows.Forms.PictureBox txtImg;
        private System.Windows.Forms.Label label2;
    }
}