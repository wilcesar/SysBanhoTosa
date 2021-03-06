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
        /// Objeto de controle de clientes.
        /// </summary>
        /// 
        ClienteController objClienteController = new ClienteController();
        /// <summary>
        /// Objeto de controle de pets.
        /// </summary>
        /// 
        PetController objPetController = new PetController();
        /// <summary>
        /// Objeto de controle de serviços.
        /// </summary>
        ServicoController objServicoController = new ServicoController();

        /// <summary>
        /// Objeto de controle de lançamento de serviços.
        /// </summary>
        LancamentoServicosController objLancamentoServicosController = new LancamentoServicosController();
        public FormLancamentosServicos()
        {
            InitializeComponent();
            AlimentaCombosBox();
            LimpaCampos();
            AtualizarGrid();
        }
        /// <summary>
        /// Alimenta os combobox da tela.
        /// </summary>
        private void AlimentaCombosBox()
        {
            cboTutor.Items.Add("");
            var lstClientes = objClienteController.GetClientes(true);
            foreach (Cliente objCliente in lstClientes)
            {
                cboTutor.Items.Add(objCliente.Id+"-"+ objCliente.Nome);
            }

            cboPet.Items.Add("");
            var lstPets = objPetController.GetPets(true);
            foreach (Pet objPet in lstPets)
            {
                cboPet.Items.Add(objPet.Id + "-" + objPet.Nome);
            }

            cboServico.Items.Add("");
            var lstServicos = objServicoController.GetServicos(true);
            foreach (Servico objServico in lstServicos)
            {
                cboServico.Items.Add(objServico.Id + "-" + objServico.Nome);
            }
        }

        /// <summary>
        /// Limpa os campos da tela.
        /// </summary>
        private void LimpaCampos()
        {
            txtCodigo.Text = "";
            cboTutor.SelectedIndex = 0;
            cboPet.SelectedIndex = -1;
            cboServico.SelectedIndex = 0;
            txtValor.Text = "";
            cboSituacao.SelectedIndex =0;
            rtfObservacao.Text = "";
            cboTutor.Focus();
        }

        /// <summary>
        /// Atualiza a grid, conforme o arquivo de texto.
        /// </summary>
        private void AtualizarGrid()
        {
            dgvLancamentos.Rows.Clear();
            var lstLancamentos = objLancamentoServicosController.GetLancamentos();
            foreach (Lancamento objLancamento in lstLancamentos)
            {
                dgvLancamentos.Rows.Add(
                    objLancamento.Id,
                    objLancamento.Cliente.Id+"-"+objLancamento.Cliente.Nome,
                    objLancamento.Pet.Id + "-" + objLancamento.Pet.Nome,
                    objLancamento.Servico.Id + "-" + objLancamento.Servico.Nome,
                    objLancamento.Valor,
                    objLancamento.DataHora,                    
                    objLancamento.Situacao,
                    objLancamento.Observacao
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
            objLancamento.Valor = decimal.Parse(txtValor.Text);
            objLancamento.DataHora = dtpAgendamento.Value;
            objLancamento.Situacao = cboSituacao.Text;
            objLancamento.Observacao = rtfObservacao.Text;

            if (objLancamentoServicosController.ValidaLancamento(objLancamento))
            {
                dgvLancamentos.Rows.Add(1,
                    objLancamento.Cliente.Id,
                    objLancamento.Pet.Id,
                    objLancamento.Servico.Id,
                    objLancamento.Valor,
                    objLancamento.DataHora,
                    objLancamento.Situacao,
                    objLancamento.Observacao);
            }

        }        

        private void btnConfirmar_Click(object sender, EventArgs e)
        {
            Lancamento objLancamento = new Lancamento();
            if (txtCodigo.Text != "")
            {
                objLancamento.Id = int.Parse(txtCodigo.Text);
            }            
            //Tipo de dado para substituir o float            
            if(cboTutor.Text != "")
            {
                objLancamento.Cliente = objClienteController.GetClienteById(int.Parse(cboTutor.Text.Substring(0, cboTutor.Text.IndexOf("-"))));
            }
            if (cboPet.Text != "")
            {
                objLancamento.Pet = objPetController.GetPetById(int.Parse(cboPet.Text.Substring(0, cboPet.Text.IndexOf("-"))));
            }
            if (cboServico.Text != "")
            {
                objLancamento.Servico = objServicoController.GeServicoById(int.Parse(cboServico.Text.Substring(0, cboServico.Text.IndexOf("-"))));
            }
            if (txtValor.Text != "")
            {
                objLancamento.Valor = decimal.Parse(txtValor.Text);
            }
            if(cboSituacao.Text != "")
            {
                objLancamento.Situacao = cboSituacao.Text;
            }                
            objLancamento.DataHora = dtpAgendamento.Value;            
            objLancamento.Observacao = rtfObservacao.Text;

            if (objLancamentoServicosController.ValidaLancamento(objLancamento))
            {
                                
                List<Lancamento> lstLancamentos = new List<Lancamento>();
                for (int intI = 0; intI < dgvLancamentos.Rows.Count; intI++)
                {
                    string strCliente = dgvLancamentos.Rows[intI].Cells[1].Value.ToString();
                    string strPet = dgvLancamentos.Rows[intI].Cells[2].Value.ToString();
                    string strServico = dgvLancamentos.Rows[intI].Cells[3].Value.ToString();

                    Lancamento objLancamentoFor = new Lancamento();
                    objLancamentoFor.Id = int.Parse(dgvLancamentos.Rows[intI].Cells[0].Value.ToString());
                    

                    objLancamentoFor.Cliente =  objClienteController.GetClienteById(int.Parse(strCliente.Substring(0, strCliente.IndexOf("-"))));
                    objLancamentoFor.Pet = objPetController.GetPetById(int.Parse(strPet.ToString().Substring(0, strPet.IndexOf("-"))));
                    objLancamentoFor.Servico = objServicoController.GeServicoById(int.Parse(strServico.Substring(0, strServico.IndexOf("-"))));
                    objLancamentoFor.Valor = decimal.Parse(dgvLancamentos.Rows[intI].Cells[4].Value.ToString());
                    objLancamentoFor.DataHora = DateTime.Parse(dgvLancamentos.Rows[intI].Cells[5].Value.ToString());
                    objLancamentoFor.Situacao = dgvLancamentos.Rows[intI].Cells[6].Value.ToString();
                    objLancamentoFor.Observacao = dgvLancamentos.Rows[intI].Cells[7].Value.ToString();

                    lstLancamentos.Add(objLancamentoFor);                    
                }
                objLancamentoServicosController.AtualizarLancamento(objLancamento, lstLancamentos);
                AtualizarGrid();
                LimpaCampos();
            }
            else
            {
                MessageBox.Show("Os campos obrigatórios não estão preenchidos corretamente.", "Atenção");
            }
        }

        private void btnImprimir_Click(object sender, EventArgs e)
        {
            if (txtCodigo.Text != "")
            {
                Lancamento objLancamento = new Lancamento();

                objLancamento.Id = int.Parse(txtCodigo.Text);
                objLancamento.Cliente = objClienteController.GetClienteById(int.Parse(cboTutor.Text.Substring(0, cboTutor.Text.IndexOf("-"))));
                objLancamento.Pet = objPetController.GetPetById(int.Parse(cboPet.Text.Substring(0, cboTutor.Text.IndexOf("-"))));
                objLancamento.Servico = objServicoController.GeServicoById(int.Parse(cboServico.Text.Substring(0, cboTutor.Text.IndexOf("-"))));
                objLancamento.Valor = decimal.Parse(txtValor.Text);
                objLancamento.DataHora = dtpAgendamento.Value;
                objLancamento.Situacao = cboSituacao.Text;
                objLancamento.Observacao = rtfObservacao.Text;

                objLancamentoServicosController.ImprimirLancamento(objLancamento);
            }
        }

        private void dgvLancamentos_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            txtCodigo.Text = this.dgvLancamentos.CurrentRow.Cells[0].Value.ToString();           
            cboTutor.Text = this.dgvLancamentos.CurrentRow.Cells[1].Value.ToString();
            cboPet.Text = this.dgvLancamentos.CurrentRow.Cells[2].Value.ToString();
            cboServico.Text = this.dgvLancamentos.CurrentRow.Cells[3].Value.ToString();
            txtValor.Text = this.dgvLancamentos.CurrentRow.Cells[4].Value.ToString();
            dtpAgendamento.Value = DateTime.Parse(this.dgvLancamentos.CurrentRow.Cells[5].Value.ToString());
            cboSituacao.Text = this.dgvLancamentos.CurrentRow.Cells[6].Value.ToString();
            rtfObservacao.Text = this.dgvLancamentos.CurrentRow.Cells[7].Value.ToString();
        }

        private void btnCancelar_Click(object sender, EventArgs e)
        {
            txtCodigo.Text = "";
            cboTutor.SelectedIndex = 0;
            cboPet.Items.Clear();
            cboPet.SelectedIndex = -1;
            cboPet.Text = "";
            cboServico.SelectedIndex = 0;
            txtValor.Text = "0.00";            
            cboSituacao.SelectedIndex = 0;
            rtfObservacao.Text = "";
            
        }

        private void cboTutor_SelectedIndexChanged(object sender, EventArgs e)
        {
            cboPet.Items.Clear();
            if (cboTutor.Text != "")
            {
                var lstPetsByCliente = objPetController.GetPetsByCliente(int.Parse(cboTutor.Text.Substring(0, cboTutor.Text.IndexOf("-"))));
                foreach (Pet objPet in lstPetsByCliente)
                {
                    cboPet.Items.Add(objPet.Id + "-" + objPet.Nome);
                }
            };            
        }

        private void cboServico_SelectedIndexChanged(object sender, EventArgs e)
        {
            if(cboServico.Text != "")
            {
                Servico objServico = objServicoController.GeServicoById(int.Parse(cboServico.Text.Substring(0, cboServico.Text.IndexOf("-"))));
                txtValor.Text = objServico.Valor.ToString();
            }            
        }

        private void txtValor_Leave(object sender, EventArgs e)
        {
            if (!decimal.TryParse(txtValor.Text, out decimal decValor))
            {
                MessageBox.Show("O valor está incorreto", "Atenção");
                txtValor.Text = "";
                txtValor.Focus();
            }
        }

        private void btnImpRelatorio_Click(object sender, EventArgs e)
        {
            objLancamentoServicosController.ImprimirRelatorioLancamentos();
        }
    }
}
