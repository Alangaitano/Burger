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
    public class AcompañamientoConexion
    {
        public List<acompañamiento> listaAcompañamiento()
        {
            List<acompañamiento> lista = new List<acompañamiento>();
            SqlConnection conexion = new SqlConnection();
            SqlCommand comando = new SqlCommand();
            SqlDataReader lector;


            conexion.ConnectionString = "data source=DESKTOP-EFT94NQ; initial catalog=hamburgueseria; integrated security=sspi";
            comando.CommandType = System.Data.CommandType.Text;
            comando.CommandText = "select * from acompañamiento where activo = 1";
            comando.Connection = conexion;
            conexion.Open();

            lector = comando.ExecuteReader();

            while (lector.Read())
            {
                acompañamiento aux = new acompañamiento();
                aux.id = int.Parse(lector["id_acompañamiento"].ToString());
                aux.nombre = lector["nombre"].ToString();
                aux.precio = obtenerPrecio(aux.id);
                aux.recargo = lector["recargo"] == DBNull.Value ? 0 : int.Parse(lector["recargo"].ToString());
                lista.Add(aux);
            }

            return lista;
        }
        public List<acompañamiento> listaAcompañamientodesc()
        {
            List<acompañamiento> lista = new List<acompañamiento>();
            SqlConnection conexion = new SqlConnection();
            SqlCommand comando = new SqlCommand();
            SqlDataReader lector;


            conexion.ConnectionString = "data source=DESKTOP-EFT94NQ; initial catalog=hamburgueseria; integrated security=sspi";
            comando.CommandType = System.Data.CommandType.Text;
            comando.CommandText = "select * from acompañamiento where activo = 0";
            comando.Connection = conexion;
            conexion.Open();

            lector = comando.ExecuteReader();

            while (lector.Read())
            {
                acompañamiento aux = new acompañamiento();
                aux.id = int.Parse(lector["id_acompañamiento"].ToString());
                aux.nombre = lector["nombre"].ToString();
                aux.precio = obtenerPrecio(aux.id);
                aux.recargo = lector["recargo"] == DBNull.Value ? 0 : int.Parse(lector["recargo"].ToString());
                lista.Add(aux);
            }

            return lista;
        }
        public float obtenerPrecio(int acompañamientoid)
        {
            SqlConnection conexion = new SqlConnection();

            conexion.ConnectionString = "data source=DESKTOP-EFT94NQ; initial catalog=hamburgueseria; integrated security=sspi";
            conexion.Open();
            var comand = conexion.CreateCommand();
            comand.CommandType = System.Data.CommandType.Text;
            comand.CommandText = "select sum(isnull(ia.cantidad,0) * i.precio) precio " +
                "from ingrediente_acompañamiento ia " +
                "inner join ingrediente i on i.id_ingrediente = ia.id_ingrediente " +
                "where ia.id_acompañamiento = "+ acompañamientoid +" " +
                "group by ia.id_acompañamiento";
            var values = comand.ExecuteScalar();
            if (values == null)
            {
                values = 0;
            }
            return float.Parse(values.ToString());
        }
        public void modificar(acompañamiento modificado)
        {
            SqlConnection conexion = new SqlConnection();
            SqlCommand comando = new SqlCommand();
            conexion.ConnectionString = "data source=DESKTOP-EFT94NQ; initial catalog=hamburgueseria; integrated security=sspi";
            comando.Connection = conexion;
            comando.CommandType = System.Data.CommandType.Text;
            string script = "UPDATE acompañamiento SET nombre = '"+ modificado.nombre +"', " +
                "recargo = " + modificado.recargo +" where id_acompañamiento = "+ modificado.id +";";
            comando.CommandText = script;
            conexion.Open();
            comando.ExecuteNonQuery();
            conexion.Close();
        }

        public object Agregar(string nombre, int recargo)
        {
            SqlConnection conexion = new SqlConnection();
            SqlCommand comando = new SqlCommand();
            conexion.ConnectionString = "data source=DESKTOP-EFT94NQ; initial catalog=hamburgueseria; integrated security=sspi";
            comando.Connection = conexion;
            comando.CommandType = System.Data.CommandType.Text;
            string script = "INSERT INTO acompañamiento (nombre,recargo) VALUES ('" + nombre + "', " + recargo + "); select SCOPE_IDENTITY()";
            comando.CommandText = script;

            conexion.Open();
            object idacompañamiento;
            idacompañamiento = comando.ExecuteScalar();
            conexion.Close();
            return idacompañamiento;
        }
        public void desactivar(acompañamiento seleccionado)
        {
            SqlConnection conexion = new SqlConnection();
            SqlCommand comando = new SqlCommand();
            conexion.ConnectionString = "data source=DESKTOP-EFT94NQ; initial catalog=hamburgueseria; integrated security=sspi";
            comando.Connection = conexion;
            comando.CommandType = System.Data.CommandType.Text;
            string script = "UPDATE acompañamiento SET activo = 0 where id_acompañamiento = " + seleccionado.id + ";";
            comando.CommandText = script;

            conexion.Open();
            comando.ExecuteNonQuery();
            conexion.Close();
        }
        public void activar(acompañamiento seleccionado)
        {
            SqlConnection conexion = new SqlConnection();
            SqlCommand comando = new SqlCommand();
            conexion.ConnectionString = "data source=DESKTOP-EFT94NQ; initial catalog=hamburgueseria; integrated security=sspi";
            comando.Connection = conexion;
            comando.CommandType = System.Data.CommandType.Text;
            string script = "UPDATE acompañamiento SET activo = 1 where id_acompañamiento = " + seleccionado.id + ";";
            comando.CommandText = script;

            conexion.Open();
            comando.ExecuteNonQuery();
            conexion.Close();
        }
    }
}
