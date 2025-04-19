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
    public partial class loginfrm : Form
    {
        public loginfrm()
        {
            InitializeComponent();
        }

        private void loginfrm_Load(object sender, EventArgs e)
        {

        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void label5_Click(object sender, EventArgs e)
        {

        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e)
        {
            //this.Close();
            Application.Exit();
        }

        private void btnlogin_Click(object sender, EventArgs e)
        {
            try
            {
                if (MainClass.IsValidUser(txtUname.Text.Trim(), txtPword.Text.Trim()) == false)
                {
                    MessageBox.Show("Login failed...Invalid Username or Password","Management system",MessageBoxButtons.OK,MessageBoxIcon.Warning);
                    return;
                }
                else
                {
                    //MessageBox.Show("Login Sauccessfullly");
                    this.Hide();
                    Mainfrm frm = new Mainfrm();
                    frm.Show();
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void panel2_Paint(object sender, PaintEventArgs e)
        {

        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {

        }

        private void Uname_Click(object sender, EventArgs e)
        {

        }

        private void Pword_Click(object sender, EventArgs e)
        {

        }

        private void txtUname_TextChanged(object sender, EventArgs e)
        {

        }

        private void label4_Click(object sender, EventArgs e)
        {

        }
    }
}
