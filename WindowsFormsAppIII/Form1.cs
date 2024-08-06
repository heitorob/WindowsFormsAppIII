using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsAppIII
{
    public partial class Form1 : Form
    {
        double total;

        public Form1()
        {
            InitializeComponent();
        }

        private void btnINSERIR_Click(object sender, EventArgs e)
        {
            double qtde = double.Parse(txtQTDE.Text);
            double unit = double.Parse(txtUNIT.Text);

            double valor = qtde * unit;

            total += valor;

            lblTOTAL.Text = total.ToString("C");

            lstPRODUTOS.Items.Add(txtPRODUTO.Text.ToUpper() + " - " + txtQTDE.Text + " - R$ " + txtUNIT.Text);

            txtPRODUTO.Clear();
            txtQTDE.Clear();
            txtUNIT.Clear();

            txtPRODUTO.Focus();
        }

        private void btnNOVA_Click(object sender, EventArgs e)
        {
            txtPRODUTO.Clear();
            txtQTDE.Clear();
            txtUNIT.Clear();

            lblTOTAL.Text = "R$ 0,00";

            lstPRODUTOS.Items.Clear();
        }

        private void btnFECHAR_Click(object sender, EventArgs e)
        {
            Close();
        }
    }
}
