using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApp1
{
    public partial class frm_enfant : Form
    {
        public frm_enfant()
        {
            InitializeComponent();
            jour.DropDownHeight = 200;
            mois.DropDownHeight = 200;
            annee.DropDownHeight = 200;
            

        }

        private void Enfant_Load(object sender, EventArgs e)
        {
            string sqlb = @"select nom_enfant from Enfant where num_client='" + int.Parse(txt_num.Text) + "'";
            if (Sql.Con.State == ConnectionState.Open)
                Sql.Con.Close();
            Sql.Con.ConnectionString = Sql.ParamConnectionString;
            Sql.Con.Open();
            SqlCommand cmdb = new SqlCommand(sqlb, Sql.Con);
            SqlDataReader dr = cmdb.ExecuteReader();
            AutoCompleteStringCollection names = new AutoCompleteStringCollection();
            while (dr.Read())
            {
                names.Add(dr.GetString(0));
            }
            txt_enfant.AutoCompleteCustomSource = names;
            Sql.Con.Close();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void button_WOC28_Click(object sender, EventArgs e)
        {
            SendKeys.Send(" ");
        }

        private void button_1_Click(object sender, EventArgs e)
        {
            Button btn = (Button)sender;
            this.txt_enfant.Focus();
            SendKeys.Send(btn.Text);
        }
        TextBox SelectedTextBox = null;
        private void button_num_Click(object sender, EventArgs e)
        {
            if (SelectedTextBox != null)
            {
                SelectedTextBox.Text = this.Text;
            }
        }

        private void pictureBox4_Click(object sender, EventArgs e)
        {
            this.Close();
            frm_bracelet fb = new frm_bracelet();
            fb.Show();
        }
        Random rand = new Random();
        int otp;
        private void valider_Click(object sender, EventArgs e)
        {
            Alert al = new Alert();
            frm_jeux fj = new frm_jeux();
            frm_jeux__1_ fj1 = new frm_jeux__1_();
            var local = DateTime.Now;
            var utc = local.ToUniversalTime();
            otp = rand.Next(10000000, 1000000000);
            txt_barcode.Text = otp.ToString();
            if (String.IsNullOrEmpty(txt_enfant.Text) || String.IsNullOrEmpty(jour.Text) || String.IsNullOrEmpty(mois.Text) || String.IsNullOrEmpty(annee.Text))
            {
                al.Show();
            }
            else
            {
                date_nais.Text = int.Parse(jour.Text) + "/" + int.Parse(mois.Text) + "/" + int.Parse(annee.Text);
            }
            
            string sqlb1 = @"insert into Enfant values(@code_bracelet,@nom_enfant,@date_nais,@sms,@taille,@montant_jeux,@num_client,@Date_creation)";
            if (Sql.Con.State == ConnectionState.Open)
                Sql.Con.Close();
            Sql.Con.ConnectionString = Sql.ParamConnectionString;
            Sql.Con.Open();
            SqlCommand cmdb1 = new SqlCommand(sqlb1, Sql.Con);
            cmdb1.Parameters.AddWithValue("@code_bracelet", int.Parse(txt_barcode.Text));
            cmdb1.Parameters.AddWithValue("@nom_enfant", txt_enfant.Text);
            cmdb1.Parameters.AddWithValue("@date_nais", date_nais.Text);
            cmdb1.Parameters.AddWithValue("@sms", 1);
            cmdb1.Parameters.AddWithValue("@taille", taille.Text);
            cmdb1.Parameters.AddWithValue("@montant_jeux", 0.0);
            cmdb1.Parameters.AddWithValue("@num_client", int.Parse(txt_num.Text));
            cmdb1.Parameters.AddWithValue("@Date_creation", utc.ToLocalTime());
            cmdb1.ExecuteNonQuery();
            Sql.Con.Close();
            ((TextBox)fj.Controls["text_enfant"]).Text = txt_enfant.Text;
            
            ((TextBox)fj1.Controls["text_enfant"]).Text = txt_enfant.Text;
           // ((TabControl)fj.Controls["tabPage6"]).Name = txt_enfant.Text;
            this.Hide();
            //if (taille.Text == "+1 métre")
            //{
                fj.Show();
           // }
           // else
           // {
           //     fj1.Show();
          //  }
                

        }

        private void pictureBox2_Click(object sender, EventArgs e)
        {
            SendKeys.Send("{BKSP}");
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {

        }

        private void txt_enfant_TextChanged(object sender, EventArgs e)
        {
            string sqlb = @"select * from Enfant where nom_enfant ='" + txt_enfant.Text + "'";
            if (Sql.Con.State == ConnectionState.Open)
                Sql.Con.Close();
            Sql.Con.ConnectionString = Sql.ParamConnectionString;
            Sql.Con.Open();
            SqlCommand cmdb = new SqlCommand(sqlb, Sql.Con);
            cmdb.ExecuteNonQuery();
            DataTable dt = new DataTable();
            SqlDataAdapter da = new SqlDataAdapter(cmdb);
            da.Fill(dt);
            foreach (DataRow dr in dt.Rows)
            {
                txt_barcode.Text = dr["code_bracelet"].ToString();
                date_nais.Text = dr["date_nais"].ToString();
                taille.Text = dr["taille"].ToString();
                txt_num.Text = dr["num_client"].ToString();
            }
            
            string strDate = date_nais.Text; 

            string[] arrDate = strDate.Split('-');

            annee.Text = arrDate[0];
           // mois.Text = arrDate[1];
            //jour.Text = arrDate[2];
            
            




            Sql.Con.Close();
        }

        private void taille_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
