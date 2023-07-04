namespace GeradorDeTestes.WinForms.ModuloDisciplina
{
    partial class TelaVisualizarMateriasForm
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
            btnCancelar = new Button();
            label2 = new Label();
            lblDisciplina = new Label();
            groupBox1 = new GroupBox();
            listMaterias = new ListBox();
            groupBox1.SuspendLayout();
            SuspendLayout();
            // 
            // txtId
            // 
            txtId.Enabled = false;
            txtId.Location = new Point(274, 17);
            txtId.Name = "txtId";
            txtId.ReadOnly = true;
            txtId.Size = new Size(19, 23);
            txtId.TabIndex = 8;
            txtId.Text = "0";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(251, 20);
            label1.Name = "label1";
            label1.Size = new Size(17, 15);
            label1.TabIndex = 7;
            label1.Text = "id";
            // 
            // btnCancelar
            // 
            btnCancelar.Anchor = AnchorStyles.Bottom | AnchorStyles.Right;
            btnCancelar.DialogResult = DialogResult.Cancel;
            btnCancelar.Location = new Point(18, 325);
            btnCancelar.Name = "btnCancelar";
            btnCancelar.Size = new Size(275, 37);
            btnCancelar.TabIndex = 5;
            btnCancelar.Text = "Fechar";
            btnCancelar.UseVisualStyleBackColor = true;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(12, 20);
            label2.Name = "label2";
            label2.Size = new Size(61, 15);
            label2.TabIndex = 9;
            label2.Text = "Disciplina:";
            // 
            // lblDisciplina
            // 
            lblDisciplina.AutoSize = true;
            lblDisciplina.Location = new Point(76, 20);
            lblDisciplina.Name = "lblDisciplina";
            lblDisciplina.Size = new Size(67, 15);
            lblDisciplina.TabIndex = 10;
            lblDisciplina.Text = "------------";
            // 
            // groupBox1
            // 
            groupBox1.Controls.Add(listMaterias);
            groupBox1.Location = new Point(12, 52);
            groupBox1.Name = "groupBox1";
            groupBox1.Size = new Size(279, 260);
            groupBox1.TabIndex = 11;
            groupBox1.TabStop = false;
            groupBox1.Text = "Matérias";
            // 
            // listMaterias
            // 
            listMaterias.FormattingEnabled = true;
            listMaterias.ItemHeight = 15;
            listMaterias.Location = new Point(6, 22);
            listMaterias.Name = "listMaterias";
            listMaterias.Size = new Size(267, 229);
            listMaterias.TabIndex = 0;
            // 
            // TelaVisualizarMateriasForm
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(305, 374);
            Controls.Add(groupBox1);
            Controls.Add(lblDisciplina);
            Controls.Add(label2);
            Controls.Add(txtId);
            Controls.Add(label1);
            Controls.Add(btnCancelar);
            Name = "TelaVisualizarMateriasForm";
            Text = "Visualizar Materias da Disciplina";
            groupBox1.ResumeLayout(false);
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private TextBox txtId;
        private Label label1;
        private Button btnCancelar;
        private Label label2;
        private Label lblDisciplina;
        private GroupBox groupBox1;
        private ListBox listMaterias;
    }
}