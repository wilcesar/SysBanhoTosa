using SysBanhoTosa.Views;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace SysBanhoTosa
{
    public partial class FormMenu : Form
    {
        public FormMenu()
        {
            InitializeComponent();
        }
        

        private void menuStrip1_ItemClicked(object sender, ToolStripItemClickedEventArgs e)
        {

        }

        private void clientesToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (Application.OpenForms.OfType<FormClientes>().Count() == 0)
            {
                FormClientes objFormCLientes = new FormClientes();
                objFormCLientes.Show();
            };
                
        }

        private void petsToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (Application.OpenForms.OfType<FormPets>().Count() == 0)
            {
                FormPets objFormPets = new FormPets();
                objFormPets.Show();
            }
                
        }

        private void serviçosToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (Application.OpenForms.OfType<FormServicos>().Count() == 0)
            {
                FormServicos objFormServicos = new FormServicos();
                objFormServicos.Show();
            }
                
        }

        private void serviçosToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            if (Application.OpenForms.OfType<FormLancamentosServicos>().Count() == 0)
            {
                FormLancamentosServicos objFormLancamentosServicos = new FormLancamentosServicos();
                objFormLancamentosServicos.Show();
            }
                
        }
    }
}
