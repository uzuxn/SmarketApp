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
    public partial class Vieworederfrm : Viewsamplefrm
    {
        public Vieworederfrm()
        {
            InitializeComponent();
        }

        private void Vieworederfrm_Load(object sender, EventArgs e)
        {
            GetData();
        }
        public void GetData()
        {
            string qr = @"select OrdId,OrdName from tblOrders where OrdName like '%" + txtsearch.Text + "%' ";
            ListBox lb = new ListBox();
            lb.Items.Add(dgvId);
            lb.Items.Add(dgvName);

            MainClass.LoadData(qr, dataGridView1, lb);
        }
        public override void btnadd_Click(object sender, EventArgs e)
        {
            //AddOrderfrm frm = new AddOrderfrm();
            //frm.ShowDialog();
            MainClass.BlurBackground(new AddOrderfrm()); 
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
                AddOrderfrm frm = new AddOrderfrm();
                frm.id = Convert.ToInt32(dataGridView1.CurrentRow.Cells["dgvId"].Value);
                frm.txtName.Text = Convert.ToString(dataGridView1.CurrentRow.Cells["dgvName"].Value);
                //frm.ShowDialog();
                MainClass.BlurBackground(frm);
                GetData();
            }
            if (dataGridView1.CurrentCell.OwningColumn.Name == "dgvDelete")
            {
                if (DialogResult.Yes == MessageBox.Show("Do You Want To Delete? ", "Confirm ", MessageBoxButtons.YesNo, MessageBoxIcon.Warning))
                {

                    int id = Convert.ToInt32(dataGridView1.CurrentRow.Cells["dgvId"].Value);
                    string qr = "sp_DeleteOrd";
                    Hashtable ht = new Hashtable();
                    ht.Add("@OrdId", id);
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
