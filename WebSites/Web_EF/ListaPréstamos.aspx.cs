using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace Web_EF {
  public partial class ListaPréstamos : System.Web.UI.Page {
    //Variables de clase
    PréstamosEntities context = new PréstamosEntities();
    List<Préstamos> lsPréstamos;
    List<Pagos> lsPagos;
    List<Avales> lsAvales;
    string cadSql;
    protected void Page_Load(object sender, EventArgs e) {
      Clientes cliente;

      if(!IsPostBack){
        //Recupera los objetos de sesión.
        cliente = (Clientes)Session["Cliente"];

        //Muestra los datos del cliente.
        tblCliente.Rows[1].Cells[0].Text = cliente.Rfc;
        tblCliente.Rows[1].Cells[1].Text = cliente.Nombre;
        tblCliente.Rows[1].Cells[2].Text = cliente.Domicilio;

        //Carga los préstamos del cliente.
        cadSql = $"select * from préstamos where rfc ='{cliente.Rfc}'";
        lsPréstamos = context.Préstamos.SqlQuery(cadSql).ToList();

        //Carga los folios en el ddl.
        ddlPréstamos.Items.Add(" ");
        foreach (Préstamos p in lsPréstamos)
          ddlPréstamos.Items.Add(p.Folio.ToString());

      }
    }
    //Muestra datos asociados al préstamo elegido en el ddl.
    protected void ddlPréstamos_SelectedIndexChanged(object sender, EventArgs e) {

      if(ddlPréstamos.Text != " "){

        //Trae de la bd al préstamos por su fólio.
        cadSql = $"select * from préstamos where folio ={ddlPréstamos.Text}";
        lsPréstamos = context.Préstamos.SqlQuery(cadSql).ToList();

        //Muestra los datos del préstamo en la tabla.
        tblF.Rows[1].Cells[0].Text = lsPréstamos[0].Folio.ToString();
        tblF.Rows[1].Cells[1].Text = lsPréstamos[0].Monto.ToString();
        tblF.Rows[1].Cells[2].Text = lsPréstamos[0].Mensualidad.ToString();
        tblF.Rows[1].Cells[3].Text = lsPréstamos[0].Saldo.ToString();

        //Muestra los pagos del préstamo.
        cadSql = $"select * from pagos where folio = {lsPréstamos[0].Folio}";
        lsPagos = context.Pagos.SqlQuery(cadSql).ToList();
        grdPagos.DataSource = lsPagos;
        grdPagos.DataBind();

        //Muestra los avales del préstamo. 
        cadSql = $"select * from Avales a, Avalan av where av.folio ={lsPréstamos[0].Folio} and a.idAval = {lsAvales[0].IdAval}";
        lsAvales = context.Avales.SqlQuery(cadSql).ToList();
        grdAvales.DataSource = lsAvales;
        grdAvales.DataBind();
        
      }
    }
  }
}