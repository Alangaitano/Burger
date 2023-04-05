using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Globalization;
using dominio;

namespace Negocio
{
    public class EmpleadoConexion
    {
        public List<empleado> listaEmpleado()
        {
            List<empleado> lista = new List<empleado>();
            SqlConnection conexion = new SqlConnection();
            SqlCommand comando = new SqlCommand();
            SqlDataReader lector;


            conexion.ConnectionString = "data source=DESKTOP-EFT94NQ; initial catalog=hamburgueseria; integrated security=sspi";
            comando.CommandType = System.Data.CommandType.Text;
            comando.CommandText = "select * from empleado";
            comando.Connection = conexion;
            conexion.Open();

            lector = comando.ExecuteReader();

            while (lector.Read())
            {
                empleado aux = new empleado();
                aux.id = lector.GetInt32(0);
                aux.nombre = lector.GetString(1);
                aux.apellido = lector.GetString(2);
                aux.telefono = lector.GetInt32(3);
                aux.email = lector.GetString(4);

                lista.Add(aux);

            }

            return lista;
        }
        public void modificar(empleado modificado)
        {
            SqlConnection conexion = new SqlConnection();
            SqlCommand comando = new SqlCommand();
            conexion.ConnectionString = "data source=DESKTOP-EFT94NQ; initial catalog=hamburgueseria; integrated security=sspi";
            comando.Connection = conexion;
            comando.CommandType = System.Data.CommandType.Text;
            var formatInfo = new NumberFormatInfo { NumberDecimalSeparator = "." };
            string script = string.Format(formatInfo, "UPDATE empleado SET nombre = '{0}', apellido = '{1}', telefono = {2},  mail = '{3}' where id_empleado = {4};", modificado.nombre, modificado.apellido, modificado.telefono, modificado.email, modificado.id);
            comando.CommandText = script;
            conexion.Open();
            comando.ExecuteNonQuery();
            conexion.Close();
        }

        public void agregar(empleado nuevo)
        {
            SqlConnection conexion = new SqlConnection();
            SqlCommand comando = new SqlCommand();
            conexion.ConnectionString = "data source=DESKTOP-EFT94NQ; initial catalog=hamburgueseria; integrated security=sspi";
            comando.Connection = conexion;
            comando.CommandType = System.Data.CommandType.Text;
            var formatInfo = new NumberFormatInfo { NumberDecimalSeparator = "." };
            string script = string.Format(formatInfo, "INSERT INTO empleado VALUES ('{0}', '{1}', {2}, '{3}')", nuevo.nombre, nuevo.apellido, nuevo.telefono, nuevo.email);
            comando.CommandText = script;

            conexion.Open();
            comando.ExecuteNonQuery();
            conexion.Close();

        }
        public void eliminar(empleado seleccionado)
        {
            SqlConnection conexion = new SqlConnection();
            SqlCommand comando = new SqlCommand();
            conexion.ConnectionString = "data source=DESKTOP-EFT94NQ; initial catalog=hamburgueseria; integrated security=sspi";
            comando.Connection = conexion;
            comando.CommandType = System.Data.CommandType.Text;
            comando.CommandText = "DELETE FROM empleado WHERE id_empleado = " + seleccionado.id + ";";

            conexion.Open();
            comando.ExecuteNonQuery();
            conexion.Close();
        }
    }
}
