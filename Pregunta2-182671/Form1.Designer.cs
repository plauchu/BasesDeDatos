namespace Pregunta2_182671 {
  partial class Form1 {
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
      this.cboClientes = new System.Windows.Forms.ComboBox();
      this.dtg1 = new System.Windows.Forms.DataGridView();
      this.dtg2 = new System.Windows.Forms.DataGridView();
      this.dtg3 = new System.Windows.Forms.DataGridView();
      this.label1 = new System.Windows.Forms.Label();
      this.btnmostrar = new System.Windows.Forms.Button();
      this.btnPed = new System.Windows.Forms.Button();
      ((System.ComponentModel.ISupportInitialize)(this.dtg1)).BeginInit();
      ((System.ComponentModel.ISupportInitialize)(this.dtg2)).BeginInit();
      ((System.ComponentModel.ISupportInitialize)(this.dtg3)).BeginInit();
      this.SuspendLayout();
      // 
      // cboClientes
      // 
      this.cboClientes.FormattingEnabled = true;
      this.cboClientes.Location = new System.Drawing.Point(331, 29);
      this.cboClientes.Name = "cboClientes";
      this.cboClientes.Size = new System.Drawing.Size(121, 21);
      this.cboClientes.TabIndex = 0;
      this.cboClientes.SelectedIndexChanged += new System.EventHandler(this.cboClientes_SelectedIndexChanged);
      // 
      // dtg1
      // 
      this.dtg1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
      this.dtg1.Location = new System.Drawing.Point(12, 129);
      this.dtg1.Name = "dtg1";
      this.dtg1.Size = new System.Drawing.Size(240, 150);
      this.dtg1.TabIndex = 1;
      // 
      // dtg2
      // 
      this.dtg2.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
      this.dtg2.Location = new System.Drawing.Point(269, 129);
      this.dtg2.Name = "dtg2";
      this.dtg2.Size = new System.Drawing.Size(240, 150);
      this.dtg2.TabIndex = 2;
      // 
      // dtg3
      // 
      this.dtg3.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
      this.dtg3.Location = new System.Drawing.Point(530, 129);
      this.dtg3.Name = "dtg3";
      this.dtg3.Size = new System.Drawing.Size(240, 150);
      this.dtg3.TabIndex = 3;
      // 
      // label1
      // 
      this.label1.AutoSize = true;
      this.label1.Location = new System.Drawing.Point(238, 32);
      this.label1.Name = "label1";
      this.label1.Size = new System.Drawing.Size(27, 13);
      this.label1.TabIndex = 4;
      this.label1.Text = "Rfc:";
      // 
      // btnmostrar
      // 
      this.btnmostrar.Location = new System.Drawing.Point(553, 32);
      this.btnmostrar.Name = "btnmostrar";
      this.btnmostrar.Size = new System.Drawing.Size(121, 23);
      this.btnmostrar.TabIndex = 5;
      this.btnmostrar.Text = "Mostrar datos";
      this.btnmostrar.UseVisualStyleBackColor = true;
      this.btnmostrar.Click += new System.EventHandler(this.btnmostrar_Click);
      // 
      // btnPed
      // 
      this.btnPed.Location = new System.Drawing.Point(553, 77);
      this.btnPed.Name = "btnPed";
      this.btnPed.Size = new System.Drawing.Size(121, 23);
      this.btnPed.TabIndex = 6;
      this.btnPed.Text = "Datos Pedido";
      this.btnPed.UseVisualStyleBackColor = true;
      this.btnPed.Click += new System.EventHandler(this.btnPed_Click);
      // 
      // Form1
      // 
      this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
      this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
      this.ClientSize = new System.Drawing.Size(800, 450);
      this.Controls.Add(this.btnPed);
      this.Controls.Add(this.btnmostrar);
      this.Controls.Add(this.label1);
      this.Controls.Add(this.dtg3);
      this.Controls.Add(this.dtg2);
      this.Controls.Add(this.dtg1);
      this.Controls.Add(this.cboClientes);
      this.Name = "Form1";
      this.Text = "Form1";
      this.Load += new System.EventHandler(this.Form1_Load);
      ((System.ComponentModel.ISupportInitialize)(this.dtg1)).EndInit();
      ((System.ComponentModel.ISupportInitialize)(this.dtg2)).EndInit();
      ((System.ComponentModel.ISupportInitialize)(this.dtg3)).EndInit();
      this.ResumeLayout(false);
      this.PerformLayout();

    }

    #endregion

    private System.Windows.Forms.ComboBox cboClientes;
    private System.Windows.Forms.DataGridView dtg1;
    private System.Windows.Forms.DataGridView dtg2;
    private System.Windows.Forms.DataGridView dtg3;
    private System.Windows.Forms.Label label1;
    private System.Windows.Forms.Button btnmostrar;
    private System.Windows.Forms.Button btnPed;
  }
}

