using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Negocio_;
using dominio;

namespace burguers
{
    public partial class ingrediente : Form
    {
        private List<dominio.ingredientes> listaIngrediente;
        public ingrediente()
        {
            InitializeComponent();
        }
        public void cargar()
        {
            try
            {
                IngredienteConexion conexion = new IngredienteConexion();
                listaIngrediente = conexion.listaIngredientes();
                dgvIngrediente.DataSource = listaIngrediente;
                dgvIngrediente.Columns[2].Visible = false;
                dgvIngrediente.Columns[3].Visible = false;
                dgvIngrediente.Columns[4].Visible = false;
            }
            catch (Exception ex)
            {
                MessageBox.Show("Hubo un error.." + ex.Message);
            }
        }

        private void ingrediente_Load(object sender, EventArgs e)
        {
            cargar();
        }

        private void btnAgregar_Click(object sender, EventArgs e)
        {
            agregarIngrediente alta = new agregarIngrediente();
            alta.ShowDialog();
            cargar();
        }

        private void btnEliminar_Click(object sender, EventArgs e)
        {
            try
            {
                ingredientes seleccionado = (ingredientes)dgvIngrediente.CurrentRow.DataBoundItem;
                IngredienteConexion conexion = new IngredienteConexion();
                conexion.eliminar(seleccionado);
                MessageBox.Show("Eliminado correctamente..");
            }
            catch (Exception ex)
            {
                MessageBox.Show("Hubo un error al intentar eliminar.. " + ex.Message);
            }
            finally
            {
                cargar();
            }
        }

        private void btnModificar_Click(object sender, EventArgs e)
        {
            ingredientes seleccionado = (ingredientes)dgvIngrediente.CurrentRow.DataBoundItem;
            agregarIngrediente modificar = new agregarIngrediente(seleccionado);

            modificar.ShowDialog();
            cargar();
        }

        private void dgvIngrediente_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void btnActivar_Click(object sender, EventArgs e)
        {
            IngredientesDesactivados desactivados = new IngredientesDesactivados();
            desactivados.ShowDialog();
        }

        private void btnRefresh_Click(object sender, EventArgs e)
        {
            cargar();
        }
    }
}
