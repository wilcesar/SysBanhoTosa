
namespace SysBanhoTosa
{
    partial class FormMenu
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
            this.mnsMenuPrincipal = new System.Windows.Forms.MenuStrip();
            this.tmiCadastros = new System.Windows.Forms.ToolStripMenuItem();
            this.tmiClientes = new System.Windows.Forms.ToolStripMenuItem();
            this.tmiPets = new System.Windows.Forms.ToolStripMenuItem();
            this.tmiServicos = new System.Windows.Forms.ToolStripMenuItem();
            this.tmiLancamentos = new System.Windows.Forms.ToolStripMenuItem();
            this.tmiLancamentoServicos = new System.Windows.Forms.ToolStripMenuItem();
            this.mnsMenuPrincipal.SuspendLayout();
            this.SuspendLayout();
            // 
            // mnsMenuPrincipal
            // 
            this.mnsMenuPrincipal.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.tmiCadastros,
            this.tmiLancamentos});
            this.mnsMenuPrincipal.Location = new System.Drawing.Point(0, 0);
            this.mnsMenuPrincipal.Name = "mnsMenuPrincipal";
            this.mnsMenuPrincipal.Size = new System.Drawing.Size(800, 24);
            this.mnsMenuPrincipal.TabIndex = 4;
            this.mnsMenuPrincipal.Text = "menuStrip1";
            this.mnsMenuPrincipal.ItemClicked += new System.Windows.Forms.ToolStripItemClickedEventHandler(this.menuStrip1_ItemClicked);
            // 
            // tmiCadastros
            // 
            this.tmiCadastros.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.tmiClientes,
            this.tmiPets,
            this.tmiServicos});
            this.tmiCadastros.Name = "tmiCadastros";
            this.tmiCadastros.Size = new System.Drawing.Size(71, 20);
            this.tmiCadastros.Text = "Cadastros";
            // 
            // tmiClientes
            // 
            this.tmiClientes.Name = "tmiClientes";
            this.tmiClientes.Size = new System.Drawing.Size(180, 22);
            this.tmiClientes.Text = "Clientes";
            this.tmiClientes.Click += new System.EventHandler(this.clientesToolStripMenuItem_Click);
            // 
            // tmiPets
            // 
            this.tmiPets.Name = "tmiPets";
            this.tmiPets.Size = new System.Drawing.Size(180, 22);
            this.tmiPets.Text = "Pets";
            this.tmiPets.Click += new System.EventHandler(this.petsToolStripMenuItem_Click);
            // 
            // tmiServicos
            // 
            this.tmiServicos.Name = "tmiServicos";
            this.tmiServicos.Size = new System.Drawing.Size(180, 22);
            this.tmiServicos.Text = "Serviços";
            this.tmiServicos.Click += new System.EventHandler(this.serviçosToolStripMenuItem_Click);
            // 
            // tmiLancamentos
            // 
            this.tmiLancamentos.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.tmiLancamentoServicos});
            this.tmiLancamentos.Name = "tmiLancamentos";
            this.tmiLancamentos.Size = new System.Drawing.Size(90, 20);
            this.tmiLancamentos.Text = "Lançamentos";
            // 
            // tmiLancamentoServicos
            // 
            this.tmiLancamentoServicos.Name = "tmiLancamentoServicos";
            this.tmiLancamentoServicos.Size = new System.Drawing.Size(180, 22);
            this.tmiLancamentoServicos.Text = "Serviços";
            this.tmiLancamentoServicos.Click += new System.EventHandler(this.serviçosToolStripMenuItem1_Click);
            // 
            // FormMenu
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.mnsMenuPrincipal);
            this.MainMenuStrip = this.mnsMenuPrincipal;
            this.Name = "FormMenu";
            this.Text = "Sistema de banho e tosa";
            this.mnsMenuPrincipal.ResumeLayout(false);
            this.mnsMenuPrincipal.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.MenuStrip mnsMenuPrincipal;
        private System.Windows.Forms.ToolStripMenuItem tmiCadastros;
        private System.Windows.Forms.ToolStripMenuItem tmiClientes;
        private System.Windows.Forms.ToolStripMenuItem tmiPets;
        private System.Windows.Forms.ToolStripMenuItem tmiServicos;
        private System.Windows.Forms.ToolStripMenuItem tmiLancamentos;
        private System.Windows.Forms.ToolStripMenuItem tmiLancamentoServicos;
    }
}

