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
        PetController objPetController = new PetController();
        ClienteController objClienteController = new ClienteController();
        public FormPets()
        {
            InitializeComponent();
            limpaCampos();
            AtualizarGrid();
        }
        private void AtualizarGrid()
        {
            dgvPets.Rows.Clear();
            foreach (Pet objPet in objPetController.GetPets())
            {
                dgvPets.Rows.Add(
                    objPet.Id,
                    objPet.Nome,
                    objPet.Tutor.Id,
                    objClienteController.GetClienteById(objPet.Tutor.Id).Nome,
                    objPet.Especie,
                    objPet.Raca                    
                );
            }
        }

        private void limpaCampos()
        {
            txtCodigo.Text = "";
            txtNome.Text = "";
            txtTutor.Text = "";
            cboEspecie.SelectedIndex = 0;
            cboRaca.SelectedIndex = -1;

            
            foreach (Cliente objCliente in objClienteController.GetClientes())
            {
                cboTutor.Items.Add(objCliente.Id + "-" + objCliente.Nome);
            }
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

            Cliente objCliente = new Cliente();
            objCliente.Id= int.Parse(cboTutor.Text.Substring(0, cboTutor.Text.IndexOf("-")));

            objPet.Tutor = objCliente;



            if (objPetController.ValidaPet(objPet))
            {
                List<Pet> lstPets = new List<Pet>();
                for (int intI = 0; intI < dgvPets.Rows.Count - 1; intI++)
                {
                    Pet objPetFor = new Pet();
                    objPetFor.Id = int.Parse(dgvPets.Rows[intI].Cells[0].Value.ToString());
                    objPetFor.Nome = dgvPets.Rows[intI].Cells[1].Value.ToString();
                    objPetFor.Especie = dgvPets.Rows[intI].Cells[4].Value.ToString();
                    objPetFor.Raca = dgvPets.Rows[intI].Cells[5].Value.ToString();

                    Cliente objClienteFor = new Cliente();
                    objClienteFor.Id = int.Parse(dgvPets.Rows[intI].Cells[2].Value.ToString());

                    objPetFor.Tutor = objClienteFor;

                    lstPets.Add(objPetFor);
                }

                objPetController.AtualizarPet(objPet, lstPets);
                AtualizarGrid();
                limpaCampos();
            }
        }

        private void btnCancelar_Click(object sender, EventArgs e)
        {
            limpaCampos();
        }

        private void dgvPets_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            txtCodigo.Text = this.dgvPets.CurrentRow.Cells[0].Value.ToString();
            txtNome.Text = this.dgvPets.CurrentRow.Cells[1].Value.ToString();
            txtTutor.Text = this.dgvPets.CurrentRow.Cells[2].Value.ToString();
            cboEspecie.Text = this.dgvPets.CurrentRow.Cells[4].Value.ToString();
            cboRaca.Text = this.dgvPets.CurrentRow.Cells[5].Value.ToString();

        }
    }
}
