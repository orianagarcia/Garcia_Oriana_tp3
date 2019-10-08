using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Dominio1;

namespace Negocio1
{
    public class ProductoNegocio
    {
        public List<Producto> Listar()
        {
            List<Producto> lista = new List<Producto>();
            AccesoDatos datos = new AccesoDatos();
            Producto aux;
            try
            {
                datos.setearQuery("SELECT Id,Titulo,Descripcion,URLImagen  FROM [TP_WEB].[dbo].[Productos]");
                datos.ejecutarLector();

                while (datos.lector.Read())
                {
                    aux = new Producto();
                    aux.id = (long)datos.lector["id"];
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

