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
using System.Net.Mail;
using System.Drawing.Drawing2D;
using System.Data.SqlClient;
using static WindowsFormsApp1.Sql;

namespace WindowsFormsApp1
{
    public partial class frm_login : Form
    {
        frm_pwd frm;
        public frm_login()
        {
            InitializeComponent();
            frm = new frm_pwd();
        }
        Control ActiveControl;
        private void button_1_Click(object sender, EventArgs e)
        {
            Button btn = (Button)sender;
            ActiveControl.Focus();
            SendKeys.Send(btn.Text);
        }

        private void txt_num_Enter(object sender, EventArgs e)
        {
            ActiveControl = (Control)sender;
        }

        private void button_clear_Click(object sender, EventArgs e)
        {
            txt_num.Clear();
        }

        private void button1_Click_1(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void button_x_Click_1(object sender, EventArgs e)
        {
            string str = txt_num.Text.Trim();
            int longueur = str.Length;

            txt_num.Text = str.Remove(longueur - 1);
        }

        Random rand = new Random();
        int otp;

        private void button_WOC13_Click(object sender, EventArgs e)
        {
            frm_pwd fv = new frm_pwd();
            frm_client nc = new frm_client();
            frm_login f1 = new frm_login();
            frm_enfant fe = new frm_enfant();
            var local = DateTime.Now;
            var utc = local.ToUniversalTime();


            otp = rand.Next(1000, 10000);
            txt_code.Text = otp.ToString();
            if (String.IsNullOrEmpty(txt_num.Text))
            {
                Alert1 a1 = new Alert1();
                a1.Show();
            }
            else if (txt_num.Text.Length < 8 || txt_num.Text.Length > 8)
            {
                Alert a = new Alert();
                a.Show();
            }
            else {
                string sqlb = @"select code_secret,nom_client from Client where num_client='" + int.Parse(txt_num.Text) + "'";
                if (Sql.Con.State == ConnectionState.Open)
                    Sql.Con.Close();
                Sql.Con.ConnectionString = Sql.ParamConnectionString;
                Sql.Con.Open();
                SqlCommand cmdb = new SqlCommand(sqlb, Sql.Con);
                SqlDataReader dr = cmdb.ExecuteReader();
                if (dr.Read())
                {
                    code_exist.Text = dr["code_secret"].ToString();
                    nom.Text = dr["nom_client"].ToString();
                    ((TextBox)fv.Controls["code_exist"]).Text = code_exist.Text;
                    ((TextBox)fv.Controls["txt_num"]).Text = txt_num.Text;
                    fv.Show();

                }

                else
                {

                    string sqlb1 = @"insert into Client values(@num_client,@code_secret,@nom_client,@solde,@Date_create)";
                    if (Sql.Con.State == ConnectionState.Open)
                        Sql.Con.Close();
                    Sql.Con.ConnectionString = Sql.ParamConnectionString;
                    Sql.Con.Open();
                    SqlCommand cmdb1 = new SqlCommand(sqlb1, Sql.Con);
                    cmdb1.Parameters.AddWithValue("@num_client", int.Parse(txt_num.Text));
                    cmdb1.Parameters.AddWithValue("@code_secret", int.Parse(txt_code.Text));
                    cmdb1.Parameters.AddWithValue("@nom_client", " ");
                    cmdb1.Parameters.AddWithValue("@solde", 0.0);
                    cmdb1.Parameters.AddWithValue("@Date_create", utc.ToLocalTime());
                    cmdb1.ExecuteNonQuery();
                    Sql.Con.Close();
                    ((TextBox)fv.Controls["txt_code"]).Text = txt_code.Text;
                    ((TextBox)fv.Controls["txt_num"]).Text = txt_num.Text;

                    fv.Show();
                }
            }
        }
            /*
                if (Sql.Con.State == ConnectionState.Open)
                Sql.Con.Close();
            Sql.Con.ConnectionString = Sql.ParamConnectionString;
            Sql.Con.Open();
         

            if (String.IsNullOrEmpty(txt_num.Text))
            {
                Alert1 a1 = new Alert1();
                a1.Show();
            }
            else if (txt_num.Text.Length < 8 || txt_num.Text.Length > 8)
            {
                Alert a = new Alert();
                a.Show();
            }
            else
            {

                string sqlb1 = @"insert into Client values(@num_client,@code_secret,@nom_client,@solde,@Date_create)";
                SqlCommand cmdb1 = new SqlCommand(sqlb1, Sql.Con);
                cmdb1.Parameters.AddWithValue("@num_client", int.Parse(txt_num.Text));
                cmdb1.Parameters.AddWithValue("@code_secret", int.Parse(txt_code.Text));
                cmdb1.Parameters.AddWithValue("@nom_client", " ");
                cmdb1.Parameters.AddWithValue("@solde", 0.0);
                cmdb1.Parameters.AddWithValue("@Date_create", utc.ToLocalTime());
                cmdb1.ExecuteNonQuery();
                
                ((TextBox)fv.Controls["txt_code"]).Text = txt_code.Text;

                fv.Show();


                string sqlb = @"select * from Client where num_client='" + int.Parse(txt_num.Text) + "'";
                SqlCommand cmdb = new SqlCommand(sqlb, Sql.Con);
                SqlDataReader dr = cmdb.ExecuteReader();
                DataTable dt = new DataTable();
                dt.Load(dr);
                if (dt.Rows.Count > 0)
                {
                    ((TextBox)fv.Controls["txt_num"]).Text = txt_num.Text;
                    txt_code.Hide();
                    frm_pwd fp = new frm_pwd(txt_num.Text);
                    fv.Show();
                }
                else
                {
                    Alert a = new Alert();
                    a.Show();
                }
                Sql.Con.Close();
            }
            */
        
        private void txt_num_TextChanged(object sender, EventArgs e)
        {

        }

        private void pictureBox2_Click(object sender, EventArgs e)
        {
            SendKeys.Send("{BKSP}");
        }

        private void annuler_Click(object sender, EventArgs e)
        {
            this.Hide();
            frm_video f2 = new frm_video();
            f2.Show();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void txt_code_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox1_TextChanged_1(object sender, EventArgs e)
        {

        }
    }
}
