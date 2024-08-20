using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace combo_box___PrincipaisPropriedades
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Inserir_Click(object sender, EventArgs e)
        {
            cboLista.Items.Add(txtTexto.Text);
            lblQtde.Text = cboLista.Items.Count.ToString();
            txtTexto.Clear();
            txtTexto.Select();
        }

        private void cboLista_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void txtTexto_TextChanged(object sender, EventArgs e)
        {

        }

        private void Ordenar_Click(object sender, EventArgs e)
        {
            cboLista.Sorted = true;
        }

        private void btnRemover_Click(object sender, EventArgs e)
        {
            if (cboLista.SelectedIndex != -1)
            {
                cboLista.Items.RemoveAt(cboLista.SelectedIndex);
                lblQtde.Text = cboLista.Items.Count.ToString();
                cboLista.ResetText();
            }
        }

        private void btnExibir_Click(object sender, EventArgs e)
        {
            if (cboLista.SelectedIndex != -1)
            {
                txtConteudo.Text = cboLista.SelectedIndex.ToString();
                txtindice.Text = cboLista.SelectedIndex.ToString();
            }
        }

        private void txtindice_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
