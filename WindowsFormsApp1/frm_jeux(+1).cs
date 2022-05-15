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
using WindowsFormsApp1.BLL;

namespace WindowsFormsApp1
{
    public partial class frm_jeux : Form
    {
        public frm_jeux()
        {
            InitializeComponent();

        }
        DataTable dt;
        private void GenerateDynamicusercontrol()
        {
            flowLayoutPanel1.Controls.Clear();
            ClassBLL objbll = new ClassBLL(); 
            dt = objbll.GetItems(); 
            if (dt != null) 
            {
                if (dt.Rows.Count > 0) 
                {
                    les_jeux[] listItems = new les_jeux[dt.Rows.Count];
                    for (int i = 0; i < 1; i++) 
                    {
                        foreach (DataRow row in dt.Rows)
                        {
                            listItems[i] = new les_jeux();
                            MemoryStream ms = new MemoryStream((byte[])row["image_jeux"]);
                            listItems[i].Icon = new Bitmap(ms);

                            listItems[i].Nom = row["nom_jeux"].ToString();
                            listItems[i].Prix = row["prix"].ToString();


                            flowLayoutPanel1.Controls.Add(listItems[i]);
                            listItems[i].Click += new System.EventHandler(this.UserControl_click);
                        }


                    }

                }
            }
        }
        #region User Control click Event
        void UserControl_click(object sender, EventArgs e)
        {
            Button delete = new Button();
            les_jeux obj = (les_jeux)sender;
            cart.Rows.Add(obj.Icon, obj.Prix, delete);
            
        }
        #endregion

        private void frm_jeux_Load(object sender, EventArgs e)
        {

            GenerateDynamicusercontrol();
            DataGridViewImageColumn dgvImage = new DataGridViewImageColumn();
            dgvImage.HeaderText = "Jeux";
            dgvImage.ImageLayout = DataGridViewImageCellLayout.Stretch;
            

            DataGridViewTextBoxColumn dgvprix = new DataGridViewTextBoxColumn();
            dgvprix.HeaderText = "Prix";
            

            DataGridViewButtonColumn delete = new DataGridViewButtonColumn();
            delete.HeaderText = "Effacer";
            delete.UseColumnTextForButtonValue = true;


            cart.Columns.Add(dgvImage);
            cart.Columns.Add(dgvprix);
            cart.Columns.Add(delete);

            cart.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            cart.RowTemplate.Height = 100;

            cart.AllowUserToAddRows = false;


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

        
    }
    
}
