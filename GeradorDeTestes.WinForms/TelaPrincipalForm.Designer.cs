namespace GeradorDeTestes.WinForms
{
    partial class TelaPrincipalForm
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(TelaPrincipalForm));
            menuStrip1 = new MenuStrip();
            materiaMenu = new ToolStripMenuItem();
            matériaToolStripMenuItem = new ToolStripMenuItem();
            materiaMenuItem = new ToolStripMenuItem();
            diciplicaMenuItem = new ToolStripMenuItem();
            questoesMenuItem = new ToolStripMenuItem();
            testesMenuItem = new ToolStripMenuItem();
            toolStrip1 = new ToolStrip();
            btnInserir = new ToolStripButton();
            btnEditar = new ToolStripButton();
            btnExcluir = new ToolStripButton();
            toolStripSeparator1 = new ToolStripSeparator();
            btnVisualizar = new ToolStripButton();
            lblTipoCadastro = new ToolStripLabel();
            panelRegistros = new Panel();
            statusStrip1 = new StatusStrip();
            lblStatus = new ToolStripStatusLabel();
            menuStrip1.SuspendLayout();
            toolStrip1.SuspendLayout();
            panelRegistros.SuspendLayout();
            statusStrip1.SuspendLayout();
            SuspendLayout();
            // 
            // menuStrip1
            // 
            menuStrip1.ImageScalingSize = new Size(28, 28);
            menuStrip1.Items.AddRange(new ToolStripItem[] { materiaMenu });
            menuStrip1.Location = new Point(0, 0);
            menuStrip1.Name = "menuStrip1";
            menuStrip1.Padding = new Padding(4, 1, 0, 1);
            menuStrip1.Size = new Size(540, 24);
            menuStrip1.TabIndex = 0;
            menuStrip1.Text = "menuStrip1";
            // 
            // materiaMenu
            // 
            materiaMenu.DropDownItems.AddRange(new ToolStripItem[] { matériaToolStripMenuItem, questoesMenuItem, testesMenuItem });
            materiaMenu.Name = "materiaMenu";
            materiaMenu.Size = new Size(71, 22);
            materiaMenu.Text = "Cadastros";
            // 
            // matériaToolStripMenuItem
            // 
            matériaToolStripMenuItem.DropDownItems.AddRange(new ToolStripItem[] { materiaMenuItem, diciplicaMenuItem });
            matériaToolStripMenuItem.Name = "matériaToolStripMenuItem";
            matériaToolStripMenuItem.Size = new Size(123, 22);
            matériaToolStripMenuItem.Text = "Matéria";
            // 
            // materiaMenuItem
            // 
            materiaMenuItem.Name = "materiaMenuItem";
            materiaMenuItem.Size = new Size(125, 22);
            materiaMenuItem.Text = "Matéria";
            // 
            // diciplicaMenuItem
            // 
            diciplicaMenuItem.Name = "diciplicaMenuItem";
            diciplicaMenuItem.Size = new Size(125, 22);
            diciplicaMenuItem.Text = "Disciplina";
            // 
            // questoesMenuItem
            // 
            questoesMenuItem.Name = "questoesMenuItem";
            questoesMenuItem.Size = new Size(123, 22);
            questoesMenuItem.Text = "Questões";
            // 
            // testesMenuItem
            // 
            testesMenuItem.Name = "testesMenuItem";
            testesMenuItem.Size = new Size(123, 22);
            testesMenuItem.Text = "Testes";
            // 
            // toolStrip1
            // 
            toolStrip1.ImageScalingSize = new Size(28, 28);
            toolStrip1.Items.AddRange(new ToolStripItem[] { btnInserir, btnEditar, btnExcluir, toolStripSeparator1, btnVisualizar, lblTipoCadastro });
            toolStrip1.Location = new Point(0, 24);
            toolStrip1.Name = "toolStrip1";
            toolStrip1.Size = new Size(540, 49);
            toolStrip1.TabIndex = 1;
            toolStrip1.Text = "toolStrip1";
            // 
            // btnInserir
            // 
            btnInserir.DisplayStyle = ToolStripItemDisplayStyle.Image;
            btnInserir.Image = (Image)resources.GetObject("btnInserir.Image");
            btnInserir.ImageTransparentColor = Color.Magenta;
            btnInserir.Name = "btnInserir";
            btnInserir.Padding = new Padding(7);
            btnInserir.Size = new Size(46, 46);
            btnInserir.Text = "toolStripButton1";
            // 
            // btnEditar
            // 
            btnEditar.DisplayStyle = ToolStripItemDisplayStyle.Image;
            btnEditar.Image = (Image)resources.GetObject("btnEditar.Image");
            btnEditar.ImageTransparentColor = Color.Magenta;
            btnEditar.Name = "btnEditar";
            btnEditar.Padding = new Padding(7);
            btnEditar.Size = new Size(46, 46);
            btnEditar.Text = "toolStripButton3";
            // 
            // btnExcluir
            // 
            btnExcluir.DisplayStyle = ToolStripItemDisplayStyle.Image;
            btnExcluir.Image = (Image)resources.GetObject("btnExcluir.Image");
            btnExcluir.ImageTransparentColor = Color.Magenta;
            btnExcluir.Name = "btnExcluir";
            btnExcluir.Padding = new Padding(7);
            btnExcluir.Size = new Size(46, 46);
            btnExcluir.Text = "toolStripButton2";
            // 
            // toolStripSeparator1
            // 
            toolStripSeparator1.Name = "toolStripSeparator1";
            toolStripSeparator1.Padding = new Padding(7);
            toolStripSeparator1.Size = new Size(6, 49);
            // 
            // btnVisualizar
            // 
            btnVisualizar.DisplayStyle = ToolStripItemDisplayStyle.Image;
            btnVisualizar.Image = (Image)resources.GetObject("btnVisualizar.Image");
            btnVisualizar.ImageTransparentColor = Color.Magenta;
            btnVisualizar.Name = "btnVisualizar";
            btnVisualizar.Padding = new Padding(7);
            btnVisualizar.Size = new Size(46, 46);
            btnVisualizar.Text = "toolStripButton4";
            // 
            // lblTipoCadastro
            // 
            lblTipoCadastro.Name = "lblTipoCadastro";
            lblTipoCadastro.Size = new Size(80, 46);
            lblTipoCadastro.Text = "Tipo Cadastro";
            // 
            // panelRegistros
            // 
            panelRegistros.Controls.Add(statusStrip1);
            panelRegistros.Dock = DockStyle.Fill;
            panelRegistros.Location = new Point(0, 73);
            panelRegistros.Margin = new Padding(2, 2, 2, 2);
            panelRegistros.Name = "panelRegistros";
            panelRegistros.Size = new Size(540, 247);
            panelRegistros.TabIndex = 2;
            // 
            // statusStrip1
            // 
            statusStrip1.ImageScalingSize = new Size(28, 28);
            statusStrip1.Items.AddRange(new ToolStripItem[] { lblStatus });
            statusStrip1.Location = new Point(0, 225);
            statusStrip1.Name = "statusStrip1";
            statusStrip1.Padding = new Padding(1, 0, 8, 0);
            statusStrip1.Size = new Size(540, 22);
            statusStrip1.TabIndex = 0;
            statusStrip1.Text = "statusStrip1";
            // 
            // lblStatus
            // 
            lblStatus.Name = "lblStatus";
            lblStatus.Size = new Size(47, 17);
            lblStatus.Text = "Rodape";
            // 
            // TelaPrincipalForm
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(540, 320);
            Controls.Add(panelRegistros);
            Controls.Add(toolStrip1);
            Controls.Add(menuStrip1);
            MainMenuStrip = menuStrip1;
            Margin = new Padding(2, 2, 2, 2);
            Name = "TelaPrincipalForm";
            Text = "Form1";
            menuStrip1.ResumeLayout(false);
            menuStrip1.PerformLayout();
            toolStrip1.ResumeLayout(false);
            toolStrip1.PerformLayout();
            panelRegistros.ResumeLayout(false);
            panelRegistros.PerformLayout();
            statusStrip1.ResumeLayout(false);
            statusStrip1.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private MenuStrip menuStrip1;
        private ToolStripMenuItem materiaMenu;
        private ToolStripMenuItem matériaToolStripMenuItem;
        private ToolStripMenuItem materiaMenuItem;
        private ToolStripMenuItem diciplicaMenuItem;
        private ToolStripMenuItem questoesMenuItem;
        private ToolStripMenuItem testesMenuItem;
        private ToolStrip toolStrip1;
        private ToolStripButton btnInserir;
        private ToolStripButton btnEditar;
        private ToolStripButton btnExcluir;
        private ToolStripSeparator toolStripSeparator1;
        private ToolStripButton btnVisualizar;
        private ToolStripLabel lblTipoCadastro;
        private Panel panelRegistros;
        private StatusStrip statusStrip1;
        private ToolStripStatusLabel lblStatus;
    }
}