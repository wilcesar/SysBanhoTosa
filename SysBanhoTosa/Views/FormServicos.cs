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
    public partial class FormServicos : Form
    {
        ServicoController objServicoController = new ServicoController();
        public FormServicos()
        {
            InitializeComponent();
            AtualizarGrid();
        }
        private void AtualizarGrid()
        {
            dgvServicos.Rows.Clear();
            foreach (Servico objServico in objServicoController.GetServicos())
            {
                dgvServicos.Rows.Add(
                    objServico.Id,
                    objServico.Nome,
                    objServico.Descricao
                );
            }
        }

        private void LimpaCampos()
        {
            txtCodigo.Text = "";
            txtNome.Text = "";
            txtDescricao.Text = "";
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

            if (objServicoController.ValidaServico(objServico)){
                List<Servico> lstServicos = new List<Servico>();

                for (int intI = 0; intI < dgvServicos.Rows.Count - 1; intI++)
                {
                    Servico objServicoFor = new Servico();
                    objServicoFor.Id = int.Parse(dgvServicos.Rows[intI].Cells[0].Value.ToString());
                    objServicoFor.Nome = dgvServicos.Rows[intI].Cells[1].Value.ToString();
                    objServicoFor.Descricao = dgvServicos.Rows[intI].Cells[2].Value.ToString();

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
        }
    }
}
