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
    public partial class Hamburguesa : Form
    {
        private int celda = 0;
        private List<hamburguesa> listaHamburguesas;
        public Hamburguesa()
        {
            InitializeComponent();
        }
        public void cargar()
        {
            try
            {
                HamburguesaConexion conexion = new HamburguesaConexion();
                listaHamburguesas = conexion.listaHamburguesas();
                dgvHamburguesa.DataSource = listaHamburguesas;
                dgvHamburguesa.Columns[2].Visible = false;
                dgvHamburguesa.Columns[4].Visible = false;
                dgvHamburguesa.Columns[3].Visible = false;

            }
            catch (Exception ex)
            {
                MessageBox.Show("Hubo un error.." + ex.Message);
            }
        }
        private void btnAgregar_Click(object sender, EventArgs e)
        {
            AgregarHamburguesa alta = new AgregarHamburguesa();
            alta.ShowDialog();
            cargar();
        }

        private void Hamburguesa_Load(object sender, EventArgs e)
        {
            cargar();
        }

        private void btnModificar_Click(object sender, EventArgs e)
        {
            hamburguesa seleccionado = (hamburguesa)dgvHamburguesa.CurrentRow.DataBoundItem;
            AgregarHamburguesa modificar = new AgregarHamburguesa(seleccionado);

            modificar.ShowDialog();
            cargar();
        }

        private void btnEliminar_Click(object sender, EventArgs e)
        {
            if (celda != -1)
            {
                try
                {
                    hamburguesa seleccionado = (hamburguesa)dgvHamburguesa.CurrentRow.DataBoundItem;
                    HamburguesaConexion conexion = new HamburguesaConexion();
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

        }

        private void btnDetalle_Click(object sender, EventArgs e)
        {
            hamburguesa seleccionado = (hamburguesa)dgvHamburguesa.CurrentRow.DataBoundItem;
            DetalleHamburguesa detalle = new DetalleHamburguesa(seleccionado.id);
            detalle.ShowDialog();
        }

        private void btnActivar_Click(object sender, EventArgs e)
        {
            ActivarHamburguesa activar = new ActivarHamburguesa();
            activar.ShowDialog();
        }

        private void dgvHamburguesa_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            celda = e.RowIndex;
        }

        private void btnRefresh_Click(object sender, EventArgs e)
        {
            cargar();
        }
    }
}
