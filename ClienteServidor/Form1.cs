using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ClienteServidor {
  public partial class Form1 : Form {
    public Form1() {
      InitializeComponent();
    }

    //Termina la aplicación.
    private void SalirToolStripMenuItem_Click(object sender, EventArgs e) {
      Application.Exit();
    }

    //Abrir la forma de Gestor BD.
    private void GestorBDToolStripMenuItem_Click(object sender, EventArgs e) {
      FrmGestorBD fgb = new FrmGestorBD();
      fgb.ShowDialog();
    }

    private void usoEFToolStripMenuItem_Click(object sender, EventArgs e) {

    }
    //Abre la forma de actualización de las tablas independientes.
    private void mnuActTablasIndep_Click(object sender, EventArgs e) {
      UsoEF.FrmActTablasIndep fati = new UsoEF.FrmActTablasIndep();
      fati.ShowDialog();
    }
    //Abre la forma de historial.
    private void mnuHistorial_Click(object sender, EventArgs e) {

      UsoEF.FrmActHistorial_EF fah = new UsoEF.FrmActHistorial_EF();
      fah.ShowDialog();
    }
  }
}
