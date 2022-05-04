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
    public partial class frm_trans : Form
    {
        public frm_trans()
        {
            InitializeComponent();
        }

        private void pictureBox4_Click(object sender, EventArgs e)
        {
            this.Close();
            frm_recharge frc = new frm_recharge();
            frc.Show();
        }

        private void frm_trans_Load(object sender, EventArgs e)
        {

        }
        Control ActiveControl;
        private void button_WOC29_Click(object sender, EventArgs e)
        {
            Button btn = (Button)sender;
            ActiveControl.Focus();
            SendKeys.Send(btn.Text);
        }

        private void txt_login_Enter(object sender, EventArgs e)
        {
           /* Button btn = (Button)sender;
            this.txt_login.Focus();
            SendKeys.Send(btn.Text);*/
        }

        private void txt_montant_Enter(object sender, EventArgs e)
        {
            ActiveControl = (Control)sender;
        }
    }
}
