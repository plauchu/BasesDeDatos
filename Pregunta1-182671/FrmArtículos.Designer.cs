namespace Pregunta1_182671 {
  partial class FrmArtículos {
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
      this.btnArts = new System.Windows.Forms.Button();
      this.dtgGeneral = new System.Windows.Forms.DataGridView();
      this.dtpFecha = new System.Windows.Forms.DateTimePicker();
      this.btnAbas = new System.Windows.Forms.Button();
      ((System.ComponentModel.ISupportInitialize)(this.dtgGeneral)).BeginInit();
      this.SuspendLayout();
      // 
      // btnArts
      // 
      this.btnArts.Location = new System.Drawing.Point(127, 327);
      this.btnArts.Name = "btnArts";
      this.btnArts.Size = new System.Drawing.Size(75, 23);
      this.btnArts.TabIndex = 0;
      this.btnArts.Text = "Actualizar";
      this.btnArts.UseVisualStyleBackColor = true;
      this.btnArts.Click += new System.EventHandler(this.btnArts_Click);
      // 
      // dtgGeneral
      // 
      this.dtgGeneral.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
      this.dtgGeneral.Location = new System.Drawing.Point(108, 46);
      this.dtgGeneral.Name = "dtgGeneral";
      this.dtgGeneral.Size = new System.Drawing.Size(240, 150);
      this.dtgGeneral.TabIndex = 1;
      // 
      // dtpFecha
      // 
      this.dtpFecha.Location = new System.Drawing.Point(285, 239);
      this.dtpFecha.Margin = new System.Windows.Forms.Padding(2);
      this.dtpFecha.Name = "dtpFecha";
      this.dtpFecha.Size = new System.Drawing.Size(107, 20);
      this.dtpFecha.TabIndex = 16;
      this.dtpFecha.Visible = false;
      // 
      // btnAbas
      // 
      this.btnAbas.Location = new System.Drawing.Point(273, 327);
      this.btnAbas.Name = "btnAbas";
      this.btnAbas.Size = new System.Drawing.Size(119, 23);
      this.btnAbas.TabIndex = 17;
      this.btnAbas.Text = "Ver Tabla Absto";
      this.btnAbas.UseVisualStyleBackColor = true;
      this.btnAbas.Click += new System.EventHandler(this.btnAbas_Click);
      // 
      // FrmArtículos
      // 
      this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
      this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
      this.ClientSize = new System.Drawing.Size(800, 450);
      this.Controls.Add(this.btnAbas);
      this.Controls.Add(this.dtpFecha);
      this.Controls.Add(this.dtgGeneral);
      this.Controls.Add(this.btnArts);
      this.Name = "FrmArtículos";
      this.Text = "FrmArtículos";
      this.Load += new System.EventHandler(this.FrmArtículos_Load);
      ((System.ComponentModel.ISupportInitialize)(this.dtgGeneral)).EndInit();
      this.ResumeLayout(false);

    }

    #endregion

    private System.Windows.Forms.Button btnArts;
    private System.Windows.Forms.DataGridView dtgGeneral;
    private System.Windows.Forms.DateTimePicker dtpFecha;
    private System.Windows.Forms.Button btnAbas;
  }
}