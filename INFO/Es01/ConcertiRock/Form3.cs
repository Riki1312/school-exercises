using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ConcertiRock
{
    public partial class Form3 : Form
    {
        Prenotazione prenotazione;
        public Form3()
        {
            InitializeComponent();
        }

        private void btnPrenota_Click(object sender, EventArgs e)
        {
            if (txtDesc.Text.Trim() != "")
            {
                try
                {
                    prenotazione.CodFiscale = txtCodiceFiscale.Text;
                    prenotazione.Nome = txtNome.Text;
                    prenotazione.Cognome = txtCognome.Text;
                    prenotazione.NPostiPresi = Convert.ToInt32(nudPosti.Value);
                    prenotazione.RegistraPrenotazione(txtDesc.Text);
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message);
                }
            }
            else
                MessageBox.Show("Descrizione della città non valida");
            
        }

        private void btnRitira_Click(object sender, EventArgs e)
        {
            try
            {
                int code = Convert.ToInt32(textBox1.Text);
                prenotazione.RitiraBiglietti(code);
            }
            catch(Exception eex)
            {
                MessageBox.Show(eex.Message);
            }
        }

        private void Form3_Load(object sender, EventArgs e)
        {
            prenotazione = new Prenotazione();
            prenotazione.RegistrazioneEseguita += new Prenotazione.Del2(showMessage1);
            prenotazione.BigliettiGiaConsegnati += new Prenotazione.Del(showMessage2);
            prenotazione.BigliettiConsegnati += new Prenotazione.Del(showMessage3);

        }

        private void showMessage1(string value)
        {
            lblMessage1.Text = "Registrazione effettuata correttamente\nCodice Prenotazione: " + value;
        }
        private void showMessage2()
        {
            lblMessage2.Text = "Biglietti già consegnati per questa prenotazione";
        }
        private void showMessage3()
        {
            lblMessage2.Text = "Biglietti consegnati correttamente";
        }
    }
}
