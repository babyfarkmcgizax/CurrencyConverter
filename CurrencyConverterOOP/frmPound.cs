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
    public partial class frmPound : Form
    {
        public frmPound()
        {
            InitializeComponent();
        }

        private void lstPoundFrom_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void convPoundBtn_Click(object sender, EventArgs e)
        {
            if (lstPoundFrom.SelectedItem == "Euro")
            {
                txtPoundTo.Text = Convert.ToString(Convert.ToDouble(txtPoundFrom.Text) * 1.74); // Conversion Rates ao 28/03/19 (find a way of refreshing rate?)
            }
            if (lstPoundFrom.SelectedItem == "Dollar")
            {
                txtPoundTo.Text = Convert.ToString(Convert.ToDouble(txtPoundFrom.Text) * 131.00);// Conversion Rates ao 28/03/19
            }
            if (lstPoundFrom.SelectedItem == "Yen")
            {
                txtPoundTo.Text = Convert.ToString(Convert.ToDouble(txtPoundFrom.Text) * 145.04);// Conversion Rates ao 28/03/19
            }
        }

        private void closePoundBtn_Click(object sender, EventArgs e)
        {
            Close();
        }


    }
}
