using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using dominio;
using System.Data.SqlClient;
using System.Globalization;
using System.Data;

namespace Negocio_
{
    public class HamburguesaConexion
    {
        public List<hamburguesa> listaHamburguesas()
        {
            List<hamburguesa> lista = new List<hamburguesa>();
            SqlConnection conexion = new SqlConnection();
            SqlCommand comando = new SqlCommand();
            SqlDataReader lector;


            conexion.ConnectionString = "data source=DESKTOP-EFT94NQ; initial catalog=hamburgueseria; integrated security=sspi";
            comando.CommandType = System.Data.CommandType.Text;
            comando.CommandText = "select * from hamburguesa where activo = 1";
            comando.Connection = conexion;
            conexion.Open();

            lector = comando.ExecuteReader();

            while (lector.Read())
            {
                hamburguesa aux = new hamburguesa();
                aux.id = int.Parse(lector["id_hamburguesa"].ToString());
                aux.nombre = lector["nombre"].ToString();
                aux.precio = obtenerPrecio(aux.id);
                lista.Add(aux);
            }

            return lista;
        }
        public float obtenerPrecio(int hamburguesaID)
        {
            SqlConnection conexion = new SqlConnection();

            conexion.ConnectionString = "data source=DESKTOP-EFT94NQ; initial catalog=hamburgueseria; integrated security=sspi";
            conexion.Open();
            var comand = conexion.CreateCommand();
            comand.CommandType = System.Data.CommandType.Text;
            comand.CommandText = "select sum(isnull(ih.cantidad,0) * i.precio) precio " +
                "from ingrediente_hamburguesa ih " +
                "inner join ingrediente i on i.id_ingrediente = ih.id_ingrediente " +
                "where ih.id_hamburguesa = " + hamburguesaID + " " +
                "group by ih.id_hamburguesa";
            var values = comand.ExecuteScalar();
            return float.Parse(values.ToString());
        }
        public List<hamburguesa> listaHamburguesasDest()
        {
            List<hamburguesa> lista = new List<hamburguesa>();
            SqlConnection conexion = new SqlConnection();
            SqlCommand comando = new SqlCommand();
            SqlDataReader lector;


            conexion.ConnectionString = "data source=DESKTOP-EFT94NQ; initial catalog=hamburgueseria; integrated security=sspi";
            comando.CommandType = System.Data.CommandType.Text;
            comando.CommandText = "select * from hamburguesa where activo = 0";
            comando.Connection = conexion;
            conexion.Open();

            lector = comando.ExecuteReader();

            while (lector.Read())
            {
                hamburguesa aux = new hamburguesa();
                aux.id = lector.GetInt32(0);
                aux.nombre = lector.GetString(1);
                lista.Add(aux);
            }

            return lista;
        }
        public void modificar(hamburguesa modificado)
        {
            SqlConnection conexion = new SqlConnection();
            SqlCommand comando = new SqlCommand();
            conexion.ConnectionString = "data source=DESKTOP-EFT94NQ; initial catalog=hamburgueseria; integrated security=sspi";
            comando.Connection = conexion;
            comando.CommandType = System.Data.CommandType.Text;
            var formatInfo = new NumberFormatInfo { NumberDecimalSeparator = "." };
            string script = string.Format(formatInfo, "UPDATE hamburguesa SET nombre = '{0}' where id_hamburguesa = {1};", modificado.nombre, modificado.id);
            comando.CommandText = script;
            conexion.Open();
            comando.ExecuteNonQuery();
            conexion.Close();
        }
        //public void agregar(hamburguesa nuevo)
        //{
        //    SqlConnection conexion = new SqlConnection();
        //    SqlCommand comando = new SqlCommand();
        //    conexion.ConnectionString = "data source=DESKTOP-EFT94NQ; initial catalog=hamburgueseria; integrated security=sspi";
        //    comando.Connection = conexion;
        //    comando.CommandType = System.Data.CommandType.Text;
        //    var formatInfo = new NumberFormatInfo { NumberDecimalSeparator = "." };
        //    string script = string.Format(formatInfo, "INSERT INTO hamburguesa (nombre) VALUES ('{0}')", nuevo.nombre);
        //    comando.CommandText = script;

        //    conexion.Open();
        //    comando.ExecuteNonQuery();
        //    conexion.Close();

        //}
        public object agregar(string nuevo)
        {
            SqlConnection conexion = new SqlConnection();
            SqlCommand comando = new SqlCommand();
            conexion.ConnectionString = "data source=DESKTOP-EFT94NQ; initial catalog=hamburgueseria; integrated security=sspi";
            comando.Connection = conexion;
            comando.CommandType = System.Data.CommandType.Text;
            string script = "INSERT INTO hamburguesa (nombre) VALUES ('"+ nuevo + "');select SCOPE_IDENTITY()";
            comando.CommandText = script;

            conexion.Open();
            object idhamburguesa;
            idhamburguesa = comando.ExecuteScalar();
            conexion.Close();
            return idhamburguesa;

        }
        public void eliminar(hamburguesa seleccionado)
        {
            SqlConnection conexion = new SqlConnection();
            SqlCommand comando = new SqlCommand();
            conexion.ConnectionString = "data source=DESKTOP-EFT94NQ; initial catalog=hamburgueseria; integrated security=sspi";
            comando.Connection = conexion;
            comando.CommandType = System.Data.CommandType.Text;
            comando.CommandText = "update hamburguesa set activo = 0 where id_hamburguesa = " + seleccionado.id + ";";

            conexion.Open();
            comando.ExecuteNonQuery();
            conexion.Close();
        }
        public void activar(hamburguesa seleccionado)
        {
            SqlConnection conexion = new SqlConnection();
            SqlCommand comando = new SqlCommand();
            conexion.ConnectionString = "data source=DESKTOP-EFT94NQ; initial catalog=hamburgueseria; integrated security=sspi";
            comando.Connection = conexion;
            comando.CommandType = System.Data.CommandType.Text;
            comando.CommandText = "update hamburguesa set activo = 1 where id_hamburguesa = " + seleccionado.id + ";";

            conexion.Open();
            comando.ExecuteNonQuery();
            conexion.Close();
        }
    }
}
