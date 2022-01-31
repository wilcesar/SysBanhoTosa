using SysBanhoTosa.Controllers;
using SysBanhoTosa.Models.Classes;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace SysBanhoTosa.Views
{
    public partial class FormServicos : Form
    {
        /// <summary>
        /// Objeto de controle de serviços.
        /// </summary>
        ServicoController objServicoController = new ServicoController();
        public FormServicos()
        {
            InitializeComponent();
            AtualizarGrid();
        }

        /// <summary>
        /// Atualiza a grid conforme os dados atualizados vindo do arquivo de texto.
        /// </summary>
        private void AtualizarGrid()
        {
            dgvServicos.Rows.Clear();
            var lstSerivicos = objServicoController.GetServicos(false);
            foreach (Servico objServico in lstSerivicos)
            {
                dgvServicos.Rows.Add(
                    objServico.Id,
                    objServico.Nome,
                    objServico.Descricao,
                    objServico.Valor,
                    objServico.Situacao
                );
            }
        }

        /// <summary>
        /// Limpa os campos da tela;
        /// </summary>
        private void LimpaCampos()
        {
            txtCodigo.Text = "";
            txtNome.Text = "";
            txtDescricao.Text = "";
            txtValor.Text = "";
            cboSituacao.SelectedIndex = 0;
        }

        private void FormServicos_Load(object sender, EventArgs e)
        {

        }

        private void btnConfirmar_Click(object sender, EventArgs e)
        {
            Servico objServico = new Servico();
            if(txtCodigo.Text != "")
            {
                objServico.Id = int.Parse(txtCodigo.Text);
            }
            objServico.Nome = txtNome.Text;
            objServico.Descricao = txtDescricao.Text;
            objServico.Valor = decimal.Parse(txtValor.Text, CultureInfo.InvariantCulture.NumberFormat);
            objServico.Situacao = cboSituacao.Text;

            if (objServicoController.ValidaServico(objServico)){
                List<Servico> lstServicos = new List<Servico>();

                for (int intI = 0; intI < dgvServicos.Rows.Count - 1; intI++)
                {
                    Servico objServicoFor = new Servico();
                    objServicoFor.Id = int.Parse(dgvServicos.Rows[intI].Cells[0].Value.ToString());
                    objServicoFor.Nome = dgvServicos.Rows[intI].Cells[1].Value.ToString();
                    objServicoFor.Descricao = dgvServicos.Rows[intI].Cells[2].Value.ToString();
                    objServicoFor.Valor = decimal.Parse(dgvServicos.Rows[intI].Cells[3].Value.ToString());
                    objServicoFor.Situacao = dgvServicos.Rows[intI].Cells[4].Value.ToString();

                    lstServicos.Add(objServicoFor);
                }
                objServicoController.AtualizarServico(objServico, lstServicos);
                AtualizarGrid();
                LimpaCampos();
            }
        }

        private void btnCancelar_Click(object sender, EventArgs e)
        {
            LimpaCampos();
        }

        private void dgvServicos_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            txtCodigo.Text = this.dgvServicos.CurrentRow.Cells[0].Value.ToString();
            txtNome.Text = this.dgvServicos.CurrentRow.Cells[1].Value.ToString();
            txtDescricao.Text = this.dgvServicos.CurrentRow.Cells[2].Value.ToString();
            txtValor.Text = this.dgvServicos.CurrentRow.Cells[3].Value.ToString();
            cboSituacao.Text = this.dgvServicos.CurrentRow.Cells[4].Value.ToString();
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
    }
}
