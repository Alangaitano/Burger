using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using dominio;
using System.Data.SqlClient;

namespace Negocio_
{
    public class Ingrediente_AcompañamientoConexion
    {
        public List<ingrediente_acompañamiento> DetalleAcompáñamiento(int seleccionado)
        {
            List<ingrediente_acompañamiento> lista = new List<ingrediente_acompañamiento>();
            SqlConnection conexion = new SqlConnection();
            SqlCommand comando = new SqlCommand();
            SqlDataReader lector;


            conexion.ConnectionString = "data source=DESKTOP-EFT94NQ; initial catalog=hamburgueseria; integrated security=sspi";
            comando.CommandType = System.Data.CommandType.Text;
            comando.CommandText = "select i.id_ingrediente idingrediente, a.id_acompañamiento idacompañamiento, " +
                "i.nombre nombre_ingrediente, a.nombre nombre_acompañamiento, cantidad " +
                "from ingrediente_acompañamiento ia " +
                "inner join ingrediente i on ia.id_ingrediente = i.id_ingrediente " +
                "inner join acompañamiento a on ia.id_acompañamiento = a.id_acompañamiento " +
                "where ia.id_acompañamiento = " + seleccionado + ";";
            comando.Connection = conexion;
            conexion.Open();

            lector = comando.ExecuteReader();

            while (lector.Read())
            {
                ingrediente_acompañamiento aux = new ingrediente_acompañamiento();
                aux.acompañamiento = new acompañamiento();
                aux.ingredientes = new ingredientes();
                aux.acompañamiento.nombre = lector["nombre_acompañamiento"].ToString();
                aux.ingredientes.nombre = lector["nombre_ingrediente"].ToString();
                aux.cantidad = lector["cantidad"] == DBNull.Value ? 0 : int.Parse(lector["cantidad"].ToString());
                aux.acompañamiento.id = int.Parse(lector["idacompañamiento"].ToString());
                aux.ingredientes.id = int.Parse(lector["idingrediente"].ToString());
                lista.Add(aux);
            }

            return lista;
        }
        //public List<ingrediente_acompañamiento> DetalleAcomp(acompañamiento seleccionado)
        //{
        //    List<ingrediente_acompañamiento> lista = new List<ingrediente_acompañamiento>();
        //    SqlConnection conexion = new SqlConnection();
        //    SqlCommand comando = new SqlCommand();
        //    SqlDataReader lector;


        //    conexion.ConnectionString = "data source=DESKTOP-EFT94NQ; initial catalog=hamburgueseria; integrated security=sspi";
        //    comando.CommandType = System.Data.CommandType.Text;
        //    comando.CommandText = "select i.nombre nombre_ingrediente, a.nombre nombre_acompañamiento, cantidad " +
        //        "from ingrediente_acompañamiento ia " +
        //        "inner join ingrediente i on ia.id_ingrediente = i.id_ingrediente " +
        //        "inner join acompañamiento a on ia.id_acompañamiento = a.id_acompañamiento " +
        //        "where ia.id_acompañamiento = " + seleccionado.id + ";";
        //    comando.Connection = conexion;
        //    conexion.Open();

        //    lector = comando.ExecuteReader();

        //    while (lector.Read())
        //    {
        //        ingrediente_acompañamiento aux = new ingrediente_acompañamiento();
        //        aux.acompañamiento = new acompañamiento();
        //        aux.ingredientes = new ingredientes();
        //        aux.acompañamiento.nombre = lector["nombre_acompañamiento"].ToString();
        //        aux.ingredientes.nombre = lector["nombre_ingrediente"].ToString();
        //        aux.cantidad = lector["cantidad"] == DBNull.Value ? 0 : int.Parse(lector["cantidad"].ToString());
        //        lista.Add(aux);
        //    }

        //    return lista;
        //}

        public void eliminar(int idingrediente, int idacompañamiento)
        {
            SqlConnection conexion = new SqlConnection();
            SqlCommand comando = new SqlCommand();
            conexion.ConnectionString = "data source=DESKTOP-EFT94NQ; initial catalog=hamburgueseria; integrated security=sspi";
            comando.Connection = conexion;
            comando.CommandType = System.Data.CommandType.Text;
            comando.CommandText = "DELETE FROM ingrediente_acompañamiento WHERE id_ingrediente = " + idingrediente + " and id_acompañamiento = " + idacompañamiento + ";";

            conexion.Open();
            comando.ExecuteNonQuery();
            conexion.Close();
        }

        public void agregar(int idingrediente, int idacompañamiento, int cantidad)
        {
            SqlConnection conexion = new SqlConnection();
            SqlCommand comando = new SqlCommand();
            conexion.ConnectionString = "data source=DESKTOP-EFT94NQ; initial catalog=hamburgueseria; integrated security=sspi";
            comando.Connection = conexion;
            comando.CommandType = System.Data.CommandType.Text;
            comando.CommandText = "insert into ingrediente_acompañamiento(id_acompañamiento,id_ingrediente,cantidad) " +
                "values (" + idacompañamiento + "," + idingrediente + "," + cantidad + ");";
            conexion.Open();
            comando.ExecuteNonQuery();
            conexion.Close();
        }
        public void modificar(int idingrediente, int idacompañamiento, int cantidad)
        {
            SqlConnection conexion = new SqlConnection();
            SqlCommand comando = new SqlCommand();
            conexion.ConnectionString = "data source=DESKTOP-EFT94NQ; initial catalog=hamburgueseria; integrated security=sspi";
            comando.Connection = conexion;
            comando.CommandType = System.Data.CommandType.Text;
            comando.CommandText = "update ingrediente_acompañamiento set cantidad = " + cantidad + " where id_acompañamiento = " + idacompañamiento + " and id_ingrediente = " + idingrediente + " ;";
            conexion.Open();
            comando.ExecuteNonQuery();
            conexion.Close();
        }
    }
}
