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
            cliente.cp = txbCp.Text;
            cliente.fechaRegistro = DateTime.Now;
            auxCliente.Agregar(cliente);

            string idVoucher = Session["VoucherCodigo" + Session.SessionID].ToString();
            voucher.Actualizar(voucher.BuscarVoucher(idVoucher));


        }
        protected void BtnBuscar_click(object sender, EventArgs e)
        {
            Cliente cliente = new Cliente();
            clienteNegocio cliNegocio = new clienteNegocio();
            cliente = cliNegocio.Buscar(Int32.Parse(txbDNI.Text));
            if (cliente != null)
            {
                txbNombre.Text = cliente.nombre;
                txbApellido.Text = cliente.apellido;
                txbMail.Text = cliente.email;
                txbDireccion.Text = cliente.direccion;
                txbCiudad.Text = cliente.ciudad;
                txbCp.Text = cliente.cp;
            }
            else
            {
                txbDNI.Text = " ";
            }
        }
    }
}