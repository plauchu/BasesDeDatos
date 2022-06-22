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

namespace ClienteServidor.UsoEF {
  public partial class FrmActHistorial_EF : Form {
    //Variables de clase.
    SistemaEscolarEntities context = new SistemaEscolarEntities();
    List<Historial> listaHist;
    List<Alum> listaAlum;
    List<Mater> listaMat;
    public FrmActHistorial_EF() {
      InitializeComponent();
    }

    //Acciones iniciales.
    private void FrmActHistorial_EF_Load(object sender, EventArgs e) {

      //Carga los datos de las tablas requeridas.
      context.Alum.Load();
      context.Historial.Load();
      context.Mater.Load();

      dtgGeneral.DataSource = context.Historial.Local;

      //Carga el combo de alumnos con los nombres.
      foreach (Alum a in context.Alum)
        cboAlumnos.Items.Add(a.NomAl);

      //Carga el combo de materias con los nombres.
      foreach (Mater a in context.Mater)
        cboAlumnos.Items.Add(a.NomMat);

    }
    //Habilita/dasbilita controles.
    private void btnAltaCalif_Click(object sender, EventArgs e) {
      cboMater.Visible = true; cboCalif.Visible = true; dtpFecha.Visible = true;
      btnRegistrarAlta.Visible = true; btnAltaCalif.Enabled = false;
      btnBajaCalif.Enabled = false; btnCambia.Enabled = false;
    }
    //Acciones para dar de alta una calificación.
    private void btnRegistrarAlta_Click(object sender, EventArgs e) {
      int folio;
      short cu, clavem, calif;
      DateTime fecha;
      Historial h;

      //Obtiene el nuevo folio para la nueva calif.
      listaHist = context.Historial.SqlQuery("select * from Historial order by folio desc").ToList();
      folio = listaHist[0].Folio + 1;

      //Obtiene calif y fecha.
      calif = Convert.ToInt16(cboCalif.Text);
      fecha = Convert.ToDateTime(dtpFecha.Value.ToShortDateString());

      //Obtiene la clave única del alumno elegido en su combo.
      listaAlum = context.Alum.SqlQuery($"select * from alum where nomal = '{cboAlumnos.Text}'").ToList();
      cu = listaAlum[0].CU;

      //Obtiene la clave única de la materia elegido en su combo.
      listaMat = context.Mater.SqlQuery($"select * from mater where nomMat ='{cboMater.Text}'").ToList();
      clavem = listaMat[0].ClaveM;

      //Da de alta la nueva calificación.
      h = new Historial(folio, calif, fecha, cu, clavem);
      context.Historial.Add(h);
      context.SaveChanges();
      MessageBox.Show("Se dio de alta la nueva calif.");
      
    }
    
    //Muestra en el grid las califs. del alumno elegido en la BD.
    private void cboAlumnos_SelectedIndexChanged(object sender, EventArgs e) {
      string cadsql;

      cadsql = $"select * from historial h, alum a where nomal = ' {cboAlumnos.Text} ' and a.cu = h.cu";
      listaHist = context.Historial.SqlQuery(cadsql).ToList();
      dtgGeneral.DataSource = listaHist;

    }
  }

}
