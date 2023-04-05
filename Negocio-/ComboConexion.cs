using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using dominio;
using System.Data.SqlClient;

namespace Negocio_
{
    public class ComboConexion
    {
        public List<combo> listaCombo()
        {
            List<combo> lista = new List<combo>();
            SqlConnection conexion = new SqlConnection();
            SqlCommand comando = new SqlCommand();
            SqlDataReader lector;


            conexion.ConnectionString = "data source=DESKTOP-EFT94NQ; initial catalog=hamburgueseria; integrated security=sspi";
            comando.CommandType = System.Data.CommandType.Text;
            comando.CommandText = "select * from combo where activo = 1";
            comando.Connection = conexion;
            conexion.Open();

            lector = comando.ExecuteReader();

            while (lector.Read())
            {
                combo aux = new combo();
                aux.detalle = new detalle_combo();
                aux.id = int.Parse(lector["id_combo"].ToString());
                aux.detalle.id = int.Parse(lector["detalle"].ToString());
                aux.nombre = lector["nombre"].ToString();
                aux.precio = obtenerPrecio(aux.detalle.id);
                lista.Add(aux);
            }

            return lista;
        }
        public List<combo> listaComboDesactivado()
        {
            List<combo> lista = new List<combo>();
            SqlConnection conexion = new SqlConnection();
            SqlCommand comando = new SqlCommand();
            SqlDataReader lector;


            conexion.ConnectionString = "data source=DESKTOP-EFT94NQ; initial catalog=hamburgueseria; integrated security=sspi";
            comando.CommandType = System.Data.CommandType.Text;
            comando.CommandText = "select * from combo where activo = 0";
            comando.Connection = conexion;
            conexion.Open();

            lector = comando.ExecuteReader();

            while (lector.Read())
            {
                combo aux = new combo();
                aux.detalle = new detalle_combo();
                aux.id = int.Parse(lector["id_combo"].ToString());
                aux.detalle.id = int.Parse(lector["detalle"].ToString());
                aux.nombre = lector["nombre"].ToString();
                aux.precio = obtenerPrecio(aux.detalle.id);
                lista.Add(aux);
            }

            return lista;
        }
        public float obtenerPrecio(int idcombo)
        {
            SqlConnection conexion = new SqlConnection();

            conexion.ConnectionString = "data source=DESKTOP-EFT94NQ; initial catalog=hamburgueseria; integrated security=sspi";
            conexion.Open();
            var comand = conexion.CreateCommand();
            comand.CommandType = System.Data.CommandType.Text;
            comand.CommandText = "select isnull(isnull(b.precio, 0) + (select sum(isnull(ia.cantidad,0) * i.precio) precio " +
                "from ingrediente_acompañamiento ia " +
                "inner join ingrediente i on i.id_ingrediente = ia.id_ingrediente " +
                "where ia.id_acompañamiento = dc.acompañamiento " +
                "group by ia.id_acompañamiento) +(select sum(isnull(ih.cantidad, 0) * isnull(i.precio, 0)) " +
                "from ingrediente_hamburguesa ih join ingrediente i on i.id_ingrediente = ih.id_ingrediente " +
                "where ih.id_hamburguesa = dc.hamburguesa " +
                "group by ih.id_hamburguesa),0) as PrecioCombo " +
                "from detalle_combo dc join bebida b on dc.bebida = b.id_bebida " +
                "join acompañamiento a on dc.acompañamiento = a.id_acompañamiento where dc.id_detalle = " + idcombo + ";";
            var values = comand.ExecuteScalar();
            return float.Parse(values.ToString());
        }
        public void eliminar(int id_combo)
        {
            SqlConnection conexion = new SqlConnection();
            SqlCommand comando = new SqlCommand();
            conexion.ConnectionString = "data source=DESKTOP-EFT94NQ; initial catalog=hamburgueseria; integrated security=sspi";
            comando.Connection = conexion;
            comando.CommandType = System.Data.CommandType.Text;
            comando.CommandText = "update combo set activo = 0 where id_combo = " + id_combo + ";";
            conexion.Open();
            comando.ExecuteNonQuery();
            conexion.Close();
        }
        public void activar(int seleccionado)
        {
            SqlConnection conexion = new SqlConnection();
            SqlCommand comando = new SqlCommand();
            conexion.ConnectionString = "data source=DESKTOP-EFT94NQ; initial catalog=hamburgueseria; integrated security=sspi";
            comando.Connection = conexion;
            comando.CommandType = System.Data.CommandType.Text;
            comando.CommandText = "update combo set activo = 1 where id_combo = " + seleccionado + ";";

            conexion.Open();
            comando.ExecuteNonQuery();
            conexion.Close();
        }
        public void modificar(int id, string nombre)
        {
            SqlConnection conexion = new SqlConnection();
            SqlCommand comando = new SqlCommand();
            conexion.ConnectionString = "data source=DESKTOP-EFT94NQ; initial catalog=hamburgueseria; integrated security=sspi";
            comando.Connection = conexion;
            comando.CommandType = System.Data.CommandType.Text;
            comando.CommandText = "update combo set nombre = '" + nombre + "'  where id_combo = " + id + ";";

            conexion.Open();
            comando.ExecuteNonQuery();
            conexion.Close();
        }
        public void agregar(int detalle, string nombre)
        {
            SqlConnection conexion = new SqlConnection();
            SqlCommand comando = new SqlCommand();
            conexion.ConnectionString = "data source=DESKTOP-EFT94NQ; initial catalog=hamburgueseria; integrated security=sspi";
            comando.Connection = conexion;
            comando.CommandType = System.Data.CommandType.Text;
            comando.CommandText = "insert into combo(detalle, nombre) values" +
                " (" + detalle + ",'" + nombre + "');";
            conexion.Open();
            comando.ExecuteNonQuery();
            conexion.Close();
        }
    }
}
