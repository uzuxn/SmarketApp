using SmarketApp.Model;
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

namespace SmarketApp.View
{
    public partial class ViewStafffrm : Viewsamplefrm
    {
        public ViewStafffrm()
        {
            InitializeComponent();
        }

        public void GetData()
        {
            string qr = @"select StaffId,SName,SPhone,SRole from tblStaff where SName like '%" + txtsearch.Text + "%' ";
            ListBox lb = new ListBox();
            lb.Items.Add(dgvId);
            lb.Items.Add(dgvName);
            lb.Items.Add(dgvPhone);
            lb.Items.Add(dgvRole);
            MainClass.LoadData(qr, dataGridView1, lb);
        }

        private void ViewStafffrm_Load(object sender, EventArgs e)
        {
            GetData();
        }
        public override void btnadd_Click(object sender, EventArgs e)
        {
            //AddCategoryfrm frm = new AddCategoryfrm();
            //frm.ShowDialog();
            MainClass.BlurBackground(new AddStafffrm());
            GetData();
        }

        public override void txtsearch_TextChanged(object sender, EventArgs e)
        {
            GetData();
        }

        private void dataGridView1_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (dataGridView1.CurrentCell.OwningColumn.Name == "dgvEdit")
            {
                AddStafffrm frm = new AddStafffrm();
                frm.id = Convert.ToInt32(dataGridView1.CurrentRow.Cells["dgvId"].Value);
                frm.txtName.Text = Convert.ToString(dataGridView1.CurrentRow.Cells["dgvName"].Value);
                frm.txtMobile.Text = Convert.ToString(dataGridView1.CurrentRow.Cells["dgvPhone"].Value);
                frm.cmbRole.Text = Convert.ToString(dataGridView1.CurrentRow.Cells["dgvRole"].Value);
                //frm.ShowDialog();
                MainClass.BlurBackground(frm);
                GetData();
            }
            if (dataGridView1.CurrentCell.OwningColumn.Name == "dgvDelete")
            {
                if (DialogResult.Yes == MessageBox.Show("Do You Want To Delete? ", "Confirm ", MessageBoxButtons.YesNo, MessageBoxIcon.Warning))
                {

                    int id = Convert.ToInt32(dataGridView1.CurrentRow.Cells["dgvId"].Value);
                    string qr = "sp_DeleteStaff";
                    Hashtable ht = new Hashtable();
                    ht.Add("@StaffId", id);
                    if (MainClass.SQL(qr, ht) > 0)
                    {
                        MessageBox.Show("Deleted Successfully", "Management system", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        GetData();
                    }
                    else
                    {
                        MessageBox.Show("Deletion Failed", "Error ", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    }

                }

            }
        }
    }
}
