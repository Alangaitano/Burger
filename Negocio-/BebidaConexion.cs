using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using dominio;
using System.Data.SqlClient;
using System.Globalization;

namespace Negocio_
{
    public class BebidaConexion
    {
        public List<bebida> listaBebidas()
        {
            List<bebida> lista = new List<bebida>();
            SqlConnection conexion = new SqlConnection();
            SqlCommand comando = new SqlCommand();
            SqlDataReader lector;


            conexion.ConnectionString = "data source=DESKTOP-EFT94NQ; initial catalog=hamburgueseria; integrated security=sspi";
            comando.CommandType = System.Data.CommandType.Text;
            comando.CommandText = "select * from bebida where activo = 1";
            comando.Connection = conexion;
            conexion.Open();

            lector = comando.ExecuteReader();

            while (lector.Read())
            {
                bebida aux = new bebida();
                aux.id = int.Parse(lector["id_bebida"].ToString());
                aux.nombre = lector["nombre"].ToString();
                aux.precio = lector["precio"] == DBNull.Value ? 0 : int.Parse(lector["precio"].ToString());
                aux.recargo = lector["recargo"] == DBNull.Value ? 0 : int.Parse(lector["recargo"].ToString());
                lista.Add(aux);
            }

            return lista;
        }
        public List<bebida> listaBebidasDesac()
        {
            List<bebida> lista = new List<bebida>();
            SqlConnection conexion = new SqlConnection();
            SqlCommand comando = new SqlCommand();
            SqlDataReader lector;


            conexion.ConnectionString = "data source=DESKTOP-EFT94NQ; initial catalog=hamburgueseria; integrated security=sspi";
            comando.CommandType = System.Data.CommandType.Text;
            comando.CommandText = "select * from bebida where activo = 0";
            comando.Connection = conexion;
            conexion.Open();

            lector = comando.ExecuteReader();

            while (lector.Read())
            {
                bebida aux = new bebida();
                aux.id = int.Parse(lector["id_bebida"].ToString());
                aux.nombre = lector["nombre"].ToString();
                aux.precio = lector["precio"] == DBNull.Value ? 0 : int.Parse(lector["precio"].ToString());
                aux.recargo = lector["recargo"] == DBNull.Value ? 0 : int.Parse(lector["recargo"].ToString());
                lista.Add(aux);
            }

            return lista;
        }
        public void modificar(bebida modificado)
        {
            SqlConnection conexion = new SqlConnection();
            SqlCommand comando = new SqlCommand();
            conexion.ConnectionString = "data source=DESKTOP-EFT94NQ; initial catalog=hamburgueseria; integrated security=sspi";
            comando.Connection = conexion;
            comando.CommandType = System.Data.CommandType.Text;
            string script = "UPDATE bebida SET nombre = '"+modificado.nombre+"', precio = "+modificado.precio+", recargo = "+modificado.recargo+" where id_bebida = "+ modificado.id +";";
            comando.CommandText = script;
            conexion.Open();
            comando.ExecuteNonQuery();
            conexion.Close();
        }
        public void activar(bebida seleccionado)
        {
            SqlConnection conexion = new SqlConnection();
            SqlCommand comando = new SqlCommand();
            conexion.ConnectionString = "data source=DESKTOP-EFT94NQ; initial catalog=hamburgueseria; integrated security=sspi";
            comando.Connection = conexion;
            comando.CommandType = System.Data.CommandType.Text;
            string script = "UPDATE bebida SET activo = 1 where id_bebida = " + seleccionado.id + ";";
            comando.CommandText = script;
            conexion.Open();
            comando.ExecuteNonQuery();
            conexion.Close();
        }

        public void agregar(bebida nuevo)
        {
            SqlConnection conexion = new SqlConnection();
            SqlCommand comando = new SqlCommand();
            conexion.ConnectionString = "data source=DESKTOP-EFT94NQ; initial catalog=hamburgueseria; integrated security=sspi";
            comando.Connection = conexion;
            comando.CommandType = System.Data.CommandType.Text;
            string script = "INSERT INTO bebida VALUES ('"+ nuevo.nombre +"' , "+ nuevo.precio +", "+ nuevo.recargo +")";
            comando.CommandText = script;

            conexion.Open();
            comando.ExecuteNonQuery();
            conexion.Close();

        }
        public void eliminar(bebida seleccionado)
        {
            SqlConnection conexion = new SqlConnection();
            SqlCommand comando = new SqlCommand();
            conexion.ConnectionString = "data source=DESKTOP-EFT94NQ; initial catalog=hamburgueseria; integrated security=sspi";
            comando.Connection = conexion;
            comando.CommandType = System.Data.CommandType.Text;
            string script = "UPDATE bebida SET activo = 0 where id_bebida = " + seleccionado.id + ";";
            comando.CommandText = script;
            conexion.Open();
            comando.ExecuteNonQuery();
            conexion.Close();
        }
    }
}
