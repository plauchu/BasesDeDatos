namespace ClienteServidor.UsoEF {
  partial class FrmActTablasIndep {
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
      System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FrmActTablasIndep));
      this.dtgGeneral = new System.Windows.Forms.DataGridView();
      this.btnActualizar = new System.Windows.Forms.Button();
      this.menuStrip1 = new System.Windows.Forms.MenuStrip();
      this.menuStrip2 = new System.Windows.Forms.MenuStrip();
      this.mnualumnos = new System.Windows.Forms.ToolStripMenuItem();
      this.mnuprof = new System.Windows.Forms.ToolStripMenuItem();
      this.mnumater = new System.Windows.Forms.ToolStripMenuItem();
      this.bndGeneral = new System.Windows.Forms.BindingNavigator(this.components);
      this.bindingNavigatorMoveFirstItem = new System.Windows.Forms.ToolStripButton();
      this.bindingNavigatorMovePreviousItem = new System.Windows.Forms.ToolStripButton();
      this.bindingNavigatorSeparator = new System.Windows.Forms.ToolStripSeparator();
      this.bindingNavigatorPositionItem = new System.Windows.Forms.ToolStripTextBox();
      this.bindingNavigatorCountItem = new System.Windows.Forms.ToolStripLabel();
      this.bindingNavigatorSeparator1 = new System.Windows.Forms.ToolStripSeparator();
      this.bindingNavigatorMoveNextItem = new System.Windows.Forms.ToolStripButton();
      this.bindingNavigatorMoveLastItem = new System.Windows.Forms.ToolStripButton();
      this.bindingNavigatorSeparator2 = new System.Windows.Forms.ToolStripSeparator();
      this.bindingNavigatorAddNewItem = new System.Windows.Forms.ToolStripButton();
      this.bindingNavigatorDeleteItem = new System.Windows.Forms.ToolStripButton();
      ((System.ComponentModel.ISupportInitialize)(this.dtgGeneral)).BeginInit();
      this.menuStrip2.SuspendLayout();
      ((System.ComponentModel.ISupportInitialize)(this.bndGeneral)).BeginInit();
      this.bndGeneral.SuspendLayout();
      this.SuspendLayout();
      // 
      // dtgGeneral
      // 
      this.dtgGeneral.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
      this.dtgGeneral.Location = new System.Drawing.Point(44, 87);
      this.dtgGeneral.Name = "dtgGeneral";
      this.dtgGeneral.Size = new System.Drawing.Size(353, 150);
      this.dtgGeneral.TabIndex = 0;
      // 
      // btnActualizar
      // 
      this.btnActualizar.Location = new System.Drawing.Point(322, 260);
      this.btnActualizar.Name = "btnActualizar";
      this.btnActualizar.Size = new System.Drawing.Size(75, 23);
      this.btnActualizar.TabIndex = 1;
      this.btnActualizar.Text = "Actualizar";
      this.btnActualizar.UseVisualStyleBackColor = true;
      this.btnActualizar.Click += new System.EventHandler(this.btnActualizar_Click);
      // 
      // menuStrip1
      // 
      this.menuStrip1.Location = new System.Drawing.Point(0, 24);
      this.menuStrip1.Name = "menuStrip1";
      this.menuStrip1.Size = new System.Drawing.Size(800, 24);
      this.menuStrip1.TabIndex = 2;
      this.menuStrip1.Text = "menuStrip1";
      // 
      // menuStrip2
      // 
      this.menuStrip2.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.mnualumnos,
            this.mnuprof,
            this.mnumater});
      this.menuStrip2.Location = new System.Drawing.Point(0, 0);
      this.menuStrip2.Name = "menuStrip2";
      this.menuStrip2.Size = new System.Drawing.Size(800, 24);
      this.menuStrip2.TabIndex = 3;
      this.menuStrip2.Text = "menuStrip2";
      // 
      // mnualumnos
      // 
      this.mnualumnos.Name = "mnualumnos";
      this.mnualumnos.Size = new System.Drawing.Size(67, 20);
      this.mnualumnos.Text = "Alumnos";
      this.mnualumnos.Click += new System.EventHandler(this.mnualumnos_Click);
      // 
      // mnuprof
      // 
      this.mnuprof.Name = "mnuprof";
      this.mnuprof.Size = new System.Drawing.Size(74, 20);
      this.mnuprof.Text = "Profesores";
      // 
      // mnumater
      // 
      this.mnumater.Name = "mnumater";
      this.mnumater.Size = new System.Drawing.Size(64, 20);
      this.mnumater.Text = "Materias";
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
      this.bndGeneral.Location = new System.Drawing.Point(0, 48);
      this.bndGeneral.MoveFirstItem = this.bindingNavigatorMoveFirstItem;
      this.bndGeneral.MoveLastItem = this.bindingNavigatorMoveLastItem;
      this.bndGeneral.MoveNextItem = this.bindingNavigatorMoveNextItem;
      this.bndGeneral.MovePreviousItem = this.bindingNavigatorMovePreviousItem;
      this.bndGeneral.Name = "bndGeneral";
      this.bndGeneral.PositionItem = this.bindingNavigatorPositionItem;
      this.bndGeneral.Size = new System.Drawing.Size(800, 25);
      this.bndGeneral.TabIndex = 4;
      this.bndGeneral.Text = "bindingNavigator1";
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
      // bindingNavigatorCountItem
      // 
      this.bindingNavigatorCountItem.Name = "bindingNavigatorCountItem";
      this.bindingNavigatorCountItem.Size = new System.Drawing.Size(37, 22);
      this.bindingNavigatorCountItem.Text = "de {0}";
      this.bindingNavigatorCountItem.ToolTipText = "Número total de elementos";
      // 
      // bindingNavigatorSeparator1
      // 
      this.bindingNavigatorSeparator1.Name = "bindingNavigatorSeparator";
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
      this.bindingNavigatorSeparator2.Name = "bindingNavigatorSeparator";
      this.bindingNavigatorSeparator2.Size = new System.Drawing.Size(6, 25);
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
      // bindingNavigatorDeleteItem
      // 
      this.bindingNavigatorDeleteItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
      this.bindingNavigatorDeleteItem.Image = ((System.Drawing.Image)(resources.GetObject("bindingNavigatorDeleteItem.Image")));
      this.bindingNavigatorDeleteItem.Name = "bindingNavigatorDeleteItem";
      this.bindingNavigatorDeleteItem.RightToLeftAutoMirrorImage = true;
      this.bindingNavigatorDeleteItem.Size = new System.Drawing.Size(23, 22);
      this.bindingNavigatorDeleteItem.Text = "Eliminar";
      // 
      // FrmActTablasIndep
      // 
      this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
      this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
      this.ClientSize = new System.Drawing.Size(800, 450);
      this.Controls.Add(this.bndGeneral);
      this.Controls.Add(this.btnActualizar);
      this.Controls.Add(this.dtgGeneral);
      this.Controls.Add(this.menuStrip1);
      this.Controls.Add(this.menuStrip2);
      this.MainMenuStrip = this.menuStrip1;
      this.Name = "FrmActTablasIndep";
      this.Text = "Actualiza las tablas independientes";
      this.Load += new System.EventHandler(this.FrmActTablasIndep_Load);
      ((System.ComponentModel.ISupportInitialize)(this.dtgGeneral)).EndInit();
      this.menuStrip2.ResumeLayout(false);
      this.menuStrip2.PerformLayout();
      ((System.ComponentModel.ISupportInitialize)(this.bndGeneral)).EndInit();
      this.bndGeneral.ResumeLayout(false);
      this.bndGeneral.PerformLayout();
      this.ResumeLayout(false);
      this.PerformLayout();

    }

    #endregion

    private System.Windows.Forms.DataGridView dtgGeneral;
    private System.Windows.Forms.Button btnActualizar;
    private System.Windows.Forms.MenuStrip menuStrip1;
    private System.Windows.Forms.MenuStrip menuStrip2;
    private System.Windows.Forms.ToolStripMenuItem mnualumnos;
    private System.Windows.Forms.ToolStripMenuItem mnuprof;
    private System.Windows.Forms.ToolStripMenuItem mnumater;
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
  }
}