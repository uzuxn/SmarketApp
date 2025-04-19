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
    public partial class AddStafffrm : Addsamplefrm
    {
        public AddStafffrm()
        {
            InitializeComponent();
        }

        public int id = 0;
        private void AddStafffrm_Load(object sender, EventArgs e)
        {

        }
        public override void btnsave_Click(object sender, EventArgs e)
        {
            string qr = "";
            if (id == 0)
            {
                qr = "sp_AddStaff";
            }
            else
            {
                qr = "sp_UpdateStaff";
            }

            Hashtable ht = new Hashtable();
            ht.Add("@StaffId", id);
            ht.Add("@SName", txtName.Text);
            ht.Add("@SPhone", txtMobile.Text);
            ht.Add("@SRole", cmbRole.Text);

            if (MainClass.SQL(qr, ht) > 0)
            {
                MessageBox.Show("Saved Successfully", "Management system", MessageBoxButtons.OK, MessageBoxIcon.Information);
                id = 0; txtName.Clear();
                txtMobile.Clear();
                cmbRole.SelectedIndex = -1;
                txtName.Focus();
            }
        }

        private void btnclose_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
