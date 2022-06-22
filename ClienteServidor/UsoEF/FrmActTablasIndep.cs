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
  public partial class FrmActTablasIndep : Form {
    //Variables de clase.
    SistemaEscolarEntities context = new SistemaEscolarEntities();
    BindingSource AlumBS = new BindingSource();
    
    public FrmActTablasIndep() {
      InitializeComponent();
    }
    //Carga de los datos de varias de las tablas de la BD.
    private void FrmActTablasIndep_Load(object sender, EventArgs e) {

      context.Alum.Load();  //Carga desde la BD datos de los alumnos.

    }
    //Muestra/actualiza los datos de los alumnos.
    private void mnualumnos_Click(object sender, EventArgs e) {

      AlumBS.DataSource = context.Alum.Local;
      dtgGeneral.DataSource = AlumBS;
      bndGeneral.BindingSource = AlumBS;
    }

    //Actualiza las tablas cuyos valores se modificaron en el grid.
    private void btnActualizar_Click(object sender, EventArgs e) {

      context.SaveChanges();
    }
  }
}
