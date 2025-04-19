using System;
using System.Collections;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace SmarketApp.Model
{
    public partial class AddOrderfrm : Addsamplefrm
    {
        public AddOrderfrm()
        {
            InitializeComponent();
        }
        public int id = 0;

        public override void btnsave_Click(object sender, EventArgs e)
        {
            string qr = "";
            if (id == 0)
            {
                qr = "sp_AddOrd";
            }
            else
            {
                qr = "sp_UpdateOrd";
            }

            Hashtable ht = new Hashtable();
            ht.Add("@OrdId", id);
            ht.Add("@OrdName", txtName.Text);

            if (MainClass.SQL(qr, ht) > 0)
            {
                MessageBox.Show("Saved Successfully", "Management system", MessageBoxButtons.OK, MessageBoxIcon.Information);
                id = 0; txtName.Clear();
                txtName.Focus();
            }
        }

        private void btnclose_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
