using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Net;
using System.Data.SqlClient;

namespace WindowsFormsApp1
    
{
    public partial class frm_pwd : Form
    {
        
        public frm_pwd()
        {
            InitializeComponent();
            
           
        }

        public frm_pwd(string text)
        {
            Text = text;
        }

        private void pictureBox2_Click(object sender, EventArgs e)
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

        public void text_code_TextChanged(object sender, EventArgs e)
        {

        }

        Control ActiveControl;
        private void button_WOC1_Click(object sender, EventArgs e)
        {
       
            Button btn = (Button)sender;
            this.text_code.Focus();
            SendKeys.Send(btn.Text);
        }

        public void text_code_Enter(object sender, EventArgs e)
        {
            ActiveControl = (Control)sender;
        }

        private void pictureBox4_Click(object sender, EventArgs e)
        {
            SendKeys.Send("{BKSP}");
        }

        private void button_WOC11_Click(object sender, EventArgs e)
        {
            this.Hide();
            frm_video f2 = new frm_video();
            f2.Show();
        }
        int a, b, c;
        
        private void button_WOC10_Click(object sender, EventArgs e)
        {
            frm_client nc = new frm_client();
            
            menu m = new menu();
            Alert al = new Alert();
            ((TextBox)nc.Controls["txt_code"]).Text = txt_code.Text;
            
            int.TryParse(text_code.Text, out a);
            int.TryParse(txt_code.Text, out b);
            int.TryParse(code_exist.Text, out c);
            if (String.IsNullOrEmpty(text_code.Text))
            {
                al.Show();
            }
            else if (a == b)
            {
                ((TextBox)nc.Controls["txt_num"]).Text = txt_num.Text;
                code_exist.Visible = false;
                this.Hide();
                nc.Show();
            }

            else if (a == c)
            {
                ((TextBox)m.Controls["txt_num"]).Text = txt_num.Text;
                txt_code.Visible = false;
                this.Hide();
                m.Show();
            }
            else
                MessageBox.Show("code incorrrrrecte");






        }

        private void txt_code_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void verif_Load(object sender, EventArgs e)
        {

        }
    }
}
