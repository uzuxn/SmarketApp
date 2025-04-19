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
    public partial class ViewProductfrm : Viewsamplefrm
    {
        public ViewProductfrm()
        {
            InitializeComponent();
        }

        private void ViewProductfrm_Load(object sender, EventArgs e)
        {

        }
        public void GetData()
        {
            string qr = @"select p.PId,p.PName,p.PPrice,c.cateName,p.CategoryId,p.PImage from tblProducts p inner join tblCategory c on c.cateId=p.CategoryId where p.PName like '%" + txtsearch.Text + "%' ";
            ListBox lb = new ListBox();
            lb.Items.Add(dgvid);
            lb.Items.Add(dgvname);
            lb.Items.Add(dgvprice);
            lb.Items.Add(dgvcateid);
            lb.Items.Add(dgvcate);
            MainClass.LoadData(qr, dataGridView1, lb);
        }
        public override void btnadd_Click(object sender, EventArgs e)
        {
            //AddCategoryfrm frm = new AddCategoryfrm();
            //frm.ShowDialog();
            MainClass.BlurBackground(new AddProductfrm());
            GetData();
        }

        public override void txtsearch_TextChanged(object sender, EventArgs e)
        {
            GetData();
        }

        private void dataGridView1_CellClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void dataGridView1_CellClick_1(object sender, DataGridViewCellEventArgs e)
        {

        }
    }
}
