using SysBanhoTosa.Controllers;
using SysBanhoTosa.Models.Classes;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace SysBanhoTosa.Views
{
    public partial class FormLancamentosServicos : Form
    {
        /// <summary>
        /// Realiza lançamentos de serviços feitos
        /// </summary>
        ClienteController objClienteController = new ClienteController();
        /// <summary>
        /// Realiza lançamentos de serviços feitos
        /// </summary>
        PetController objPetController = new PetController();
        ServicoController objServicoController = new ServicoController();
        public FormLancamentosServicos()
        {
            InitializeComponent();
        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            Lancamento objLancamento = new Lancamento();
            if (txtCodigo.Text != "")
            {
                objLancamento.Id = int.Parse(txtCodigo.Text);
            }
            objLancamento.Cliente = objClienteController.GetClienteById(int.Parse(cboTutor.Text.Substring(0, cboTutor.Text.IndexOf("-"))));
            objLancamento.Pet = objPetController.GetPetById(int.Parse(cboPet.Text.Substring(0, cboTutor.Text.IndexOf("-"))));
            objLancamento.Servico = objServicoController.GeServicoById(int.Parse(cboServico.Text.Substring(0, cboTutor.Text.IndexOf("-"))));
            objLancamento.Valor = float.Parse(txtValor.Text);               
        }

        private void btnRemover_Click(object sender, EventArgs e)
        {

        }
    }
}
