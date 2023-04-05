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

namespace burguers
{
    public partial class activarCombo : Form
    {
        private List<combo> listaCombo;
        private int celda = 0;
        public activarCombo()
        {
            InitializeComponent();
        }
        private void cargar()
        {
            try
            {
                ComboConexion conexion = new ComboConexion();
                listaCombo = conexion.listaComboDesactivado();
                foreach (var componente in listaCombo)
                {
                    int rowId = dgvComboDesactivado.Rows.Add();

                    dgvComboDesactivado.Rows[rowId].Cells[0].Value = componente.id;
                    dgvComboDesactivado.Rows[rowId].Cells[1].Value = componente.detalle.id;
                    dgvComboDesactivado.Rows[rowId].Cells[2].Value = componente.nombre;
                    dgvComboDesactivado.Rows[rowId].Cells[3].Value = componente.precio;
                    dgvComboDesactivado.Rows[rowId].Cells[4].Value = componente.tamaño;

                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Hubo un error.." + ex.Message);
            }
        }
        private void activarCombo__Load(object sender, EventArgs e)
        {
            cargar();
        }

        private void btnActivar_Click(object sender, EventArgs e)
        {
            try
            {
                int seleccionado = int.Parse(dgvComboDesactivado.Rows[celda].Cells[0].Value.ToString());
                ComboConexion conexion = new ComboConexion();
                conexion.activar(seleccionado);
                MessageBox.Show("Activado correctamente..");
            }
            catch (Exception ex)
            {
                MessageBox.Show("Hubo un error al intentar activar.. " + ex.Message);
            }
            finally
            {
                dgvComboDesactivado.Rows.Clear();
                cargar();
                Close();

            }
        }

        private void dgvComboDesactivado_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            celda = e.RowIndex;
        }

        private void btnCancelar_Click(object sender, EventArgs e)
        {
            Close();
        }
    }
}
