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
    public partial class Maj_client_mode_connecter : Form
    {
        public Maj_client_mode_connecter()
        {
            InitializeComponent();
        }

        public static BindingSource bs_client = new BindingSource();

        private void Maj_client_mode_connecter_Load(object sender, EventArgs e)
        {
            DataTable dt = ado.execute_req("select * from client");
            bs_client.DataSource = dt;
            textBox_code.DataBindings.Add(new Binding("text",bs_client,"codeCl"));
            textBox_nom.DataBindings.Add(new Binding("text",bs_client,"nomCl"));
            textBox_ville.DataBindings.Add(new Binding("text",bs_client,"villeCl"));
            
        }

        private void button_dernier_Click(object sender, EventArgs e)
        {
            bs_client.MoveLast();
        }

        private void button_premiere_Click(object sender, EventArgs e)
        {
            bs_client.MoveFirst();
        }

        private void button_suivant_Click(object sender, EventArgs e)
        {
            bs_client.MoveNext();
        }

        private void button_precedent_Click(object sender, EventArgs e)
        {
            bs_client.MovePrevious();
        }

        private void button_ajouter_Click(object sender, EventArgs e)
        {
            string req = string.Format("insert into client values('{0}','{1}','{2}')", textBox_code.Text, textBox_nom.Text,textBox_ville.Text );
            ado.execute_req(req);
        }

        private void button_modifier_Click(object sender, EventArgs e)
        {
            string req = string.Format("update client set nomCl='{0}',villeCl='{1}' where codeCl={2}", textBox_nom.Text, textBox_ville.Text,textBox_code.Text);
            ado.execute_req(req);
        }

        private void button_supprimer_Click(object sender, EventArgs e)
        {
            string req = string.Format("delete client where codeCl = '{0}'", textBox_code.Text);
            ado.execute_req(req);
        }

        private void button_rechercher_Click(object sender, EventArgs e)
        {
            string req = string.Format("select * from client where codeCl='{0}'", textBox_rechercher.Text);
            ado.execute_req(req);

            textBox_code.Text = ado.dt.Rows[0][0].ToString();
            textBox_nom.Text = ado.dt.Rows[0][1].ToString();
            textBox_ville.Text= ado.dt.Rows[0][2].ToString();
        }

        private void button_quitter_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }
    }
}
