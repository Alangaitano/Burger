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
using System.Data.SqlClient;
using Negocio_;

namespace burguers
{
    public partial class Bebidas : Form
    {
        private List<bebida> listaBebidas;
        public Bebidas()
        {
            InitializeComponent();
        }
        public void cargar()
        {
            try
            {
                BebidaConexion conexion = new BebidaConexion();
                listaBebidas = conexion.listaBebidas();
                dgvBebidas.DataSource = listaBebidas;
                dgvBebidas.Columns[2].Visible = false;
                dgvBebidas.Columns[3].Visible = false;
                dgvBebidas.Columns[4].Visible = false;
            }
            catch (Exception ex)
            {
                MessageBox.Show("Hubo un error.." + ex.Message);
            }
        }
        private void btnAgregar_Click(object sender, EventArgs e)
        {
            AgregarBebida alta = new AgregarBebida();
            alta.ShowDialog();
            cargar();
        }

        private void Bebidas_Load(object sender, EventArgs e)
        {
            cargar();
        }

        private void btnModificar_Click(object sender, EventArgs e)
        {
            bebida seleccionado = (bebida)dgvBebidas.CurrentRow.DataBoundItem;
            AgregarBebida modificar = new AgregarBebida(seleccionado);

            modificar.ShowDialog();
            cargar();
        }

        private void btnEliminar_Click(object sender, EventArgs e)
        {
            try
            {
                bebida seleccionado = (bebida)dgvBebidas.CurrentRow.DataBoundItem;
                BebidaConexion conexion = new BebidaConexion();
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

        private void dgvBebidas_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void btnactivar_Click(object sender, EventArgs e)
        {
            bebidasDesactivadas bebidasDesactivadas = new bebidasDesactivadas();
            bebidasDesactivadas.ShowDialog();
        }

        private void btnrefresh_Click(object sender, EventArgs e)
        {
            cargar();
        }
    }
}
