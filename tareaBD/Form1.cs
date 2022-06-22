using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace tareaBD {
  public partial class frmQuery : Form {
    //Variables de clase.
    GestorBD.GestorBD GestorBD;
    DataSet dsQ1 = new DataSet();
    DataSet dsQ2 = new DataSet();
    DataSet dsQ3 = new DataSet();
    DataSet dsQ4 = new DataSet();
    Comunes comunes = new Comunes();
    DataRow fila;
    string cadSql;
    public frmQuery() {
      InitializeComponent();
    }

    private void Form1_Load(object sender, EventArgs e) {
      //Crea la conexión a la base de datos.
      GestorBD = new GestorBD.GestorBD("SQLNCLI11", "DESKTOP-77NC78G\\SQLEXPRESS",
        "sa", "adminadmin", "SistemaUniversidades");

    }

    private void query1_Click(object sender, EventArgs e) {
      cadSql = "select cd, c.nombre Campus, i.nombre Institición from Campus c, Institución i " +
          "where c.idinst = i.idinst order by cd";
      GestorBD.consBD(cadSql, dsQ2, "Temp");
      grdResultados.DataSource = dsQ2.Tables["Temp"];
    }

    private void query2_Click(object sender, EventArgs e) {
      cadSql = "select * from Carrera";
      GestorBD.consBD(cadSql, dsQ1, "Temp");
      grdResultados.DataSource = dsQ1.Tables["Temp"];
    }

    private void query3_Click(object sender, EventArgs e) {
      cadSql = "select * from Campus";
      GestorBD.consBD(cadSql, dsQ3, "Temp");
      grdResultados.DataSource = dsQ3.Tables["Temp"];
    }

    private void query4_Click(object sender, EventArgs e) {
      cadSql = "select * from AreaAcad";
      GestorBD.consBD(cadSql, dsQ4, "Temp");
      grdResultados.DataSource = dsQ4.Tables["Temp"];
    }
  }
}
