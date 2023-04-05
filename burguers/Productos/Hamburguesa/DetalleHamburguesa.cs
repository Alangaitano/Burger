using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using dominio;
using Negocio_;
using System.Data.SqlClient;

namespace burguers
{
    public partial class DetalleHamburguesa : Form
    {
        public int celda = 0;
        private List<ingrediente_hamburguesa> ingrediente_Hamburguesas;
        private int idhamburguesa = 0;
        public DetalleHamburguesa()
        {
            InitializeComponent();
        }

        public DetalleHamburguesa(int id_hamburguesa)
        {
            InitializeComponent();
            this.idhamburguesa = id_hamburguesa;
        }
        public void cargaritem()
        {
            try
            {
                Ingrediente_HamburguesaConexion conexion = new Ingrediente_HamburguesaConexion();
                ingrediente_Hamburguesas = conexion.DetalleHamburguesa(idhamburguesa);
                foreach (var componente in ingrediente_Hamburguesas)
                {
                    int rowId = dgvDetalleHamburguesa.Rows.Add();

                    dgvDetalleHamburguesa.Rows[rowId].Cells[0].Value = componente.hamburguesas.nombre;
                    dgvDetalleHamburguesa.Rows[rowId].Cells[1].Value = componente.ingredientes.nombre;
                    dgvDetalleHamburguesa.Rows[rowId].Cells[2].Value = componente.cantidad;
                    dgvDetalleHamburguesa.Rows[rowId].Cells[3].Value = componente.id_hamburguesa;
                    dgvDetalleHamburguesa.Rows[rowId].Cells[4].Value = componente.id_ingrediente;

                }

            }
            catch (Exception ex)
            {
                MessageBox.Show("Hubo un error.." + ex.Message);
            }
        }

        private void DetalleHamburguesa_Load(object sender, EventArgs e)
        {
            cargaritem();
            cargarcbx();
        }
        private void cargarcbx()
        {
            int cantidad = 0;
            string nombreingrediente = "";
            cbxIngrediente.DisplayMember = "nombre";
            cbxIngrediente.ValueMember = "id";
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
                cbxIngrediente.Items.Add(new ingredientes
                {
                    nombre = ingredientes["Nombre"].ToString(),
                    id = int.Parse(ingredientes["id_ingrediente"].ToString())
                });
            }
            conexion.Close();
            cbxIngrediente.Text = nombreingrediente;
        }

        private void btnEliminar_Click(object sender, EventArgs e)
        {
            try
            {
                if (celda != -1)
                {
                    int idingrediente = int.Parse(dgvDetalleHamburguesa.Rows[celda].Cells[4].Value.ToString());
                    int idhamburguesa = int.Parse(dgvDetalleHamburguesa.Rows[celda].Cells[3].Value.ToString());
                    Ingrediente_HamburguesaConexion conexion = new Ingrediente_HamburguesaConexion();
                    conexion.eliminar(idingrediente,idhamburguesa);
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
                dgvDetalleHamburguesa.Rows.Clear();
                cargaritem();
            }
        }

        private void dgvdetallehamburguesa_cellClick(object sender, DataGridViewCellEventArgs e)
        {
            celda = e.RowIndex;
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
        private void btnAgregar_Click(object sender, EventArgs e)
        {

            try
            {
                int idingrediente = ((ingredientes)cbxIngrediente.SelectedItem).id;
                int cantidad = int.Parse(txtCantidad.Text);
                int idhamburguesaa = idhamburguesa;
                Ingrediente_HamburguesaConexion conexion = new Ingrediente_HamburguesaConexion();
                var listaingrediente = conexion.DetalleHamburguesa(idhamburguesaa);
                if (listaingrediente.Any(i => i.id_ingrediente == idingrediente))
                {
                    conexion.modificar(idingrediente, idhamburguesaa, cantidad);
                }
                else
                {
                    conexion.agregar(idingrediente, idhamburguesaa, cantidad);
                }
                MessageBox.Show("Agregado correctamente..");
            }
            catch (Exception ex)
            {
                MessageBox.Show("Hubo un error al intentar agregar..." + ex);
            }
            finally
            {
                dgvDetalleHamburguesa.Rows.Clear();
                cargaritem();
            }

        }

        private void btnCancelar_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void btnmas_Click(object sender, EventArgs e)
        {
            sumar(txtCantidad);
        }

        private void btnmenos_Click(object sender, EventArgs e)
        {
            restar(txtCantidad);
        }
    }
}
