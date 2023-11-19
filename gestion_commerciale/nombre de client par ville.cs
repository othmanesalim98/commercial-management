using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace gestion_commerciale
{
    public partial class nombre_de_client_par_ville : Form
    {
        public nombre_de_client_par_ville()
        {
            InitializeComponent();
        }

        private void nombre_de_client_par_ville_Load(object sender, EventArgs e)
        {
            comboBox_ville.DisplayMember = "villeCl";
            comboBox_ville.ValueMember = "codeCl";
            comboBox_ville.DataSource = ado.execute_req("select * from client");
        }

        private void comboBox_ville_SelectedIndexChanged(object sender, EventArgs e)
        {
            string req = string.Format("select count(*) from client where villeCl='{0}'", comboBox_ville.Text);

            string nbr = ado.Exceuter_scalar(req).ToString();
            label_count.Text =nbr+"" ;

        }

        private void label_count_Click(object sender, EventArgs e)
        {

        }
    }
}
