using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Es02_CasaEditrice
{
    public partial class FromMain : Form
    {
        const string DBName = "DBCasaEditrice";

        public FromMain()
        {
            InitializeComponent();
        }

        private void FromMain_Load(object sender, EventArgs e)
        {
            CaricaPeriodi();
            CaricaCitta();
            CaricaAbbonamenti();
            CaricaRiviste();
        }

        private void CaricaAbbonamenti()
        {
            DatabaseManager database = new DatabaseManager(DBName);

            cbAbbonato.DisplayMember = "anagrafe";
            cbAbbonato.ValueMember = "id_abbonato";
            cbAbbonato.DataSource = database.ExecuteQuery("SELECT id_abbonato, CONCAT(cognome, ' ',nome) AS anagrafe FROM Abbonato");
        }
        private void CaricaRiviste()
        {
            DatabaseManager database = new DatabaseManager(DBName);

            cbRivista.DisplayMember = "titolo";
            cbRivista.ValueMember = "id_rivista";
            cbRivista.DataSource = database.ExecuteQuery("SELECT id_rivista, titolo FROM Rivista");
        }
        private void CaricaCitta()
        {
            DatabaseManager database = new DatabaseManager(DBName);

            cbCitta.DisplayMember = "valore";
            cbCitta.ValueMember = "id_citta";
            cbCitta.DataSource = database.ExecuteQuery("SELECT * FROM Citta");
        }
        private void CaricaPeriodi()
        {
            DatabaseManager database = new DatabaseManager(DBName);
            DataTable dt = database.ExecuteQuery("SELECT * FROM Periodi");

            cbPeriodo.DisplayMember = cb_Periodo.DisplayMember = "valore";
            cbPeriodo.ValueMember = cb_Periodo.ValueMember = "id_periodi";
            cbPeriodo.DataSource = cb_Periodo.DataSource = dt;
        }

        private void ButtonQ1(object sender, EventArgs e)
        {
            string risposta = Microsoft.VisualBasic.Interaction.InputBox("Inserire titolo", "Query01", "", 0, 0);

            MessageBox.Show(QueryManager.Q_NumAbbonatiAnnuali(risposta).ToString());
        }
        private void ButtonQ2(object sender, EventArgs e)
        {
            string risposta = Microsoft.VisualBasic.Interaction.InputBox("Inserire cognome e nome", "Query02", "", 0, 0);

            MessageBox.Show(QueryManager.Q_NumeroAbbonamenti(risposta.Split('-')[0], risposta.Split('-')[1]).ToString());
        }

        private void ButtonVis1(object sender, EventArgs e)
        {
            FormDataView frm = new FormDataView(QueryManager.Q_NumeroAbbonati());
            frm.ShowDialog();
        }
        private void ButtonVis2(object sender, EventArgs e)
        {
            FormDataView frm = new FormDataView(QueryManager.Q_AbbonatiMinimi(5000));
            frm.ShowDialog();
        }
        private void ButtonVis3(object sender, EventArgs e)
        {
            FormDataView frm = new FormDataView(QueryManager.Q_SenzaAbbonati());
            frm.ShowDialog();
        }
        private void ButtonVis4(object sender, EventArgs e)
        {
            FormDataView frm = new FormDataView(QueryManager.Q_NumAbbonatiCitta());
            frm.ShowDialog();
        }

        private void ButtonAggiorna(object sender, EventArgs e)
        {
            CaricaPeriodi();
            CaricaCitta();
            CaricaAbbonamenti();
            CaricaRiviste();
        }

        private void ButtonInsRivista(object sender, EventArgs e)
        {
            string prezzo = numPrezo.Value.ToString().Replace(',', '.');
            if (txtTitolo.Text != "")
                QueryManager.Ins_Rivista(txtTitolo.Text, Convert.ToInt32(cb_Periodo.SelectedValue), prezzo);
        }
        private void ButtonInsPersona(object sender, EventArgs e)
        {
            if (txtCognome.Text != "" && txtNome.Text != "")
                QueryManager.Ins_Persona(txtCognome.Text, txtNome.Text, Convert.ToInt32(cbCitta.SelectedValue), dtpNascita.Value);
        }
        private void ButtonInsCitta(object sender, EventArgs e)
        {
            QueryManager.Ins_Citta(txtCitta.Text);
        }
        private void ButtonInsPeriodo(object sender, EventArgs e)
        {
            QueryManager.Ins_Periodo(txtPeriodo.Text);
        }
        private void ButtonInsAbbonamento(object sender, EventArgs e)
        {
            QueryManager.Ins_Abbonamento(Convert.ToInt32(cbAbbonato.SelectedValue), Convert.ToInt32(cbPeriodo.SelectedValue), dtpValidita.Value, Convert.ToInt32(cbRivista.SelectedValue));
        }
    }
}
