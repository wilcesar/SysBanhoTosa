
namespace SysBanhoTosa.Views
{
    partial class FormServicos
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
            this.pnlCampos = new System.Windows.Forms.Panel();
            this.lblValor = new System.Windows.Forms.Label();
            this.txtValor = new System.Windows.Forms.TextBox();
            this.cboSituacao = new System.Windows.Forms.ComboBox();
            this.lblSituacao = new System.Windows.Forms.Label();
            this.lblDescricao = new System.Windows.Forms.Label();
            this.txtDescricao = new System.Windows.Forms.TextBox();
            this.txtCodigo = new System.Windows.Forms.TextBox();
            this.lblCodigo = new System.Windows.Forms.Label();
            this.lblNome = new System.Windows.Forms.Label();
            this.txtNome = new System.Windows.Forms.TextBox();
            this.pnlBotoes = new System.Windows.Forms.Panel();
            this.btnCancelar = new System.Windows.Forms.Button();
            this.btnConfirmar = new System.Windows.Forms.Button();
            this.pnlGrid = new System.Windows.Forms.Panel();
            this.dgvServicos = new System.Windows.Forms.DataGridView();
            this.clnId = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.clnNome = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.clnDescricao = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.clnValor = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.clnSituacao = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.pnlCampos.SuspendLayout();
            this.pnlBotoes.SuspendLayout();
            this.pnlGrid.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvServicos)).BeginInit();
            this.SuspendLayout();
            // 
            // pnlCampos
            // 
            this.pnlCampos.Controls.Add(this.lblValor);
            this.pnlCampos.Controls.Add(this.txtValor);
            this.pnlCampos.Controls.Add(this.cboSituacao);
            this.pnlCampos.Controls.Add(this.lblSituacao);
            this.pnlCampos.Controls.Add(this.lblDescricao);
            this.pnlCampos.Controls.Add(this.txtDescricao);
            this.pnlCampos.Controls.Add(this.txtCodigo);
            this.pnlCampos.Controls.Add(this.lblCodigo);
            this.pnlCampos.Controls.Add(this.lblNome);
            this.pnlCampos.Controls.Add(this.txtNome);
            this.pnlCampos.Location = new System.Drawing.Point(2, 3);
            this.pnlCampos.Name = "pnlCampos";
            this.pnlCampos.Size = new System.Drawing.Size(447, 167);
            this.pnlCampos.TabIndex = 1;
            // 
            // lblValor
            // 
            this.lblValor.AutoSize = true;
            this.lblValor.Location = new System.Drawing.Point(23, 86);
            this.lblValor.Name = "lblValor";
            this.lblValor.Size = new System.Drawing.Size(31, 13);
            this.lblValor.TabIndex = 24;
            this.lblValor.Text = "Valor";
            // 
            // txtValor
            // 
            this.txtValor.Location = new System.Drawing.Point(23, 102);
            this.txtValor.Name = "txtValor";
            this.txtValor.Size = new System.Drawing.Size(95, 20);
            this.txtValor.TabIndex = 23;
            this.txtValor.Leave += new System.EventHandler(this.txtValor_Leave);
            // 
            // cboSituacao
            // 
            this.cboSituacao.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cboSituacao.FormattingEnabled = true;
            this.cboSituacao.Items.AddRange(new object[] {
            "ATIVO",
            "INATIVO"});
            this.cboSituacao.Location = new System.Drawing.Point(296, 102);
            this.cboSituacao.Name = "cboSituacao";
            this.cboSituacao.Size = new System.Drawing.Size(121, 21);
            this.cboSituacao.TabIndex = 21;
            // 
            // lblSituacao
            // 
            this.lblSituacao.AutoSize = true;
            this.lblSituacao.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblSituacao.Location = new System.Drawing.Point(296, 86);
            this.lblSituacao.Name = "lblSituacao";
            this.lblSituacao.Size = new System.Drawing.Size(57, 13);
            this.lblSituacao.TabIndex = 22;
            this.lblSituacao.Text = "Situação";
            // 
            // lblDescricao
            // 
            this.lblDescricao.AutoSize = true;
            this.lblDescricao.Location = new System.Drawing.Point(23, 46);
            this.lblDescricao.Name = "lblDescricao";
            this.lblDescricao.Size = new System.Drawing.Size(105, 13);
            this.lblDescricao.TabIndex = 13;
            this.lblDescricao.Text = "Descrição detalhada";
            // 
            // txtDescricao
            // 
            this.txtDescricao.Location = new System.Drawing.Point(23, 63);
            this.txtDescricao.Name = "txtDescricao";
            this.txtDescricao.Size = new System.Drawing.Size(395, 20);
            this.txtDescricao.TabIndex = 12;
            // 
            // txtCodigo
            // 
            this.txtCodigo.Enabled = false;
            this.txtCodigo.Location = new System.Drawing.Point(23, 20);
            this.txtCodigo.Name = "txtCodigo";
            this.txtCodigo.Size = new System.Drawing.Size(121, 20);
            this.txtCodigo.TabIndex = 8;
            // 
            // lblCodigo
            // 
            this.lblCodigo.AutoSize = true;
            this.lblCodigo.Location = new System.Drawing.Point(23, 3);
            this.lblCodigo.Name = "lblCodigo";
            this.lblCodigo.Size = new System.Drawing.Size(40, 13);
            this.lblCodigo.TabIndex = 11;
            this.lblCodigo.Text = "Código";
            // 
            // lblNome
            // 
            this.lblNome.AutoSize = true;
            this.lblNome.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblNome.Location = new System.Drawing.Point(176, 3);
            this.lblNome.Name = "lblNome";
            this.lblNome.Size = new System.Drawing.Size(39, 13);
            this.lblNome.TabIndex = 9;
            this.lblNome.Text = "Nome";
            // 
            // txtNome
            // 
            this.txtNome.Location = new System.Drawing.Point(176, 20);
            this.txtNome.Name = "txtNome";
            this.txtNome.Size = new System.Drawing.Size(242, 20);
            this.txtNome.TabIndex = 10;
            // 
            // pnlBotoes
            // 
            this.pnlBotoes.Controls.Add(this.btnCancelar);
            this.pnlBotoes.Controls.Add(this.btnConfirmar);
            this.pnlBotoes.Location = new System.Drawing.Point(448, 3);
            this.pnlBotoes.Name = "pnlBotoes";
            this.pnlBotoes.Size = new System.Drawing.Size(76, 167);
            this.pnlBotoes.TabIndex = 20;
            // 
            // btnCancelar
            // 
            this.btnCancelar.Location = new System.Drawing.Point(1, 46);
            this.btnCancelar.Name = "btnCancelar";
            this.btnCancelar.Size = new System.Drawing.Size(75, 37);
            this.btnCancelar.TabIndex = 5;
            this.btnCancelar.Text = "Cancelar";
            this.btnCancelar.UseVisualStyleBackColor = true;
            this.btnCancelar.Click += new System.EventHandler(this.btnCancelar_Click);
            // 
            // btnConfirmar
            // 
            this.btnConfirmar.Location = new System.Drawing.Point(1, 3);
            this.btnConfirmar.Name = "btnConfirmar";
            this.btnConfirmar.Size = new System.Drawing.Size(75, 37);
            this.btnConfirmar.TabIndex = 3;
            this.btnConfirmar.Text = "Confirmar";
            this.btnConfirmar.UseVisualStyleBackColor = true;
            this.btnConfirmar.Click += new System.EventHandler(this.btnConfirmar_Click);
            // 
            // pnlGrid
            // 
            this.pnlGrid.Controls.Add(this.dgvServicos);
            this.pnlGrid.Location = new System.Drawing.Point(2, 176);
            this.pnlGrid.Name = "pnlGrid";
            this.pnlGrid.Size = new System.Drawing.Size(522, 316);
            this.pnlGrid.TabIndex = 21;
            // 
            // dgvServicos
            // 
            this.dgvServicos.AllowUserToAddRows = false;
            this.dgvServicos.BackgroundColor = System.Drawing.SystemColors.Control;
            this.dgvServicos.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvServicos.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.clnId,
            this.clnNome,
            this.clnDescricao,
            this.clnValor,
            this.clnSituacao});
            this.dgvServicos.Location = new System.Drawing.Point(3, 3);
            this.dgvServicos.Name = "dgvServicos";
            this.dgvServicos.ReadOnly = true;
            this.dgvServicos.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvServicos.Size = new System.Drawing.Size(516, 316);
            this.dgvServicos.TabIndex = 0;
            this.dgvServicos.CellDoubleClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvServicos_CellDoubleClick);
            // 
            // clnId
            // 
            this.clnId.HeaderText = "ID";
            this.clnId.Name = "clnId";
            this.clnId.ReadOnly = true;
            this.clnId.Width = 30;
            // 
            // clnNome
            // 
            this.clnNome.HeaderText = "NOME";
            this.clnNome.Name = "clnNome";
            this.clnNome.ReadOnly = true;
            this.clnNome.Width = 170;
            // 
            // clnDescricao
            // 
            this.clnDescricao.HeaderText = "DESCRIÇÃO";
            this.clnDescricao.Name = "clnDescricao";
            this.clnDescricao.ReadOnly = true;
            this.clnDescricao.Visible = false;
            this.clnDescricao.Width = 300;
            // 
            // clnValor
            // 
            this.clnValor.HeaderText = "VALOR";
            this.clnValor.Name = "clnValor";
            this.clnValor.ReadOnly = true;
            // 
            // clnSituacao
            // 
            this.clnSituacao.HeaderText = "SITUAÇÃO";
            this.clnSituacao.Name = "clnSituacao";
            this.clnSituacao.ReadOnly = true;
            // 
            // FormServicos
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(526, 492);
            this.Controls.Add(this.pnlGrid);
            this.Controls.Add(this.pnlBotoes);
            this.Controls.Add(this.pnlCampos);
            this.MinimumSize = new System.Drawing.Size(542, 531);
            this.Name = "FormServicos";
            this.Text = "Cadastro de serviços";
            this.Load += new System.EventHandler(this.FormServicos_Load);
            this.pnlCampos.ResumeLayout(false);
            this.pnlCampos.PerformLayout();
            this.pnlBotoes.ResumeLayout(false);
            this.pnlGrid.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgvServicos)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel pnlCampos;
        private System.Windows.Forms.TextBox txtCodigo;
        private System.Windows.Forms.Label lblCodigo;
        private System.Windows.Forms.Label lblNome;
        private System.Windows.Forms.TextBox txtNome;
        private System.Windows.Forms.Panel pnlBotoes;
        private System.Windows.Forms.Button btnCancelar;
        private System.Windows.Forms.Button btnConfirmar;
        private System.Windows.Forms.Panel pnlGrid;
        private System.Windows.Forms.DataGridView dgvServicos;
        private System.Windows.Forms.Label lblDescricao;
        private System.Windows.Forms.TextBox txtDescricao;
        private System.Windows.Forms.ComboBox cboSituacao;
        private System.Windows.Forms.Label lblSituacao;
        private System.Windows.Forms.Label lblValor;
        private System.Windows.Forms.TextBox txtValor;
        private System.Windows.Forms.DataGridViewTextBoxColumn clnId;
        private System.Windows.Forms.DataGridViewTextBoxColumn clnNome;
        private System.Windows.Forms.DataGridViewTextBoxColumn clnDescricao;
        private System.Windows.Forms.DataGridViewTextBoxColumn clnValor;
        private System.Windows.Forms.DataGridViewTextBoxColumn clnSituacao;
    }
}