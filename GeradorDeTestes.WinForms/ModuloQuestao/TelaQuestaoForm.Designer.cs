namespace GeradorDeTestes.WinForms.ModuloQuestoes
{
    partial class TelaQuestaoForm
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
            txtId = new TextBox();
            label1 = new Label();
            btnGravar = new Button();
            btnCancelar = new Button();
            label2 = new Label();
            cbMateria = new ComboBox();
            label3 = new Label();
            txtEnunciado = new TextBox();
            label4 = new Label();
            btnAdicionar = new Button();
            groupBox1 = new GroupBox();
            chListAlternativas = new CheckedListBox();
            btnRemover = new Button();
            txtResposta = new TextBox();
            groupBox1.SuspendLayout();
            SuspendLayout();
            // 
            // txtId
            // 
            txtId.Enabled = false;
            txtId.Location = new Point(317, 16);
            txtId.Name = "txtId";
            txtId.ReadOnly = true;
            txtId.Size = new Size(19, 23);
            txtId.TabIndex = 8;
            txtId.Text = "0";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(294, 19);
            label1.Name = "label1";
            label1.Size = new Size(17, 15);
            label1.TabIndex = 7;
            label1.Text = "id";
            // 
            // btnGravar
            // 
            btnGravar.Anchor = AnchorStyles.Bottom | AnchorStyles.Right;
            btnGravar.BackColor = Color.PowderBlue;
            btnGravar.DialogResult = DialogResult.OK;
            btnGravar.Location = new Point(168, 301);
            btnGravar.Name = "btnGravar";
            btnGravar.Size = new Size(87, 37);
            btnGravar.TabIndex = 6;
            btnGravar.Text = "Gravar";
            btnGravar.UseVisualStyleBackColor = false;
            btnGravar.Click += btnGravar_Click;
            // 
            // btnCancelar
            // 
            btnCancelar.Anchor = AnchorStyles.Bottom | AnchorStyles.Right;
            btnCancelar.BackColor = Color.PowderBlue;
            btnCancelar.DialogResult = DialogResult.Cancel;
            btnCancelar.Location = new Point(261, 301);
            btnCancelar.Name = "btnCancelar";
            btnCancelar.Size = new Size(87, 37);
            btnCancelar.TabIndex = 5;
            btnCancelar.Text = "Cancelar";
            btnCancelar.UseVisualStyleBackColor = false;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(28, 19);
            label2.Name = "label2";
            label2.Size = new Size(50, 15);
            label2.TabIndex = 9;
            label2.Text = "Materia:";
            // 
            // cbMateria
            // 
            cbMateria.BackColor = Color.PowderBlue;
            cbMateria.DropDownStyle = ComboBoxStyle.DropDownList;
            cbMateria.FormattingEnabled = true;
            cbMateria.Location = new Point(81, 16);
            cbMateria.Name = "cbMateria";
            cbMateria.Size = new Size(207, 23);
            cbMateria.TabIndex = 10;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(12, 58);
            label3.Name = "label3";
            label3.Size = new Size(66, 15);
            label3.TabIndex = 11;
            label3.Text = "Enunciado:";
            // 
            // txtEnunciado
            // 
            txtEnunciado.Location = new Point(81, 55);
            txtEnunciado.Name = "txtEnunciado";
            txtEnunciado.Size = new Size(255, 23);
            txtEnunciado.TabIndex = 12;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(21, 97);
            label4.Name = "label4";
            label4.Size = new Size(57, 15);
            label4.TabIndex = 13;
            label4.Text = "Resposta:";
            // 
            // btnAdicionar
            // 
            btnAdicionar.BackColor = Color.PowderBlue;
            btnAdicionar.Location = new Point(261, 86);
            btnAdicionar.Name = "btnAdicionar";
            btnAdicionar.Size = new Size(75, 23);
            btnAdicionar.TabIndex = 15;
            btnAdicionar.Text = "Adicionar";
            btnAdicionar.UseVisualStyleBackColor = false;
            btnAdicionar.Click += btnAdicionar_Click;
            // 
            // groupBox1
            // 
            groupBox1.Controls.Add(chListAlternativas);
            groupBox1.Location = new Point(12, 151);
            groupBox1.Name = "groupBox1";
            groupBox1.Size = new Size(324, 137);
            groupBox1.TabIndex = 16;
            groupBox1.TabStop = false;
            groupBox1.Text = "Alternativas";
            // 
            // chListAlternativas
            // 
            chListAlternativas.FormattingEnabled = true;
            chListAlternativas.Location = new Point(9, 19);
            chListAlternativas.Name = "chListAlternativas";
            chListAlternativas.Size = new Size(309, 112);
            chListAlternativas.TabIndex = 0;
            chListAlternativas.SelectedIndexChanged += chListAlternativas_SelectedIndexChanged;
            // 
            // btnRemover
            // 
            btnRemover.BackColor = Color.PowderBlue;
            btnRemover.Location = new Point(261, 120);
            btnRemover.Name = "btnRemover";
            btnRemover.Size = new Size(75, 23);
            btnRemover.TabIndex = 17;
            btnRemover.Text = "Remover";
            btnRemover.UseVisualStyleBackColor = false;
            btnRemover.Click += btnRemover_Click;
            // 
            // txtResposta
            // 
            txtResposta.BackColor = Color.Snow;
            txtResposta.Font = new Font("Segoe UI", 9F, FontStyle.Regular, GraphicsUnit.Point);
            txtResposta.Location = new Point(82, 86);
            txtResposta.Margin = new Padding(4, 5, 4, 5);
            txtResposta.Multiline = true;
            txtResposta.Name = "txtResposta";
            txtResposta.ScrollBars = ScrollBars.Vertical;
            txtResposta.Size = new Size(172, 57);
            txtResposta.TabIndex = 36;
            // 
            // TelaQuestaoForm
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.Honeydew;
            ClientSize = new Size(359, 350);
            Controls.Add(txtResposta);
            Controls.Add(btnRemover);
            Controls.Add(groupBox1);
            Controls.Add(btnAdicionar);
            Controls.Add(label4);
            Controls.Add(txtEnunciado);
            Controls.Add(label3);
            Controls.Add(cbMateria);
            Controls.Add(label2);
            Controls.Add(txtId);
            Controls.Add(label1);
            Controls.Add(btnGravar);
            Controls.Add(btnCancelar);
            Name = "TelaQuestaoForm";
            Text = "Cadastro de Questoes";
            groupBox1.ResumeLayout(false);
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private TextBox txtId;
        private Label label1;
        private Button btnGravar;
        private Button btnCancelar;
        private Label label2;
        private ComboBox cbMateria;
        private Label label3;
        private TextBox txtEnunciado;
        private Label label4;
        private Button btnAdicionar;
        private GroupBox groupBox1;
        private Button btnRemover;
        private CheckedListBox chListAlternativas;
        private TextBox txtResposta;
    }
}