using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CurrencyConverterOOP
{
    public partial class frmEuro : Form
    {
        public frmEuro()
        {
            InitializeComponent();
        }

        private void lstEuroFrom_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void convEuroBtn_Click(object sender, EventArgs e)
        {
            if (lstEuroFrom.SelectedItem == "Dollar")
            {
                txtEuroTo.Text = Convert.ToString(Convert.ToDouble(txtEuroFrom.Text) * 1.20); // Conversion Rates ao 28/03/19 (find a way of refreshing rate?)
            }
            if (lstEuroFrom.SelectedItem == "Pound Sterling")
            {
                txtEuroTo.Text = Convert.ToString(Convert.ToDouble(txtEuroFrom.Text) * 0.86);// Conversion Rates ao 28/03/19
            }
            if (lstEuroFrom.SelectedItem == "Yen")
            {
                txtEuroTo.Text = Convert.ToString(Convert.ToDouble(txtEuroFrom.Text) * 124.24);// Conversion Rates ao 28/03/19
            }
        }

        // Closes Euro form when button clicked
        private void closeEuroBtn_Click(object sender, EventArgs e)
        {
            Close();
        }
    }
}
