using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Dominio;
using Negocio;


namespace Negocio
{
    public class ProductoNegocio
    {
        public List<Producto> Listar ()
        {
            List<Producto> lista = new List<Producto>();
            Producto aux;
            AccesoDatosNegocio datos = new AccesoDatosNegocio ();
            try
            {
                datos.setearQuery("select Id,nombre,descripcion,URLImagen from Productos");
                datos.ejecutarLector();

                while(datos.lector.Read())
                {
                    aux = new Producto();
                    aux.id = (int)datos.lector["id"];
                    aux.nombre = datos.lector.GetString(1);
                    aux.descripcion = datos.lector.GetString(2);
                    aux.urlImagen = datos.lector.GetString(3);
                    lista.Add(aux);

                }
                return lista;
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
