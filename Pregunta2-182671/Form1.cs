using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Pregunta2_182671 {
  public partial class Form1 : Form {
    //Atributos de la clase.
    GestorBD.GestorBD GestorBD;   //"Para manejar la BD.
    DataSet DsRfc = new DataSet(); //Para gaurdar el resultado de consultas.
    DataSet Ds1 = new DataSet();
    DataSet Ds2 = new DataSet();
    DataSet Ds3 = new DataSet();
    Comunes mc = new Comunes();
    string rfc, cadSql;

    public Form1() {
      InitializeComponent();
    }

    private void cboClientes_SelectedIndexChanged(object sender, EventArgs e) {
      rfc = cboClientes.Text;
    }

    private void btnmostrar_Click(object sender, EventArgs e) {
      cadSql = "select u.rfc, u.nombre, u.tipo, c.domicilio from Usuarios u, clientes c where u.rfc = '" + rfc + "'";
      GestorBD.consBD(cadSql, Ds1, "temp");

      //Muestra los datos del cliente.
      dtg1.DataSource = Ds1.Tables["temp"];

      cadSql = "select p.FolioP, p.FechaPed, p.monto, p.saldoCli from Pedidos p where p.rfcc = '" + rfc + "'";
      GestorBD.consBD(cadSql, Ds2, "temp");

      //Muestra los datos del cliente.
      dtg2.DataSource = Ds2.Tables["temp"];
    }

    private void btnPed_Click(object sender, EventArgs e) {
      //Toma el FolioP
      int folio;
      folio = Convert.ToInt32(dtg2["FolioP", dtg2.CurrentRow.Index].Value);

      cadSql = "select a.nombre, a.precio, d.cantPed, a.precio*d.cantPed as TotalArtículo from Detalle d, Artículos a" +
      "where d.IdArt = a.IdArt and d.FolioP ="+folio;
      GestorBD.consBD(cadSql, Ds3, "temp");

      //Muestra los datos del cliente.
      dtg3.DataSource = Ds3.Tables["temp"];
    }

    private void Form1_Load(object sender, EventArgs e) {
      GestorBD = new GestorBD.GestorBD("SQLNCLI11", "DESKTOP-77NC78G\\SQLEXPRESS", "sa", "adminadmin", "PedidosClientes");

      //Carga combo rfc
      cadSql = "select rfc from usuarios where tipo = 'Cli'";
      GestorBD.consBD(cadSql, DsRfc, "Temp");
      mc.cargaCombo(cboClientes, DsRfc, "Temp", "rfc");
    }
  }
}
