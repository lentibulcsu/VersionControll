using CQN0K0_06_het.MnbServiceReference;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CQN0K0_06_het
{
    public partial class Form1 : Form
    {
        BindingList<Entities.RateData> Rates = new BindingList<Entities.RateData>();

        public Form1()
        {
            InitializeComponent();

            ElsoFuggveny();

            dataGridView1.DataSource = Rates;
        }

        private void ElsoFuggveny()
        {
            var mnbService = new MNBArfolyamServiceSoapClient();

            var request = new GetExchangeRatesRequestBody()
            {
                currencyNames = "EUR",
                startDate = "2020-01-01",
                endDate = "2020-06-30"
            };


            var response = mnbService.GetExchangeRates(request);

            var result = response.GetExchangeRatesResult;
        }

        private void MasodikFuggveny()
        {

        }
    }
}
