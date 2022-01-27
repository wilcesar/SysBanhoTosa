
namespace SysBanhoTosa.Views
{
    partial class FormLancamentoServicos
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.pnlLancamento = new System.Windows.Forms.Panel();
            this.dtpAgendamento = new System.Windows.Forms.DateTimePicker();
            this.lblValor = new System.Windows.Forms.Label();
            this.lblServico = new System.Windows.Forms.Label();
            this.lblPet = new System.Windows.Forms.Label();
            this.lblTutor = new System.Windows.Forms.Label();
            this.txtValor = new System.Windows.Forms.TextBox();
            this.cboServico = new System.Windows.Forms.ComboBox();
            this.cboPet = new System.Windows.Forms.ComboBox();
            this.cboTutor = new System.Windows.Forms.ComboBox();
            this.pnlGrid = new System.Windows.Forms.Panel();
            this.dgvLancamentos = new System.Windows.Forms.DataGridView();
            this.btnAdd = new System.Windows.Forms.Button();
            this.btnRemover = new System.Windows.Forms.Button();
            this.clnPet = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.clnServico = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.clnValor = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.clnData = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.txtCodigo = new System.Windows.Forms.TextBox();
            this.lblCodigo = new System.Windows.Forms.Label();
            this.pnlLancamento.SuspendLayout();
            this.pnlGrid.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvLancamentos)).BeginInit();
            this.SuspendLayout();
            // 
            // pnlLancamento
            // 
            this.pnlLancamento.Controls.Add(this.txtCodigo);
            this.pnlLancamento.Controls.Add(this.lblCodigo);
            this.pnlLancamento.Controls.Add(this.btnRemover);
            this.pnlLancamento.Controls.Add(this.btnAdd);
            this.pnlLancamento.Controls.Add(this.dtpAgendamento);
            this.pnlLancamento.Controls.Add(this.lblValor);
            this.pnlLancamento.Controls.Add(this.lblServico);
            this.pnlLancamento.Controls.Add(this.lblPet);
            this.pnlLancamento.Controls.Add(this.lblTutor);
            this.pnlLancamento.Controls.Add(this.txtValor);
            this.pnlLancamento.Controls.Add(this.cboServico);
            this.pnlLancamento.Controls.Add(this.cboPet);
            this.pnlLancamento.Controls.Add(this.cboTutor);
            this.pnlLancamento.Location = new System.Drawing.Point(2, 0);
            this.pnlLancamento.Name = "pnlLancamento";
            this.pnlLancamento.Size = new System.Drawing.Size(676, 217);
            this.pnlLancamento.TabIndex = 0;
            // 
            // dtpAgendamento
            // 
            this.dtpAgendamento.Location = new System.Drawing.Point(463, 121);
            this.dtpAgendamento.Name = "dtpAgendamento";
            this.dtpAgendamento.Size = new System.Drawing.Size(182, 20);
            this.dtpAgendamento.TabIndex = 8;
            // 
            // lblValor
            // 
            this.lblValor.AutoSize = true;
            this.lblValor.Location = new System.Drawing.Point(348, 105);
            this.lblValor.Name = "lblValor";
            this.lblValor.Size = new System.Drawing.Size(31, 13);
            this.lblValor.TabIndex = 7;
            this.lblValor.Text = "Valor";
            // 
            // lblServico
            // 
            this.lblServico.AutoSize = true;
            this.lblServico.Location = new System.Drawing.Point(10, 55);
            this.lblServico.Name = "lblServico";
            this.lblServico.Size = new System.Drawing.Size(43, 13);
            this.lblServico.TabIndex = 6;
            this.lblServico.Text = "Servico";
            // 
            // lblPet
            // 
            this.lblPet.AutoSize = true;
            this.lblPet.Location = new System.Drawing.Point(348, 56);
            this.lblPet.Name = "lblPet";
            this.lblPet.Size = new System.Drawing.Size(23, 13);
            this.lblPet.TabIndex = 5;
            this.lblPet.Text = "Pet";
            // 
            // lblTutor
            // 
            this.lblTutor.AutoSize = true;
            this.lblTutor.Location = new System.Drawing.Point(348, 7);
            this.lblTutor.Name = "lblTutor";
            this.lblTutor.Size = new System.Drawing.Size(32, 13);
            this.lblTutor.TabIndex = 4;
            this.lblTutor.Text = "Tutor";
            // 
            // txtValor
            // 
            this.txtValor.Location = new System.Drawing.Point(348, 121);
            this.txtValor.Name = "txtValor";
            this.txtValor.Size = new System.Drawing.Size(95, 20);
            this.txtValor.TabIndex = 3;
            // 
            // cboServico
            // 
            this.cboServico.FormattingEnabled = true;
            this.cboServico.Location = new System.Drawing.Point(10, 72);
            this.cboServico.Name = "cboServico";
            this.cboServico.Size = new System.Drawing.Size(297, 21);
            this.cboServico.TabIndex = 2;
            // 
            // cboPet
            // 
            this.cboPet.FormattingEnabled = true;
            this.cboPet.Location = new System.Drawing.Point(348, 72);
            this.cboPet.Name = "cboPet";
            this.cboPet.Size = new System.Drawing.Size(297, 21);
            this.cboPet.TabIndex = 1;
            // 
            // cboTutor
            // 
            this.cboTutor.FormattingEnabled = true;
            this.cboTutor.Location = new System.Drawing.Point(348, 23);
            this.cboTutor.Name = "cboTutor";
            this.cboTutor.Size = new System.Drawing.Size(297, 21);
            this.cboTutor.TabIndex = 0;
            // 
            // pnlGrid
            // 
            this.pnlGrid.Controls.Add(this.dgvLancamentos);
            this.pnlGrid.Location = new System.Drawing.Point(2, 220);
            this.pnlGrid.Name = "pnlGrid";
            this.pnlGrid.Size = new System.Drawing.Size(676, 228);
            this.pnlGrid.TabIndex = 1;
            // 
            // dgvLancamentos
            // 
            this.dgvLancamentos.BackgroundColor = System.Drawing.SystemColors.Control;
            this.dgvLancamentos.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvLancamentos.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.clnPet,
            this.clnServico,
            this.clnValor,
            this.clnData});
            this.dgvLancamentos.Location = new System.Drawing.Point(0, 3);
            this.dgvLancamentos.Name = "dgvLancamentos";
            this.dgvLancamentos.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvLancamentos.Size = new System.Drawing.Size(662, 225);
            this.dgvLancamentos.TabIndex = 0;
            // 
            // btnAdd
            // 
            this.btnAdd.Location = new System.Drawing.Point(69, 121);
            this.btnAdd.Name = "btnAdd";
            this.btnAdd.Size = new System.Drawing.Size(75, 23);
            this.btnAdd.TabIndex = 9;
            this.btnAdd.Text = "Adicionar";
            this.btnAdd.UseVisualStyleBackColor = true;
            this.btnAdd.Click += new System.EventHandler(this.btnAdd_Click);
            // 
            // btnRemover
            // 
            this.btnRemover.Location = new System.Drawing.Point(150, 121);
            this.btnRemover.Name = "btnRemover";
            this.btnRemover.Size = new System.Drawing.Size(75, 23);
            this.btnRemover.TabIndex = 10;
            this.btnRemover.Text = "Remover";
            this.btnRemover.UseVisualStyleBackColor = true;
            // 
            // clnPet
            // 
            this.clnPet.HeaderText = "PET";
            this.clnPet.Name = "clnPet";
            this.clnPet.Width = 200;
            // 
            // clnServico
            // 
            this.clnServico.HeaderText = "SERVIÇO";
            this.clnServico.Name = "clnServico";
            this.clnServico.Width = 200;
            // 
            // clnValor
            // 
            this.clnValor.HeaderText = "VALOR";
            this.clnValor.Name = "clnValor";
            // 
            // clnData
            // 
            this.clnData.HeaderText = "DATA";
            this.clnData.Name = "clnData";
            // 
            // txtCodigo
            // 
            this.txtCodigo.Enabled = false;
            this.txtCodigo.Location = new System.Drawing.Point(10, 26);
            this.txtCodigo.Name = "txtCodigo";
            this.txtCodigo.Size = new System.Drawing.Size(121, 20);
            this.txtCodigo.TabIndex = 11;
            // 
            // lblCodigo
            // 
            this.lblCodigo.AutoSize = true;
            this.lblCodigo.Location = new System.Drawing.Point(10, 9);
            this.lblCodigo.Name = "lblCodigo";
            this.lblCodigo.Size = new System.Drawing.Size(40, 13);
            this.lblCodigo.TabIndex = 12;
            this.lblCodigo.Text = "Código";
            // 
            // FormLancamentoServicos
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(768, 450);
            this.Controls.Add(this.pnlGrid);
            this.Controls.Add(this.pnlLancamento);
            this.Name = "FormLancamentoServicos";
            this.Text = "Lancamento de servicos";
            this.pnlLancamento.ResumeLayout(false);
            this.pnlLancamento.PerformLayout();
            this.pnlGrid.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgvLancamentos)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel pnlLancamento;
        private System.Windows.Forms.Panel pnlGrid;
        private System.Windows.Forms.ComboBox cboServico;
        private System.Windows.Forms.ComboBox cboPet;
        private System.Windows.Forms.ComboBox cboTutor;
        private System.Windows.Forms.TextBox txtValor;
        private System.Windows.Forms.Label lblTutor;
        private System.Windows.Forms.Label lblValor;
        private System.Windows.Forms.Label lblServico;
        private System.Windows.Forms.Label lblPet;
        private System.Windows.Forms.DataGridView dgvLancamentos;
        private System.Windows.Forms.DateTimePicker dtpAgendamento;
        private System.Windows.Forms.Button btnRemover;
        private System.Windows.Forms.Button btnAdd;
        private System.Windows.Forms.DataGridViewTextBoxColumn clnPet;
        private System.Windows.Forms.DataGridViewTextBoxColumn clnServico;
        private System.Windows.Forms.DataGridViewTextBoxColumn clnValor;
        private System.Windows.Forms.DataGridViewTextBoxColumn clnData;
        private System.Windows.Forms.TextBox txtCodigo;
        private System.Windows.Forms.Label lblCodigo;
    }
}