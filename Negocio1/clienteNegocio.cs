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

        public Cliente Buscar(int dniBuscado)
        {
            AccesoDatos datos = new AccesoDatos();
            Cliente aux = new Cliente();
            
            try
            {
                datos.setearQuery("select id,dni,nombre,apellido,email,direccion,ciudad,codigopostal from clientes where dni="+dniBuscado+"");
                datos.ejecutarLector();
                while (datos.lector.Read())
                {
                    aux.id = (long)datos.lector["id"];
                    aux.dni = datos.lector.GetInt32(1);
                    aux.nombre = datos.lector.GetString(2);
                    aux.apellido = datos.lector.GetString(3);
                    aux.email = datos.lector.GetString(4);
                    aux.direccion = datos.lector.GetString(5);
                    aux.ciudad = datos.lector.GetString(6);
                    aux.cp = datos.lector.GetString(7);
                    
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
    }
}
