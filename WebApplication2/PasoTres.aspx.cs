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
    public partial class PasoTres : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            if (!IsPostBack)
            {
                var idPremio = Request.QueryString["valor"];
                var idVoucher = Session["VoucherCodigo" + Session.SessionID];
            }
        }
        protected void BtnParticipar_click(object sender, EventArgs e)
        {
            Cliente cliente = new Cliente();
            clienteNegocio auxCliente = new clienteNegocio();
            Vouchers auxVoucher = new Vouchers();
            VoucherNegocio voucher = new VoucherNegocio();

            cliente.nombre = txbNombre.Text;
            cliente.apellido = txbApellido.Text;
            cliente.dni = Convert.ToInt32(txbDNI.Text);
            cliente.email = txbMail.Text;
            cliente.direccion = txbDireccion.Text;
            cliente.ciudad = txbCiudad.Text;
            cliente.cp = Convert.ToInt32(txbCp.Text);
            cliente.fechaRegistro = DateTime.Now;
            auxCliente.Agregar(cliente);





        }
    }
}