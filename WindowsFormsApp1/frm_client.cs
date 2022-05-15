using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;

namespace WindowsFormsApp1
{
    public partial class frm_client : Form
    {
        public frm_client()
        {
            InitializeComponent();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void button_1_Click(object sender, EventArgs e)
        {
            Button btn = (Button)sender;
            this.txt_nom.Focus();
            SendKeys.Send(btn.Text);
        }

        private void pictureBox2_Click(object sender, EventArgs e)
        {
            SendKeys.Send("{BKSP}");
        }

        private void txt_nom_TextChanged(object sender, EventArgs e)
        {

        }

        private void pictureBox4_Click(object sender, EventArgs e)
        {
            frm_login f1 = new frm_login();
            this.Close();
            f1.Show();
        }

        private void pictureBox3_Click(object sender, EventArgs e)
        {
            this.Close();
            frm_video f2 = new frm_video();
            f2.Show();
        }

        private void button_WOC26_Click(object sender, EventArgs e)
        {
            this.Hide();
            frm_video f2 = new frm_video();
            f2.Show();
        }

        private void button_WOC27_Click(object sender, EventArgs e)
        {
            frm_pwd fv = new frm_pwd();
            frm_client nc = new frm_client();
            frm_login f1 = new frm_login();
            menu m = new menu();
            
            if (Sql.Con.State == ConnectionState.Open)
                Sql.Con.Close();
            Sql.Con.ConnectionString = Sql.ParamConnectionString;
            Sql.Con.Open();
            if (String.IsNullOrEmpty(txt_nom.Text))
            {
                MessageBox.Show("veuiller saisir votre nom");

            }
            else
            {
                string sqlb1 = @"Update Client set nom_client= @nom_client where code_secret='" + int.Parse(txt_code.Text) + "' ";
                SqlCommand cmdb1 = new SqlCommand(sqlb1, Sql.Con);
                //Sql.Conn.Open();
                cmdb1.Parameters.AddWithValue("@nom_client", txt_nom.Text);
                cmdb1.ExecuteNonQuery();
                Sql.Con.Close();
                ((TextBox)m.Controls["txt_num"]).Text = txt_num.Text;
                this.Hide();
                m.Show();
            }
          
         
        }

        private void frm_client_Load(object sender, EventArgs e)
        {

        }
    }
}
