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
    public partial class FormClientes : Form
    {
        /// <summary>
        /// Objeto de controle de clientes.
        /// </summary>
        ClienteController objClientecontroller = new ClienteController();
        public FormClientes()
        {
            InitializeComponent();
            AtualizarGrid();
            LimpaCampos();
        }

        /// <summary>
        /// Limpa os campos da tela.
        /// </summary>
        private void LimpaCampos()
        {
            txtCodigo.Text = "";
            txtNome.Text = "";
            txtEmail.Text = "";
            txtTelefone.Text = "";
            txtLogradouro.Text = "";
            txtNumero.Text = "";
            txtBairro.Text = "";
            txtComplemento.Text = "";
            txtCEP.Text = "";
            txtCidade.Text = "";
            cboUf.SelectedIndex = 0;
            cboSituacao.SelectedIndex = 0;
            txtNome.Focus();
        }

        /// <summary>
        /// Atualiza a grid de clientes.
        /// </summary>
        private void AtualizarGrid()
        {
            dgvClientes.Rows.Clear();
            var lstClientes = objClientecontroller.GetClientes(false);
            foreach (Cliente objCliente in lstClientes)
            {
                dgvClientes.Rows.Add(
                    objCliente.Id,
                    objCliente.Nome,
                    objCliente.Email,
                    objCliente.Telefone,
                    objCliente.Endereco.Logradouro,
                    objCliente.Endereco.Numero,
                    objCliente.Endereco.Bairro,
                    objCliente.Endereco.Complemento,
                    objCliente.Endereco.Cep,
                    objCliente.Endereco.Cidade,
                    objCliente.Endereco.Uf,
                    objCliente.Situacao
                );
            }
        }
        private void btnConfirmar_Click(object sender, EventArgs e)
        {            

            Cliente objCliente = new Cliente();
            if(txtCodigo.Text != "")
            {
                objCliente.Id = int.Parse(txtCodigo.Text);
            }            
            objCliente.Nome = txtNome.Text;
            objCliente.Email = txtEmail.Text;
            objCliente.Telefone = txtTelefone.Text;
            objCliente.Situacao = cboSituacao.Text;

            Endereco objEndereco = new Endereco();
            objEndereco.Logradouro = txtLogradouro.Text;
            objEndereco.Numero = txtNumero.Text;
            objEndereco.Bairro = txtBairro.Text;
            objEndereco.Complemento = txtComplemento.Text;
            objEndereco.Cep = txtCEP.Text;
            objEndereco.Cidade = txtCidade.Text;
            objEndereco.Uf = cboUf.Text;

            objCliente.Endereco = objEndereco;

            if (objClientecontroller.ValidaCliente(objCliente))
            {                
                
                List<Cliente> lstClientes = new List<Cliente>();
                for ( int intI = 0; intI < dgvClientes.Rows.Count; intI++)
                {
                    Cliente objClienteFor = new Cliente();
                    objClienteFor.Id = int.Parse(dgvClientes.Rows[intI].Cells[0].Value.ToString());
                    objClienteFor.Nome = dgvClientes.Rows[intI].Cells[1].Value.ToString();
                    objClienteFor.Email = dgvClientes.Rows[intI].Cells[2].Value.ToString();
                    objClienteFor.Telefone = dgvClientes.Rows[intI].Cells[3].Value.ToString();
                    objClienteFor.Situacao = dgvClientes.Rows[intI].Cells[11].Value.ToString();

                    Endereco objEnderecoFor = new Endereco();
                    objEnderecoFor.Logradouro = dgvClientes.Rows[intI].Cells[4].Value.ToString();
                    objEnderecoFor.Numero = dgvClientes.Rows[intI].Cells[5].Value.ToString();
                    objEnderecoFor.Bairro = dgvClientes.Rows[intI].Cells[6].Value.ToString();
                    objEnderecoFor.Complemento = dgvClientes.Rows[intI].Cells[7].Value.ToString();
                    objEnderecoFor.Cep = dgvClientes.Rows[intI].Cells[8].Value.ToString();
                    objEnderecoFor.Cidade = dgvClientes.Rows[intI].Cells[9].Value.ToString();
                    objEnderecoFor.Uf = dgvClientes.Rows[intI].Cells[10].Value.ToString();

                    objClienteFor.Endereco = objEnderecoFor;

                    lstClientes.Add(objClienteFor);

                }
                
                objClientecontroller.AtualizarCliente(objCliente, lstClientes);
                AtualizarGrid();
                LimpaCampos();
            };

        }

        private void dgvClientes_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            txtCodigo.Text = this.dgvClientes.CurrentRow.Cells[0].Value.ToString();
            txtNome.Text = this.dgvClientes.CurrentRow.Cells[1].Value.ToString();
            txtEmail.Text = this.dgvClientes.CurrentRow.Cells[2].Value.ToString();
            txtTelefone.Text = this.dgvClientes.CurrentRow.Cells[3].Value.ToString();
            txtLogradouro.Text = this.dgvClientes.CurrentRow.Cells[4].Value.ToString();
            txtNumero.Text = this.dgvClientes.CurrentRow.Cells[5].Value.ToString(); 
            txtBairro.Text = this.dgvClientes.CurrentRow.Cells[6].Value.ToString();
            txtComplemento.Text = this.dgvClientes.CurrentRow.Cells[7].Value.ToString();
            txtCEP.Text = this.dgvClientes.CurrentRow.Cells[8].Value.ToString();
            txtCidade.Text = this.dgvClientes.CurrentRow.Cells[9].Value.ToString();
            cboUf.SelectedItem = this.dgvClientes.CurrentRow.Cells[10].Value.ToString();            
            cboSituacao.SelectedItem = this.dgvClientes.CurrentRow.Cells[11].Value.ToString();
            txtNome.Focus();
        }

        private void btnCancelar_Click(object sender, EventArgs e)
        {
            LimpaCampos();
            txtNome.Focus();
        }

        private void dgvClientes_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }
    }
}
