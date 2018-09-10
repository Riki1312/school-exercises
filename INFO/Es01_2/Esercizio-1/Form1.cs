using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Esercizio_1
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void btIns_Click(object sender, EventArgs e)
        {
            clsCitta citta = new clsCitta();

            citta.Descrizione = txtDesc.Text;
            citta.NPostiDisponibili = Convert.ToInt32(numPosti.Value);

            TextNormale();

            try
            {
                citta.InserisciCitta();
            }catch(Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }
        private void btnCerca_Click(object sender, EventArgs e)
        {
            clsCitta citta = new clsCitta();

            TextNormale();
            try
            {
                txtCodCitta.Text = citta.CercaCitta(txtDesc.Text).ToString();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
            txtCodCitta.BackColor = Color.GreenYellow;
            txtDesc.BackColor = Color.GreenYellow;
        }
        private void btnPosti_Click(object sender, EventArgs e)
        {
            clsCitta citta = new clsCitta();
            TextNormale();
            try
            {
                numPosti.Value = citta.PostiDisponibili(Convert.ToInt32(txtCodCitta.Text));
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
            numPosti.BackColor = Color.GreenYellow;
            txtCodCitta.BackColor = Color.GreenYellow;
        }
        private void button4_Click(object sender, EventArgs e)
        {
            clsPrenotazioni prenota = new clsPrenotazioni();
            prenota.AvvenutaPrenotazione += new clsPrenotazioni.Successo(MostraEvento);

            if (txtDescPre.Text != string.Empty)
            {
                try
                {
                    prenota.Cognome = txtCognome.Text;
                    prenota.Nome = txtNome.Text;
                    prenota.NPostiPrenotati = Convert.ToInt32(numPrenotazioni.Value);
                    prenota.CodFiscale = txtCFS.Text;

                    numPrenotazione.Value = prenota.RegistraPrenotazioni(txtDescPre.Text);
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message);
                }
            }
        }
        private void button3_Click(object sender, EventArgs e)
        {
            clsPrenotazioni prenotazioni = new clsPrenotazioni();
            prenotazioni.AvvenutaConsegna += new clsPrenotazioni.Successo(MostraEvento);

            prenotazioni.RitiraBiglietti(Convert.ToInt32(numPrenotazione.Value));
        }

        private void TextNormale()
        {
            txtCodCitta.BackColor = Color.White;
            txtDesc.BackColor = Color.White;
            numPosti.BackColor = Color.White;
        }

        private void MostraEvento(string msg)
        {
            MessageBox.Show(msg);
        }
    }
}
