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
    public partial class FormPets : Form
    {
        /// <summary>
        /// Objeto de controle de pets.
        /// </summary>
        PetController objPetController = new PetController();

        /// <summary>
        /// Objeto de controle de clientes.
        /// </summary>
        ClienteController objClienteController = new ClienteController();
        public FormPets()
        {
            InitializeComponent();
            LimpaCampos();
            AtualizarGrid();
        }

        /// <summary>
        /// Atualiza a grid conforme dados atualizados no arquivo texto.
        /// </summary>
        private void AtualizarGrid()
        {
            dgvPets.Rows.Clear();
            List<Pet> lstPets = objPetController.GetPets(false);
            foreach (Pet objPet in lstPets)
            {
                dgvPets.Rows.Add(
                    objPet.Id,
                    objPet.Nome,
                    objPet.Tutor.Id+"-"+objClienteController.GetClienteById(objPet.Tutor.Id).Nome,
                    objPet.Especie,
                    objPet.Raca,
                    objPet.Situacao
                );
            }
        }

        /// <summary>
        /// Limpa os campos da tela.
        /// </summary>
        private void LimpaCampos()
        {
            txtCodigo.Text = "";
            txtNome.Text = "";            
            cboEspecie.SelectedIndex = 0;
            cboRaca.SelectedIndex = 0;            
            cboSituacao.SelectedIndex = 0;

            cboTutor.Items.Clear();
            cboTutor.Items.Add("");

            var lstClientes = objClienteController.GetClientes(false);
            foreach (Cliente objCliente in lstClientes)
            {
                cboTutor.Items.Add(objCliente.Id + "-" + objCliente.Nome);
            }
            cboTutor.SelectedIndex = 0;
            txtNome.Focus();
        }

        private void btnConfirmar_Click(object sender, EventArgs e)
        {
            Pet objPet = new Pet();
            if(txtCodigo.Text != "") {
                objPet.Id = int.Parse(txtCodigo.Text);
            }
            
            objPet.Nome = txtNome.Text;
            objPet.Especie = cboEspecie.Text;
            objPet.Raca = cboRaca.Text;
            objPet.Situacao = cboSituacao.Text;

            Cliente objCliente = new Cliente();
            if(cboTutor.Text != "")
            {
                objCliente.Id = int.Parse(cboTutor.Text.Substring(0, cboTutor.Text.IndexOf("-")));
            }            

            objPet.Tutor = objCliente;



            if (objPetController.ValidaPet(objPet))
            {
                List<Pet> lstPets = new List<Pet>();
                for (int intI = 0; intI < dgvPets.Rows.Count; intI++)
                {
                    Pet objPetFor = new Pet();
                    objPetFor.Id = int.Parse(dgvPets.Rows[intI].Cells[0].Value.ToString());
                    objPetFor.Nome = dgvPets.Rows[intI].Cells[1].Value.ToString();
                    objPetFor.Especie = dgvPets.Rows[intI].Cells[3].Value.ToString();
                    objPetFor.Raca = dgvPets.Rows[intI].Cells[4].Value.ToString();
                    objPetFor.Situacao = dgvPets.Rows[intI].Cells[5].Value.ToString();

                    string strCliente = dgvPets.Rows[intI].Cells[2].Value.ToString();
                    objPetFor.Tutor = objClienteController.GetClienteById(int.Parse(strCliente.Substring(0, strCliente.IndexOf("-"))));
                    lstPets.Add(objPetFor);
                }

                objPetController.AtualizarPet(objPet, lstPets);
                AtualizarGrid();
                LimpaCampos();
            }
            else
            {
                MessageBox.Show("Os campos obrigatórios não estão preenchidos corretamente.", "Atenção");
            }
        }

        private void btnCancelar_Click(object sender, EventArgs e)
        {
            LimpaCampos();
        }

        private void dgvPets_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            txtCodigo.Text = this.dgvPets.CurrentRow.Cells[0].Value.ToString();
            txtNome.Text = this.dgvPets.CurrentRow.Cells[1].Value.ToString();  
            cboTutor.Text = this.dgvPets.CurrentRow.Cells[2].Value.ToString();
            cboEspecie.Text = this.dgvPets.CurrentRow.Cells[clnEspecie.Name].Value.ToString();
            cboRaca.Text = this.dgvPets.CurrentRow.Cells[4].Value.ToString();
            cboSituacao.SelectedItem = this.dgvPets.CurrentRow.Cells[5].Value.ToString();

        }
    }
}
