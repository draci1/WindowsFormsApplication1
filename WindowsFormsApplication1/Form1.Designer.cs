namespace WindowsFormsApplication1
{
    partial class form1
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
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.UserMenu = new System.Windows.Forms.ToolStripMenuItem();
            this.logInToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.exitToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.UshtrimetMenu = new System.Windows.Forms.ToolStripMenuItem();
            this.rectCalculatorToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.kalkulatorToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.listaEStudentaveToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.notaToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.notaMesatareToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.lbl1 = new System.Windows.Forms.Label();
            this.txtb1 = new System.Windows.Forms.TextBox();
            this.tabelaEShumToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.menuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // menuStrip1
            // 
            this.menuStrip1.BackColor = System.Drawing.SystemColors.InactiveCaption;
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.UserMenu,
            this.UshtrimetMenu});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(1902, 24);
            this.menuStrip1.TabIndex = 0;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // UserMenu
            // 
            this.UserMenu.BackColor = System.Drawing.Color.Transparent;
            this.UserMenu.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.logInToolStripMenuItem,
            this.exitToolStripMenuItem});
            this.UserMenu.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold);
            this.UserMenu.Name = "UserMenu";
            this.UserMenu.Size = new System.Drawing.Size(45, 20);
            this.UserMenu.Text = "User";
            this.UserMenu.Click += new System.EventHandler(this.userToolStripMenuItem_Click);
            // 
            // logInToolStripMenuItem
            // 
            this.logInToolStripMenuItem.Name = "logInToolStripMenuItem";
            this.logInToolStripMenuItem.Size = new System.Drawing.Size(108, 22);
            this.logInToolStripMenuItem.Text = "Log In";
            this.logInToolStripMenuItem.Click += new System.EventHandler(this.logInToolStripMenuItem_Click);
            // 
            // exitToolStripMenuItem
            // 
            this.exitToolStripMenuItem.Name = "exitToolStripMenuItem";
            this.exitToolStripMenuItem.Size = new System.Drawing.Size(108, 22);
            this.exitToolStripMenuItem.Text = "Exit";
            this.exitToolStripMenuItem.Click += new System.EventHandler(this.exitToolStripMenuItem_Click);
            // 
            // UshtrimetMenu
            // 
            this.UshtrimetMenu.BackColor = System.Drawing.Color.Transparent;
            this.UshtrimetMenu.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.rectCalculatorToolStripMenuItem,
            this.kalkulatorToolStripMenuItem,
            this.listaEStudentaveToolStripMenuItem,
            this.notaToolStripMenuItem,
            this.notaMesatareToolStripMenuItem,
            this.tabelaEShumToolStripMenuItem});
            this.UshtrimetMenu.Enabled = false;
            this.UshtrimetMenu.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold);
            this.UshtrimetMenu.ForeColor = System.Drawing.SystemColors.WindowText;
            this.UshtrimetMenu.Name = "UshtrimetMenu";
            this.UshtrimetMenu.Size = new System.Drawing.Size(76, 20);
            this.UshtrimetMenu.Text = "Ushtrimet";
            this.UshtrimetMenu.Click += new System.EventHandler(this.UshtrimetMenu_Click);
            // 
            // rectCalculatorToolStripMenuItem
            // 
            this.rectCalculatorToolStripMenuItem.Name = "rectCalculatorToolStripMenuItem";
            this.rectCalculatorToolStripMenuItem.Size = new System.Drawing.Size(175, 22);
            this.rectCalculatorToolStripMenuItem.Text = "Kalk.Drejtkënd.";
            this.rectCalculatorToolStripMenuItem.Click += new System.EventHandler(this.rectCalculatorToolStripMenuItem_Click);
            // 
            // kalkulatorToolStripMenuItem
            // 
            this.kalkulatorToolStripMenuItem.Name = "kalkulatorToolStripMenuItem";
            this.kalkulatorToolStripMenuItem.Size = new System.Drawing.Size(175, 22);
            this.kalkulatorToolStripMenuItem.Text = "Kalkulator";
            this.kalkulatorToolStripMenuItem.Click += new System.EventHandler(this.kalkulatorToolStripMenuItem_Click);
            // 
            // listaEStudentaveToolStripMenuItem
            // 
            this.listaEStudentaveToolStripMenuItem.Name = "listaEStudentaveToolStripMenuItem";
            this.listaEStudentaveToolStripMenuItem.Size = new System.Drawing.Size(175, 22);
            this.listaEStudentaveToolStripMenuItem.Text = "Lista e studentave";
            this.listaEStudentaveToolStripMenuItem.Click += new System.EventHandler(this.listaEStudentaveToolStripMenuItem_Click);
            // 
            // notaToolStripMenuItem
            // 
            this.notaToolStripMenuItem.Name = "notaToolStripMenuItem";
            this.notaToolStripMenuItem.Size = new System.Drawing.Size(175, 22);
            this.notaToolStripMenuItem.Text = "Nota e lëndës";
            this.notaToolStripMenuItem.Click += new System.EventHandler(this.notaToolStripMenuItem_Click);
            // 
            // notaMesatareToolStripMenuItem
            // 
            this.notaMesatareToolStripMenuItem.Name = "notaMesatareToolStripMenuItem";
            this.notaMesatareToolStripMenuItem.Size = new System.Drawing.Size(175, 22);
            this.notaMesatareToolStripMenuItem.Text = "Nota mesatare";
            this.notaMesatareToolStripMenuItem.Click += new System.EventHandler(this.notaMesatareToolStripMenuItem_Click);
            // 
            // lbl1
            // 
            this.lbl1.AutoSize = true;
            this.lbl1.Location = new System.Drawing.Point(1679, 6);
            this.lbl1.Name = "lbl1";
            this.lbl1.Size = new System.Drawing.Size(71, 13);
            this.lbl1.TabIndex = 1;
            this.lbl1.Text = "Data dhe Ora";
            // 
            // txtb1
            // 
            this.txtb1.Location = new System.Drawing.Point(1756, 4);
            this.txtb1.Name = "txtb1";
            this.txtb1.Size = new System.Drawing.Size(134, 20);
            this.txtb1.TabIndex = 2;
            this.txtb1.TextChanged += new System.EventHandler(this.txtb1_TextChanged);
            // 
            // tabelaEShumToolStripMenuItem
            // 
            this.tabelaEShumToolStripMenuItem.Name = "tabelaEShumToolStripMenuItem";
            this.tabelaEShumToolStripMenuItem.Size = new System.Drawing.Size(175, 22);
            this.tabelaEShumToolStripMenuItem.Text = "Tabela e shum.";
            this.tabelaEShumToolStripMenuItem.Click += new System.EventHandler(this.tabelaEShumToolStripMenuItem_Click);
            // 
            // form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.BackColor = System.Drawing.SystemColors.GradientInactiveCaption;
            this.ClientSize = new System.Drawing.Size(1902, 263);
            this.Controls.Add(this.txtb1);
            this.Controls.Add(this.lbl1);
            this.Controls.Add(this.menuStrip1);
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "form1";
            this.Text = "Shkenca Kompjuterike";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.Load += new System.EventHandler(this.Form1_Load);
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem logInToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem exitToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem rectCalculatorToolStripMenuItem;
        public System.Windows.Forms.ToolStripMenuItem UshtrimetMenu;
        private System.Windows.Forms.ToolStripMenuItem kalkulatorToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem listaEStudentaveToolStripMenuItem;
        private System.Windows.Forms.Label lbl1;
        private System.Windows.Forms.TextBox txtb1;
        private System.Windows.Forms.ToolStripMenuItem notaToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem notaMesatareToolStripMenuItem;
        public System.Windows.Forms.ToolStripMenuItem UserMenu;
        private System.Windows.Forms.ToolStripMenuItem tabelaEShumToolStripMenuItem;
    }
}

