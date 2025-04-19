
using SmarketApp.Model;
using SmarketApp.View;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace SmarketApp
{
    public partial class Mainfrm : Form
    {
        public Mainfrm()
        {
            InitializeComponent();
        }

        static Mainfrm obj;
        public static Mainfrm instance
        {
            get { if (obj == null) { obj = new Mainfrm(); } return obj; }
        }

        public void Addcontrols(Form f)
        {
            panel8.Controls.Clear();
            f.Dock = DockStyle.Fill; ;
            f.TopLevel = false;
            panel8.Controls.Add(f);
            f.Show();
        }

        private void Mainfrm_Load(object sender, EventArgs e)
        {
            //AboutBox abt = new AboutBox();
           // abt.Show();
            lblShowUsername.Text = MainClass.USER;
            obj = this;
        }

        private void btnclose_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void btnmax_Click(object sender, EventArgs e)
        {
            if (this.WindowState != FormWindowState.Maximized)
                this.WindowState = FormWindowState.Maximized;
            else
                this.WindowState = FormWindowState.Normal;

        }

        private void btnmin_Click(object sender, EventArgs e)
        {
            WindowState = FormWindowState.Minimized;
        }

        private void panel8_Paint(object sender, PaintEventArgs e)
        {

        }

        private void btnhome_Click(object sender, EventArgs e)
        {
            Addcontrols(new Homefrm());
        }

        private void btncategory_Click(object sender, EventArgs e)
        {
            Addcontrols(new ViewCategoryfrm());
        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void btnpos_Click(object sender, EventArgs e)
        {
            Addcontrols(new Vieworederfrm());
        }

        private void btnstaff_Click(object sender, EventArgs e)
        {
            Addcontrols(new ViewStafffrm());
        }

        private void btnproduct_Click(object sender, EventArgs e)
        {
            Addcontrols(new ViewProductfrm());
        }

        private void btnabout_Click(object sender, EventArgs e)
        {
            //Addcontrols(new POSfrm());
           // POSfrm frm = new POSfrm();
            //frm.Show();
        }

        private void btnPOS_Click_1(object sender, EventArgs e)
        {
           // Addcontrols(new POSfrm());
            //POSfrm frm = new POSfrm();
            //rm.Show();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Addcontrols(new POSfrm());
            POSfrm frm = new POSfrm();
            frm.Show();
        }
    }
}
