
namespace SysBanhoTosa.Views
{
    partial class FormLancamentosServicos
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
            this.rtfObservacao = new System.Windows.Forms.RichTextBox();
            this.lblObservacao = new System.Windows.Forms.Label();
            this.lblData = new System.Windows.Forms.Label();
            this.lblSituacao = new System.Windows.Forms.Label();
            this.cboSituacao = new System.Windows.Forms.ComboBox();
            this.txtCodigo = new System.Windows.Forms.TextBox();
            this.lblCodigo = new System.Windows.Forms.Label();
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
            this.clnId = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.clnCliente = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.clnPet = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.clnServico = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.clnValor = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.clnData = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.clnSituacao = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.clnObservacao = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.pnlBotoes = new System.Windows.Forms.Panel();
            this.btnImprimir = new System.Windows.Forms.Button();
            this.btnCancelar = new System.Windows.Forms.Button();
            this.btnConfirmar = new System.Windows.Forms.Button();
            this.btnImpRelatorio = new System.Windows.Forms.Button();
            this.pnlLancamento.SuspendLayout();
            this.pnlGrid.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvLancamentos)).BeginInit();
            this.pnlBotoes.SuspendLayout();
            this.SuspendLayout();
            // 
            // pnlLancamento
            // 
            this.pnlLancamento.Controls.Add(this.rtfObservacao);
            this.pnlLancamento.Controls.Add(this.lblObservacao);
            this.pnlLancamento.Controls.Add(this.lblData);
            this.pnlLancamento.Controls.Add(this.lblSituacao);
            this.pnlLancamento.Controls.Add(this.cboSituacao);
            this.pnlLancamento.Controls.Add(this.txtCodigo);
            this.pnlLancamento.Controls.Add(this.lblCodigo);
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
            this.pnlLancamento.Size = new System.Drawing.Size(676, 185);
            this.pnlLancamento.TabIndex = 0;
            // 
            // rtfObservacao
            // 
            this.rtfObservacao.Location = new System.Drawing.Point(348, 112);
            this.rtfObservacao.Name = "rtfObservacao";
            this.rtfObservacao.Size = new System.Drawing.Size(297, 70);
            this.rtfObservacao.TabIndex = 6;
            this.rtfObservacao.Text = "";
            // 
            // lblObservacao
            // 
            this.lblObservacao.AutoSize = true;
            this.lblObservacao.Location = new System.Drawing.Point(348, 96);
            this.lblObservacao.Name = "lblObservacao";
            this.lblObservacao.Size = new System.Drawing.Size(65, 13);
            this.lblObservacao.TabIndex = 16;
            this.lblObservacao.Text = "Observação";
            // 
            // lblData
            // 
            this.lblData.AutoSize = true;
            this.lblData.Location = new System.Drawing.Point(122, 102);
            this.lblData.Name = "lblData";
            this.lblData.Size = new System.Drawing.Size(30, 13);
            this.lblData.TabIndex = 15;
            this.lblData.Text = "Data";
            // 
            // lblSituacao
            // 
            this.lblSituacao.AutoSize = true;
            this.lblSituacao.Location = new System.Drawing.Point(10, 145);
            this.lblSituacao.Name = "lblSituacao";
            this.lblSituacao.Size = new System.Drawing.Size(49, 13);
            this.lblSituacao.TabIndex = 14;
            this.lblSituacao.Text = "Situação";
            // 
            // cboSituacao
            // 
            this.cboSituacao.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cboSituacao.FormattingEnabled = true;
            this.cboSituacao.Items.AddRange(new object[] {
            "1-ABERTO",
            "2-EM PROCESSO",
            "3-FINALIZADO",
            "4-CANCELADO"});
            this.cboSituacao.Location = new System.Drawing.Point(10, 161);
            this.cboSituacao.Name = "cboSituacao";
            this.cboSituacao.Size = new System.Drawing.Size(297, 21);
            this.cboSituacao.TabIndex = 5;
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
            // dtpAgendamento
            // 
            this.dtpAgendamento.Location = new System.Drawing.Point(125, 118);
            this.dtpAgendamento.Name = "dtpAgendamento";
            this.dtpAgendamento.Size = new System.Drawing.Size(182, 20);
            this.dtpAgendamento.TabIndex = 4;
            // 
            // lblValor
            // 
            this.lblValor.AutoSize = true;
            this.lblValor.Location = new System.Drawing.Point(10, 102);
            this.lblValor.Name = "lblValor";
            this.lblValor.Size = new System.Drawing.Size(31, 13);
            this.lblValor.TabIndex = 7;
            this.lblValor.Text = "Valor";
            // 
            // lblServico
            // 
            this.lblServico.AutoSize = true;
            this.lblServico.Location = new System.Drawing.Point(348, 55);
            this.lblServico.Name = "lblServico";
            this.lblServico.Size = new System.Drawing.Size(43, 13);
            this.lblServico.TabIndex = 6;
            this.lblServico.Text = "Serviço";
            // 
            // lblPet
            // 
            this.lblPet.AutoSize = true;
            this.lblPet.Location = new System.Drawing.Point(10, 56);
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
            this.txtValor.Location = new System.Drawing.Point(10, 118);
            this.txtValor.Name = "txtValor";
            this.txtValor.Size = new System.Drawing.Size(95, 20);
            this.txtValor.TabIndex = 3;
            this.txtValor.Leave += new System.EventHandler(this.txtValor_Leave);
            // 
            // cboServico
            // 
            this.cboServico.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cboServico.FormattingEnabled = true;
            this.cboServico.Location = new System.Drawing.Point(348, 72);
            this.cboServico.Name = "cboServico";
            this.cboServico.Size = new System.Drawing.Size(297, 21);
            this.cboServico.TabIndex = 2;
            this.cboServico.SelectedIndexChanged += new System.EventHandler(this.cboServico_SelectedIndexChanged);
            // 
            // cboPet
            // 
            this.cboPet.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cboPet.FormattingEnabled = true;
            this.cboPet.Location = new System.Drawing.Point(10, 72);
            this.cboPet.Name = "cboPet";
            this.cboPet.Size = new System.Drawing.Size(297, 21);
            this.cboPet.TabIndex = 1;
            // 
            // cboTutor
            // 
            this.cboTutor.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cboTutor.FormattingEnabled = true;
            this.cboTutor.Location = new System.Drawing.Point(348, 23);
            this.cboTutor.Name = "cboTutor";
            this.cboTutor.Size = new System.Drawing.Size(297, 21);
            this.cboTutor.TabIndex = 0;
            this.cboTutor.SelectedIndexChanged += new System.EventHandler(this.cboTutor_SelectedIndexChanged);
            // 
            // pnlGrid
            // 
            this.pnlGrid.Controls.Add(this.dgvLancamentos);
            this.pnlGrid.Location = new System.Drawing.Point(2, 191);
            this.pnlGrid.Name = "pnlGrid";
            this.pnlGrid.Size = new System.Drawing.Size(758, 257);
            this.pnlGrid.TabIndex = 1;
            // 
            // dgvLancamentos
            // 
            this.dgvLancamentos.AllowUserToAddRows = false;
            this.dgvLancamentos.BackgroundColor = System.Drawing.SystemColors.Control;
            this.dgvLancamentos.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvLancamentos.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.clnId,
            this.clnCliente,
            this.clnPet,
            this.clnServico,
            this.clnValor,
            this.clnData,
            this.clnSituacao,
            this.clnObservacao});
            this.dgvLancamentos.Location = new System.Drawing.Point(0, 3);
            this.dgvLancamentos.Name = "dgvLancamentos";
            this.dgvLancamentos.ReadOnly = true;
            this.dgvLancamentos.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvLancamentos.Size = new System.Drawing.Size(754, 280);
            this.dgvLancamentos.TabIndex = 0;
            this.dgvLancamentos.CellDoubleClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvLancamentos_CellDoubleClick);
            // 
            // clnId
            // 
            this.clnId.HeaderText = "CÓDIGO";
            this.clnId.Name = "clnId";
            this.clnId.ReadOnly = true;
            // 
            // clnCliente
            // 
            this.clnCliente.HeaderText = "TUTOR";
            this.clnCliente.Name = "clnCliente";
            this.clnCliente.ReadOnly = true;
            // 
            // clnPet
            // 
            this.clnPet.HeaderText = "PET";
            this.clnPet.Name = "clnPet";
            this.clnPet.ReadOnly = true;
            this.clnPet.Width = 200;
            // 
            // clnServico
            // 
            this.clnServico.HeaderText = "SERVIÇO";
            this.clnServico.Name = "clnServico";
            this.clnServico.ReadOnly = true;
            this.clnServico.Width = 200;
            // 
            // clnValor
            // 
            this.clnValor.HeaderText = "VALOR";
            this.clnValor.Name = "clnValor";
            this.clnValor.ReadOnly = true;
            // 
            // clnData
            // 
            this.clnData.HeaderText = "DATA";
            this.clnData.Name = "clnData";
            this.clnData.ReadOnly = true;
            // 
            // clnSituacao
            // 
            this.clnSituacao.HeaderText = "SITUAÇÃO";
            this.clnSituacao.Name = "clnSituacao";
            this.clnSituacao.ReadOnly = true;
            // 
            // clnObservacao
            // 
            this.clnObservacao.HeaderText = "OBSERVAÇÃO";
            this.clnObservacao.Name = "clnObservacao";
            this.clnObservacao.ReadOnly = true;
            this.clnObservacao.Visible = false;
            // 
            // pnlBotoes
            // 
            this.pnlBotoes.Controls.Add(this.btnImpRelatorio);
            this.pnlBotoes.Controls.Add(this.btnImprimir);
            this.pnlBotoes.Controls.Add(this.btnCancelar);
            this.pnlBotoes.Controls.Add(this.btnConfirmar);
            this.pnlBotoes.Location = new System.Drawing.Point(684, 0);
            this.pnlBotoes.Name = "pnlBotoes";
            this.pnlBotoes.Size = new System.Drawing.Size(77, 185);
            this.pnlBotoes.TabIndex = 7;
            // 
            // btnImprimir
            // 
            this.btnImprimir.Location = new System.Drawing.Point(1, 90);
            this.btnImprimir.Name = "btnImprimir";
            this.btnImprimir.Size = new System.Drawing.Size(75, 37);
            this.btnImprimir.TabIndex = 3;
            this.btnImprimir.Text = "Imprimir";
            this.btnImprimir.UseVisualStyleBackColor = true;
            this.btnImprimir.Click += new System.EventHandler(this.btnImprimir_Click);
            // 
            // btnCancelar
            // 
            this.btnCancelar.Location = new System.Drawing.Point(1, 47);
            this.btnCancelar.Name = "btnCancelar";
            this.btnCancelar.Size = new System.Drawing.Size(75, 37);
            this.btnCancelar.TabIndex = 2;
            this.btnCancelar.Text = "Cancelar";
            this.btnCancelar.UseVisualStyleBackColor = true;
            this.btnCancelar.Click += new System.EventHandler(this.btnCancelar_Click);
            // 
            // btnConfirmar
            // 
            this.btnConfirmar.Location = new System.Drawing.Point(1, 4);
            this.btnConfirmar.Name = "btnConfirmar";
            this.btnConfirmar.Size = new System.Drawing.Size(75, 37);
            this.btnConfirmar.TabIndex = 7;
            this.btnConfirmar.Text = "Confirmar";
            this.btnConfirmar.UseVisualStyleBackColor = true;
            this.btnConfirmar.Click += new System.EventHandler(this.btnConfirmar_Click);
            // 
            // btnImpRelatorio
            // 
            this.btnImpRelatorio.Location = new System.Drawing.Point(1, 133);
            this.btnImpRelatorio.Name = "btnImpRelatorio";
            this.btnImpRelatorio.Size = new System.Drawing.Size(75, 37);
            this.btnImpRelatorio.TabIndex = 8;
            this.btnImpRelatorio.Text = "Imprimir relatório";
            this.btnImpRelatorio.UseVisualStyleBackColor = true;
            this.btnImpRelatorio.Click += new System.EventHandler(this.btnImpRelatorio_Click);
            // 
            // FormLancamentosServicos
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(768, 450);
            this.Controls.Add(this.pnlBotoes);
            this.Controls.Add(this.pnlGrid);
            this.Controls.Add(this.pnlLancamento);
            this.MinimumSize = new System.Drawing.Size(784, 489);
            this.Name = "FormLancamentosServicos";
            this.Text = "Lancamento de serviços";
            this.pnlLancamento.ResumeLayout(false);
            this.pnlLancamento.PerformLayout();
            this.pnlGrid.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgvLancamentos)).EndInit();
            this.pnlBotoes.ResumeLayout(false);
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
        private System.Windows.Forms.TextBox txtCodigo;
        private System.Windows.Forms.Label lblCodigo;
        private System.Windows.Forms.Panel pnlBotoes;
        private System.Windows.Forms.Button btnCancelar;
        private System.Windows.Forms.Button btnConfirmar;
        private System.Windows.Forms.Button btnImprimir;
        private System.Windows.Forms.Label lblData;
        private System.Windows.Forms.Label lblSituacao;
        private System.Windows.Forms.ComboBox cboSituacao;
        private System.Windows.Forms.Label lblObservacao;
        private System.Windows.Forms.DataGridViewTextBoxColumn clnId;
        private System.Windows.Forms.DataGridViewTextBoxColumn clnCliente;
        private System.Windows.Forms.DataGridViewTextBoxColumn clnPet;
        private System.Windows.Forms.DataGridViewTextBoxColumn clnServico;
        private System.Windows.Forms.DataGridViewTextBoxColumn clnValor;
        private System.Windows.Forms.DataGridViewTextBoxColumn clnData;
        private System.Windows.Forms.DataGridViewTextBoxColumn clnSituacao;
        private System.Windows.Forms.DataGridViewTextBoxColumn clnObservacao;
        private System.Windows.Forms.RichTextBox rtfObservacao;
        private System.Windows.Forms.Button btnImpRelatorio;
    }
}