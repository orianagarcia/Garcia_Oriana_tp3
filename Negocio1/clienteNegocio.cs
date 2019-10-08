using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Dominio1; 

namespace Negocio1
{
    public class clienteNegocio
    {
        public void Agregar(Cliente aux)
        {
            AccesoDatos datos = new AccesoDatos();

            try
            {
                datos.setearQuery("Insert into Clientes values (@dni, @nombre, @apellido, @email, @direccion, @ciudad, @cp, @fechaRegistro)");
                datos.Clear();
                datos.agregarParametro("@dni", aux.dni);
                datos.agregarParametro("@nombre", aux.nombre);
                datos.agregarParametro("@apellido", aux.apellido);
                datos.agregarParametro("@email", aux.email);
                datos.agregarParametro("@direccion", aux.direccion);
                datos.agregarParametro("@ciudad", aux.ciudad);
                datos.agregarParametro("@cp", aux.cp);
                datos.agregarParametro("@fechaRegistro", aux.fechaRegistro);
                datos.ejecutarAccion();

            }
            catch (Exception ex)
            {

                throw ex;
            }
            finally{
                datos.cerrarConexion();
            }

        }
    }
}
