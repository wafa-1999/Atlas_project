using System;
using System.Collections.Generic;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using WMPLib;

namespace WindowsFormsApp1
{
    public partial class Form3 : Form
    {
        public Form3()
        {
            InitializeComponent();
        }

        private void video_Enter(object sender, EventArgs e)
        {
            video.URL = "D:\stage_pfe_dotnet\Nouveau dossier (2)\MEDIA\Coffee Box 3 16-9.mp4";
        }

        private void Form3_Load(object sender, EventArgs e)
        {
            video.settings.autoStart = true;
        }
    }
}
