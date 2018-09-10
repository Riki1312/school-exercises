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
    public partial class frmPrenotazione : Form
    {
        Citta citta;
        public frmPrenotazione()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            citta = new Citta();
        }

        private void btnSearch_Click(object sender, EventArgs e)
        {
            try
            {
                DataTable dt = citta.PostiDisponibili(textBox1.Text);
                label2.Text = dt.Rows[0][0].ToString() + " posti disponibili nella destinazione ricercata";
            }
            catch(Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
       
        }

        private void btnSCity_Click_1(object sender, EventArgs e)
        {
            try
            {
                DataTable dt = citta.CercaCitta(textBox2.Text);
                label3.Text = "Codice città: " + dt.Rows[0][0].ToString();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void btnInsert_Click(object sender, EventArgs e)
        {
            try
            {
                citta.Descrizione = txtDesc.Text;
                citta.NPostiDisponibili = Convert.ToInt32(nudPosti.Value);
                citta.InserisciCitta();

                label5.Text = "Inserimento avvenuto corretamente";
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Form3 frm = new Form3();
            frm.ShowDialog();
        }
    }
}
