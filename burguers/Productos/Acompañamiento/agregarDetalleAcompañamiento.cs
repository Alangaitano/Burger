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
using dominio;
using Negocio_;

namespace burguers
{
    public partial class agregarDetalleAcompañamiento : Form
    {
        public int celda = 0;
        private int idacompañamiento;
        private List<ingrediente_acompañamiento> ingrediente_Acompañamientos;
        public agregarDetalleAcompañamiento()
        {
            InitializeComponent();
        }
        public agregarDetalleAcompañamiento(int idacompañamiento)
        {
            InitializeComponent();
            this.idacompañamiento = idacompañamiento;
        }
        public void sumar(TextBox textBox)
        {
            double ingrediente = Convert.ToDouble(textBox.Text);
            double suma = ingrediente + 1;
            textBox.Text = suma.ToString();
        }
        public void restar(TextBox textBox)
        {
            double ingrendiente = Convert.ToDouble(textBox.Text);
            double resta = ingrendiente - 1;
            if (resta < 0)
            {
                resta = 0;
            }
            textBox.Text = resta.ToString();
        }
        private void cargar()
        {
            int cantidad = 0;
            string nombreingrediente = "";
            cbxIngredientes.DisplayMember = "nombre";
            cbxIngredientes.ValueMember = "id";
            if (txtCantidad.Text == null)
            {
                txtCantidad.Text = "0";
            }
            else
            {
                txtCantidad.Text = cantidad.ToString();
            }
            SqlConnection conexion = new SqlConnection();
            conexion.ConnectionString = "data source=DESKTOP-EFT94NQ; initial catalog=hamburgueseria; integrated security=sspi";
            SqlCommand comando = new SqlCommand("SELECT * from Ingrediente", conexion);
            conexion.Open();
            SqlDataReader ingredientes = comando.ExecuteReader();
            while (ingredientes.Read())
            {
                cbxIngredientes.Items.Add(new ingredientes
                {
                    nombre = ingredientes["Nombre"].ToString(),
                    id = int.Parse(ingredientes["id_ingrediente"].ToString())
                });
            }
            conexion.Close();
            cbxIngredientes.Text = nombreingrediente;
        }
        public void cargaritem()
        {
            try
            {
                Ingrediente_AcompañamientoConexion conexion = new Ingrediente_AcompañamientoConexion();
                ingrediente_Acompañamientos = conexion.DetalleAcompáñamiento(idacompañamiento);
                foreach (var componente in ingrediente_Acompañamientos)
                {
                    int rowId = dgvdetalleacompañamiento.Rows.Add();

                    dgvdetalleacompañamiento.Rows[rowId].Cells[0].Value = componente.acompañamiento.nombre;
                    dgvdetalleacompañamiento.Rows[rowId].Cells[1].Value = componente.ingredientes.nombre;
                    dgvdetalleacompañamiento.Rows[rowId].Cells[2].Value = componente.cantidad;
                    dgvdetalleacompañamiento.Rows[rowId].Cells[3].Value = componente.acompañamiento.id;
                    dgvdetalleacompañamiento.Rows[rowId].Cells[4].Value = componente.ingredientes.id;

                }

            }
            catch (Exception ex)
            {
                MessageBox.Show("Hubo un error.." + ex.Message);
            }
        }
        private void agregarDetalleAcompañamiento_Load(object sender, EventArgs e)
        {
            cargar();
            cargaritem();
        }

        private void btnMas_Click(object sender, EventArgs e)
        {
            sumar(txtCantidad);
        }

        private void btnMenos_Click(object sender, EventArgs e)
        {
            restar(txtCantidad);
        }

        private void btnAceptar_Click(object sender, EventArgs e)
        {
            try
            {
                int idingrediente = ((ingredientes)cbxIngredientes.SelectedItem).id;
                int cantidad = int.Parse(txtCantidad.Text);
                int idacompañamiento = this.idacompañamiento;
                Ingrediente_AcompañamientoConexion conexion = new Ingrediente_AcompañamientoConexion();
                var listaingrediente = conexion.DetalleAcompáñamiento(idacompañamiento);
                if (listaingrediente.Any(i => i.ingredientes.id == idingrediente))
                {
                    conexion.modificar(idingrediente, idacompañamiento, cantidad);
                }
                else
                {
                    conexion.agregar(idingrediente, idacompañamiento, cantidad);
                }
                MessageBox.Show("Agregado correctamente..");
                dgvdetalleacompañamiento.Rows.Clear();
                cargaritem();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Hubo un error al intentar agregar..." + ex);
            }
        }

        private void btnBorrar_Click(object sender, EventArgs e)
        {
            try
            {
                if (celda != -1)
                {
                    int idingrediente = int.Parse(dgvdetalleacompañamiento.Rows[celda].Cells[4].Value.ToString());
                    int idacompañamiento = int.Parse(dgvdetalleacompañamiento.Rows[celda].Cells[3].Value.ToString());
                    Ingrediente_AcompañamientoConexion conexion = new Ingrediente_AcompañamientoConexion();
                    conexion.eliminar(idingrediente, idacompañamiento);
                    MessageBox.Show("Eliminado correctamente..");
                }
                else
                {
                    MessageBox.Show("Seleccione el ingrediente");
                }

            }
            catch (Exception ex)
            {
                MessageBox.Show("Hubo un error al intentar eliminar.. " + ex.Message);
            }
            finally
            {
                dgvdetalleacompañamiento.Rows.Clear();
                cargaritem();
            }
        }

        private void dgvdetalleacompañamiento_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            celda = e.RowIndex;
        }


    }
}
