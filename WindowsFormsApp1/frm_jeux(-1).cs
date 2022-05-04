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
using System.IO;

namespace WindowsFormsApp1
{
    public partial class frm_jeux__1_ : Form
    {
        public frm_jeux__1_()
        {
            InitializeComponent();
        }

        private void frm_jeux__1__Load(object sender, EventArgs e)
        {
            string sqlb1 = @"select image_jeux,nom_jeux,prix from jeux where nbre_jeux = 1 and taille_enfant = 'moins'";
            if (Sql.Con.State == ConnectionState.Open)
                Sql.Con.Close();
            Sql.Con.ConnectionString = Sql.ParamConnectionString;
            Sql.Con.Open();
            SqlCommand cmdb1 = new SqlCommand(sqlb1, Sql.Con);
            SqlDataReader dr = cmdb1.ExecuteReader();
            while (dr.Read())
            {
                long len = dr.GetBytes(0, 0, null, 0, 0);
                byte[] array = new byte[System.Convert.ToInt32(len) + 1];
                dr.GetBytes(0, 0, array, 0, System.Convert.ToInt32(len));
                var pic = new PictureBox();
                pic.Width = 120;
                pic.Height = 120;
                pic.Location = new Point(100, 80);

                pic.BackgroundImageLayout = ImageLayout.Stretch;


                var prix = new Label();
                prix.Text = dr["prix"].ToString();
                prix.Width = 50;
                prix.BackColor = Color.FromArgb(46, 134, 222);
                prix.TextAlign = ContentAlignment.MiddleCenter;



                Label nom = new Label();
                nom.Text = dr["nom_jeux"].ToString();
                nom.BackColor = Color.FromArgb(46, 134, 222);
                nom.TextAlign = ContentAlignment.MiddleCenter;
                nom.Dock = DockStyle.Bottom;




                MemoryStream ms = new MemoryStream(array);
                Bitmap bitmap = new Bitmap(ms);
                pic.BackgroundImage = bitmap;
                pic.Controls.Add(nom);
                pic.Controls.Add(prix);
                lbl_enfant.Text = text_enfant.Text;
                flowLayoutPanel1.Controls.Add(pic);

            }
            Sql.Con.Close();


            string sqlb2 = @"select image_jeux,nom_jeux,prix from jeux where nbre_jeux = 2 and taille_enfant = 'moins'";
            if (Sql.Con.State == ConnectionState.Open)
                Sql.Con.Close();
            Sql.Con.ConnectionString = Sql.ParamConnectionString;
            Sql.Con.Open();
            SqlCommand cmdb2 = new SqlCommand(sqlb2, Sql.Con);
            SqlDataReader dr1 = cmdb2.ExecuteReader();
            while (dr1.Read())
            {
                long len = dr1.GetBytes(0, 0, null, 0, 0);
                byte[] array = new byte[System.Convert.ToInt32(len) + 1];
                dr1.GetBytes(0, 0, array, 0, System.Convert.ToInt32(len));
                PictureBox pic1 = new PictureBox();
                pic1.Width = 120;
                pic1.Height = 100;

                pic1.Location = new Point(100, 80);


                pic1.BackgroundImageLayout = ImageLayout.Stretch;




                Label prix = new Label();
                prix.Text = dr1["prix"].ToString();
                prix.Width = 50;
                prix.BackColor = Color.FromArgb(46, 134, 222);
                prix.TextAlign = ContentAlignment.MiddleCenter;


                Label nom = new Label();
                nom.Text = dr1["nom_jeux"].ToString();
                nom.BackColor = Color.FromArgb(46, 134, 222);
                nom.TextAlign = ContentAlignment.MiddleCenter;
                nom.Dock = DockStyle.Bottom;




                MemoryStream ms = new MemoryStream(array);
                Bitmap bitmap = new Bitmap(ms);
                pic1.BackgroundImage = bitmap;
                pic1.Controls.Add(nom);
                pic1.Controls.Add(prix);
                flowLayoutPanel2.Controls.Add(pic1);
            }
            Sql.Con.Close();

            string sqlb3 = @"select image_jeux,nom_jeux,prix from jeux where nbre_jeux = 3 and taille_enfant = 'moins'";
            if (Sql.Con.State == ConnectionState.Open)
                Sql.Con.Close();
            Sql.Con.ConnectionString = Sql.ParamConnectionString;
            Sql.Con.Open();
            SqlCommand cmdb3 = new SqlCommand(sqlb3, Sql.Con);
            SqlDataReader dr2 = cmdb3.ExecuteReader();

            while (dr2.Read())
            {
                long len = dr2.GetBytes(0, 0, null, 0, 0);
                byte[] array = new byte[System.Convert.ToInt32(len) + 1];
                dr2.GetBytes(0, 0, array, 0, System.Convert.ToInt32(len));
                PictureBox pic3 = new PictureBox();
                pic3.Width = 120;
                pic3.Height = 100;


                pic3.BackgroundImageLayout = ImageLayout.Stretch;


                Label prix = new Label();
                prix.Text = dr2["prix"].ToString();
                prix.Width = 100;
                prix.BackColor = Color.FromArgb(46, 134, 222);
                prix.TextAlign = ContentAlignment.MiddleCenter;


                Label nom = new Label();
                nom.Text = dr2["nom_jeux"].ToString();
                nom.BackColor = Color.FromArgb(46, 134, 222);
                nom.TextAlign = ContentAlignment.MiddleCenter;
                nom.Dock = DockStyle.Bottom;




                MemoryStream ms = new MemoryStream(array);
                Bitmap bitmap = new Bitmap(ms);
                pic3.BackgroundImage = bitmap;
                pic3.Controls.Add(nom);
                pic3.Controls.Add(prix);
                flowLayoutPanel3.Controls.Add(pic3);
            }
            Sql.Con.Close();
        }
    }
}
