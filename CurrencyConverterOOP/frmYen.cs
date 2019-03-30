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
    public partial class frmYen : Form
    {
        public frmYen()
        {
            InitializeComponent();
        }
        private void lstYenFrom_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void convYenBtn_Click(object sender, EventArgs e)
        {
            if (lstYenFrom.SelectedItem == "Euro")
            {
                txtYenTo.Text = Convert.ToString(Convert.ToDouble(txtYenFrom.Text) * 0.0080); // Conversion Rates ao 28/03/19 (find a way of refreshing rate?)
            }
            if (lstYenFrom.SelectedItem == "Dollar")
            {
                txtYenTo.Text = Convert.ToString(Convert.ToDouble(txtYenFrom.Text) * 0.0090);// Conversion Rates ao 28/03/19
            }
            if (lstYenFrom.SelectedItem == "Pound Sterling")
            {
                txtYenTo.Text = Convert.ToString(Convert.ToDouble(txtYenFrom.Text) * 0.0069);// Conversion Rates ao 28/03/19
            }
        }

        private void closeYenBtn_Click(object sender, EventArgs e)
        {
            Close();
        }
    }
}
