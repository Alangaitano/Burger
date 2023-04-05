using dominio;
using Negocio_;
using System;
using System.Collections.Generic;
using System.Windows.Forms;

namespace burguers
{
    public partial class Combo : Form
    {
        public int celda = 0;
        private List<combo> listaCombo;
        public Combo()
        {
            InitializeComponent();
        }

        private void cargar()
        {
            try
            {
                ComboConexion conexion = new ComboConexion();
                listaCombo = conexion.listaCombo();
                foreach (var componente in listaCombo)
                {
                    int rowId = dgvCombo.Rows.Add();

                    dgvCombo.Rows[rowId].Cells[0].Value = componente.id;
                    dgvCombo.Rows[rowId].Cells[1].Value = componente.detalle.id;
                    dgvCombo.Rows[rowId].Cells[2].Value = componente.nombre;
                    dgvCombo.Rows[rowId].Cells[3].Value = componente.precio;

                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Hubo un error.." + ex.Message);
            }
        }



        private void Combo_Load(object sender, EventArgs e)
        {
            cargar();
        }

        private void btnEliminar_Click(object sender, EventArgs e)
        {
            try
            {
                int seleccionado = int.Parse(dgvCombo.Rows[celda].Cells[0].Value.ToString());
                ComboConexion conexion = new ComboConexion();
                conexion.eliminar(seleccionado);
                MessageBox.Show("Eliminado correctamente..");
            }
            catch (Exception ex)
            {
                MessageBox.Show("Hubo un error al intentar eliminar.. " + ex.Message);
            }
            finally
            {
                dgvCombo.Rows.Clear();
                cargar();
            }

        }

        private void btnActivar_Click(object sender, EventArgs e)
        {
            activarCombo activar = new activarCombo();
            activar.ShowDialog();
        }

        private void btnDetalle_Click(object sender, EventArgs e)
        {
            int idDetalle = int.Parse(dgvCombo.Rows[celda].Cells[1].Value.ToString());
            DetalleCombo detalle = new DetalleCombo(idDetalle);
            detalle.ShowDialog();

        }

        private void dgvCombo_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            celda = e.RowIndex;
        }

        private void btnAgregar_Click(object sender, EventArgs e)
        {
            AgregarDetalleCombo detalle = new AgregarDetalleCombo();
            detalle.ShowDialog();
        }

        private void btnModificar_Click(object sender, EventArgs e)
        {
            int idDetalle = int.Parse(dgvCombo.Rows[celda].Cells[1].Value.ToString());
            int seleccionado = int.Parse(dgvCombo.Rows[celda].Cells[0].Value.ToString());
            string nombre = dgvCombo.Rows[celda].Cells[2].Value.ToString();
            AgregarCombo modificar = new AgregarCombo(seleccionado,idDetalle, nombre);
            modificar.ShowDialog();
        }

        private void btnRefrescar_Click(object sender, EventArgs e)
        {
            dgvCombo.Rows.Clear();
            cargar();
        }

        private void dgvCombo_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }
    }
}
