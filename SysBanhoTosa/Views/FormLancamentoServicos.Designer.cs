
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
            this.pnlGrid = new System.Windows.Forms.Panel();
            this.cboTutor = new System.Windows.Forms.ComboBox();
            this.cboPet = new System.Windows.Forms.ComboBox();
            this.cboServico = new System.Windows.Forms.ComboBox();
            this.txtValor = new System.Windows.Forms.TextBox();
            this.lblTutor = new System.Windows.Forms.Label();
            this.lblPet = new System.Windows.Forms.Label();
            this.lblServico = new System.Windows.Forms.Label();
            this.lblValor = new System.Windows.Forms.Label();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.dateTimePicker1 = new System.Windows.Forms.DateTimePicker();
            this.pnlLancamento.SuspendLayout();
            this.pnlGrid.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // pnlLancamento
            // 
            this.pnlLancamento.Controls.Add(this.dateTimePicker1);
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
            this.pnlLancamento.Size = new System.Drawing.Size(798, 214);
            this.pnlLancamento.TabIndex = 0;
            // 
            // pnlGrid
            // 
            this.pnlGrid.Controls.Add(this.dataGridView1);
            this.pnlGrid.Location = new System.Drawing.Point(2, 220);
            this.pnlGrid.Name = "pnlGrid";
            this.pnlGrid.Size = new System.Drawing.Size(798, 228);
            this.pnlGrid.TabIndex = 1;
            // 
            // cboTutor
            // 
            this.cboTutor.FormattingEnabled = true;
            this.cboTutor.Location = new System.Drawing.Point(10, 23);
            this.cboTutor.Name = "cboTutor";
            this.cboTutor.Size = new System.Drawing.Size(297, 21);
            this.cboTutor.TabIndex = 0;
            // 
            // cboPet
            // 
            this.cboPet.FormattingEnabled = true;
            this.cboPet.Location = new System.Drawing.Point(10, 63);
            this.cboPet.Name = "cboPet";
            this.cboPet.Size = new System.Drawing.Size(297, 21);
            this.cboPet.TabIndex = 1;
            // 
            // cboServico
            // 
            this.cboServico.FormattingEnabled = true;
            this.cboServico.Location = new System.Drawing.Point(10, 104);
            this.cboServico.Name = "cboServico";
            this.cboServico.Size = new System.Drawing.Size(297, 21);
            this.cboServico.TabIndex = 2;
            // 
            // txtValor
            // 
            this.txtValor.Location = new System.Drawing.Point(10, 144);
            this.txtValor.Name = "txtValor";
            this.txtValor.Size = new System.Drawing.Size(115, 20);
            this.txtValor.TabIndex = 3;
            // 
            // lblTutor
            // 
            this.lblTutor.AutoSize = true;
            this.lblTutor.Location = new System.Drawing.Point(10, 7);
            this.lblTutor.Name = "lblTutor";
            this.lblTutor.Size = new System.Drawing.Size(32, 13);
            this.lblTutor.TabIndex = 4;
            this.lblTutor.Text = "Tutor";
            // 
            // lblPet
            // 
            this.lblPet.AutoSize = true;
            this.lblPet.Location = new System.Drawing.Point(10, 47);
            this.lblPet.Name = "lblPet";
            this.lblPet.Size = new System.Drawing.Size(23, 13);
            this.lblPet.TabIndex = 5;
            this.lblPet.Text = "Pet";
            // 
            // lblServico
            // 
            this.lblServico.AutoSize = true;
            this.lblServico.Location = new System.Drawing.Point(10, 87);
            this.lblServico.Name = "lblServico";
            this.lblServico.Size = new System.Drawing.Size(43, 13);
            this.lblServico.TabIndex = 6;
            this.lblServico.Text = "Servico";
            // 
            // lblValor
            // 
            this.lblValor.AutoSize = true;
            this.lblValor.Location = new System.Drawing.Point(10, 128);
            this.lblValor.Name = "lblValor";
            this.lblValor.Size = new System.Drawing.Size(31, 13);
            this.lblValor.TabIndex = 7;
            this.lblValor.Text = "Valor";
            // 
            // dataGridView1
            // 
            this.dataGridView1.BackgroundColor = System.Drawing.SystemColors.Control;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(0, 3);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.Size = new System.Drawing.Size(795, 225);
            this.dataGridView1.TabIndex = 0;
            // 
            // dateTimePicker1
            // 
            this.dateTimePicker1.Location = new System.Drawing.Point(10, 170);
            this.dateTimePicker1.Name = "dateTimePicker1";
            this.dateTimePicker1.Size = new System.Drawing.Size(200, 20);
            this.dateTimePicker1.TabIndex = 8;
            // 
            // FormLancamentoServicos
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.pnlGrid);
            this.Controls.Add(this.pnlLancamento);
            this.Name = "FormLancamentoServicos";
            this.Text = "Lancamento de servicos";
            this.pnlLancamento.ResumeLayout(false);
            this.pnlLancamento.PerformLayout();
            this.pnlGrid.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
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
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.DateTimePicker dateTimePicker1;
    }
}