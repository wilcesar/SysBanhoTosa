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
            AlimentaCombosBox();
        }
        private void AlimentaCombosBox()
        {            
            foreach(Cliente objCliente in objClienteController.GetClientes())
            {
                cboTutor.Items.Add(objCliente.Id+"-"+ objCliente.Nome);
            }
            foreach(Pet objPet in objPetController.GetPets())
            {
                cboPet.Items.Add(objPet.Id + "-" + objPet.Nome);
            }
            foreach(Servico objServico in objServicoController.GetServicos())
            {
                cboServico.Items.Add(objServico.Id + "-" + objServico.Nome);
            }
        }
        private void LimpaCampos()
        {
            txtCodigo.Text = "";
            cboTutor.SelectedIndex = 0;
            cboPet.SelectedIndex = 0;
            cboServico.SelectedIndex = 0;
            txtValor.Text = "";
        }

        private void AtualizarGrid()
        {
            dgvLancamentos.Rows.Clear();
            foreach (Lancamento objLancamento in objLancamentoServicosController.GetLancamentos())
            {
                dgvLancamentos.Rows.Add(
                    objLancamento.Id,
                    objLancamento.Cliente.Id+"-"+objLancamento.Cliente.Nome,
                    objLancamento.Pet.Id + "-" + objLancamento.Pet.Nome,
                    objLancamento.Servico.Id + "-" + objLancamento.Servico.Nome,
                    objLancamento.DataHora,
                    objLancamento.Valor
                );
            }
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

        private void btnConfirmar_Click(object sender, EventArgs e)
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
                                
                List<Lancamento> lstLancamentos = new List<Lancamento>();
                for (int intI = 0; intI < dgvLancamentos.Rows.Count - 1; intI++)
                {
                    string strCliente = dgvLancamentos.Rows[intI].Cells[1].Value.ToString();
                    string strPet = dgvLancamentos.Rows[intI].Cells[2].Value.ToString();
                    string strServico = dgvLancamentos.Rows[intI].Cells[3].Value.ToString();

                    Lancamento objLancamentoFor = new Lancamento();
                    objLancamentoFor.Id = int.Parse(dgvLancamentos.Rows[intI].Cells[0].Value.ToString());
                    

                    objLancamentoFor.Cliente =  objClienteController.GetClienteById(int.Parse(strCliente.Substring(0, strCliente.IndexOf("-"))));
                    objLancamentoFor.Pet = objPetController.GetPetById(int.Parse(strPet.ToString().Substring(0, strPet.IndexOf("-"))));
                    objLancamentoFor.Servico = objServicoController.GeServicoById(int.Parse(strServico.Substring(0, strServico.IndexOf("-"))));
                    objLancamento.Valor = float.Parse(dgvLancamentos.Rows[intI].Cells[4].Value.ToString());
                    objLancamento.DataHora = DateTime.Parse(dgvLancamentos.Rows[intI].Cells[5].Value.ToString());

                    lstLancamentos.Add(objLancamento);                    
                }
                objLancamentoServicosController.AtualizarLancamento(objLancamento, lstLancamentos);
                AtualizarGrid();
                LimpaCampos();
            }
        }
    }
}
