using System;
using System.Windows.Forms;

namespace TeknikServis.Forms
{
    public partial class FrmCurrency : Form
    {
        public FrmCurrency()
        {
            InitializeComponent();
        }

        private void FrmCurrency_Load(object sender, EventArgs e)
        {
            webCurrency.Navigate("https://www.tcmb.gov.tr/kurlar/today.xml");
        }
    }
}
