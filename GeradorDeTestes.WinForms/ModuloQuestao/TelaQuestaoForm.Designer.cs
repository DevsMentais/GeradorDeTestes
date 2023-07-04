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
            txtResposta = new TextBox();
            label4 = new Label();
            btnAdicionar = new Button();
            groupBox1 = new GroupBox();
            btnRemover = new Button();
            chListAlternativas = new CheckedListBox();
            groupBox1.SuspendLayout();
            SuspendLayout();
            // 
            // txtId
            // 
            txtId.Enabled = false;
            txtId.Location = new Point(403, 63);
            txtId.Margin = new Padding(4, 5, 4, 5);
            txtId.Name = "txtId";
            txtId.ReadOnly = true;
            txtId.Size = new Size(25, 31);
            txtId.TabIndex = 8;
            txtId.Text = "0";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(370, 68);
            label1.Margin = new Padding(4, 0, 4, 0);
            label1.Name = "label1";
            label1.Size = new Size(27, 25);
            label1.TabIndex = 7;
            label1.Text = "id";
            // 
            // btnGravar
            // 
            btnGravar.Anchor = AnchorStyles.Bottom | AnchorStyles.Right;
            btnGravar.DialogResult = DialogResult.OK;
            btnGravar.Location = new Point(173, 588);
            btnGravar.Margin = new Padding(4, 5, 4, 5);
            btnGravar.Name = "btnGravar";
            btnGravar.Size = new Size(124, 62);
            btnGravar.TabIndex = 6;
            btnGravar.Text = "Gravar";
            btnGravar.UseVisualStyleBackColor = true;
            // 
            // btnCancelar
            // 
            btnCancelar.Anchor = AnchorStyles.Bottom | AnchorStyles.Right;
            btnCancelar.DialogResult = DialogResult.Cancel;
            btnCancelar.Location = new Point(306, 588);
            btnCancelar.Margin = new Padding(4, 5, 4, 5);
            btnCancelar.Name = "btnCancelar";
            btnCancelar.Size = new Size(124, 62);
            btnCancelar.TabIndex = 5;
            btnCancelar.Text = "Cancelar";
            btnCancelar.UseVisualStyleBackColor = true;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(40, 68);
            label2.Margin = new Padding(4, 0, 4, 0);
            label2.Name = "label2";
            label2.Size = new Size(71, 25);
            label2.TabIndex = 9;
            label2.Text = "Materia";
            // 
            // cbMateria
            // 
            cbMateria.FormattingEnabled = true;
            cbMateria.Location = new Point(116, 63);
            cbMateria.Margin = new Padding(4, 5, 4, 5);
            cbMateria.Name = "cbMateria";
            cbMateria.Size = new Size(183, 33);
            cbMateria.TabIndex = 10;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(17, 133);
            label3.Margin = new Padding(4, 0, 4, 0);
            label3.Name = "label3";
            label3.Size = new Size(94, 25);
            label3.TabIndex = 11;
            label3.Text = "Enunciado";
            // 
            // txtEnunciado
            // 
            txtEnunciado.Location = new Point(116, 128);
            txtEnunciado.Margin = new Padding(4, 5, 4, 5);
            txtEnunciado.Name = "txtEnunciado";
            txtEnunciado.Size = new Size(313, 31);
            txtEnunciado.TabIndex = 12;
            // 
            // txtResposta
            // 
            txtResposta.Location = new Point(116, 193);
            txtResposta.Margin = new Padding(4, 5, 4, 5);
            txtResposta.Name = "txtResposta";
            txtResposta.Size = new Size(197, 31);
            txtResposta.TabIndex = 14;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(30, 198);
            label4.Margin = new Padding(4, 0, 4, 0);
            label4.Name = "label4";
            label4.Size = new Size(84, 25);
            label4.TabIndex = 13;
            label4.Text = "Resposta";
            // 
            // btnAdicionar
            // 
            btnAdicionar.Location = new Point(323, 193);
            btnAdicionar.Margin = new Padding(4, 5, 4, 5);
            btnAdicionar.Name = "btnAdicionar";
            btnAdicionar.Size = new Size(107, 38);
            btnAdicionar.TabIndex = 15;
            btnAdicionar.Text = "Adicionar";
            btnAdicionar.UseVisualStyleBackColor = true;
            btnAdicionar.Click += btnAdicionar_Click;
            // 
            // groupBox1
            // 
            groupBox1.Controls.Add(btnRemover);
            groupBox1.Controls.Add(chListAlternativas);
            groupBox1.Location = new Point(17, 263);
            groupBox1.Margin = new Padding(4, 5, 4, 5);
            groupBox1.Name = "groupBox1";
            groupBox1.Padding = new Padding(4, 5, 4, 5);
            groupBox1.Size = new Size(413, 305);
            groupBox1.TabIndex = 16;
            groupBox1.TabStop = false;
            groupBox1.Text = "Alternativas";
            // 
            // btnRemover
            // 
            btnRemover.Location = new Point(13, 37);
            btnRemover.Margin = new Padding(4, 5, 4, 5);
            btnRemover.Name = "btnRemover";
            btnRemover.Size = new Size(107, 38);
            btnRemover.TabIndex = 17;
            btnRemover.Text = "Remover";
            btnRemover.UseVisualStyleBackColor = true;
            // 
            // chListAlternativas
            // 
            chListAlternativas.FormattingEnabled = true;
            chListAlternativas.Location = new Point(13, 97);
            chListAlternativas.Margin = new Padding(4, 5, 4, 5);
            chListAlternativas.Name = "chListAlternativas";
            chListAlternativas.Size = new Size(390, 172);
            chListAlternativas.TabIndex = 0;
            // 
            // TelaQuestaoForm
            // 
            AutoScaleDimensions = new SizeF(10F, 25F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(447, 670);
            Controls.Add(groupBox1);
            Controls.Add(btnAdicionar);
            Controls.Add(txtResposta);
            Controls.Add(label4);
            Controls.Add(txtEnunciado);
            Controls.Add(label3);
            Controls.Add(cbMateria);
            Controls.Add(label2);
            Controls.Add(txtId);
            Controls.Add(label1);
            Controls.Add(btnGravar);
            Controls.Add(btnCancelar);
            Margin = new Padding(4, 5, 4, 5);
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
        private TextBox txtResposta;
        private Label label4;
        private Button btnAdicionar;
        private GroupBox groupBox1;
        private Button btnRemover;
        private CheckedListBox chListAlternativas;
    }
}