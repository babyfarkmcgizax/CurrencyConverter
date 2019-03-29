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
    public partial class FrmMenu : Form
    {
        public FrmMenu()
        {
            InitializeComponent();
        }

        private void euroBtn_Click(object sender, EventArgs e)
        {
            // Create the link to Euro form
            frmEuro theEuroForm = new frmEuro();

            //Make the Euro form show up on the monitor
            theEuroForm.Show();
        }

        private void poundBtn_Click(object sender, EventArgs e)
        {
            // Create the link to Pounds form
            frmPound thePoundForm = new frmPound();

            // Make the Euro form show up on the monitor
            thePoundForm.Show();
        }

        private void dollarBtn_Click(object sender, EventArgs e)
        {
            // Create the link to Dollar form
            frmDollar theDollarForm = new frmDollar();

            // Make the Dollar form show up on the monitor
            theDollarForm.Show();
        }

        private void yenBtn_Click(object sender, EventArgs e)
        {
            // Create the link to Yen form
            frmYen theYenForm = new frmYen();

            // Make the Yen form show up on the monitor
            theYenForm.Show();
        }

        // Close button ends promgram upon click
        private void closeMenuBtn_Click(object sender, EventArgs e)
        {
            Close();
        }
    }
}
