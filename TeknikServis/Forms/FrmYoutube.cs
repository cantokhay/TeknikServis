using System;
using System.Windows.Forms;

namespace TeknikServis.Forms
{
    public partial class FrmYoutube : Form
    {
        public FrmYoutube()
        {
            InitializeComponent();
        }

        private void FrmYoutube_Load(object sender, EventArgs e)
        {
            webYoutube.Navigate("https://www.youtube.com/");
        }
    }
}
