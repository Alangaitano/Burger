using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;
using Negocio_;
using dominio;

namespace burguers
{
    public partial class AgregarDetalleCombo : Form
    {
        private int seleccionado = -1;
        public AgregarDetalleCombo()
        {
            InitializeComponent();
        }
        public AgregarDetalleCombo(int seleccionado)
        {
            InitializeComponent();
            this.seleccionado = seleccionado;
        }
        private void cargarhamburguesa()
        {
            cbxHamburguesas.DisplayMember = "nombre";
            cbxHamburguesas.ValueMember = "id";
            SqlConnection conexion = new SqlConnection();
            conexion.ConnectionString = "data source=DESKTOP-EFT94NQ; initial catalog=hamburgueseria; integrated security=sspi";
            SqlCommand comando = new SqlCommand("SELECT * from hamburguesa", conexion);
            conexion.Open();
            SqlDataReader hamburguesa = comando.ExecuteReader();
            while (hamburguesa.Read())
            {
                cbxHamburguesas.Items.Add(new hamburguesa
                {
                    nombre = hamburguesa["Nombre"].ToString(),
                    id = int.Parse(hamburguesa["id_hamburguesa"].ToString())
                });
            }
            conexion.Close();
        }

        private void cargaracompañamiento()
        {
            cbxAcompañamientos.DisplayMember = "nombre";
            cbxAcompañamientos.ValueMember = "id";
            SqlConnection conexion = new SqlConnection();
            conexion.ConnectionString = "data source=DESKTOP-EFT94NQ; initial catalog=hamburgueseria; integrated security=sspi";
            SqlCommand comando = new SqlCommand("SELECT * from acompañamiento", conexion);
            conexion.Open();
            SqlDataReader acompañamiento = comando.ExecuteReader();
            while (acompañamiento.Read())
            {
                cbxAcompañamientos.Items.Add(new acompañamiento
                {
                    nombre = acompañamiento["Nombre"].ToString(),
                    id = int.Parse(acompañamiento["id_acompañamiento"].ToString())
                });
            }
            conexion.Close();
        }
        private void cargarbebidas()
        {
            cbxBebidas.DisplayMember = "nombre";
            cbxBebidas.ValueMember = "id";
            SqlConnection conexion = new SqlConnection();
            conexion.ConnectionString = "data source=DESKTOP-EFT94NQ; initial catalog=hamburgueseria; integrated security=sspi";
            SqlCommand comando = new SqlCommand("SELECT * from bebida where activo = 1", conexion);
            conexion.Open();
            SqlDataReader bebidas = comando.ExecuteReader();
            while (bebidas.Read())
            {
                cbxBebidas.Items.Add(new bebida
                {
                    nombre = bebidas["Nombre"].ToString(),
                    id = int.Parse(bebidas["id_bebida"].ToString())
                });
            }
            conexion.Close();
        }
        private void AgregarDetalleCombo_Load(object sender, EventArgs e)
        {
            cargarhamburguesa();
            cargaracompañamiento();
            cargarbebidas();
        }

        private void btnAceptar_Click(object sender, EventArgs e)
        {
            detallleComboConexion conexion = new detallleComboConexion();
            int id_hamburguesa = ((hamburguesa)cbxHamburguesas.SelectedItem).id;
            int id_bebida = ((bebida)cbxBebidas.SelectedItem).id;
            int id_acompañamiento = ((acompañamiento)cbxAcompañamientos.SelectedItem).id;
            if (seleccionado >= 0)
            {
                conexion.modificar(seleccionado, id_hamburguesa, id_bebida, id_acompañamiento);
                MessageBox.Show("modificado correctamente....");
                Close();
            }
            else
            {
                int id_detalle = int.Parse(conexion.agregar(id_bebida, id_acompañamiento, id_hamburguesa).ToString());
                AgregarCombo combo = new AgregarCombo(id_detalle);
                combo.ShowDialog();
            }
        }
    }
}
