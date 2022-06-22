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

namespace Tarea6 {
  public partial class FrmActPagoPréstamo : Form {
    //Variables de clase
    PréstamosEntities context = new PréstamosEntities();
    BindingSource ClientesBS = new BindingSource();
    List<Préstamos> lsPréstamos;
    List<Clientes> lsClientes;
    List<Pagos> lsPag;
    string rfc;
    string cadSql;
    public FrmActPagoPréstamo(PréstamosEntities context, string rfc) {
      InitializeComponent();
      this.context = context;
      this.rfc = rfc;

    }

    public FrmActPagoPréstamo() {
      InitializeComponent();
    }

    private void FrmActPagoPréstamo_Load(object sender, EventArgs e) {
      //Carga los datos de las tablas requeridas.
      context.Clientes.Load();

      //Carga el combo de clientes con los nombres.
      foreach (Clientes c in context.Clientes)
        cboClientes.Items.Add(c.Nombre);

    }

    private void btnSalir_Click(object sender, EventArgs e) {
      Application.Exit();
    }
    //Abre la forma de página principal.
    private void btnRegresa_Click(object sender, EventArgs e) {

    }
    //Muestra en el grid los datos del préstamo del cliente.
    private void cboPréstamos_SelectedIndexChanged(object sender, EventArgs e) {
      if (cboPréstamos.Text != " ") {
        //Trae de la bd al préstamos por su fólio.
        cadSql = $"select * from préstamos where folio ={cboPréstamos.Text}";
        ClientesBS.DataSource = context.Préstamos.SqlQuery(cadSql).ToList();
        dtgGeneral.DataSource = ClientesBS;
        bndGeneral.BindingSource = ClientesBS;
      }
      }
    //Actualiza las tablas cuyos valores se modificaron
    private void btnActualiza_Click(object sender, EventArgs e) {

      context.SaveChanges();    
    }

    //Muestra folio de préstamos
    private void cboClientes_SelectedIndexChanged(object sender, EventArgs e) {
      context.Préstamos.Load();
      context.Clientes.Load();
      string rfc;

      cadSql = $"select * from clientes where nombre = '" + cboClientes.Text + "'";
      lsClientes = context.Clientes.SqlQuery(cadSql).ToList();
      rfc = lsClientes[0].Rfc;
      //Carga los préstamos del cliente.
      cadSql = $"select * from préstamos where rfc ='{rfc}'";
      lsPréstamos = context.Préstamos.SqlQuery(cadSql).ToList();

      //Carga los folios en el cbo.
      cboPréstamos.Items.Add(" ");
      foreach (Préstamos p in lsPréstamos)
        cboPréstamos.Items.Add(p.Folio.ToString());
    }

    private void btnPagos_Click(object sender, EventArgs e) {
      cadSql =$"select * from pagos pa where pa.folio = "+ cboPréstamos.Text;
      lsPag = context.Pagos.SqlQuery(cadSql).ToList();

      ClientesBS.DataSource = lsPag;
      dtgGeneral.DataSource = ClientesBS;
      bndGeneral.BindingSource = ClientesBS;
    }
  }
}
