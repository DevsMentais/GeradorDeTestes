namespace GeradorDeTestes.WinForms.ModuloMateria
{
    partial class TelaMateriaForm
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
            txtId.Location = new Point(98, 29);
            txtId.Margin = new Padding(3, 4, 3, 4);
            txtId.Name = "txtId";
            txtId.ReadOnly = true;
            txtId.Size = new Size(21, 27);
            txtId.TabIndex = 8;
            txtId.Text = "0";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(72, 33);
            label1.Name = "label1";
            label1.Size = new Size(22, 20);
            label1.TabIndex = 7;
            label1.Text = "id";
            // 
            // btnGravar
            // 
            btnGravar.Anchor = AnchorStyles.Bottom | AnchorStyles.Right;
            btnGravar.DialogResult = DialogResult.OK;
            btnGravar.Location = new Point(208, 225);
            btnGravar.Margin = new Padding(3, 4, 3, 4);
            btnGravar.Name = "btnGravar";
            btnGravar.Size = new Size(99, 49);
            btnGravar.TabIndex = 6;
            btnGravar.Text = "Gravar";
            btnGravar.UseVisualStyleBackColor = true;
            // 
            // btnCancelar
            // 
            btnCancelar.Anchor = AnchorStyles.Bottom | AnchorStyles.Right;
            btnCancelar.DialogResult = DialogResult.Cancel;
            btnCancelar.Location = new Point(314, 225);
            btnCancelar.Margin = new Padding(3, 4, 3, 4);
            btnCancelar.Name = "btnCancelar";
            btnCancelar.Size = new Size(99, 49);
            btnCancelar.TabIndex = 5;
            btnCancelar.Text = "Cancelar";
            btnCancelar.UseVisualStyleBackColor = true;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(46, 76);
            label2.Name = "label2";
            label2.Size = new Size(50, 20);
            label2.TabIndex = 9;
            label2.Text = "Nome";
            // 
            // txtNome
            // 
            txtNome.Location = new Point(98, 72);
            txtNome.Margin = new Padding(3, 4, 3, 4);
            txtNome.Name = "txtNome";
            txtNome.Size = new Size(315, 27);
            txtNome.TabIndex = 10;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(25, 119);
            label3.Name = "label3";
            label3.Size = new Size(74, 20);
            label3.TabIndex = 11;
            label3.Text = "Disciplina";
            // 
            // cbDisciplina
            // 
            cbDisciplina.FormattingEnabled = true;
            cbDisciplina.Location = new Point(98, 115);
            cbDisciplina.Margin = new Padding(3, 4, 3, 4);
            cbDisciplina.Name = "cbDisciplina";
            cbDisciplina.Size = new Size(138, 28);
            cbDisciplina.TabIndex = 12;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(55, 164);
            label4.Name = "label4";
            label4.Size = new Size(42, 20);
            label4.TabIndex = 13;
            label4.Text = "Série";
            // 
            // rdbPrimeiro
            // 
            rdbPrimeiro.AutoSize = true;
            rdbPrimeiro.Location = new Point(98, 161);
            rdbPrimeiro.Margin = new Padding(3, 4, 3, 4);
            rdbPrimeiro.Name = "rdbPrimeiro";
            rdbPrimeiro.Size = new Size(44, 24);
            rdbPrimeiro.TabIndex = 14;
            rdbPrimeiro.TabStop = true;
            rdbPrimeiro.Text = "1ª";
            rdbPrimeiro.UseVisualStyleBackColor = true;
            // 
            // rdbSegundo
            // 
            rdbSegundo.AutoSize = true;
            rdbSegundo.Location = new Point(174, 161);
            rdbSegundo.Margin = new Padding(3, 4, 3, 4);
            rdbSegundo.Name = "rdbSegundo";
            rdbSegundo.Size = new Size(44, 24);
            rdbSegundo.TabIndex = 15;
            rdbSegundo.TabStop = true;
            rdbSegundo.Text = "2ª";
            rdbSegundo.UseVisualStyleBackColor = true;
            // 
            // TelaMateriaForm
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(427, 291);
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
            Margin = new Padding(3, 4, 3, 4);
            Name = "TelaMateriaForm";
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