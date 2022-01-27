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
        /// Controller de clientes
        /// </summary>
        ClienteController objClienteController = new ClienteController();
        /// <summary>
        /// Controller de pets
        /// </summary>
        PetController objPetController = new PetController();
        /// <summary>
        /// Controller de serviços
        /// </summary>
        ServicoController objServicoController = new ServicoController();
        LancamentoServicosController objLancamentoServicosController = new LancamentoServicosController();
        public FormLancamentosServicos()
        {
            InitializeComponent();
        }
        private void LimpaCampos()
        {
            txtCodigo.Text = "";
            cboTutor.SelectedIndex = 0;
            cboPet.SelectedIndex = 0;
            cboServico.SelectedIndex = 0;            
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
            objLancamento.DataHora = dtpAgendamento.Value;
            if (objLancamentoServicosController.ValidaLancamento(objLancamento))
            {
                dgvLancamentos.Rows.Add(1,
                    objLancamento.Cliente.Id,
                    objLancamento.Pet.Id,
                    objLancamento.Servico.Id,
                    objLancamento.Valor,
                    objLancamento.DataHora);
            }

        }

        private void btnRemover_Click(object sender, EventArgs e)
        {
            
        }
    }
}
