namespace Pregunta1_182671 {
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
      this.label1 = new System.Windows.Forms.Label();
      this.btIngresa = new System.Windows.Forms.Button();
      this.txContra = new System.Windows.Forms.TextBox();
      this.txUser = new System.Windows.Forms.TextBox();
      this.label2 = new System.Windows.Forms.Label();
      this.label3 = new System.Windows.Forms.Label();
      this.SuspendLayout();
      // 
      // label1
      // 
      this.label1.AutoSize = true;
      this.label1.Location = new System.Drawing.Point(200, 124);
      this.label1.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
      this.label1.Name = "label1";
      this.label1.Size = new System.Drawing.Size(0, 13);
      this.label1.TabIndex = 1;
      // 
      // btIngresa
      // 
      this.btIngresa.Location = new System.Drawing.Point(303, 272);
      this.btIngresa.Margin = new System.Windows.Forms.Padding(2);
      this.btIngresa.Name = "btIngresa";
      this.btIngresa.Size = new System.Drawing.Size(212, 19);
      this.btIngresa.TabIndex = 9;
      this.btIngresa.Text = "Ingresar";
      this.btIngresa.UseVisualStyleBackColor = true;
      this.btIngresa.Click += new System.EventHandler(this.btIngresa_Click);
      // 
      // txContra
      // 
      this.txContra.Location = new System.Drawing.Point(378, 211);
      this.txContra.Margin = new System.Windows.Forms.Padding(2);
      this.txContra.Name = "txContra";
      this.txContra.PasswordChar = '*';
      this.txContra.Size = new System.Drawing.Size(154, 20);
      this.txContra.TabIndex = 8;
      // 
      // txUser
      // 
      this.txUser.Location = new System.Drawing.Point(378, 159);
      this.txUser.Margin = new System.Windows.Forms.Padding(2);
      this.txUser.Name = "txUser";
      this.txUser.Size = new System.Drawing.Size(154, 20);
      this.txUser.TabIndex = 7;
      // 
      // label2
      // 
      this.label2.AutoSize = true;
      this.label2.Location = new System.Drawing.Point(269, 211);
      this.label2.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
      this.label2.Name = "label2";
      this.label2.Size = new System.Drawing.Size(64, 13);
      this.label2.TabIndex = 6;
      this.label2.Text = "Contraseña:";
      // 
      // label3
      // 
      this.label3.AutoSize = true;
      this.label3.Location = new System.Drawing.Point(269, 159);
      this.label3.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
      this.label3.Name = "label3";
      this.label3.Size = new System.Drawing.Size(46, 13);
      this.label3.TabIndex = 5;
      this.label3.Text = "Usuario:";
      // 
      // Form1
      // 
      this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
      this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
      this.ClientSize = new System.Drawing.Size(800, 450);
      this.Controls.Add(this.btIngresa);
      this.Controls.Add(this.txContra);
      this.Controls.Add(this.txUser);
      this.Controls.Add(this.label2);
      this.Controls.Add(this.label3);
      this.Controls.Add(this.label1);
      this.Name = "Form1";
      this.Text = "Form1";
      this.Load += new System.EventHandler(this.Form1_Load);
      this.ResumeLayout(false);
      this.PerformLayout();

    }

    #endregion

    private System.Windows.Forms.Label label1;
    private System.Windows.Forms.Button btIngresa;
    private System.Windows.Forms.TextBox txContra;
    private System.Windows.Forms.TextBox txUser;
    private System.Windows.Forms.Label label2;
    private System.Windows.Forms.Label label3;
  }
}

