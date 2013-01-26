using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace alkoholAbbau
{
    public partial class Form1 : Form
    {
        private double promille, vFaktor, zeit;

        public Form1()
        {
            InitializeComponent();
        }

        private void btnBeenden_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void btnClear_Click(object sender, EventArgs e)
        {
            tBPromille.Clear();
            tBPromilleNach.Clear();
            nudAnzahlGetraenke.Value = 0;
            nudGewicht.Value = 0;
            nudAnzahlGetraenke.Focus();
            nudAnzahlGetraenke.Select(0,10);
        }

        private void btnBerechnen_Click(object sender, EventArgs e)
        {
            int i = 1;
            promille = 8 * Convert.ToDouble(nudAnzahlGetraenke.Value) / (vFaktor * Convert.ToDouble(nudGewicht.Value));
            tBPromille.Text = Convert.ToString(promille);
            while (promille > 0.2)
            {
                promille -= 0.2;
                tBPromilleNach.Text = tBPromilleNach.Text + "\n" + i + " Stunde(n): " + Math.Round((decimal)promille,2) + "\n\r";
                i++;
            }
            MessageBox.Show("Der Alkohol ist nach " + (i - 1) + " Stunde(n) und " + Convert.ToInt32((promille/0.2)*60) + " Minute(n) abgebaut");
        }

        private void rBmaennlich_CheckedChanged(object sender, EventArgs e)
        {
            vFaktor = 0.7;
        }

        private void rBweiblich_CheckedChanged(object sender, EventArgs e)
        {
            vFaktor = 0.6;
        }
    }
}
