using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using dominio;
using System.Data.SqlClient;

namespace Negocio_
{
    public class detallleComboConexion
    {
        public List<detalle_combo> DetalleCombo(int seleccionado)
        {
            List<detalle_combo> lista = new List<detalle_combo>();
            SqlConnection conexion = new SqlConnection();
            SqlCommand comando = new SqlCommand();
            SqlDataReader lector;


            conexion.ConnectionString = "data source=DESKTOP-EFT94NQ; initial catalog=hamburgueseria; integrated security=sspi";
            comando.CommandType = System.Data.CommandType.Text;
            comando.CommandText = "select id_detalle, bebida.nombre as bebida, acompañamiento.nombre as acompañamiento, hamburguesa.nombre as hamburguesa from detalle_combo" +
                " inner join bebida on bebida.id_bebida = detalle_combo.bebida" +
                " inner join acompañamiento on acompañamiento.id_acompañamiento = detalle_combo.acompañamiento" +
                " inner join hamburguesa on hamburguesa.id_hamburguesa = detalle_combo.hamburguesa where id_detalle = " + seleccionado + ";";
            comando.Connection = conexion;
            conexion.Open();

            lector = comando.ExecuteReader();

            while (lector.Read())
            {
                detalle_combo aux = new detalle_combo();
                aux.bebida = new bebida();
                aux.Acompañamiento = new acompañamiento();
                aux.hamburguesa = new hamburguesa();
                aux.id = int.Parse(lector["id_detalle"].ToString());
                aux.bebida.nombre = lector["bebida"].ToString();
                aux.Acompañamiento.nombre = lector["acompañamiento"].ToString();
                aux.hamburguesa.nombre = lector["hamburguesa"].ToString();
                lista.Add(aux);
            }
            return lista;
        }
        public object agregar(int bebida, int acompañamiento, int hamburguesa)
        {
            SqlConnection conexion = new SqlConnection();
            SqlCommand comando = new SqlCommand();
            conexion.ConnectionString = "data source=DESKTOP-EFT94NQ; initial catalog=hamburgueseria; integrated security=sspi";
            comando.Connection = conexion;
            comando.CommandType = System.Data.CommandType.Text;
            comando.CommandText = "insert into detalle_combo (bebida, acompañamiento, hamburguesa) values" +
                " (" + bebida + "," + acompañamiento + "," + hamburguesa + "); select SCOPE_IDENTITY()";
            conexion.Open();
            object id_Detalle;
            id_Detalle = comando.ExecuteScalar();
            comando.ExecuteNonQuery();
            conexion.Close();
            return id_Detalle;
        }
        public void modificar(int modificado ,int idhamburguesa, int idbebida, int idacompañamiento)
        {
            SqlConnection conexion = new SqlConnection();
            SqlCommand comando = new SqlCommand();
            conexion.ConnectionString = "data source=DESKTOP-EFT94NQ; initial catalog=hamburgueseria; integrated security=sspi";
            comando.Connection = conexion;
            comando.CommandType = System.Data.CommandType.Text;
            string script = "UPDATE detalle_combo SET hamburguesa = "+idhamburguesa+", bebida = "+idbebida+" , acompañamiento = "+idacompañamiento+" where id_detalle = "+ modificado +";";
            comando.CommandText = script;
            conexion.Open();
            comando.ExecuteNonQuery();
            conexion.Close();
        }
    }
}
