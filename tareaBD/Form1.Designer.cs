namespace tareaBD {
  partial class frmQuery {
    /// <summary>
    /// Variable del diseñador necesaria.
    /// </summary>
    private System.ComponentModel.IContainer components = null;

    /// <summary>
    /// Limpiar los recursos que se estén usando.
    /// </summary>
    /// <param name="disposing">true si los recursos administrados se deben desechar; false en caso contrario.</param>
    protected override void Dispose(bool disposing) {
      if (disposing && (components != null)) {
        components.Dispose();
      }
      base.Dispose(disposing);
    }

    #region Código generado por el Diseñador de Windows Forms

    /// <summary>
    /// Método necesario para admitir el Diseñador. No se puede modificar
    /// el contenido de este método con el editor de código.
    /// </summary>
    private void InitializeComponent() {
      this.components = new System.ComponentModel.Container();
      this.menuStrip1 = new System.Windows.Forms.MenuStrip();
      this.menúToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
      this.query1 = new System.Windows.Forms.ToolStripMenuItem();
      this.query2 = new System.Windows.Forms.ToolStripMenuItem();
      this.query3 = new System.Windows.Forms.ToolStripMenuItem();
      this.query4 = new System.Windows.Forms.ToolStripMenuItem();
      this.contextMenuStrip1 = new System.Windows.Forms.ContextMenuStrip(this.components);
      this.grdResultados = new System.Windows.Forms.DataGridView();
      this.label1 = new System.Windows.Forms.Label();
      this.menuStrip1.SuspendLayout();
      ((System.ComponentModel.ISupportInitialize)(this.grdResultados)).BeginInit();
      this.SuspendLayout();
      // 
      // menuStrip1
      // 
      this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.menúToolStripMenuItem});
      this.menuStrip1.Location = new System.Drawing.Point(0, 0);
      this.menuStrip1.Name = "menuStrip1";
      this.menuStrip1.Size = new System.Drawing.Size(800, 24);
      this.menuStrip1.TabIndex = 0;
      this.menuStrip1.Text = "menuStrip1";
      // 
      // menúToolStripMenuItem
      // 
      this.menúToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.query1,
            this.query2,
            this.query3,
            this.query4});
      this.menúToolStripMenuItem.Name = "menúToolStripMenuItem";
      this.menúToolStripMenuItem.Size = new System.Drawing.Size(50, 20);
      this.menúToolStripMenuItem.Text = "Menú";
      // 
      // query1
      // 
      this.query1.Name = "query1";
      this.query1.Size = new System.Drawing.Size(180, 22);
      this.query1.Text = "Query1";
      this.query1.Click += new System.EventHandler(this.query1_Click);
      // 
      // query2
      // 
      this.query2.Name = "query2";
      this.query2.Size = new System.Drawing.Size(180, 22);
      this.query2.Text = "Query2";
      this.query2.Click += new System.EventHandler(this.query2_Click);
      // 
      // query3
      // 
      this.query3.Name = "query3";
      this.query3.Size = new System.Drawing.Size(180, 22);
      this.query3.Text = "Query3";
      this.query3.Click += new System.EventHandler(this.query3_Click);
      // 
      // query4
      // 
      this.query4.Name = "query4";
      this.query4.Size = new System.Drawing.Size(180, 22);
      this.query4.Text = "Query4";
      this.query4.Click += new System.EventHandler(this.query4_Click);
      // 
      // contextMenuStrip1
      // 
      this.contextMenuStrip1.Name = "contextMenuStrip1";
      this.contextMenuStrip1.Size = new System.Drawing.Size(61, 4);
      // 
      // grdResultados
      // 
      this.grdResultados.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
      this.grdResultados.Location = new System.Drawing.Point(147, 77);
      this.grdResultados.Name = "grdResultados";
      this.grdResultados.Size = new System.Drawing.Size(441, 150);
      this.grdResultados.TabIndex = 2;
      // 
      // label1
      // 
      this.label1.AutoSize = true;
      this.label1.Location = new System.Drawing.Point(144, 46);
      this.label1.Name = "label1";
      this.label1.Size = new System.Drawing.Size(60, 13);
      this.label1.TabIndex = 3;
      this.label1.Text = "Resultados";
      // 
      // frmQuery
      // 
      this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
      this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
      this.ClientSize = new System.Drawing.Size(800, 450);
      this.Controls.Add(this.label1);
      this.Controls.Add(this.grdResultados);
      this.Controls.Add(this.menuStrip1);
      this.MainMenuStrip = this.menuStrip1;
      this.Name = "frmQuery";
      this.Text = "Query";
      this.Load += new System.EventHandler(this.Form1_Load);
      this.menuStrip1.ResumeLayout(false);
      this.menuStrip1.PerformLayout();
      ((System.ComponentModel.ISupportInitialize)(this.grdResultados)).EndInit();
      this.ResumeLayout(false);
      this.PerformLayout();

    }

    #endregion

    private System.Windows.Forms.MenuStrip menuStrip1;
    private System.Windows.Forms.ToolStripMenuItem menúToolStripMenuItem;
    private System.Windows.Forms.ToolStripMenuItem query1;
    private System.Windows.Forms.ToolStripMenuItem query2;
    private System.Windows.Forms.ToolStripMenuItem query3;
    private System.Windows.Forms.ToolStripMenuItem query4;
    private System.Windows.Forms.ContextMenuStrip contextMenuStrip1;
    private System.Windows.Forms.DataGridView grdResultados;
    private System.Windows.Forms.Label label1;
  }
}

