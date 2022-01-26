
namespace SysBanhoTosa.Views
{
    partial class FormPets
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
            this.lblRaca = new System.Windows.Forms.Label();
            this.lblEspecie = new System.Windows.Forms.Label();
            this.cboRaca = new System.Windows.Forms.ComboBox();
            this.cboEspecie = new System.Windows.Forms.ComboBox();
            this.txtCodigo = new System.Windows.Forms.TextBox();
            this.lblCodigo = new System.Windows.Forms.Label();
            this.lblNome = new System.Windows.Forms.Label();
            this.txtNome = new System.Windows.Forms.TextBox();
            this.pnlBotoes = new System.Windows.Forms.Panel();
            this.btnCancelar = new System.Windows.Forms.Button();
            this.btnExluir = new System.Windows.Forms.Button();
            this.btnConfirmar = new System.Windows.Forms.Button();
            this.pnlGrid = new System.Windows.Forms.Panel();
            this.dgvPets = new System.Windows.Forms.DataGridView();
            this.txtTutor = new System.Windows.Forms.TextBox();
            this.lblTutor = new System.Windows.Forms.Label();
            this.clnId = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.clnNome = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.clnIdDono = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.clnNomeDono = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.clnEspecie = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.clnRaca = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.cboTutor = new System.Windows.Forms.ComboBox();
            this.pnlCampos.SuspendLayout();
            this.pnlBotoes.SuspendLayout();
            this.pnlGrid.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvPets)).BeginInit();
            this.SuspendLayout();
            // 
            // pnlCampos
            // 
            this.pnlCampos.Controls.Add(this.cboTutor);
            this.pnlCampos.Controls.Add(this.txtTutor);
            this.pnlCampos.Controls.Add(this.lblTutor);
            this.pnlCampos.Controls.Add(this.lblRaca);
            this.pnlCampos.Controls.Add(this.lblEspecie);
            this.pnlCampos.Controls.Add(this.cboRaca);
            this.pnlCampos.Controls.Add(this.cboEspecie);
            this.pnlCampos.Controls.Add(this.txtCodigo);
            this.pnlCampos.Controls.Add(this.lblCodigo);
            this.pnlCampos.Controls.Add(this.lblNome);
            this.pnlCampos.Controls.Add(this.txtNome);
            this.pnlCampos.Location = new System.Drawing.Point(2, 3);
            this.pnlCampos.Name = "pnlCampos";
            this.pnlCampos.Size = new System.Drawing.Size(447, 167);
            this.pnlCampos.TabIndex = 0;
            // 
            // lblRaca
            // 
            this.lblRaca.AutoSize = true;
            this.lblRaca.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblRaca.Location = new System.Drawing.Point(176, 46);
            this.lblRaca.Name = "lblRaca";
            this.lblRaca.Size = new System.Drawing.Size(37, 13);
            this.lblRaca.TabIndex = 15;
            this.lblRaca.Text = "Raça";
            // 
            // lblEspecie
            // 
            this.lblEspecie.AutoSize = true;
            this.lblEspecie.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblEspecie.Location = new System.Drawing.Point(23, 46);
            this.lblEspecie.Name = "lblEspecie";
            this.lblEspecie.Size = new System.Drawing.Size(52, 13);
            this.lblEspecie.TabIndex = 14;
            this.lblEspecie.Text = "Espécie";
            // 
            // cboRaca
            // 
            this.cboRaca.FormattingEnabled = true;
            this.cboRaca.Items.AddRange(new object[] {
            "Afegão ou Afghan Hound",
            "Affenpinscher",
            "Airedale Terrier",
            "Akita Americano",
            "Akita Inu ou Akita Japonês",
            "Alano Espanhol",
            "American Staffordshire Terrier",
            "American Water Spaniel",
            "Barbet",
            "Basenji",
            "Basset Azul da Gasconha",
            "Basset Fulvo da Bretanha",
            "Basset Hound",
            "Beagle",
            "Beagle Harrier",
            "Bearded Collie",
            "Bedlington Terrier",
            "Bernese Mountain Dog",
            "Bichon Bolonhês",
            "Bichon Havanês",
            "Bichon Frisé",
            "Bichon Maltês",
            "Bloodhound",
            "Boiadeiro Australiano",
            "Boiadeiro Bernês",
            "Border Collie",
            "Border Terrier",
            "Borzoi",
            "Boston Terrier",
            "Boxer",
            "Bull Terrier",
            "Buldogue ou Bulldog Inglês",
            "Buldogue ou Bulldog Francês",
            "Bullmastiff ou Bulmastife"});
            this.cboRaca.Location = new System.Drawing.Point(176, 62);
            this.cboRaca.Name = "cboRaca";
            this.cboRaca.Size = new System.Drawing.Size(242, 21);
            this.cboRaca.TabIndex = 13;
            // 
            // cboEspecie
            // 
            this.cboEspecie.FormattingEnabled = true;
            this.cboEspecie.Items.AddRange(new object[] {
            "Cachorro",
            "Gato"});
            this.cboEspecie.Location = new System.Drawing.Point(23, 62);
            this.cboEspecie.Name = "cboEspecie";
            this.cboEspecie.Size = new System.Drawing.Size(121, 21);
            this.cboEspecie.TabIndex = 12;
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
            this.pnlBotoes.Controls.Add(this.btnExluir);
            this.pnlBotoes.Controls.Add(this.btnConfirmar);
            this.pnlBotoes.Location = new System.Drawing.Point(448, 3);
            this.pnlBotoes.Name = "pnlBotoes";
            this.pnlBotoes.Size = new System.Drawing.Size(76, 167);
            this.pnlBotoes.TabIndex = 2;
            // 
            // btnCancelar
            // 
            this.btnCancelar.Location = new System.Drawing.Point(1, 89);
            this.btnCancelar.Name = "btnCancelar";
            this.btnCancelar.Size = new System.Drawing.Size(75, 37);
            this.btnCancelar.TabIndex = 5;
            this.btnCancelar.Text = "Cancelar";
            this.btnCancelar.UseVisualStyleBackColor = true;
            this.btnCancelar.Click += new System.EventHandler(this.btnCancelar_Click);
            // 
            // btnExluir
            // 
            this.btnExluir.Location = new System.Drawing.Point(1, 46);
            this.btnExluir.Name = "btnExluir";
            this.btnExluir.Size = new System.Drawing.Size(75, 37);
            this.btnExluir.TabIndex = 4;
            this.btnExluir.Text = "Excluir";
            this.btnExluir.UseVisualStyleBackColor = true;
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
            this.pnlGrid.Controls.Add(this.dgvPets);
            this.pnlGrid.Location = new System.Drawing.Point(2, 173);
            this.pnlGrid.Name = "pnlGrid";
            this.pnlGrid.Size = new System.Drawing.Size(522, 316);
            this.pnlGrid.TabIndex = 3;
            // 
            // dgvPets
            // 
            this.dgvPets.BackgroundColor = System.Drawing.SystemColors.Control;
            this.dgvPets.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvPets.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.clnId,
            this.clnNome,
            this.clnIdDono,
            this.clnNomeDono,
            this.clnEspecie,
            this.clnRaca});
            this.dgvPets.Location = new System.Drawing.Point(3, 3);
            this.dgvPets.Name = "dgvPets";
            this.dgvPets.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvPets.Size = new System.Drawing.Size(516, 316);
            this.dgvPets.TabIndex = 0;
            this.dgvPets.CellDoubleClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvPets_CellDoubleClick);
            // 
            // txtTutor
            // 
            this.txtTutor.Location = new System.Drawing.Point(23, 106);
            this.txtTutor.Name = "txtTutor";
            this.txtTutor.Size = new System.Drawing.Size(121, 20);
            this.txtTutor.TabIndex = 16;
            // 
            // lblTutor
            // 
            this.lblTutor.AutoSize = true;
            this.lblTutor.Location = new System.Drawing.Point(23, 89);
            this.lblTutor.Name = "lblTutor";
            this.lblTutor.Size = new System.Drawing.Size(32, 13);
            this.lblTutor.TabIndex = 17;
            this.lblTutor.Text = "Tutor";
            // 
            // clnId
            // 
            this.clnId.HeaderText = "ID";
            this.clnId.Name = "clnId";
            this.clnId.Width = 30;
            // 
            // clnNome
            // 
            this.clnNome.HeaderText = "NOME";
            this.clnNome.Name = "clnNome";
            this.clnNome.Width = 170;
            // 
            // clnIdDono
            // 
            this.clnIdDono.HeaderText = "ID DONO";
            this.clnIdDono.Name = "clnIdDono";
            this.clnIdDono.Width = 50;
            // 
            // clnNomeDono
            // 
            this.clnNomeDono.HeaderText = "NOME DONO";
            this.clnNomeDono.Name = "clnNomeDono";
            this.clnNomeDono.Width = 170;
            // 
            // clnEspecie
            // 
            this.clnEspecie.HeaderText = "ESPECIE";
            this.clnEspecie.Name = "clnEspecie";
            this.clnEspecie.Visible = false;
            // 
            // clnRaca
            // 
            this.clnRaca.HeaderText = "RAÇA";
            this.clnRaca.Name = "clnRaca";
            this.clnRaca.Visible = false;
            // 
            // cboTutor
            // 
            this.cboTutor.FormattingEnabled = true;
            this.cboTutor.Location = new System.Drawing.Point(176, 106);
            this.cboTutor.Name = "cboTutor";
            this.cboTutor.Size = new System.Drawing.Size(242, 21);
            this.cboTutor.TabIndex = 18;
            // 
            // FormPets
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(526, 492);
            this.Controls.Add(this.pnlGrid);
            this.Controls.Add(this.pnlBotoes);
            this.Controls.Add(this.pnlCampos);
            this.Name = "FormPets";
            this.Text = "Cadastro de Pets";
            this.pnlCampos.ResumeLayout(false);
            this.pnlCampos.PerformLayout();
            this.pnlBotoes.ResumeLayout(false);
            this.pnlGrid.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgvPets)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel pnlCampos;
        private System.Windows.Forms.Panel pnlBotoes;
        private System.Windows.Forms.Button btnCancelar;
        private System.Windows.Forms.Button btnExluir;
        private System.Windows.Forms.Button btnConfirmar;
        private System.Windows.Forms.Panel pnlGrid;
        private System.Windows.Forms.DataGridView dgvPets;
        private System.Windows.Forms.TextBox txtCodigo;
        private System.Windows.Forms.Label lblCodigo;
        private System.Windows.Forms.Label lblNome;
        private System.Windows.Forms.TextBox txtNome;
        private System.Windows.Forms.ComboBox cboRaca;
        private System.Windows.Forms.ComboBox cboEspecie;
        private System.Windows.Forms.Label lblRaca;
        private System.Windows.Forms.Label lblEspecie;
        private System.Windows.Forms.TextBox txtTutor;
        private System.Windows.Forms.Label lblTutor;
        private System.Windows.Forms.DataGridViewTextBoxColumn clnId;
        private System.Windows.Forms.DataGridViewTextBoxColumn clnNome;
        private System.Windows.Forms.DataGridViewTextBoxColumn clnIdDono;
        private System.Windows.Forms.DataGridViewTextBoxColumn clnNomeDono;
        private System.Windows.Forms.DataGridViewTextBoxColumn clnEspecie;
        private System.Windows.Forms.DataGridViewTextBoxColumn clnRaca;
        private System.Windows.Forms.ComboBox cboTutor;
    }
}