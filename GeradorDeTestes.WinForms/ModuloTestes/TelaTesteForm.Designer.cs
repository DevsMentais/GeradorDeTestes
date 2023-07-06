namespace GeradorDeTestes.WinForms.ModuloTestes
{
    partial class TelaTesteForm
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
            cbDisciplina = new ComboBox();
            label3 = new Label();
            label4 = new Label();
            numQtdQuestoes = new NumericUpDown();
            txtTitulo = new TextBox();
            label5 = new Label();
            cbMateria = new ComboBox();
            chProvaRecup = new CheckBox();
            groupBox1 = new GroupBox();
            listBoxSorteadas = new ListBox();
            btnSortear = new Button();
            ((System.ComponentModel.ISupportInitialize)numQtdQuestoes).BeginInit();
            groupBox1.SuspendLayout();
            SuspendLayout();
            // 
            // txtId
            // 
            txtId.Enabled = false;
            txtId.Location = new Point(588, 54);
            txtId.Margin = new Padding(5, 6, 5, 6);
            txtId.Name = "txtId";
            txtId.ReadOnly = true;
            txtId.Size = new Size(30, 35);
            txtId.TabIndex = 12;
            txtId.Text = "0";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(549, 60);
            label1.Margin = new Padding(5, 0, 5, 0);
            label1.Name = "label1";
            label1.Size = new Size(30, 30);
            label1.TabIndex = 11;
            label1.Text = "id";
            // 
            // btnGravar
            // 
            btnGravar.Anchor = AnchorStyles.Bottom | AnchorStyles.Right;
            btnGravar.BackColor = Color.PowderBlue;
            btnGravar.DialogResult = DialogResult.OK;
            btnGravar.Location = new Point(315, 750);
            btnGravar.Margin = new Padding(5, 6, 5, 6);
            btnGravar.Name = "btnGravar";
            btnGravar.Size = new Size(149, 74);
            btnGravar.TabIndex = 10;
            btnGravar.Text = "Gravar";
            btnGravar.UseVisualStyleBackColor = false;
            btnGravar.Click += btnGravar_Click;
            // 
            // btnCancelar
            // 
            btnCancelar.Anchor = AnchorStyles.Bottom | AnchorStyles.Right;
            btnCancelar.BackColor = Color.PowderBlue;
            btnCancelar.DialogResult = DialogResult.Cancel;
            btnCancelar.Location = new Point(475, 750);
            btnCancelar.Margin = new Padding(5, 6, 5, 6);
            btnCancelar.Name = "btnCancelar";
            btnCancelar.Size = new Size(149, 74);
            btnCancelar.TabIndex = 9;
            btnCancelar.Text = "Cancelar";
            btnCancelar.UseVisualStyleBackColor = false;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(57, 60);
            label2.Margin = new Padding(5, 0, 5, 0);
            label2.Name = "label2";
            label2.Size = new Size(70, 30);
            label2.TabIndex = 13;
            label2.Text = "Título:";
            // 
            // cbDisciplina
            // 
            cbDisciplina.BackColor = Color.PowderBlue;
            cbDisciplina.DropDownStyle = ComboBoxStyle.DropDownList;
            cbDisciplina.FormattingEnabled = true;
            cbDisciplina.Location = new Point(130, 142);
            cbDisciplina.Margin = new Padding(5, 6, 5, 6);
            cbDisciplina.Name = "cbDisciplina";
            cbDisciplina.Size = new Size(227, 38);
            cbDisciplina.TabIndex = 14;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(21, 148);
            label3.Margin = new Padding(5, 0, 5, 0);
            label3.Name = "label3";
            label3.Size = new Size(107, 30);
            label3.TabIndex = 15;
            label3.Text = "Disciplina:";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(391, 148);
            label4.Margin = new Padding(5, 0, 5, 0);
            label4.Name = "label4";
            label4.Size = new Size(151, 30);
            label4.TabIndex = 16;
            label4.Text = "Qtd. Questões:";
            // 
            // numQtdQuestoes
            // 
            numQtdQuestoes.Location = new Point(542, 142);
            numQtdQuestoes.Margin = new Padding(5, 6, 5, 6);
            numQtdQuestoes.Name = "numQtdQuestoes";
            numQtdQuestoes.Size = new Size(79, 35);
            numQtdQuestoes.TabIndex = 17;
            // 
            // txtTitulo
            // 
            txtTitulo.Location = new Point(130, 54);
            txtTitulo.Margin = new Padding(5, 6, 5, 6);
            txtTitulo.Name = "txtTitulo";
            txtTitulo.Size = new Size(385, 35);
            txtTitulo.TabIndex = 18;
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Location = new Point(39, 232);
            label5.Margin = new Padding(5, 0, 5, 0);
            label5.Name = "label5";
            label5.Size = new Size(89, 30);
            label5.TabIndex = 19;
            label5.Text = "Matéria:";
            // 
            // cbMateria
            // 
            cbMateria.BackColor = Color.PowderBlue;
            cbMateria.DropDownStyle = ComboBoxStyle.DropDownList;
            cbMateria.Enabled = false;
            cbMateria.FormattingEnabled = true;
            cbMateria.Location = new Point(130, 226);
            cbMateria.Margin = new Padding(5, 6, 5, 6);
            cbMateria.Name = "cbMateria";
            cbMateria.Size = new Size(227, 38);
            cbMateria.TabIndex = 20;
            // 
            // chProvaRecup
            // 
            chProvaRecup.AutoSize = true;
            chProvaRecup.Location = new Point(375, 230);
            chProvaRecup.Margin = new Padding(5, 6, 5, 6);
            chProvaRecup.Name = "chProvaRecup";
            chProvaRecup.Size = new Size(245, 34);
            chProvaRecup.TabIndex = 21;
            chProvaRecup.Text = "Prova de Recuperação";
            chProvaRecup.UseVisualStyleBackColor = true;
            // 
            // groupBox1
            // 
            groupBox1.Controls.Add(listBoxSorteadas);
            groupBox1.Location = new Point(21, 362);
            groupBox1.Margin = new Padding(5, 6, 5, 6);
            groupBox1.Name = "groupBox1";
            groupBox1.Padding = new Padding(5, 6, 5, 6);
            groupBox1.Size = new Size(600, 376);
            groupBox1.TabIndex = 22;
            groupBox1.TabStop = false;
            groupBox1.Text = "Questões Selecionadas";
            // 
            // listBoxSorteadas
            // 
            listBoxSorteadas.FormattingEnabled = true;
            listBoxSorteadas.ItemHeight = 30;
            listBoxSorteadas.Location = new Point(10, 42);
            listBoxSorteadas.Margin = new Padding(5, 6, 5, 6);
            listBoxSorteadas.Name = "listBoxSorteadas";
            listBoxSorteadas.Size = new Size(577, 304);
            listBoxSorteadas.TabIndex = 1;
            // 
            // btnSortear
            // 
            btnSortear.BackColor = Color.PowderBlue;
            btnSortear.Location = new Point(21, 284);
            btnSortear.Margin = new Padding(5, 6, 5, 6);
            btnSortear.Name = "btnSortear";
            btnSortear.Size = new Size(600, 66);
            btnSortear.TabIndex = 0;
            btnSortear.Text = "Sortear";
            btnSortear.UseVisualStyleBackColor = false;
            btnSortear.Click += btnSortear_Click;
            // 
            // TelaTesteForm
            // 
            AutoScaleDimensions = new SizeF(12F, 30F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.Honeydew;
            ClientSize = new Size(645, 848);
            Controls.Add(groupBox1);
            Controls.Add(btnSortear);
            Controls.Add(chProvaRecup);
            Controls.Add(cbMateria);
            Controls.Add(label5);
            Controls.Add(txtTitulo);
            Controls.Add(numQtdQuestoes);
            Controls.Add(label4);
            Controls.Add(label3);
            Controls.Add(cbDisciplina);
            Controls.Add(label2);
            Controls.Add(txtId);
            Controls.Add(label1);
            Controls.Add(btnGravar);
            Controls.Add(btnCancelar);
            Enabled = false;
            Margin = new Padding(5, 6, 5, 6);
            Name = "TelaTesteForm";
            Text = "Cadastro de Testes";
            ((System.ComponentModel.ISupportInitialize)numQtdQuestoes).EndInit();
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
        private ComboBox cbDisciplina;
        private Label label3;
        private Label label4;
        private NumericUpDown numQtdQuestoes;
        private TextBox txtTitulo;
        private Label label5;
        private ComboBox cbMateria;
        private CheckBox chProvaRecup;
        private GroupBox groupBox1;
        private ListBox listBoxSorteadas;
        private Button btnSortear;
    }
}