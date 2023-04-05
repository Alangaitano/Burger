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
    public partial class IngredientesDesactivados : Form
    {
        private List<ingredientes> listaingredientes;
        public IngredientesDesactivados()
        {
            InitializeComponent();
        }
        public void cargar()
        {
            try
            {
                IngredienteConexion conexion = new IngredienteConexion();
                listaingredientes = conexion.listaIngredientesdesac();
                dgvingredientesdesactivados.DataSource = listaingredientes;
                dgvingredientesdesactivados.Columns[1].Visible = false;
                dgvingredientesdesactivados.Columns[2].Visible = false;
            }
            catch (Exception ex)
            {
                MessageBox.Show("Hubo un error.." + ex.Message);
            }
        }
        private void IngredientesDesactivados_Load(object sender, EventArgs e)
        {
            cargar();
        }

        private void btnActivar_Click(object sender, EventArgs e)
        {
            try
            {
                ingredientes seleccionado = (ingredientes)dgvingredientesdesactivados.CurrentRow.DataBoundItem;
                IngredienteConexion conexion = new IngredienteConexion();
                conexion.activar(seleccionado);
                MessageBox.Show("Agregado correctamente..");
            }
            catch (Exception ex)
            {
                MessageBox.Show("Hubo un error al intentar agregar.. " + ex.Message);
            }
            finally
            {
                cargar();
            }
        }
    }
}
