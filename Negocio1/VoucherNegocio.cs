using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Dominio1;

namespace Negocio1
{
    public class VoucherNegocio
    {
        public Vouchers BuscarVoucher(string codigo)
        {
            AccesoDatos datos = new AccesoDatos();
            Vouchers aux = null;
            try
            {
                datos.setearQuery("select id,codigoVoucher,Estado,IdCliente,IdProducto,FechaRegistro FROM [TP_WEB].[dbo].[Vouchers] where CodigoVoucher =  '" +codigo+"'");
                datos.ejecutarLector();
                while (datos.lector.Read())
                {
                    aux = new Vouchers();
                    aux.id = (long)datos.lector["id"];
                    aux.codigo = (string)datos.lector["CodigoVoucher"];
                    aux.estado = (Boolean)datos.lector["Estado"];
                }
                return aux;
            }
            catch (Exception ex)
            {
                throw ex;
            }
            finally
            {
                datos.cerrarConexion();
            }
        }

        public void Actualizar (Vouchers aux,long idProducto)
        {
            AccesoDatos datos = new AccesoDatos();
            Vouchers voucher = new Vouchers(); 

            try
            {
                datos.setearQuery("update vouchers set Estado=1,idCliente=@idCliente,IdProducto=@idProducto,FechaRegistro=GETDATE() where CodigoVoucher = '"+aux.codigo+"' ");
                datos.agregarParametro("@idProducto", idProducto);
                datos.agregarParametro("@idCliente", 1);
                datos.ejecutarLector();
            }
            catch (Exception ex)
            {

                throw ex;
            }
            finally
            {
                datos.cerrarConexion();
            }

        }
    }
}
