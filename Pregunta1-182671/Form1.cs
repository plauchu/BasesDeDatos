using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.Entity;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Pregunta1_182671 {
  public partial class Form1 : Form {
    //Variables de clase
    PedidosClientesEntities context = new PedidosClientesEntities();
    public Form1() {
      InitializeComponent();
    }

    private void Form1_Load(object sender, EventArgs e) {

    }

    private void btIngresa_Click(object sender, EventArgs e) {
      string cadSql;

      cadSql = $"select * from usuarios where rfc = '{txUser.Text}' and " +
        $"Passw = '{txContra.Text}'";

      List<Clientes> lsClientes = context.Clientes.SqlQuery(cadSql).ToList();

      if (lsClientes.Count != 0) {
      FrmArtículos f  = new FrmArtículos(context, txUser.Text);
        f.ShowDialog();
      } else {
        MessageBox.Show("Error en el usuario o contraseña");

      }
    }
  }
}
