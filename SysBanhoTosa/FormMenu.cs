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

        private void btnClientes_Click(object sender, EventArgs e)
        {
            FormClientes objFormCLientes = new FormClientes();
            objFormCLientes.Show();

        }

        private void btnPets_Click(object sender, EventArgs e)
        {
            FormPets objFormPets = new FormPets();
            objFormPets.Show();
        }

        private void btnServicos_Click(object sender, EventArgs e)
        {
            FormServicos objFormServicos = new FormServicos();
            objFormServicos.Show();
        }

        private void btnLancamentoServicos_Click(object sender, EventArgs e)
        {

        }
    }
}
