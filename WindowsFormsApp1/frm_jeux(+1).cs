using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;
using System.Windows.Forms;
using System.IO;

namespace WindowsFormsApp1
{
    public partial class frm_jeux : Form
    {
        public frm_jeux()
        {
            InitializeComponent();

        }



        private void frm_jeux_Load(object sender, EventArgs e)
        {
            string sqlb1 = @"select pathImage, nom_jeux, prix from jeux where nbre_jeux = 1 ";
            if (Sql.Con.State == ConnectionState.Open)
                Sql.Con.Close();
            Sql.Con.ConnectionString = Sql.ParamConnectionString;
            Sql.Con.Open();
            SqlCommand cmdb1 = new SqlCommand(sqlb1, Sql.Con);
            SqlDataAdapter da = new SqlDataAdapter(cmdb1);
            DataTable dt = new DataTable();
            da.Fill(dt);
            dt.Columns.Add("Pic", Type.GetType("System.Byte[]"));
            foreach (DataRow drow in dt.Rows)
            {
                drow["Pic"] = File.ReadAllBytes(drow["pathImage"].ToString());
            }
            pack1.DataSource = dt;
            
            Sql.Con.Close();

            /*

            string sqlb1 = @"select image_jeux, nom_jeux, prix from jeux where nbre_jeux = 1 ";
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

                pic.Click += Pic_Click1;

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
                // pic.Controls.Add(prix);
                lbl_enfant.Text = text_enfant.Text;
                flowLayoutPanel1.Controls.Add(pic);

            }



                /*
                SqlDataAdapter da = new SqlDataAdapter(cmdb1);
                DataTable dt = new DataTable();
                da.Fill(dt);
                dt.Columns.Add("pic", Type.GetType("System.Byte[]"));
                foreach (DataRow drow in dt.Rows)
                {
                    drow["pic"] = File.ReadAllBytes(drow["image"].ToString());

                }
                dataGridView1.DataSource = dt;*/


            //pictureBox1.Image = Image.FromFile(@"select image from test");

            /*  SqlDataAdapter da = new SqlDataAdapter(cmdb1);
              DataTable dtjeu = new DataTable();
              dgjeux.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
              dgjeux.RowTemplate.Height = 120;
              da.Fill(dtjeu);
              dgjeux.DataSource = dtjeu;

              dgjeux.RowHeadersVisible = false;*/


        string sqlb2 = @"select image_jeux,nom_jeux,prix from jeux where nbre_jeux = 2 and taille_enfant = 'plus'";
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

        string sqlb3 = @"select image_jeux,nom_jeux,prix from jeux where nbre_jeux = 3 and taille_enfant = 'plus'";
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

        string sqlb4 = @"select image_jeux,nom_jeux,prix from jeux where nbre_jeux = 4 and taille_enfant = 'plus'";
        if (Sql.Con.State == ConnectionState.Open)
            Sql.Con.Close();
        Sql.Con.ConnectionString = Sql.ParamConnectionString;
        Sql.Con.Open();
        SqlCommand cmdb4 = new SqlCommand(sqlb4, Sql.Con);
        SqlDataReader dr3 = cmdb4.ExecuteReader();

        while (dr3.Read())
        {
            long len = dr3.GetBytes(0, 0, null, 0, 0);
            byte[] array = new byte[System.Convert.ToInt32(len) + 1];
            dr3.GetBytes(0, 0, array, 0, System.Convert.ToInt32(len));
            PictureBox pic4 = new PictureBox();
            pic4.Width = 120;
            pic4.Height = 100;


            pic4.BackgroundImageLayout = ImageLayout.Stretch;


            Label prix = new Label();
            prix.Text = dr3["prix"].ToString();
            prix.Width = 100;
            prix.BackColor = Color.FromArgb(46, 134, 222);
            prix.TextAlign = ContentAlignment.MiddleCenter;


            Label nom = new Label();
            nom.Text = dr3["nom_jeux"].ToString();
            nom.BackColor = Color.FromArgb(46, 134, 222);
            nom.TextAlign = ContentAlignment.MiddleCenter;
            nom.Dock = DockStyle.Bottom;




            MemoryStream ms = new MemoryStream(array);
            Bitmap bitmap = new Bitmap(ms);
            pic4.BackgroundImage = bitmap;
            pic4.Controls.Add(nom);
            pic4.Controls.Add(prix);
            flowLayoutPanel4.Controls.Add(pic4);
        }
        Sql.Con.Close();


        string sqlb5 = @"select image_jeux,nom_jeux,prix from jeux where nbre_jeux = 5 and taille_enfant = 'plus'";
        if (Sql.Con.State == ConnectionState.Open)
            Sql.Con.Close();
        Sql.Con.ConnectionString = Sql.ParamConnectionString;
        Sql.Con.Open();
        SqlCommand cmdb5 = new SqlCommand(sqlb5, Sql.Con);
        SqlDataReader dr4 = cmdb4.ExecuteReader();

        while (dr4.Read())
        {
            long len = dr4.GetBytes(0, 0, null, 0, 0);
            byte[] array = new byte[System.Convert.ToInt32(len) + 1];
            dr4.GetBytes(0, 0, array, 0, System.Convert.ToInt32(len));
            PictureBox pic5 = new PictureBox();
            pic5.Width = 120;
            pic5.Height = 100;


            pic5.BackgroundImageLayout = ImageLayout.Stretch;


            Label prix = new Label();
            prix.Text = dr4["prix"].ToString();
            prix.Width = 100;
            prix.BackColor = Color.FromArgb(46, 134, 222);
            prix.TextAlign = ContentAlignment.MiddleCenter;


            Label nom = new Label();
            nom.Text = dr4["nom_jeux"].ToString();
            nom.BackColor = Color.FromArgb(46, 134, 222);
            nom.TextAlign = ContentAlignment.MiddleCenter;
            nom.Dock = DockStyle.Bottom;




            MemoryStream ms = new MemoryStream(array);
            Bitmap bitmap = new Bitmap(ms);
            pic5.BackgroundImage = bitmap;
            pic5.Controls.Add(nom);
            pic5.Controls.Add(prix);
            flowLayoutPanel5.Controls.Add(pic5);
        }
        Sql.Con.Close();
        tabPage6.Name = text_enfant.Text;
            
        }
        
