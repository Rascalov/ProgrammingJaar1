using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Net;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CurrencyToBtc
{
    public partial class Form1 : Form
    {

        private int aantalBitCoins = 0;
        private double BitcoinValue = 0;
        public Form1()
        {
            InitializeComponent();
            cmbValutaGame.SelectedIndex = 0;
        }
        WebClient wc = new WebClient();
        private void btnConvert_Click(object sender, EventArgs e)
        {
            DateTime Datum = DateTime.Now;
            string valuta;
            string value;
            value = txtInvoer.Text;
            valuta = cmbValuta.Text;
            string valutaCode = valuta.Split(' ').FirstOrDefault();
            string error = "";
            double uitkomst;


            try {
                var json = wc.DownloadString("https://blockchain.info/tobtc?currency=" + valutaCode + "&value=" + value);
                txtUitvoer.Text = "BTC: " + json.ToString();
                uitkomst = double.Parse(value) / double.Parse(json);
                lblWaarde.Text = "1 BTC naar " + valutaCode + ": " + uitkomst.ToString("0.00");
                error = "Time: " + Datum.ToString();
            }
            catch
            {
                error = "Geldige invoer aub!";
            }

            lblError.Text = error;
        }

        private void txtUitvoer_TextChanged(object sender, EventArgs e)
        {

        }

        private void btnBigBlackRock_Click(object sender, EventArgs e)
        {
            SpeelGeluidAf();
            aantalBitCoins++;
            string value = "1";
            string valuta;
            valuta = cmbValutaGame.Text;
            string valutaCode = valuta.Split(' ').FirstOrDefault();

            double uitkomst;
            double uitkomstBitcoin;



            var json = wc.DownloadString("https://blockchain.info/tobtc?currency=" + valutaCode + "&value=" + value);
            
            uitkomst = double.Parse(value) / double.Parse(json);


            uitkomstBitcoin = uitkomst * aantalBitCoins;


            lblBitcoinAmount.Text = aantalBitCoins.ToString() + " Bitcoin(s)";
            lblBitcoinValue.Text = uitkomstBitcoin.ToString(GeldTeken(valutaCode) + "0.00");
            
            
        }

        private char GeldTeken(string valutaTeken)
        {
            switch (valutaTeken)
            {
                case "USD":
                case "CAD":
                    return '$';
                case "EUR":
                    return '€';
                case "RUB":
                    return '₽';
            }

            return 'e';
        }

        private void SpeelGeluidAf()
        {

            var path = "C:/Users/Project OS/Desktop/coin.wav";
            System.Media.SoundPlayer player = new System.Media.SoundPlayer(path);
            player.Play();

        }

        private void label4_Click(object sender, EventArgs e)
        {

        }
    }
}
