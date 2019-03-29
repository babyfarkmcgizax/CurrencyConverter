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
    public partial class frmDollar : Form
    {
        public frmDollar()
        {
            InitializeComponent();
        }

        private void lstDollarFrom_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void convDollarBtn_Click(object sender, EventArgs e)
        {
            if (lstDollarFrom.SelectedItem == "Euro")
            {
                txtDollarTo.Text = Convert.ToString(Convert.ToDouble(txtDollarFrom.Text) * 0.89); // Conversion Rates ao 28/03/19 (find a way of refreshing rate?)
            }
            if (lstDollarFrom.SelectedItem == "Pound Sterling")
            {
                txtDollarTo.Text = Convert.ToString(Convert.ToDouble(txtDollarFrom.Text) * 0.76);// Conversion Rates ao 28/03/19
            }
            if (lstDollarFrom.SelectedItem == "Yen")
            {
                txtDollarTo.Text = Convert.ToString(Convert.ToDouble(txtDollarFrom.Text) * 110.73);// Conversion Rates ao 28/03/19
            }
        }

        private void closeDollarBtn_Click(object sender, EventArgs e)
        {
            Close();
        }
    }
}
