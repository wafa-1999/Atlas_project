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
    public partial class frm_video : Form
    {
        
        public frm_video()
        {
            InitializeComponent();
            
        }

        private void Form2_Load(object sender, EventArgs e)
        {
            axWindowsMediaPlayer1.settings.autoStart = true;
        }

        private void axWindowsMediaPlayer1_Enter(object sender, EventArgs e)
        {
            axWindowsMediaPlayer1.URL = @"D:\stage_pfe_dotnet\display\MEDIA\atlas.mp4";
        }

        private void axWindowsMediaPlayer1_ClickEvent(object sender, AxWMPLib._WMPOCXEvents_ClickEvent e)
        {
            axWindowsMediaPlayer1.Ctlcontrols.stop();
            this.Hide();
            frm_login f1 = new frm_login();
            f1.Show();
        }
    }
}
