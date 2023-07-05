namespace GeradorDeTestes.WinForms.ModuloMateria
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
            txtNome = new TextBox();
            label3 = new Label();
            cbDisciplina = new ComboBox();
            label4 = new Label();
            rdbPrimeiro = new RadioButton();
            rdbSegundo = new RadioButton();
            SuspendLayout();
            // 
            // txtId
            // 
            txtId.Enabled = false;
            txtId.Location = new Point(343, 12);
            txtId.Name = "txtId";
            txtId.ReadOnly = true;
            txtId.Size = new Size(19, 23);
            txtId.TabIndex = 8;
            txtId.Text = "0";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(320, 15);
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
            btnGravar.Location = new Point(182, 97);
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
            btnCancelar.Location = new Point(275, 97);
            btnCancelar.Name = "btnCancelar";
            btnCancelar.Size = new Size(87, 37);
            btnCancelar.TabIndex = 5;
            btnCancelar.Text = "Cancelar";
            btnCancelar.UseVisualStyleBackColor = false;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(33, 15);
            label2.Name = "label2";
            label2.Size = new Size(43, 15);
            label2.TabIndex = 9;
            label2.Text = "Nome:";
            // 
            // txtNome
            // 
            txtNome.Location = new Point(79, 12);
            txtNome.Name = "txtNome";
            txtNome.Size = new Size(211, 23);
            txtNome.TabIndex = 10;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(15, 51);
            label3.Name = "label3";
            label3.Size = new Size(61, 15);
            label3.TabIndex = 11;
            label3.Text = "Disciplina:";
            // 
            // cbDisciplina
            // 
            cbDisciplina.BackColor = Color.PowderBlue;
            cbDisciplina.DropDownStyle = ComboBoxStyle.DropDownList;
            cbDisciplina.FormattingEnabled = true;
            cbDisciplina.Location = new Point(79, 48);
            cbDisciplina.Name = "cbDisciplina";
            cbDisciplina.Size = new Size(152, 23);
            cbDisciplina.TabIndex = 12;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(237, 51);
            label4.Name = "label4";
            label4.Size = new Size(35, 15);
            label4.TabIndex = 13;
            label4.Text = "Série:";
            // 
            // rdbPrimeiro
            // 
            rdbPrimeiro.AutoSize = true;
            rdbPrimeiro.Location = new Point(278, 49);
            rdbPrimeiro.Name = "rdbPrimeiro";
            rdbPrimeiro.Size = new Size(36, 19);
            rdbPrimeiro.TabIndex = 14;
            rdbPrimeiro.TabStop = true;
            rdbPrimeiro.Text = "1ª";
            rdbPrimeiro.UseVisualStyleBackColor = true;
            // 
            // rdbSegundo
            // 
            rdbSegundo.AutoSize = true;
            rdbSegundo.Location = new Point(320, 49);
            rdbSegundo.Name = "rdbSegundo";
            rdbSegundo.Size = new Size(36, 19);
            rdbSegundo.TabIndex = 15;
            rdbSegundo.TabStop = true;
            rdbSegundo.Text = "2ª";
            rdbSegundo.UseVisualStyleBackColor = true;
            // 
            // TelaQuestaoForm
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.Honeydew;
            ClientSize = new Size(374, 146);
            Controls.Add(rdbSegundo);
            Controls.Add(rdbPrimeiro);
            Controls.Add(label4);
            Controls.Add(cbDisciplina);
            Controls.Add(label3);
            Controls.Add(txtNome);
            Controls.Add(label2);
            Controls.Add(txtId);
            Controls.Add(label1);
            Controls.Add(btnGravar);
            Controls.Add(btnCancelar);
            Name = "TelaQuestaoForm";
            Text = "Cadastro de Matérias";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private TextBox txtId;
        private Label label1;
        private Button btnGravar;
        private Button btnCancelar;
        private Label label2;
        private TextBox txtNome;
        private Label label3;
        private ComboBox cbDisciplina;
        private Label label4;
        private RadioButton rdbPrimeiro;
        private RadioButton rdbSegundo;
    }
}