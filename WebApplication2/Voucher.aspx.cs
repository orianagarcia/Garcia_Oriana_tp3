﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using Negocio1;
using Dominio1;

namespace WebApplication2
{
    public partial class Voucher : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {

        }
        protected void BtnVoucherAceptar_Click(object sender, EventArgs e)
        {
            try
            {
                VoucherNegocio voucherNegocio = new VoucherNegocio();
                Vouchers voucherAux = new Vouchers();
                voucherAux = voucherNegocio.BuscarVoucher(txbVoucher.Text);

                if (voucherAux.codigo != null)
                {
                    if (voucherAux.estado == false)
                    {
                        Session["VoucherCodigo" + Session.SessionID] = txbVoucher.Text;
                        var valor = Session["VoucherCodigo" + Session.SessionID];
                        Response.Redirect("Premios.aspx");
                    }
                }
            }
            catch (Exception ex)
            {
                throw ex;
            }

        }
    }
}