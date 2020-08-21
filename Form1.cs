using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CalcoloCombinatorio
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void btnDsCe_Click(object sender, EventArgs e)
        {
            txtDsN.Text = "";
            txtDsK.Text = "";
            lblRisDs.Text = "";
        }

        private void btnPsCe_Click(object sender, EventArgs e)
        {
            txtPsN.Text = "";
            lblRisPs.Text = "";
        }

        private void btnDrCe_Click(object sender, EventArgs e)
        {
            txtDrN.Text = "";
            txtDrK.Text = "";
            lblRisDr.Text = "";
        }

        private void btnPrCe_Click(object sender, EventArgs e)
        {
            txtPrN.Text = "";
            txtPrK.Text = "";
            lblRisPr.Text = "";
        }

        private void btnCbCe_Click(object sender, EventArgs e)
        {
            txtCbN.Text = "";
            txtCbK.Text = "";
            lblRisCb.Text = "";
        }

        private void btnPcCe_Click(object sender, EventArgs e)
        {
            txtPcN.Text = "";
            lblRisPc.Text = "";
        }

        private void btnCsCe_Click(object sender, EventArgs e)
        {
            txtCsN.Text = "";
            txtCsK.Text = "";
            lblRisCs.Text = "";
        }

        private void btnFCe_Click(object sender, EventArgs e)
        {
            txtFN.Text = "";
            lblRisF.Text = "";
        }

        private void btnDs_Click(object sender, EventArgs e)
        {
            int n = Convert.ToInt32(txtDsN.Text);
            int k = Convert.ToInt32(txtDsK.Text);
            lblRisDs.Text = Convert.ToString(DisposizioneSemplice(n, k));
        }

        private void btnDr_Click(object sender, EventArgs e)
        {
            int n = Convert.ToInt32(txtDrN.Text);
            int k = Convert.ToInt32(txtDrK.Text);
            lblRisDr.Text = Convert.ToString(DisposizioneRipetizione(n, k));
        }

        private void btnF_Click(object sender, EventArgs e)
        {
            int n = Convert.ToInt32(txtFN.Text);
            lblRisF.Text = Convert.ToString(Fattoriale(n));
        }

        private void btnPs_Click(object sender, EventArgs e)
        {
            int n = Convert.ToInt32(txtPsN.Text);
            lblRisPs.Text = Convert.ToString(Fattoriale(n));
        }

        private void btnPc_Click(object sender, EventArgs e)
        {
            int n = Convert.ToInt32(txtPcN.Text);
            lblRisPc.Text = Convert.ToString(Fattoriale(n) / n);
        }

        private void btnPr_Click(object sender, EventArgs e)
        {
            int n = Convert.ToInt32(txtPrN.Text);
            int k = Convert.ToInt32(txtPrK.Text);
            lblRisPr.Text = Convert.ToString(Fattoriale(n) / Fattoriale(k));
        }

        private void btnCb_Click(object sender, EventArgs e)
        {
            int n = Convert.ToInt32(txtCbN.Text);
            int k = Convert.ToInt32(txtCbK.Text);
            lblRisCb.Text = Convert.ToString(Fattoriale(n) / (Fattoriale(k)*Fattoriale(n-k)));
        }

        private void btnCs_Click(object sender, EventArgs e)
        {
            int n = Convert.ToInt32(txtCsN.Text);
            int k = Convert.ToInt32(txtCsK.Text);
            lblRisCs.Text = Convert.ToString(DisposizioneSemplice(n,k) / Fattoriale(k));
        }

        private int DisposizioneSemplice(int n, int k)
        {
            int rs = 1;
            for (int i = n; i >= (n - k + 1); i--)
                rs *= i;

            return rs;
        }

        private int DisposizioneRipetizione(int n, int k)
        {
            return Convert.ToInt32(Math.Pow(n,k));
        }

        private int Fattoriale(int n)
        {
            if (n == 0) return 1;
            if (n == 1) return 1;
            int rs = 1;
            for (int i = n; i >= 1; i--)
                rs *= i;
            return rs;
        }
    }
}
