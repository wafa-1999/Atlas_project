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
    public partial class frm_recharge : Form
    {
        public frm_recharge()
        {
            InitializeComponent();
        }

        private void btn_ticket_Click(object sender, EventArgs e)
        {
            frm_insert fi = new frm_insert();
            this.Hide();
            fi.Show();

        }

        private void btn_carte_Click(object sender, EventArgs e)
        {
            frm_trans ft = new frm_trans();
            this.Hide();
            ft.Show();

        }

        private void pictureBox4_Click(object sender, EventArgs e)
        {
            menu m = new menu();
            this.Hide();
            m.Show();
        }
    }
}