            private void Pic_Click1(object sender, EventArgs e)
            {
                var pic = (PictureBox)sender;
                 //var prix = (Label)sender;

                 //tabPage6.Controls.Add(cart);
                /* cart.ColumnCount = 3;
                 cart.RowCount = 1;
                 //panel.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 70F));
                 //panel.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 30F));
                 //panel.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 30F));
                 cart.ColumnStyles.Add(new ColumnStyle(SizeType.Absolute, 50F));
                 cart.Controls.Add(new Label() { Text = "Jeux" }, 1, 0);
                 cart.Controls.Add(new Label() { Text = "Prix" }, 2, 0);
                 cart.Controls.Add(new Label() { Text = "Cancel" }, 3, 0);

                 // For Add New Row (Loop this code for add multiple rows)
                 cart.RowCount = cart.RowCount + 1;
                 cart.RowStyles.Add(new RowStyle(SizeType.Absolute, 50F));
                 cart.Controls.Add(new PictureBox() { Image = pic.Image }, 1, cart.RowCount - 1);
                 cart.Controls.Add(new Label() { Text = "888888888888" }, 2, cart.RowCount - 1);
                 cart.Controls.Add(new Label() { Text = "xxxxxxx@gmail.com" }, 3, cart.RowCount - 1);
                 cart.Controls.Add(pic);

                cart.RowCount = cart.RowCount + 1;
                cart.Controls.Add(pic);*/



            }


        
    }
}
