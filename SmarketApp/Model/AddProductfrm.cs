using System;
using System.Collections;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace SmarketApp.Model
{
    public partial class AddProductfrm : Addsamplefrm
    {
        public AddProductfrm()
        {
            InitializeComponent();
        }
        public int id = 0;
        public int cid = 0;
        private void AddProductfrm_Load(object sender, EventArgs e)
        {
            string qr = "select cateId as id,cateName as name from tblCategory";
            MainClass.CBFill(qr,cmbCate);
            if(cid>0)
            {
                cmbCate.SelectedValue = cid;
            }
            if(cid>0)
            {
                ForUpdateLoadData();
            }
        }
        string filepath;
        Byte[] imagebytearr;
        private void btnbrowseimg_Click(object sender, EventArgs e)
        {
            OpenFileDialog ofd = new OpenFileDialog();
            ofd.Filter = "Images(.jpeg,.jpg,.png)|* .png;* .jpg;* .jpeg";
            if(ofd.ShowDialog()== DialogResult.OK )
            {
                filepath = ofd.FileName;
                txtImg.Image = new Bitmap(filepath);

            }
        }
        public override void btnsave_Click(object sender, EventArgs e)
        {
            string qr = "";
            if (id == 0)
            {
                qr = "sp_AddProduct";
            }
            else
            {
                qr = "sp_UpdateProduct";
            }

            Image temp = new Bitmap(txtImg.Image);
            MemoryStream ms  = new MemoryStream();
            temp.Save(ms, System.Drawing.Imaging.ImageFormat.Png);
            imagebytearr=ms.ToArray();

            Hashtable ht = new Hashtable();
            ht.Add("@pid", id);
            ht.Add("@pname", txtName.Text);
            ht.Add("@pprice", Convert.ToDouble(txtPrice.Text));
            ht.Add("@categoryid", Convert.ToInt32(cmbCate.SelectedValue));
            ht.Add("@pimage", imagebytearr);

            if (MainClass.SQL(qr, ht) > 0)
            {
                MessageBox.Show("Saved Successfully", "Management system", MessageBoxButtons.OK, MessageBoxIcon.Information);
                id = 0;
                cid = 0;
                txtName.Clear();
                txtPrice.Clear();
                cmbCate.SelectedIndex = -1;

                txtName.Focus();
            }
        }

        private void ForUpdateLoadData()
        {
            SqlCommand cmd = new SqlCommand("select * from tblProducts where PId="+id+"", MainClass.con);
            SqlDataAdapter da   = new SqlDataAdapter(cmd);  
            DataTable dt = new DataTable();
            da.Fill(dt);
            if(dt.Rows.Count > 0)
            {
                txtName.Text = dt.Rows[0]["PName"].ToString();
                txtName.Text = dt.Rows[0]["PPrice"].ToString();
                Byte[] imageArray = (byte[])(dt.Rows[0]["PImage"]);
                byte[] imagebyteArr = imageArray;
                txtImg.Image = Image.FromStream(new MemoryStream(imageArray));
            }
        }

        private void btnclose_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
