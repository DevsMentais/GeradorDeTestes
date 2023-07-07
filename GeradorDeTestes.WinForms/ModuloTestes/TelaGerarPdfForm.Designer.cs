namespace GeradorDeTestes.WinForms.ModuloTestes
{
    partial class TelaGerarPdfForm
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
            btnGravar = new Button();
            btnCancelar = new Button();
            btnDiretorio = new Button();
            txtDiretorio = new TextBox();
            rdbQuestao = new RadioButton();
            rdbGabarito = new RadioButton();
            label2 = new Label();
            label1 = new Label();
            SuspendLayout();
            // 
            // btnGravar
            // 
            btnGravar.Anchor = AnchorStyles.Bottom | AnchorStyles.Right;
            btnGravar.BackColor = Color.PowderBlue;
            btnGravar.DialogResult = DialogResult.OK;
            btnGravar.Location = new Point(110, 159);
            btnGravar.Name = "btnGravar";
            btnGravar.Size = new Size(87, 37);
            btnGravar.TabIndex = 12;
            btnGravar.Text = "Gerar";
            btnGravar.UseVisualStyleBackColor = false;
            btnGravar.Click += btnGravar_Click;
            // 
            // btnCancelar
            // 
            btnCancelar.Anchor = AnchorStyles.Bottom | AnchorStyles.Right;
            btnCancelar.BackColor = Color.PowderBlue;
            btnCancelar.DialogResult = DialogResult.Cancel;
            btnCancelar.Location = new Point(203, 159);
            btnCancelar.Name = "btnCancelar";
            btnCancelar.Size = new Size(87, 37);
            btnCancelar.TabIndex = 11;
            btnCancelar.Text = "Cancelar";
            btnCancelar.UseVisualStyleBackColor = false;
            // 
            // btnDiretorio
            // 
            btnDiretorio.BackColor = Color.PowderBlue;
            btnDiretorio.Location = new Point(150, 79);
            btnDiretorio.Name = "btnDiretorio";
            btnDiretorio.Size = new Size(140, 31);
            btnDiretorio.TabIndex = 18;
            btnDiretorio.Text = "Diretório";
            btnDiretorio.UseVisualStyleBackColor = false;
            btnDiretorio.Click += btnDiretorio_Click;
            // 
            // txtDiretorio
            // 
            txtDiretorio.Location = new Point(12, 116);
            txtDiretorio.Name = "txtDiretorio";
            txtDiretorio.Size = new Size(278, 23);
            txtDiretorio.TabIndex = 17;
            // 
            // rdbQuestao
            // 
            rdbQuestao.AutoSize = true;
            rdbQuestao.Location = new Point(174, 45);
            rdbQuestao.Name = "rdbQuestao";
            rdbQuestao.Size = new Size(116, 19);
            rdbQuestao.TabIndex = 16;
            rdbQuestao.TabStop = true;
            rdbQuestao.Text = "Apenas Questões";
            rdbQuestao.UseVisualStyleBackColor = true;
            // 
            // rdbGabarito
            // 
            rdbGabarito.AutoSize = true;
            rdbGabarito.Location = new Point(174, 20);
            rdbGabarito.Name = "rdbGabarito";
            rdbGabarito.Size = new Size(70, 19);
            rdbGabarito.TabIndex = 15;
            rdbGabarito.TabStop = true;
            rdbGabarito.Text = "Gabarito";
            rdbGabarito.UseVisualStyleBackColor = true;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Segoe UI", 9.75F, FontStyle.Regular, GraphicsUnit.Point);
            label2.ForeColor = Color.Black;
            label2.Location = new Point(12, 20);
            label2.Name = "label2";
            label2.Size = new Size(156, 17);
            label2.TabIndex = 14;
            label2.Text = "Escolha uma das opções:";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 9.75F, FontStyle.Regular, GraphicsUnit.Point);
            label1.ForeColor = Color.Black;
            label1.Location = new Point(12, 85);
            label1.Name = "label1";
            label1.Size = new Size(132, 17);
            label1.TabIndex = 19;
            label1.Text = "Escolha um diretorio:";
            // 
            // TelaGerarPdfForm
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.Honeydew;
            ClientSize = new Size(302, 208);
            Controls.Add(label1);
            Controls.Add(btnDiretorio);
            Controls.Add(txtDiretorio);
            Controls.Add(rdbQuestao);
            Controls.Add(rdbGabarito);
            Controls.Add(label2);
            Controls.Add(btnGravar);
            Controls.Add(btnCancelar);
            Name = "TelaGerarPdfForm";
            Text = "Gerador de PDF";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button btnGravar;
        private Button btnCancelar;
        private Button btnDiretorio;
        private TextBox txtDiretorio;
        private RadioButton rdbQuestao;
        private RadioButton rdbGabarito;
        private Label label2;
        private Label label1;
    }
}