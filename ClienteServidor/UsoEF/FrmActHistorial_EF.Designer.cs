namespace ClienteServidor.UsoEF {
  partial class FrmActHistorial_EF {
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
      this.btnRegistrarCambio = new System.Windows.Forms.Button();
      this.btnCambia = new System.Windows.Forms.Button();
      this.btnBajaCalif = new System.Windows.Forms.Button();
      this.btnRegistrarAlta = new System.Windows.Forms.Button();
      this.dtpFecha = new System.Windows.Forms.DateTimePicker();
      this.cboCalif = new System.Windows.Forms.ComboBox();
      this.cboMater = new System.Windows.Forms.ComboBox();
      this.btnAltaCalif = new System.Windows.Forms.Button();
      this.cboAlumnos = new System.Windows.Forms.ComboBox();
      this.dtgGeneral = new System.Windows.Forms.DataGridView();
      ((System.ComponentModel.ISupportInitialize)(this.dtgGeneral)).BeginInit();
      this.SuspendLayout();
      // 
      // btnRegistrarCambio
      // 
      this.btnRegistrarCambio.Location = new System.Drawing.Point(535, 379);
      this.btnRegistrarCambio.Margin = new System.Windows.Forms.Padding(2);
      this.btnRegistrarCambio.Name = "btnRegistrarCambio";
      this.btnRegistrarCambio.Size = new System.Drawing.Size(101, 22);
      this.btnRegistrarCambio.TabIndex = 19;
      this.btnRegistrarCambio.Text = "Registrar Cambio";
      this.btnRegistrarCambio.UseVisualStyleBackColor = true;
      this.btnRegistrarCambio.Visible = false;
      // 
      // btnCambia
      // 
      this.btnCambia.Location = new System.Drawing.Point(529, 258);
      this.btnCambia.Margin = new System.Windows.Forms.Padding(2);
      this.btnCambia.Name = "btnCambia";
      this.btnCambia.Size = new System.Drawing.Size(106, 25);
      this.btnCambia.TabIndex = 18;
      this.btnCambia.Text = "Cambio";
      this.btnCambia.UseVisualStyleBackColor = true;
      // 
      // btnBajaCalif
      // 
      this.btnBajaCalif.Location = new System.Drawing.Point(351, 258);
      this.btnBajaCalif.Margin = new System.Windows.Forms.Padding(2);
      this.btnBajaCalif.Name = "btnBajaCalif";
      this.btnBajaCalif.Size = new System.Drawing.Size(105, 25);
      this.btnBajaCalif.TabIndex = 17;
      this.btnBajaCalif.Text = "Baja calificación";
      this.btnBajaCalif.UseVisualStyleBackColor = true;
      // 
      // btnRegistrarAlta
      // 
      this.btnRegistrarAlta.Location = new System.Drawing.Point(354, 379);
      this.btnRegistrarAlta.Margin = new System.Windows.Forms.Padding(2);
      this.btnRegistrarAlta.Name = "btnRegistrarAlta";
      this.btnRegistrarAlta.Size = new System.Drawing.Size(101, 22);
      this.btnRegistrarAlta.TabIndex = 16;
      this.btnRegistrarAlta.Text = "Registrar Alta";
      this.btnRegistrarAlta.UseVisualStyleBackColor = true;
      this.btnRegistrarAlta.Visible = false;
      this.btnRegistrarAlta.Click += new System.EventHandler(this.btnRegistrarAlta_Click);
      // 
      // dtpFecha
      // 
      this.dtpFecha.Location = new System.Drawing.Point(529, 330);
      this.dtpFecha.Margin = new System.Windows.Forms.Padding(2);
      this.dtpFecha.Name = "dtpFecha";
      this.dtpFecha.Size = new System.Drawing.Size(107, 20);
      this.dtpFecha.TabIndex = 15;
      this.dtpFecha.Visible = false;
      // 
      // cboCalif
      // 
      this.cboCalif.FormattingEnabled = true;
      this.cboCalif.Items.AddRange(new object[] {
            "5",
            "6",
            "7",
            "8",
            "9",
            "10"});
      this.cboCalif.Location = new System.Drawing.Point(351, 328);
      this.cboCalif.Margin = new System.Windows.Forms.Padding(2);
      this.cboCalif.Name = "cboCalif";
      this.cboCalif.Size = new System.Drawing.Size(106, 21);
      this.cboCalif.TabIndex = 14;
      this.cboCalif.Text = "Calificación:";
      this.cboCalif.Visible = false;
      // 
      // cboMater
      // 
      this.cboMater.FormattingEnabled = true;
      this.cboMater.Location = new System.Drawing.Point(129, 328);
      this.cboMater.Margin = new System.Windows.Forms.Padding(2);
      this.cboMater.Name = "cboMater";
      this.cboMater.Size = new System.Drawing.Size(132, 21);
      this.cboMater.TabIndex = 13;
      this.cboMater.Text = "Materias:";
      this.cboMater.Visible = false;
      // 
      // btnAltaCalif
      // 
      this.btnAltaCalif.Location = new System.Drawing.Point(130, 259);
      this.btnAltaCalif.Margin = new System.Windows.Forms.Padding(2);
      this.btnAltaCalif.Name = "btnAltaCalif";
      this.btnAltaCalif.Size = new System.Drawing.Size(130, 24);
      this.btnAltaCalif.TabIndex = 12;
      this.btnAltaCalif.Text = "Alta calificación";
      this.btnAltaCalif.UseVisualStyleBackColor = true;
      this.btnAltaCalif.Click += new System.EventHandler(this.btnAltaCalif_Click);
      // 
      // cboAlumnos
      // 
      this.cboAlumnos.FormattingEnabled = true;
      this.cboAlumnos.Location = new System.Drawing.Point(130, 206);
      this.cboAlumnos.Margin = new System.Windows.Forms.Padding(2);
      this.cboAlumnos.Name = "cboAlumnos";
      this.cboAlumnos.Size = new System.Drawing.Size(132, 21);
      this.cboAlumnos.TabIndex = 11;
      this.cboAlumnos.Text = "Alumnos:";
      this.cboAlumnos.SelectedIndexChanged += new System.EventHandler(this.cboAlumnos_SelectedIndexChanged);
      // 
      // dtgGeneral
      // 
      this.dtgGeneral.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
      this.dtgGeneral.Location = new System.Drawing.Point(120, 50);
      this.dtgGeneral.Margin = new System.Windows.Forms.Padding(2);
      this.dtgGeneral.Name = "dtgGeneral";
      this.dtgGeneral.RowHeadersWidth = 51;
      this.dtgGeneral.RowTemplate.Height = 24;
      this.dtgGeneral.Size = new System.Drawing.Size(560, 121);
      this.dtgGeneral.TabIndex = 10;
      // 
      // FrmActHistorial_EF
      // 
      this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
      this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
      this.ClientSize = new System.Drawing.Size(800, 450);
      this.Controls.Add(this.btnRegistrarCambio);
      this.Controls.Add(this.btnCambia);
      this.Controls.Add(this.btnBajaCalif);
      this.Controls.Add(this.btnRegistrarAlta);
      this.Controls.Add(this.dtpFecha);
      this.Controls.Add(this.cboCalif);
      this.Controls.Add(this.cboMater);
      this.Controls.Add(this.btnAltaCalif);
      this.Controls.Add(this.cboAlumnos);
      this.Controls.Add(this.dtgGeneral);
      this.Name = "FrmActHistorial_EF";
      this.Text = "Da de alta una nueva calificación en historial.";
      this.Load += new System.EventHandler(this.FrmActHistorial_EF_Load);
      ((System.ComponentModel.ISupportInitialize)(this.dtgGeneral)).EndInit();
      this.ResumeLayout(false);

    }

    #endregion

    private System.Windows.Forms.Button btnRegistrarCambio;
    private System.Windows.Forms.Button btnCambia;
    private System.Windows.Forms.Button btnBajaCalif;
    private System.Windows.Forms.Button btnRegistrarAlta;
    private System.Windows.Forms.DateTimePicker dtpFecha;
    private System.Windows.Forms.ComboBox cboCalif;
    private System.Windows.Forms.ComboBox cboMater;
    private System.Windows.Forms.Button btnAltaCalif;
    private System.Windows.Forms.ComboBox cboAlumnos;
    private System.Windows.Forms.DataGridView dtgGeneral;
  }
}