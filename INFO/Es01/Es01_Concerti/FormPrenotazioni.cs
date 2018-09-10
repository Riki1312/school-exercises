using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Es01_Concerti
{
    public partial class FormPrenotazioni : Form
    {
        ClsPrenotazione Prenotazione;

        public FormPrenotazioni()
        {
            InitializeComponent();
        }

        private void FormPrenotazioni_load(object sender, EventArgs e)
        {
            Prenotazione = new ClsPrenotazione();

            Prenotazione.RegistrazioneEseguita += new ClsPrenotazione.DelegateRegistrazione((string value) =>
            {
                MessaggioPrenotazione.Text = "Prenotazione avvenuta con successo: \nCodice Prenotazione: " + value;
            });
            Prenotazione.BigliettiGiaConsegnati += new ClsPrenotazione.DelegateBiglietti(() =>
            {
                MessaggioRitira.Text = "Biglietti già consegnati";
            });
            Prenotazione.BigliettiConsegnati += new ClsPrenotazione.DelegateBiglietti(() =>
            {
                MessaggioRitira.Text = "Consegna biglietti avvenuta con successo";
            });

        }

        private void ButtonPrenota_Click(object sender, EventArgs e)
        {
            if (TextBoxDescCitta.Text.Trim() != "")
            {
                try
                {
                    Prenotazione.CodiceFiscale = TextBoxCodiceFiscale.Text;
                    Prenotazione.Nome = TextBoxNome.Text;
                    Prenotazione.Cognome = TextBoxCognome.Text;
                    Prenotazione.PostiPrenotati = Convert.ToInt32(TextBoxPostiPrenotare.Value);
                    Prenotazione.Registra(TextBoxDescCitta.Text);
                }
                catch (Exception ex) { MessageBox.Show(ex.Message); }
            }
            else
                MessageBox.Show("Errore: descrizione della città non valida");

        }

        private void ButtonRitira_Click(object sender, EventArgs e)
        {
            try
            {
                int code = Convert.ToInt32(TextBoxCodicePrenotazione.Text);
                Prenotazione.RitiraBiglietti(code);
            }
            catch (Exception eex) { MessageBox.Show(eex.Message); }
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
