namespace Tarea6 {
  partial class FrmActPagoPréstamo {
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
      this.components = new System.ComponentModel.Container();
      System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FrmActPagoPréstamo));
      this.cboClientes = new System.Windows.Forms.ComboBox();
      this.label1 = new System.Windows.Forms.Label();
      this.dtgGeneral = new System.Windows.Forms.DataGridView();
      this.bndGeneral = new System.Windows.Forms.BindingNavigator(this.components);
      this.bindingNavigatorAddNewItem = new System.Windows.Forms.ToolStripButton();
      this.bindingNavigatorCountItem = new System.Windows.Forms.ToolStripLabel();
      this.bindingNavigatorDeleteItem = new System.Windows.Forms.ToolStripButton();
      this.bindingNavigatorMoveFirstItem = new System.Windows.Forms.ToolStripButton();
      this.bindingNavigatorMovePreviousItem = new System.Windows.Forms.ToolStripButton();
      this.bindingNavigatorSeparator = new System.Windows.Forms.ToolStripSeparator();
      this.bindingNavigatorPositionItem = new System.Windows.Forms.ToolStripTextBox();
      this.bindingNavigatorSeparator1 = new System.Windows.Forms.ToolStripSeparator();
      this.bindingNavigatorMoveNextItem = new System.Windows.Forms.ToolStripButton();
      this.bindingNavigatorMoveLastItem = new System.Windows.Forms.ToolStripButton();
      this.bindingNavigatorSeparator2 = new System.Windows.Forms.ToolStripSeparator();
      this.label2 = new System.Windows.Forms.Label();
      this.cboPréstamos = new System.Windows.Forms.ComboBox();
      this.btnActualiza = new System.Windows.Forms.Button();
      this.btnRegresa = new System.Windows.Forms.Button();
      this.btnSalir = new System.Windows.Forms.Button();
      this.btnPagos = new System.Windows.Forms.Button();
      ((System.ComponentModel.ISupportInitialize)(this.dtgGeneral)).BeginInit();
      ((System.ComponentModel.ISupportInitialize)(this.bndGeneral)).BeginInit();
      this.bndGeneral.SuspendLayout();
      this.SuspendLayout();
      // 
      // cboClientes
      // 
      this.cboClientes.FormattingEnabled = true;
      this.cboClientes.Location = new System.Drawing.Point(442, 87);
      this.cboClientes.Name = "cboClientes";
      this.cboClientes.Size = new System.Drawing.Size(121, 21);
      this.cboClientes.TabIndex = 0;
      this.cboClientes.SelectedIndexChanged += new System.EventHandler(this.cboClientes_SelectedIndexChanged);
      // 
      // label1
      // 
      this.label1.AutoSize = true;
      this.label1.Location = new System.Drawing.Point(129, 95);
      this.label1.Name = "label1";
      this.label1.Size = new System.Drawing.Size(84, 13);
      this.label1.TabIndex = 1;
      this.label1.Text = "Nombre cliente: ";
      // 
      // dtgGeneral
      // 
      this.dtgGeneral.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
      this.dtgGeneral.Location = new System.Drawing.Point(172, 191);
      this.dtgGeneral.Name = "dtgGeneral";
      this.dtgGeneral.Size = new System.Drawing.Size(363, 150);
      this.dtgGeneral.TabIndex = 2;
      // 
      // bndGeneral
      // 
      this.bndGeneral.AddNewItem = this.bindingNavigatorAddNewItem;
      this.bndGeneral.CountItem = this.bindingNavigatorCountItem;
      this.bndGeneral.DeleteItem = this.bindingNavigatorDeleteItem;
      this.bndGeneral.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.bindingNavigatorMoveFirstItem,
            this.bindingNavigatorMovePreviousItem,
            this.bindingNavigatorSeparator,
            this.bindingNavigatorPositionItem,
            this.bindingNavigatorCountItem,
            this.bindingNavigatorSeparator1,
            this.bindingNavigatorMoveNextItem,
            this.bindingNavigatorMoveLastItem,
            this.bindingNavigatorSeparator2,
            this.bindingNavigatorAddNewItem,
            this.bindingNavigatorDeleteItem});
      this.bndGeneral.Location = new System.Drawing.Point(0, 0);
      this.bndGeneral.MoveFirstItem = this.bindingNavigatorMoveFirstItem;
      this.bndGeneral.MoveLastItem = this.bindingNavigatorMoveLastItem;
      this.bndGeneral.MoveNextItem = this.bindingNavigatorMoveNextItem;
      this.bndGeneral.MovePreviousItem = this.bindingNavigatorMovePreviousItem;
      this.bndGeneral.Name = "bndGeneral";
      this.bndGeneral.PositionItem = this.bindingNavigatorPositionItem;
      this.bndGeneral.Size = new System.Drawing.Size(800, 25);
      this.bndGeneral.TabIndex = 3;
      this.bndGeneral.Text = "bindingNavigator1";
      // 
      // bindingNavigatorAddNewItem
      // 
      this.bindingNavigatorAddNewItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
      this.bindingNavigatorAddNewItem.Image = ((System.Drawing.Image)(resources.GetObject("bindingNavigatorAddNewItem.Image")));
      this.bindingNavigatorAddNewItem.Name = "bindingNavigatorAddNewItem";
      this.bindingNavigatorAddNewItem.RightToLeftAutoMirrorImage = true;
      this.bindingNavigatorAddNewItem.Size = new System.Drawing.Size(23, 22);
      this.bindingNavigatorAddNewItem.Text = "Agregar nuevo";
      // 
      // bindingNavigatorCountItem
      // 
      this.bindingNavigatorCountItem.Name = "bindingNavigatorCountItem";
      this.bindingNavigatorCountItem.Size = new System.Drawing.Size(37, 22);
      this.bindingNavigatorCountItem.Text = "de {0}";
      this.bindingNavigatorCountItem.ToolTipText = "Número total de elementos";
      // 
      // bindingNavigatorDeleteItem
      // 
      this.bindingNavigatorDeleteItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
      this.bindingNavigatorDeleteItem.Image = ((System.Drawing.Image)(resources.GetObject("bindingNavigatorDeleteItem.Image")));
      this.bindingNavigatorDeleteItem.Name = "bindingNavigatorDeleteItem";
      this.bindingNavigatorDeleteItem.RightToLeftAutoMirrorImage = true;
      this.bindingNavigatorDeleteItem.Size = new System.Drawing.Size(23, 22);
      this.bindingNavigatorDeleteItem.Text = "Eliminar";
      // 
      // bindingNavigatorMoveFirstItem
      // 
      this.bindingNavigatorMoveFirstItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
      this.bindingNavigatorMoveFirstItem.Image = ((System.Drawing.Image)(resources.GetObject("bindingNavigatorMoveFirstItem.Image")));
      this.bindingNavigatorMoveFirstItem.Name = "bindingNavigatorMoveFirstItem";
      this.bindingNavigatorMoveFirstItem.RightToLeftAutoMirrorImage = true;
      this.bindingNavigatorMoveFirstItem.Size = new System.Drawing.Size(23, 22);
      this.bindingNavigatorMoveFirstItem.Text = "Mover primero";
      // 
      // bindingNavigatorMovePreviousItem
      // 
      this.bindingNavigatorMovePreviousItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
      this.bindingNavigatorMovePreviousItem.Image = ((System.Drawing.Image)(resources.GetObject("bindingNavigatorMovePreviousItem.Image")));
      this.bindingNavigatorMovePreviousItem.Name = "bindingNavigatorMovePreviousItem";
      this.bindingNavigatorMovePreviousItem.RightToLeftAutoMirrorImage = true;
      this.bindingNavigatorMovePreviousItem.Size = new System.Drawing.Size(23, 22);
      this.bindingNavigatorMovePreviousItem.Text = "Mover anterior";
      // 
      // bindingNavigatorSeparator
      // 
      this.bindingNavigatorSeparator.Name = "bindingNavigatorSeparator";
      this.bindingNavigatorSeparator.Size = new System.Drawing.Size(6, 25);
      // 
      // bindingNavigatorPositionItem
      // 
      this.bindingNavigatorPositionItem.AccessibleName = "Posición";
      this.bindingNavigatorPositionItem.AutoSize = false;
      this.bindingNavigatorPositionItem.Font = new System.Drawing.Font("Segoe UI", 9F);
      this.bindingNavigatorPositionItem.Name = "bindingNavigatorPositionItem";
      this.bindingNavigatorPositionItem.Size = new System.Drawing.Size(50, 23);
      this.bindingNavigatorPositionItem.Text = "0";
      this.bindingNavigatorPositionItem.ToolTipText = "Posición actual";
      // 
      // bindingNavigatorSeparator1
      // 
      this.bindingNavigatorSeparator1.Name = "bindingNavigatorSeparator1";
      this.bindingNavigatorSeparator1.Size = new System.Drawing.Size(6, 25);
      // 
      // bindingNavigatorMoveNextItem
      // 
      this.bindingNavigatorMoveNextItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
      this.bindingNavigatorMoveNextItem.Image = ((System.Drawing.Image)(resources.GetObject("bindingNavigatorMoveNextItem.Image")));
      this.bindingNavigatorMoveNextItem.Name = "bindingNavigatorMoveNextItem";
      this.bindingNavigatorMoveNextItem.RightToLeftAutoMirrorImage = true;
      this.bindingNavigatorMoveNextItem.Size = new System.Drawing.Size(23, 22);
      this.bindingNavigatorMoveNextItem.Text = "Mover siguiente";
      // 
      // bindingNavigatorMoveLastItem
      // 
      this.bindingNavigatorMoveLastItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
      this.bindingNavigatorMoveLastItem.Image = ((System.Drawing.Image)(resources.GetObject("bindingNavigatorMoveLastItem.Image")));
      this.bindingNavigatorMoveLastItem.Name = "bindingNavigatorMoveLastItem";
      this.bindingNavigatorMoveLastItem.RightToLeftAutoMirrorImage = true;
      this.bindingNavigatorMoveLastItem.Size = new System.Drawing.Size(23, 22);
      this.bindingNavigatorMoveLastItem.Text = "Mover último";
      // 
      // bindingNavigatorSeparator2
      // 
      this.bindingNavigatorSeparator2.Name = "bindingNavigatorSeparator2";
      this.bindingNavigatorSeparator2.Size = new System.Drawing.Size(6, 25);
      // 
      // label2
      // 
      this.label2.AutoSize = true;
      this.label2.Location = new System.Drawing.Point(129, 136);
      this.label2.Name = "label2";
      this.label2.Size = new System.Drawing.Size(83, 13);
      this.label2.TabIndex = 4;
      this.label2.Text = "Folio préstamos:";
      // 
      // cboPréstamos
      // 
      this.cboPréstamos.FormattingEnabled = true;
      this.cboPréstamos.Location = new System.Drawing.Point(442, 133);
      this.cboPréstamos.Name = "cboPréstamos";
      this.cboPréstamos.Size = new System.Drawing.Size(121, 21);
      this.cboPréstamos.TabIndex = 5;
      this.cboPréstamos.SelectedIndexChanged += new System.EventHandler(this.cboPréstamos_SelectedIndexChanged);
      // 
      // btnActualiza
      // 
      this.btnActualiza.Location = new System.Drawing.Point(619, 254);
      this.btnActualiza.Name = "btnActualiza";
      this.btnActualiza.Size = new System.Drawing.Size(75, 23);
      this.btnActualiza.TabIndex = 6;
      this.btnActualiza.Text = "Actualiza";
      this.btnActualiza.UseVisualStyleBackColor = true;
      this.btnActualiza.Click += new System.EventHandler(this.btnActualiza_Click);
      // 
      // btnRegresa
      // 
      this.btnRegresa.Location = new System.Drawing.Point(32, 396);
      this.btnRegresa.Name = "btnRegresa";
      this.btnRegresa.Size = new System.Drawing.Size(143, 23);
      this.btnRegresa.TabIndex = 7;
      this.btnRegresa.Text = "Página Principal";
      this.btnRegresa.UseVisualStyleBackColor = true;
      this.btnRegresa.Click += new System.EventHandler(this.btnRegresa_Click);
      // 
      // btnSalir
      // 
      this.btnSalir.Location = new System.Drawing.Point(619, 396);
      this.btnSalir.Name = "btnSalir";
      this.btnSalir.Size = new System.Drawing.Size(75, 23);
      this.btnSalir.TabIndex = 8;
      this.btnSalir.Text = "Salir";
      this.btnSalir.UseVisualStyleBackColor = true;
      this.btnSalir.Click += new System.EventHandler(this.btnSalir_Click);
      // 
      // btnPagos
      // 
      this.btnPagos.Location = new System.Drawing.Point(619, 201);
      this.btnPagos.Name = "btnPagos";
      this.btnPagos.Size = new System.Drawing.Size(75, 23);
      this.btnPagos.TabIndex = 9;
      this.btnPagos.Text = "Pagos";
      this.btnPagos.UseVisualStyleBackColor = true;
      this.btnPagos.Click += new System.EventHandler(this.btnPagos_Click);
      // 
      // FrmActPagoPréstamo
      // 
      this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
      this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
      this.ClientSize = new System.Drawing.Size(800, 450);
      this.Controls.Add(this.btnPagos);
      this.Controls.Add(this.btnSalir);
      this.Controls.Add(this.btnRegresa);
      this.Controls.Add(this.btnActualiza);
      this.Controls.Add(this.cboPréstamos);
      this.Controls.Add(this.label2);
      this.Controls.Add(this.bndGeneral);
      this.Controls.Add(this.dtgGeneral);
      this.Controls.Add(this.label1);
      this.Controls.Add(this.cboClientes);
      this.Name = "FrmActPagoPréstamo";
      this.Text = "FrmActPagoPréstamo";
      this.Load += new System.EventHandler(this.FrmActPagoPréstamo_Load);
      ((System.ComponentModel.ISupportInitialize)(this.dtgGeneral)).EndInit();
      ((System.ComponentModel.ISupportInitialize)(this.bndGeneral)).EndInit();
      this.bndGeneral.ResumeLayout(false);
      this.bndGeneral.PerformLayout();
      this.ResumeLayout(false);
      this.PerformLayout();

    }

    #endregion

    private System.Windows.Forms.ComboBox cboClientes;
    private System.Windows.Forms.Label label1;
    private System.Windows.Forms.DataGridView dtgGeneral;
    private System.Windows.Forms.BindingNavigator bndGeneral;
    private System.Windows.Forms.ToolStripButton bindingNavigatorAddNewItem;
    private System.Windows.Forms.ToolStripLabel bindingNavigatorCountItem;
    private System.Windows.Forms.ToolStripButton bindingNavigatorDeleteItem;
    private System.Windows.Forms.ToolStripButton bindingNavigatorMoveFirstItem;
    private System.Windows.Forms.ToolStripButton bindingNavigatorMovePreviousItem;
    private System.Windows.Forms.ToolStripSeparator bindingNavigatorSeparator;
    private System.Windows.Forms.ToolStripTextBox bindingNavigatorPositionItem;
    private System.Windows.Forms.ToolStripSeparator bindingNavigatorSeparator1;
    private System.Windows.Forms.ToolStripButton bindingNavigatorMoveNextItem;
    private System.Windows.Forms.ToolStripButton bindingNavigatorMoveLastItem;
    private System.Windows.Forms.ToolStripSeparator bindingNavigatorSeparator2;
    private System.Windows.Forms.Label label2;
    private System.Windows.Forms.ComboBox cboPréstamos;
    private System.Windows.Forms.Button btnActualiza;
    private System.Windows.Forms.Button btnRegresa;
    private System.Windows.Forms.Button btnSalir;
    private System.Windows.Forms.Button btnPagos;
  }
}