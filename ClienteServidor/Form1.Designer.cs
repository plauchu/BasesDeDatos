namespace ClienteServidor {
  partial class Form1 {
    /// <summary>
    /// Required designer variable.
    /// </summary>
    private System.ComponentModel.IContainer components = null;

    /// <summary>
    /// Clean up any resources being used.
    /// </summary>
    /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
    protected override void Dispose(bool disposing) {
      if (disposing && (components != null)) {
        components.Dispose();
      }
      base.Dispose(disposing);
    }

    #region Windows Form Designer generated code

    /// <summary>
    /// Required method for Designer support - do not modify
    /// the contents of this method with the code editor.
    /// </summary>
    private void InitializeComponent() {
      System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
      this.menuStrip1 = new System.Windows.Forms.MenuStrip();
      this.archivoToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
      this.salirToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
      this.procesosToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
      this.gestorBDToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
      this.usoEFToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
      this.mnuActTablasIndep = new System.Windows.Forms.ToolStripMenuItem();
      this.mnuHistorial = new System.Windows.Forms.ToolStripMenuItem();
      this.menuStrip1.SuspendLayout();
      this.SuspendLayout();
      // 
      // menuStrip1
      // 
      this.menuStrip1.ImageScalingSize = new System.Drawing.Size(20, 20);
      this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.archivoToolStripMenuItem,
            this.procesosToolStripMenuItem});
      this.menuStrip1.Location = new System.Drawing.Point(0, 0);
      this.menuStrip1.Name = "menuStrip1";
      this.menuStrip1.Padding = new System.Windows.Forms.Padding(4, 2, 0, 2);
      this.menuStrip1.Size = new System.Drawing.Size(494, 24);
      this.menuStrip1.TabIndex = 0;
      this.menuStrip1.Text = "menuStrip1";
      // 
      // archivoToolStripMenuItem
      // 
      this.archivoToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.salirToolStripMenuItem});
      this.archivoToolStripMenuItem.Name = "archivoToolStripMenuItem";
      this.archivoToolStripMenuItem.Size = new System.Drawing.Size(60, 20);
      this.archivoToolStripMenuItem.Text = "Archivo";
      // 
      // salirToolStripMenuItem
      // 
      this.salirToolStripMenuItem.Name = "salirToolStripMenuItem";
      this.salirToolStripMenuItem.Size = new System.Drawing.Size(96, 22);
      this.salirToolStripMenuItem.Text = "Salir";
      this.salirToolStripMenuItem.Click += new System.EventHandler(this.SalirToolStripMenuItem_Click);
      // 
      // procesosToolStripMenuItem
      // 
      this.procesosToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.gestorBDToolStripMenuItem,
            this.usoEFToolStripMenuItem});
      this.procesosToolStripMenuItem.Name = "procesosToolStripMenuItem";
      this.procesosToolStripMenuItem.Size = new System.Drawing.Size(66, 20);
      this.procesosToolStripMenuItem.Text = "Procesos";
      // 
      // gestorBDToolStripMenuItem
      // 
      this.gestorBDToolStripMenuItem.Name = "gestorBDToolStripMenuItem";
      this.gestorBDToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
      this.gestorBDToolStripMenuItem.Text = "Gestor BD";
      this.gestorBDToolStripMenuItem.Click += new System.EventHandler(this.GestorBDToolStripMenuItem_Click);
      // 
      // usoEFToolStripMenuItem
      // 
      this.usoEFToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.mnuActTablasIndep,
            this.mnuHistorial});
      this.usoEFToolStripMenuItem.Name = "usoEFToolStripMenuItem";
      this.usoEFToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
      this.usoEFToolStripMenuItem.Text = "Uso EF";
      this.usoEFToolStripMenuItem.Click += new System.EventHandler(this.usoEFToolStripMenuItem_Click);
      // 
      // mnuActTablasIndep
      // 
      this.mnuActTablasIndep.Name = "mnuActTablasIndep";
      this.mnuActTablasIndep.Size = new System.Drawing.Size(240, 22);
      this.mnuActTablasIndep.Text = "Actualiza tablas independientes";
      this.mnuActTablasIndep.Click += new System.EventHandler(this.mnuActTablasIndep_Click);
      // 
      // mnuHistorial
      // 
      this.mnuHistorial.Name = "mnuHistorial";
      this.mnuHistorial.Size = new System.Drawing.Size(240, 22);
      this.mnuHistorial.Text = "Actualiza historial";
      this.mnuHistorial.Click += new System.EventHandler(this.mnuHistorial_Click);
      // 
      // Form1
      // 
      this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
      this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
      this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
      this.ClientSize = new System.Drawing.Size(494, 214);
      this.Controls.Add(this.menuStrip1);
      this.MainMenuStrip = this.menuStrip1;
      this.Margin = new System.Windows.Forms.Padding(2);
      this.Name = "Form1";
      this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
      this.Text = "Menú principal";
      this.menuStrip1.ResumeLayout(false);
      this.menuStrip1.PerformLayout();
      this.ResumeLayout(false);
      this.PerformLayout();

    }

    #endregion

    private System.Windows.Forms.MenuStrip menuStrip1;
    private System.Windows.Forms.ToolStripMenuItem archivoToolStripMenuItem;
    private System.Windows.Forms.ToolStripMenuItem salirToolStripMenuItem;
    private System.Windows.Forms.ToolStripMenuItem procesosToolStripMenuItem;
    private System.Windows.Forms.ToolStripMenuItem gestorBDToolStripMenuItem;
    private System.Windows.Forms.ToolStripMenuItem usoEFToolStripMenuItem;
    private System.Windows.Forms.ToolStripMenuItem mnuActTablasIndep;
    private System.Windows.Forms.ToolStripMenuItem mnuHistorial;
  }
}

