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
    public partial class Liste_des_client_d_un_ville : Form
    {
        public Liste_des_client_d_un_ville()
        {
            InitializeComponent();
        }

        ado d = new ado();

        private void Liste_des_client_d_un_ville_Load(object sender, EventArgs e)
        {
            comboBox_ville.DisplayMember = "villeCl";
            comboBox_ville.ValueMember = "villeCl";
            comboBox_ville.DataSource = ado.execute_req("select * from client");
        }

        private void comboBox_ville_SelectedIndexChanged(object sender, EventArgs e)
        {
            string req = string.Format("select * from client where villeCl='{0}'", comboBox_ville.SelectedValue.ToString());
          

            dataGridView1.DataSource = ado.execute_req(req);

            
            

        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }
    }
}
