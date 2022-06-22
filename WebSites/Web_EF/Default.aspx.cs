using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Data;
using System.Data.Entity;

namespace Web_EF {
  public partial class Default : System.Web.UI.Page {
    //Variables de clase.
    PréstamosEntities context = new PréstamosEntities();
    protected void Page_Load(object sender, EventArgs e) {

    }

    
    protected void Login1_Authenticate(object sender, AuthenticateEventArgs e) {
      string cadsql;
      List<Clientes> lsClientes;

      cadsql = $"select * from clientes where rfc = '{Login1.UserName}' and " +
        $"contraseña = '{Login1.Password}'";
      lsClientes = context.Clientes.SqlQuery(cadsql).ToList();

      //Verifica 
      if(lsClientes.Count != 0) {
        Session["Cliente"] = lsClientes[0];
        Server.Transfer("ListaPréstamos.aspx");
      }
    }
  }
}