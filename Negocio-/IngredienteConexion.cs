using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;
using dominio;
using System.Globalization;

namespace Negocio_
{
    public class IngredienteConexion
    {
        public List<ingredientes> listaIngredientes()
        {
            List<ingredientes> lista = new List<ingredientes>();
            SqlConnection conexion = new SqlConnection();
            SqlCommand comando = new SqlCommand();
            SqlDataReader lector;


            conexion.ConnectionString = "data source=DESKTOP-EFT94NQ; initial catalog=hamburgueseria; integrated security=sspi";
            comando.CommandType = System.Data.CommandType.Text;
            comando.CommandText = "select * from ingrediente where activo = 1";
            comando.Connection = conexion;
            conexion.Open();

            lector = comando.ExecuteReader();

            while (lector.Read())
            {
                ingredientes aux = new ingredientes();
                aux.id = int.Parse(lector["id_ingrediente"].ToString());
                aux.nombre = lector["nombre"].ToString();
                aux.precio = lector["precio"] == DBNull.Value ? 0 : int.Parse(lector["precio"].ToString());
                lista.Add(aux);
            }

            return lista;
        }
        public List<ingredientes> listaIngredientesdesac()
        {
            List<ingredientes> lista = new List<ingredientes>();
            SqlConnection conexion = new SqlConnection();
            SqlCommand comando = new SqlCommand();
            SqlDataReader lector;


            conexion.ConnectionString = "data source=DESKTOP-EFT94NQ; initial catalog=hamburgueseria; integrated security=sspi";
            comando.CommandType = System.Data.CommandType.Text;
            comando.CommandText = "select * from ingrediente where activo = 0";
            comando.Connection = conexion;
            conexion.Open();

            lector = comando.ExecuteReader();

            while (lector.Read())
            {
                ingredientes aux = new ingredientes();
                aux.id = int.Parse(lector["id_ingrediente"].ToString());
                aux.nombre = lector["nombre"].ToString();
                aux.precio = lector["precio"] == DBNull.Value ? 0 : int.Parse(lector["precio"].ToString());
                lista.Add(aux);
            }

            return lista;
        }
        public void modificar(ingredientes modificado)
        {
            SqlConnection conexion = new SqlConnection();
            SqlCommand comando = new SqlCommand();
            conexion.ConnectionString = "data source=DESKTOP-EFT94NQ; initial catalog=hamburgueseria; integrated security=sspi";
            comando.Connection = conexion;
            comando.CommandType = System.Data.CommandType.Text;
            string script = "UPDATE ingrediente SET nombre = '" + modificado.nombre + "', precio = " + modificado.precio + " where id_ingrediente = "+ modificado.id + ";";
            comando.CommandText = script;
            conexion.Open();
            comando.ExecuteNonQuery();
            conexion.Close();
        }

        public void agregar(ingredientes nuevo)
        {
            SqlConnection conexion = new SqlConnection();
            SqlCommand comando = new SqlCommand();
            conexion.ConnectionString = "data source=DESKTOP-EFT94NQ; initial catalog=hamburgueseria; integrated security=sspi";
            comando.Connection = conexion;
            comando.CommandType = System.Data.CommandType.Text;
            var formatInfo = new NumberFormatInfo { NumberDecimalSeparator = "." };
            string script = "INSERT INTO ingrediente VALUES ('" + nuevo.nombre + "' , " + nuevo.precio + ");";
            comando.CommandText = script;

            conexion.Open();
            comando.ExecuteNonQuery();
            conexion.Close();

        }
        public void eliminar(ingredientes seleccionado)
        {
            SqlConnection conexion = new SqlConnection();
            SqlCommand comando = new SqlCommand();
            conexion.ConnectionString = "data source=DESKTOP-EFT94NQ; initial catalog=hamburgueseria; integrated security=sspi";
            comando.Connection = conexion;
            comando.CommandType = System.Data.CommandType.Text;
            comando.CommandText = "update ingrediente set activo = 0 where id_ingrediente =" + seleccionado.id + ";";

            conexion.Open();
            comando.ExecuteNonQuery();
            conexion.Close();
        }
        public void activar(ingredientes seleccionado)
        {
            SqlConnection conexion = new SqlConnection();
            SqlCommand comando = new SqlCommand();
            conexion.ConnectionString = "data source=DESKTOP-EFT94NQ; initial catalog=hamburgueseria; integrated security=sspi";
            comando.Connection = conexion;
            comando.CommandType = System.Data.CommandType.Text;
            string script = "update ingrediente set activo = 1 where id_ingrediente =" + seleccionado.id + ";";
            comando.CommandText = script;

            conexion.Open();
            comando.ExecuteNonQuery();
            conexion.Close();

        }
    }
}
