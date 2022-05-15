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
    public partial class les_jeux : UserControl
    {
        public les_jeux()
        {
            InitializeComponent();
        }


        private Image _icon;
        private String _nom;
        private String _prix;
        [Category("Custom props")]

        public Image Icon
        {
            get { return _icon; }
            set { _icon = value; pb_icon.Image = value; }
        }

        [Category("Custom props")]

        public String Nom
        {
            get { return _nom; }
            set { _nom = value; lbl_nom.Text = value; }
        }

        [Category("Custom props")]

        public String Prix
        {
            get { return _prix; }
            set { _prix = value; lbl_prix.Text = value; }
        }


        #region Hover Effect
        private void ucRequest_HouseEnter(object sender, EventArgs e)
        {
            this.BackColor = Color.FromArgb(217, 229, 242); //change user control back color when mouse enters.
        }
        private void ucRequest_HouseLeave(object sender, EventArgs e)
        {
            this.BackColor = Color.FromArgb(255, 255, 255); //reset user control back color when mouse leaves.
        }


        private void les_jeux_Load(object sender, EventArgs e)
        {

        }
        #endregion
    }
}
