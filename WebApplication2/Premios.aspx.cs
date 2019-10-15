using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using Negocio1;
using Dominio1;


namespace WebApplication2
{
    public partial class Premios : System.Web.UI.Page
    {
        public List<Producto> listar = new List<Producto>();

        protected void Page_Load(object sender, EventArgs e)
        {
            string v = (string)Session["VoucherCodigo" + Session.SessionID]; 
            listar = (new ProductoNegocio().Listar());
        }
    }
}