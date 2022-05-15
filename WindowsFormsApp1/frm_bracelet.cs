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
    public partial class frm_bracelet : Form
    {
        public frm_bracelet()
        {
            InitializeComponent();

            btn_moins.Click += new System.EventHandler(btn_bracelet_Click);
            btn_plus.Click += new System.EventHandler(btn_bracelet_Click);
        }

        private void btn_bracelet_Click(object sender, EventArgs e)
        {
            frm_enfant fe = new frm_enfant();
            ((TextBox)fe.Controls["txt_num"]).Text = txt_num.Text;
            taille.Text = (sender as Button).Text;
            ((TextBox)fe.Controls["taille"]).Text = taille.Text;
           
            this.Hide();
            fe.Show();

        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {

        }

        private void frm_bracelet_Load(object sender, EventArgs e)
        {

        }
    }
}
