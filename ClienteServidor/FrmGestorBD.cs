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
  public partial class FrmGestorBD : Form {
    //Variables de clase.
    GestorBD.GestorBD GestorBD;
    DataSet dsAlum = new DataSet(), dsMater = new DataSet(), dsCalifs = new DataSet();
    DataSet dsTemp = new DataSet();
    Comunes comunes = new Comunes();
    DataRow fila;
    string cadSql;
    const int OK = 1;

    public FrmGestorBD() {
      InitializeComponent();
    }

    //Acciones iniciales al cargar la forma.
    private void FrmGestorBD_Load(object sender, EventArgs e) {
      //Crea la conexión a la base de datos.
      GestorBD = new GestorBD.GestorBD("SQLNCLI11", "DESKTOP-77NC78G\\SQLEXPRESS",
        "sa", "adminadmin", "SistemaEscolar");
      //Proveedor para Oracle: MSDAORA u OraOLEDB.Oracle.

      //Obtiene los datos de los alumnos.
      cadSql = "select * from alum";
      GestorBD.consBD(cadSql, dsAlum, "Alum");
      dtgGeneral.DataSource = dsAlum.Tables["Alum"];
      comunes.cargaCombo(cboAlumnos, dsAlum, "Alum", "NomAl");

      //Obtiene los datos de las materias.
      cadSql = "select * from mater";
      GestorBD.consBD(cadSql, dsMater, "Mater");
      //dtgGeneral.DataSource = dsMater.Tables["Mater"];
      comunes.cargaCombo(cboMater, dsMater, "Mater", "NomMat");
    }

    //Muestra las calificaciones del alumno elegido en el combo de alumnos.
    private void CboAlumnos_SelectedIndexChanged(object sender, EventArgs e) {
      cadSql = "select Folio, NomAl,NomMat,Calif,Fecha from alum a, historial h, mater m " +
        "where nomal='" + cboAlumnos.Text + "' and a.cu=h.cu and h.clavem=m.clavem";
      GestorBD.consBD(cadSql, dsCalifs, "Califs");
      dtgGeneral.DataSource = dsCalifs.Tables["Califs"];
    }

    //Habilita/deshabilita controles.
    private void BtnAltaCalif_Click(object sender, EventArgs e) {
      cboMater.Visible = true; cboCalif.Visible = true; dtpFecha.Visible = true;
      btnRegistrarAlta.Visible = true; btnAltaCalif.Enabled = false;
      btnBajaCalif.Enabled = false; btnCambia.Enabled = false;
    }

    private void btnBajaCalif_Click(object sender, EventArgs e) {
      int folio;
      DialogResult botón;



      //Toma el folio de la calificación seleccionada en el data grid.
      folio = Convert.ToInt16(dtgGeneral["Folio", dtgGeneral.CurrentRow.Index].Value);
      botón = MessageBox.Show("¿Se elimina el registro con folio= " + folio.ToString(),
        "Eliminación", MessageBoxButtons.YesNo);



      //Si se selecciona el botón Yes, del MessageBox, elimina el registro asociado.
      if (botón == DialogResult.Yes) {
        //Construye la cadena de eliminación y la envía para su ejecución.
        cadSql = "delete from Historial where Folio = " + folio;
        if (GestorBD.bajaBD(cadSql) == OK)
          MessageBox.Show("Se eliminó la calificación del folio " + folio + " exitosamente");
        else
          MessageBox.Show("No se pudo eliminar la calificación");
      }
    }

    private void btnCambia_Click(object sender, EventArgs e) {
      cboCalif.Visible = true; cboCalif.Text = "Calificación:";
      btnRegistrarCambio.Visible = true; btnAltaCalif.Enabled = false;
      btnBajaCalif.Enabled = false; cboAlumnos.Enabled = false;

    }

    private void btnRegistrarCambio_Click(object sender, EventArgs e) {
      int folio;
      int nuevaCalif;

      //Toma el folio de la calificación seleccionada en el data grid.
      folio = Convert.ToInt16(dtgGeneral["Folio", dtgGeneral.CurrentRow.Index].Value);

      //Construye la cadena de cambio.
      dtgGeneral["Calif", dtgGeneral.CurrentRow.Index].Value = cboCalif.Text;
      nuevaCalif = Convert.ToInt16(cboCalif.Text);

      // y la envía para su ejecución.
      cadSql = "update Historial set Calif=" + nuevaCalif + " where Folio=" + folio;
      if (GestorBD.cambiaBD(cadSql) == OK)
        MessageBox.Show("Se actualizó Historial exitosamente");
      else
        MessageBox.Show("No se pudo actualizar Historial");
    }

    //Acciones para dar de alta una calificación.
    private void BtnRegistrarAlta_Click(object sender, EventArgs e) {
        //Variables locales.

        //Obtiene el folio de la nueva calificación.
        cadSql = "select max(folio) as maxFolio from historial";
        GestorBD.consBD(cadSql, dsTemp, "Temp");
        fila = dsTemp.Tables["Temp"].Rows[0];
        int folio = (int)fila["maxFolio"] + 1;

        //Obtiene la fecha.
        string fecha = dtpFecha.Value.ToShortDateString();

        //Obtiene la clave única del alumno.
        cadSql = "select cu from alum where nomal='" + cboAlumnos.Text + "'";
        GestorBD.consBD(cadSql, dsAlum, "Alum");
        fila = dsAlum.Tables["Alum"].Rows[0];
        int cu = Convert.ToInt32(fila["CU"]);

        //Obtiene la clave de la materia.
        cadSql = "select clavem from mater where nommat='" + cboMater.Text + "'";
        GestorBD.consBD(cadSql, dsMater, "Mater");
        fila = dsMater.Tables["Mater"].Rows[0];
        int clavem = Convert.ToInt32(fila["ClaveM"]);

        //Construte la cadena de inserción.
        cadSql = "insert into historial values(" + folio + "," + cboCalif.Text + ",'" +
          fecha + "'," + cu + "," + clavem + ")";

        //Envía la inserción de la nueva calificación.
        if (GestorBD.altaBD(cadSql) == OK)
          MessageBox.Show("Calif. insertada exitosamente");
        else
          MessageBox.Show("Falló el alta de caluf.");

        //Habilita/deshabilita controles.
        cboMater.Visible = false; cboMater.Text = "Materias:";
        cboCalif.Visible = false; cboCalif.Text = "Calificación:";
        dtpFecha.Visible = false;
        btnRegistrarAlta.Visible = false; btnAltaCalif.Enabled = true;
        btnBajaCalif.Enabled = true; btnCambia.Enabled = true;
      }

      //Para obtener el valor de la celda seleccionada al darle clic en el DataGrid
      //existen tres maneras (necesariamente hay que dar clic en la celda elegida):
      //1) nombreDataGrid.CurrentCell.Value;
      //2) nombreDataGrid[ÍndiceColumna, ÍndiceFila].Value;
      //3) nombreDataGrid[NombreColumna, ÍndiceFila].Value
      private void DtgGeneral_Click(object sender, EventArgs e) {
        int fila, col; Object valor;

        //Obtiene fila, columna y valor de la celda elegida.
        fila = dtgGeneral.CurrentCell.RowIndex;
        col = dtgGeneral.CurrentCell.ColumnIndex;
        valor = dtgGeneral.CurrentCell.Value;
        MessageBox.Show("Fila: " + fila + " Columna: " + col + " Valor: " + valor);

        //Obtiene sólo el valor.
        MessageBox.Show("Valor: " + dtgGeneral[col, fila].Value.ToString());
      }

    }
  }
