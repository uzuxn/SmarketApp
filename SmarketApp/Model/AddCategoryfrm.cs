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
    public partial class AddCategoryfrm : Addsamplefrm
    {
        public AddCategoryfrm()
        {
            InitializeComponent();
        }

        private void AddCategoryfrm_Load(object sender, EventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }
        public int id = 0;
        public override void btnsave_Click(object sender, EventArgs e)
        {
            string qr = "";
            if(id==0)
            {
                qr = "sp_AddCate";
            }
            else
            {
                qr = "sp_UpdateCate";
            }

            Hashtable ht = new Hashtable();
            ht.Add("@cateId", id);
            ht.Add("@cateName",txtName.Text);

            if (MainClass.SQL(qr, ht) > 0)
            {
                MessageBox.Show("Saved Successfully", "Management system", MessageBoxButtons.OK, MessageBoxIcon.Information);
                id = 0;txtName.Clear();
                txtName.Focus();
            }
        }
    }
}
