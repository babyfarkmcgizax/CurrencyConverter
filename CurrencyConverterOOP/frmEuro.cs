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

        // Select from lstEuroFrom ListBox
        private void lstEuroFrom_SelectedIndexChanged(object sender, EventArgs e)
        {
          
        }


        private void convEuroBtn_Click(object sender, EventArgs e)
        {
            // If user selects Dollar to convert Euro to, program will x by conversion rate stored in ExchangeRates Class. 
            if (lstEuroFrom.SelectedItem == "Dollar")
            {
                txtEuroTo.Text = Convert.ToString(Convert.ToDouble(txtEuroFrom.Text) * ExhangeRates.euroToDollar);
            }
            // If user selects Pound to convert Euro to, program will x by conversion rate stored in ExchangeRates Class. 
            if (lstEuroFrom.SelectedItem == "Pound Sterling")
            {
                txtEuroTo.Text = Convert.ToString(Convert.ToDouble(txtEuroFrom.Text) * ExhangeRates.euroToPound);
            }
            // If user selects Yen to convert Euro to, program will x by conversion rate stored in ExchangeRates Class. 
            if (lstEuroFrom.SelectedItem == "Yen")
            {
                txtEuroTo.Text = Convert.ToString(Convert.ToDouble(txtEuroFrom.Text) * ExhangeRates.euroToYen);
            }
        }

        private void euroStatusLabel1_Click(object sender, EventArgs e)
        {
            // If user selects Dollar to convert Euro to, exchange rate displayed.
            if (lstEuroFrom.SelectedItem == "Dollar")
            {
                euroStatusLabel1.Text = "Dollar Exchange rate: " + ExhangeRates.euroToDollar;
            }
            // If user selects Pound to convert Euro to, exchange rate displayed.
            if (lstEuroFrom.SelectedItem == "Pound Sterling")
            {
                euroStatusLabel1.Text = "Pound Exchange rate: " + ExhangeRates.euroToPound;
            }
            // If user selects Yen to convert Euro to, exchange rate displayed.
            if (lstEuroFrom.SelectedItem == "Yen")
            {
                euroStatusLabel1.Text = "Yen Exchange rate: " + ExhangeRates.euroToYen;
            }
        }

        // Closes Euro form when button clicked
        private void closeEuroBtn_Click(object sender, EventArgs e)
        {
            Close();
        }
    }
}
