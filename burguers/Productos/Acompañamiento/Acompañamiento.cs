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
    public partial class Acompañamiento : Form
    {
        private List<acompañamiento> listaAcompañamiento;
        public Acompañamiento()
        {
            InitializeComponent();
        }
        public void cargar()
        {
            try
            {
                AcompañamientoConexion conexion = new AcompañamientoConexion();
                listaAcompañamiento = conexion.listaAcompañamiento();
                dgvAcompañamiento.DataSource = listaAcompañamiento;
                dgvAcompañamiento.Columns[2].Visible = false;
                dgvAcompañamiento.Columns[3].Visible = false;
                dgvAcompañamiento.Columns[4].Visible = false;
            }
            catch (Exception ex)
            {
                MessageBox.Show("Hubo un error.." + ex.Message);
            }
        }
        private void btnAgregar_Click(object sender, EventArgs e)
        {
            AgregarAcompañamiento alta = new AgregarAcompañamiento();
            alta.ShowDialog();
            cargar();
        }

        private void Acompañamiento_Load(object sender, EventArgs e)
        {
            cargar();
        }

        private void btnModificar_Click(object sender, EventArgs e)
        {
            acompañamiento seleccionado = (acompañamiento)dgvAcompañamiento.CurrentRow.DataBoundItem;
            AgregarAcompañamiento modificar = new AgregarAcompañamiento(seleccionado);
            modificar.ShowDialog();
            cargar();
        }

        private void btnEliminar_Click(object sender, EventArgs e)
        {
            try
            {
                acompañamiento seleccionado = (acompañamiento)dgvAcompañamiento.CurrentRow.DataBoundItem;
                AcompañamientoConexion conexion = new AcompañamientoConexion();
                conexion.desactivar(seleccionado);
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

        private void Acompañamiento_Load_1(object sender, EventArgs e)
        {
            cargar();
        }

        private void btnDetalle_Click(object sender, EventArgs e)
        {
            acompañamiento seleccionado = (acompañamiento)dgvAcompañamiento.CurrentRow.DataBoundItem;
            agregarDetalleAcompañamiento detalle = new agregarDetalleAcompañamiento(seleccionado.id);
            detalle.ShowDialog();
        }

        private void btnActivar_Click(object sender, EventArgs e)
        {
            AcompañamientoDesactivados desactivados = new AcompañamientoDesactivados();
            desactivados.ShowDialog();
        }
    }
}
