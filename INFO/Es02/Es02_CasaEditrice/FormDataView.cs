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
    public partial class FormDataView : Form
    {
        public FormDataView(DataTable dt)
        {
            InitializeComponent();
            dataGridView1.DataSource = dt;
        }

        private void FormDataView_Load(object sender, EventArgs e)
        {

        }
    }
}
