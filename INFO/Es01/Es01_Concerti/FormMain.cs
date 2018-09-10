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
    public partial class FormMain : Form
    {
        ClsCitta Citta;

        public FormMain()
        {
            InitializeComponent();
        }

        private void FormMain_load(object sender, EventArgs e)
        {
            Citta = new ClsCitta();
        }

        private void ButtonInserisci_Click(object sender, EventArgs e)
        {
            try
            {
                Citta.Descrizione = TextBoxDescrizione.Text;
                Citta.PostiDisponibili = Convert.ToInt32(NumeroPosti.Value);
                Citta.Inserisci();

                MessaggioInserimento.Text = "Inserimento avvenuto con successo.";
            }
            catch (Exception ex) { MessageBox.Show(ex.Message); }
        }

        private void ButtonCerca_Click(object sender, EventArgs e)
        {
            try
            {
                DataTable dt = Citta.NumeroPosti(TextBoxCercaPosti.Text);
                MessaggioCercaPosti.Text = dt.Rows[0][0].ToString() + " posti disponibili.";
            }
            catch (Exception ex) { MessageBox.Show(ex.Message); }
        }

        private void ButtonCercaCitta_Click(object sender, EventArgs e)
        {
            try
            {
                DataTable dt = Citta.Cerca(TextBoxCercaCitta.Text);
                MessaggioCercaCitta.Text = "Codice città: " + dt.Rows[0][0].ToString() + ".";
            }
            catch (Exception ex) { MessageBox.Show(ex.Message); }
        }

        private void ButtonPrenotazioni_Click(object sender, EventArgs e)
        {
            FormPrenotazioni frm = new FormPrenotazioni();
            frm.ShowDialog();
        }
    }
}
