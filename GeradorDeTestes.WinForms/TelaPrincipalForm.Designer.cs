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
            menuBar = new MenuStrip();
            cadastroMenu = new ToolStripMenuItem();
            materiaToolStripMenuItem = new ToolStripMenuItem();
            materiaMenuItem = new ToolStripMenuItem();
            disciplinaMenuItem = new ToolStripMenuItem();
            questoesMenuItem = new ToolStripMenuItem();
            testesMenuItem = new ToolStripMenuItem();
            barraFerramentas = new ToolStrip();
            btnInserir = new ToolStripButton();
            btnEditar = new ToolStripButton();
            btnExcluir = new ToolStripButton();
            toolStripSeparator1 = new ToolStripSeparator();
            btnDuplicar = new ToolStripButton();
            toolStripSeparator3 = new ToolStripSeparator();
            btnVisualizar = new ToolStripButton();
            toolStripSeparator4 = new ToolStripSeparator();
            btnSalvar = new ToolStripButton();
            toolStripSeparator2 = new ToolStripSeparator();
            lblTipoCadastro = new ToolStripLabel();
            panelRegistros = new Panel();
            toolStrip1 = new ToolStrip();
            toolStripButton1 = new ToolStripButton();
            lblStatus = new ToolStripLabel();
            menuBar.SuspendLayout();
            barraFerramentas.SuspendLayout();
            toolStrip1.SuspendLayout();
            SuspendLayout();
            // 
            // menuBar
            // 
            menuBar.BackColor = Color.SkyBlue;
            menuBar.ImageScalingSize = new Size(28, 28);
            menuBar.Items.AddRange(new ToolStripItem[] { cadastroMenu });
            menuBar.Location = new Point(0, 0);
            menuBar.Name = "menuBar";
            menuBar.Padding = new Padding(4, 1, 0, 1);
            menuBar.Size = new Size(597, 30);
            menuBar.TabIndex = 0;
            menuBar.Text = "menuStrip1";
            // 
            // cadastroMenu
            // 
            cadastroMenu.DropDownItems.AddRange(new ToolStripItem[] { materiaToolStripMenuItem, questoesMenuItem, testesMenuItem });
            cadastroMenu.Image = Properties.Resources.list;
            cadastroMenu.ImageScaling = ToolStripItemImageScaling.None;
            cadastroMenu.Name = "cadastroMenu";
            cadastroMenu.Size = new Size(95, 28);
            cadastroMenu.Text = "Cadastros";
            // 
            // materiaToolStripMenuItem
            // 
            materiaToolStripMenuItem.DropDownItems.AddRange(new ToolStripItem[] { materiaMenuItem, disciplinaMenuItem });
            materiaToolStripMenuItem.Image = Properties.Resources.books;
            materiaToolStripMenuItem.ImageScaling = ToolStripItemImageScaling.None;
            materiaToolStripMenuItem.Name = "materiaToolStripMenuItem";
            materiaToolStripMenuItem.Size = new Size(123, 22);
            materiaToolStripMenuItem.Text = "Matéria";
            // 
            // materiaMenuItem
            // 
            materiaMenuItem.Image = Properties.Resources.study__1_;
            materiaMenuItem.ImageScaling = ToolStripItemImageScaling.None;
            materiaMenuItem.Name = "materiaMenuItem";
            materiaMenuItem.Size = new Size(125, 22);
            materiaMenuItem.Text = "Matéria";
            materiaMenuItem.Click += materiaMenuItem_Click;
            // 
            // disciplinaMenuItem
            // 
            disciplinaMenuItem.Image = Properties.Resources.graduation_hat__2_;
            disciplinaMenuItem.ImageScaling = ToolStripItemImageScaling.None;
            disciplinaMenuItem.Name = "disciplinaMenuItem";
            disciplinaMenuItem.Size = new Size(125, 22);
            disciplinaMenuItem.Text = "Disciplina";
            disciplinaMenuItem.Click += disciplinaMenuItem_Click;
            // 
            // questoesMenuItem
            // 
            questoesMenuItem.Image = Properties.Resources.pencil;
            questoesMenuItem.ImageScaling = ToolStripItemImageScaling.None;
            questoesMenuItem.Name = "questoesMenuItem";
            questoesMenuItem.Size = new Size(123, 22);
            questoesMenuItem.Text = "Questões";
            questoesMenuItem.Click += questoesMenuItem_Click;
            // 
            // testesMenuItem
            // 
            testesMenuItem.Image = Properties.Resources.maths;
            testesMenuItem.ImageScaling = ToolStripItemImageScaling.None;
            testesMenuItem.Name = "testesMenuItem";
            testesMenuItem.Size = new Size(123, 22);
            testesMenuItem.Text = "Testes";
            testesMenuItem.Click += testesMenuItem_Click;
            // 
            // barraFerramentas
            // 
            barraFerramentas.BackColor = Color.MintCream;
            barraFerramentas.ImageScalingSize = new Size(28, 28);
            barraFerramentas.Items.AddRange(new ToolStripItem[] { btnInserir, btnEditar, btnExcluir, toolStripSeparator1, btnDuplicar, toolStripSeparator3, btnVisualizar, toolStripSeparator4, btnSalvar, toolStripSeparator2, lblTipoCadastro });
            barraFerramentas.Location = new Point(0, 30);
            barraFerramentas.Name = "barraFerramentas";
            barraFerramentas.Padding = new Padding(0, 0, 2, 0);
            barraFerramentas.Size = new Size(597, 49);
            barraFerramentas.TabIndex = 1;
            barraFerramentas.Text = "toolStrip1";
            // 
            // btnInserir
            // 
            btnInserir.DisplayStyle = ToolStripItemDisplayStyle.Image;
            btnInserir.Enabled = false;
            btnInserir.Image = Properties.Resources._1486485588_add_create_new_math_sign_cross_plus_81186;
            btnInserir.ImageTransparentColor = Color.Magenta;
            btnInserir.Name = "btnInserir";
            btnInserir.Padding = new Padding(7);
            btnInserir.Size = new Size(46, 46);
            btnInserir.Text = "toolStripButton1";
            btnInserir.Click += btnInserir_Click;
            // 
            // btnEditar
            // 
            btnEditar.DisplayStyle = ToolStripItemDisplayStyle.Image;
            btnEditar.Enabled = false;
            btnEditar.Image = Properties.Resources._1486504369_change_edit_options_pencil_settings_tools_write_81307;
            btnEditar.ImageTransparentColor = Color.Magenta;
            btnEditar.Name = "btnEditar";
            btnEditar.Padding = new Padding(7);
            btnEditar.Size = new Size(46, 46);
            btnEditar.Text = "toolStripButton3";
            btnEditar.Click += btnEditar_Click;
            // 
            // btnExcluir
            // 
            btnExcluir.DisplayStyle = ToolStripItemDisplayStyle.Image;
            btnExcluir.Enabled = false;
            btnExcluir.Image = Properties.Resources._1486504346_cancel_close_delete_exit_remove_x_81304;
            btnExcluir.ImageTransparentColor = Color.Magenta;
            btnExcluir.Name = "btnExcluir";
            btnExcluir.Padding = new Padding(7);
            btnExcluir.Size = new Size(46, 46);
            btnExcluir.Text = "toolStripButton2";
            btnExcluir.Click += btnExcluir_Click;
            // 
            // toolStripSeparator1
            // 
            toolStripSeparator1.Name = "toolStripSeparator1";
            toolStripSeparator1.Padding = new Padding(7);
            toolStripSeparator1.Size = new Size(6, 49);
            // 
            // btnDuplicar
            // 
            btnDuplicar.DisplayStyle = ToolStripItemDisplayStyle.Image;
            btnDuplicar.Enabled = false;
            btnDuplicar.Image = (Image)resources.GetObject("btnDuplicar.Image");
            btnDuplicar.ImageTransparentColor = Color.Magenta;
            btnDuplicar.Name = "btnDuplicar";
            btnDuplicar.Padding = new Padding(7);
            btnDuplicar.Size = new Size(46, 46);
            btnDuplicar.Click += btnDuplicar_Click;
            // 
            // toolStripSeparator3
            // 
            toolStripSeparator3.Name = "toolStripSeparator3";
            toolStripSeparator3.Padding = new Padding(7);
            toolStripSeparator3.Size = new Size(6, 49);
            // 
            // btnVisualizar
            // 
            btnVisualizar.DisplayStyle = ToolStripItemDisplayStyle.Image;
            btnVisualizar.Enabled = false;
            btnVisualizar.Image = Properties.Resources._1486503764_browser_interface_ui_design_layout_website_81271;
            btnVisualizar.ImageTransparentColor = Color.Magenta;
            btnVisualizar.Name = "btnVisualizar";
            btnVisualizar.Padding = new Padding(7);
            btnVisualizar.Size = new Size(46, 46);
            btnVisualizar.Click += btnVisualizar_Click;
            // 
            // toolStripSeparator4
            // 
            toolStripSeparator4.Name = "toolStripSeparator4";
            toolStripSeparator4.Padding = new Padding(7);
            toolStripSeparator4.Size = new Size(6, 49);
            // 
            // btnSalvar
            // 
            btnSalvar.DisplayStyle = ToolStripItemDisplayStyle.Image;
            btnSalvar.Enabled = false;
            btnSalvar.Image = Properties.Resources._1486503760_backup_disk_data_data_storage_floppy_save_81268;
            btnSalvar.ImageTransparentColor = Color.Magenta;
            btnSalvar.Name = "btnSalvar";
            btnSalvar.Padding = new Padding(7);
            btnSalvar.Size = new Size(46, 46);
            btnSalvar.Click += btnSalvar_Click;
            // 
            // toolStripSeparator2
            // 
            toolStripSeparator2.Name = "toolStripSeparator2";
            toolStripSeparator2.Padding = new Padding(7);
            toolStripSeparator2.Size = new Size(6, 49);
            // 
            // lblTipoCadastro
            // 
            lblTipoCadastro.Name = "lblTipoCadastro";
            lblTipoCadastro.Size = new Size(77, 46);
            lblTipoCadastro.Text = "TipoCadastro";
            // 
            // panelRegistros
            // 
            panelRegistros.Dock = DockStyle.Fill;
            panelRegistros.Location = new Point(0, 79);
            panelRegistros.Name = "panelRegistros";
            panelRegistros.Size = new Size(597, 286);
            panelRegistros.TabIndex = 2;
            // 
            // toolStrip1
            // 
            toolStrip1.Dock = DockStyle.Bottom;
            toolStrip1.ImageScalingSize = new Size(28, 28);
            toolStrip1.Items.AddRange(new ToolStripItem[] { toolStripButton1, lblStatus });
            toolStrip1.Location = new Point(0, 330);
            toolStrip1.Name = "toolStrip1";
            toolStrip1.Padding = new Padding(0, 0, 2, 0);
            toolStrip1.Size = new Size(597, 35);
            toolStrip1.TabIndex = 3;
            toolStrip1.Text = "toolStrip1";
            // 
            // toolStripButton1
            // 
            toolStripButton1.DisplayStyle = ToolStripItemDisplayStyle.Image;
            toolStripButton1.Image = (Image)resources.GetObject("toolStripButton1.Image");
            toolStripButton1.ImageTransparentColor = Color.Magenta;
            toolStripButton1.Name = "toolStripButton1";
            toolStripButton1.Size = new Size(32, 32);
            toolStripButton1.Text = "toolStripButton1";
            // 
            // lblStatus
            // 
            lblStatus.Name = "lblStatus";
            lblStatus.Size = new Size(192, 32);
            lblStatus.Text = "Bem-vindo(a) ao Gerador De Testes";
            // 
            // TelaPrincipalForm
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(597, 365);
            Controls.Add(toolStrip1);
            Controls.Add(panelRegistros);
            Controls.Add(barraFerramentas);
            Controls.Add(menuBar);
            MainMenuStrip = menuBar;
            Margin = new Padding(2);
            Name = "TelaPrincipalForm";
            ShowIcon = false;
            Text = "Gerador de Testes";
            menuBar.ResumeLayout(false);
            menuBar.PerformLayout();
            barraFerramentas.ResumeLayout(false);
            barraFerramentas.PerformLayout();
            toolStrip1.ResumeLayout(false);
            toolStrip1.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private MenuStrip menuBar;
        private ToolStripMenuItem cadastroMenu;
        private ToolStripMenuItem materiaToolStripMenuItem;
        private ToolStripMenuItem materiaMenuItem;
        private ToolStripMenuItem disciplinaMenuItem;
        private ToolStripMenuItem questoesMenuItem;
        private ToolStripMenuItem testesMenuItem;
        private ToolStrip barraFerramentas;
        private ToolStripButton btnInserir;
        private ToolStripButton btnEditar;
        private ToolStripButton btnExcluir;
        private ToolStripSeparator toolStripSeparator1;
        private ToolStripButton btnVisualizar;
        private ToolStripLabel lblTipoCadastro;
        private ToolStripButton btnDuplicar;
        private ToolStripSeparator toolStripSeparator3;
        private ToolStripSeparator toolStripSeparator4;
        private ToolStripButton btnSalvar;
        private ToolStripSeparator toolStripSeparator2;
        private Panel panelRegistros;
        private ToolStrip toolStrip1;
        private ToolStripButton toolStripButton1;
        private ToolStripLabel lblStatus;
    }
}