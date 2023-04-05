using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using dominio;
using System.Data.SqlClient;

namespace Negocio_
{
    public class Ingrediente_HamburguesaConexion
    {
        public List<ingrediente_hamburguesa> DetalleHamburguesa(int id_hamburguesa)
        {
            List<ingrediente_hamburguesa> lista = new List<ingrediente_hamburguesa>();
            SqlConnection conexion = new SqlConnection();
            SqlCommand comando = new SqlCommand();
            SqlDataReader lector;


            conexion.ConnectionString = "data source=DESKTOP-EFT94NQ; initial catalog=hamburgueseria; integrated security=sspi";
            comando.CommandType = System.Data.CommandType.Text;
            comando.CommandText = "select ingrediente_hamburguesa.id_ingrediente as idingrediente , ingrediente_hamburguesa.id_hamburguesa as idhamburguesa," +
                " hamburguesa.nombre as nombre_hamburguesa, ingrediente.nombre as nombre_ingrediente, cantidad " +
                "from ingrediente_hamburguesa " +
                " inner join ingrediente on ingrediente_hamburguesa.id_ingrediente = ingrediente.id_ingrediente" +
                " inner join hamburguesa on ingrediente_hamburguesa.id_hamburguesa = hamburguesa.id_hamburguesa " +
                "where hamburguesa.id_hamburguesa = " + id_hamburguesa + "; " ;
            comando.Connection = conexion;
            conexion.Open();

            lector = comando.ExecuteReader();

            while (lector.Read())
            {
                ingrediente_hamburguesa aux = new ingrediente_hamburguesa();
                aux.hamburguesas = new hamburguesa();
                aux.ingredientes = new ingredientes();
                aux.id_hamburguesa = int.Parse(lector["idhamburguesa"].ToString());
                aux.id_ingrediente = int.Parse(lector["idingrediente"].ToString());
                aux.hamburguesas.nombre = lector["nombre_hamburguesa"].ToString();
                aux.ingredientes.nombre = lector["nombre_ingrediente"].ToString();
                aux.cantidad = lector["cantidad"] == DBNull.Value ? 0 : int.Parse(lector["cantidad"].ToString());
                lista.Add(aux);
            }

            return lista;
        }

        public void eliminar(int idingrediente, int idhamburguesa)
        {
            SqlConnection conexion = new SqlConnection();
            SqlCommand comando = new SqlCommand();
            conexion.ConnectionString = "data source=DESKTOP-EFT94NQ; initial catalog=hamburgueseria; integrated security=sspi";
            comando.Connection = conexion;
            comando.CommandType = System.Data.CommandType.Text;
            comando.CommandText = "DELETE FROM ingrediente_hamburguesa WHERE id_ingrediente = " + idingrediente + " and id_hamburguesa = " + idhamburguesa + ";";

            conexion.Open();
            comando.ExecuteNonQuery();
            conexion.Close();
        }

        public void agregar(int idingrediente, int idhamburguesa, int cantidad)
        {
            SqlConnection conexion = new SqlConnection();
            SqlCommand comando = new SqlCommand();
            conexion.ConnectionString = "data source=DESKTOP-EFT94NQ; initial catalog=hamburgueseria; integrated security=sspi";
            comando.Connection = conexion;
            comando.CommandType = System.Data.CommandType.Text;
            comando.CommandText = "insert into ingrediente_hamburguesa(id_hamburguesa,id_ingrediente,cantidad) " +
                "values ("+ idhamburguesa + ","+ idingrediente +","+ cantidad +");";
            conexion.Open();
            comando.ExecuteNonQuery();
            conexion.Close();
        }
        public void modificar(int idingrediente, int idhamburguesa, int cantidad)
        {
            SqlConnection conexion = new SqlConnection();
            SqlCommand comando = new SqlCommand();
            conexion.ConnectionString = "data source=DESKTOP-EFT94NQ; initial catalog=hamburgueseria; integrated security=sspi";
            comando.Connection = conexion;
            comando.CommandType = System.Data.CommandType.Text;
            comando.CommandText = "update ingrediente_hamburguesa set cantidad = "+ cantidad +" where id_hamburguesa = "+ idhamburguesa +" and id_ingrediente = "+ idingrediente +" ;";
            conexion.Open();
            comando.ExecuteNonQuery();
            conexion.Close();
        }
    }
}
