using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Esercizio_2
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            PopolaPeriodo();
            PopolaCitta();
            PopolaAbbonato();
            PopolaRivista();
        }

        private void PopolaPeriodo()
        {
            DatabaseManager database = new DatabaseManager("dbEsercizio2");
            DataTable dt = database.ExecuteQuery("SELECT * FROM Periodi");

            cbPeriodo.DisplayMember = cb_Periodo.DisplayMember = "stringa";
            cbPeriodo.ValueMember = cb_Periodo.ValueMember = "id_periodi";
            cbPeriodo.DataSource = cb_Periodo.DataSource = dt;
        }
        private void PopolaCitta()
        {
            DatabaseManager database = new DatabaseManager("dbEsercizio2");

            cbCitta.DisplayMember = "stringa";
            cbCitta.ValueMember = "id_citta";
            cbCitta.DataSource = database.ExecuteQuery("SELECT * FROM Citta");
        }
        private void PopolaAbbonato()
        {
            DatabaseManager database = new DatabaseManager("dbEsercizio2");

            cbAbbonato.DisplayMember = "anagrafe";
            cbAbbonato.ValueMember = "id_abbonato";
            cbAbbonato.DataSource = database.ExecuteQuery("SELECT id_abbonato, CONCAT(cognome, ' ',nome) AS anagrafe FROM Abbonato");
        }
        private void PopolaRivista()
        {
            DatabaseManager database = new DatabaseManager("dbEsercizio2");

            cbRivista.DisplayMember = "titolo";
            cbRivista.ValueMember = "id_rivista";
            cbRivista.DataSource = database.ExecuteQuery("SELECT id_rivista, titolo FROM Rivista");
        }

        private void button1_Click(object sender, EventArgs e)
        {
            string prezzo = numPrezo.Value.ToString().Replace(',', '.');
            if (txtTitolo.Text != "")
                clsQuery.InsRivista(txtTitolo.Text, Convert.ToInt32(cb_Periodo.SelectedValue), prezzo);
        }
        private void btnInsPersona_Click(object sender, EventArgs e)
        {
            if (txtCognome.Text != "" && txtNome.Text != "")
                clsQuery.InsPersona(txtCognome.Text, txtNome.Text, Convert.ToInt32(cbCitta.SelectedValue), dtpNascita.Value);
        }
        private void btnInsCitta_Click(object sender, EventArgs e)
        {
            clsQuery.InsCitta(txtCitta.Text);
        }
        private void btnInsPeriodo_Click(object sender, EventArgs e)
        {
            clsQuery.InsPeriodo(txtPeriodo.Text);
        }
        private void btnUpdate_Click(object sender, EventArgs e)
        {
            PopolaPeriodo();
            PopolaCitta();
            PopolaAbbonato();
            PopolaRivista();
        }
        private void btnQuery1_Click(object sender, EventArgs e)
        {
            string risposta = Microsoft.VisualBasic.Interaction.InputBox("Fornire titolo per abbonati annuali.", "Query01", "", 0, 0);

            MessageBox.Show(clsQuery.NumAbbonatiAnnuali(risposta).ToString());
        }
        private void button1_Click_1(object sender, EventArgs e)
        {
            clsQuery.InsAbbonamento(Convert.ToInt32(cbAbbonato.SelectedValue), Convert.ToInt32(cbPeriodo.SelectedValue), dtpValidita.Value, Convert.ToInt32(cbRivista.SelectedValue));
        }

        private void button2_Click(object sender, EventArgs e)
        {
            string risposta = Microsoft.VisualBasic.Interaction.InputBox("Anagrafe (cognome-nome)", "Query02", "", 0, 0);

            MessageBox.Show(clsQuery.NumAbbonamenti(risposta.Split('-')[0], risposta.Split('-')[1]).ToString());
        }

        private void button3_Click(object sender, EventArgs e)
        {
            frmDv frm = new frmDv(clsQuery.NumAbbonati());
            frm.ShowDialog();
        }

        private void button4_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Per comodità ho utilizzato 2 come abitanti anzichè 5000");
            frmDv frm = new frmDv(clsQuery.AbbonatiMinimi(2));
            frm.ShowDialog();
        }

        private void button5_Click(object sender, EventArgs e)
        {
            frmDv frm = new frmDv(clsQuery.SenzaAbbonati());
            frm.ShowDialog();
        }

        private void button6_Click(object sender, EventArgs e)
        {
            frmDv frm = new frmDv(clsQuery.NumAbbonatiCitta());
            frm.ShowDialog();
        }
    }
}
