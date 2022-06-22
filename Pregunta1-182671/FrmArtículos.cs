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
  public partial class FrmArtículos : Form {
    //Variables de clase
    PedidosClientesEntities context = new PedidosClientesEntities();
    String rfc;
    List<ReAbast> listaAbas;
    List<Artículos> listaArts;
    ReAbast r;
    public FrmArtículos() {
      InitializeComponent();
    }
    public FrmArtículos(PedidosClientesEntities context, string rfc) {
      InitializeComponent();
      this.context = context;
      this.rfc = rfc;

      if (rfc == "ger" || rfc == "emp") {
        btnArts.Enabled = true;
      } else {
        btnArts.Enabled = false;
      }
    }

    private void FrmArtículos_Load(object sender, EventArgs e) {
      dtgGeneral.DataSource = context.ReAbast.Local;
    }

    private void btnArts_Click(object sender, EventArgs e) {
      //    FolioR = el máximo FolioR +1

      //Cant = Artículos.CantPedir(CantPedir del artículo para el cual se genera la tupla)

      //Monto = Cant * Artículos.Precio(Precio del     "		"         "  )

      //FechaPed = fecha actual(se obtiene con DateTime.Now.ToShortDateString())

      //FechaEnt = null(se escribe null, sin ' ', directamente en la cadena de inserción)

      //IdArt = Artículos.IdArt(IdArt del artículo para el cual se genera la tupla)
      int folio, cant, monto, idArt;
      DateTime fechaped, fechaEnt;

      context.Artículos.Load();
      context.ReAbast.Load();
      //Obtiene el nuevo folio.
      listaAbas = context.ReAbast.SqlQuery("select * from ReAbast order by folio desc").ToList();
      folio = listaAbas[0].FolioR + 1;

      fechaped = Convert.ToDateTime(dtpFecha.Value.ToShortDateString());

      cant = Convert.ToInt32(listaArts[0].CantPedir);

      //Obtiene monto.
      monto = Convert.ToInt32(cant * listaArts[0].Precio);

      //Obtiene la clave.
      listaArts = context.Artículos.SqlQuery($"select * from Artículos where cantAct <  cantMin").ToList();
      idArt = listaArts[0].IdArt;

      //Da de alta la nueva calificación.
      r = new ReAbast(folio, cant, monto, fechaped, null, idArt);
      context.ReAbast.Add(r);
      context.SaveChanges();
      MessageBox.Show("Se dio de alta");


    }

    private void btnAbas_Click(object sender, EventArgs e) {
      dtgGeneral.DataSource = context.ReAbast.Local;
    }
  }
}
