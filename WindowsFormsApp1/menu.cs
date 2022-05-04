using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApp1
{
    public partial class menu : Form
    {
        public menu()
        {
            InitializeComponent();
        }

        private void menu_Load(object sender, EventArgs e)
        {
            
        }

        private void btn_bracelet_Click(object sender, EventArgs e)
        {
            frm_bracelet br = new frm_bracelet();
            ((TextBox)br.Controls["txt_num"]).Text = txt_num.Text;
            this.Hide();
            br.Show();
        }

        private void btn_credit_Click(object sender, EventArgs e)
        {
            frm_solde fs = new frm_solde();
            this.Hide();
            fs.Show(); 
        }

        private void btn_recharge_Click(object sender, EventArgs e)
        {
            frm_recharge fr = new frm_recharge();
            frm_recharge frc = new frm_recharge();
            ((TextBox)fr.Controls["txt_num"]).Text = txt_num.Text;
            this.Hide();
            frc.Show();

        }

        private void pictureBox3_Click(object sender, EventArgs e)
        {
            frm_login f1 = new frm_login();
            this.Close();
            f1.Show();
        }

        private void pictureBox2_Click(object sender, EventArgs e)
        {
            this.Close();
            frm_video f2 = new frm_video();
            f2.Show();

        }
    }
}
