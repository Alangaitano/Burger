using Negocio;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace burguers
{
    public partial class empleados : Form
    {
        private List<dominio.empleado> listaEmpleado;
        public empleados()
        {
            InitializeComponent();
        }
        public void cargar()
        {
            try
            {
                EmpleadoConexion conexion = new EmpleadoConexion();
                listaEmpleado = conexion.listaEmpleado();
                dgvEmpleados.DataSource = listaEmpleado;
            }
            catch (Exception ex)
            {
                MessageBox.Show("Hubo un error.." + ex.Message);
            }
        }
        private void filtrar()
        {
            List<dominio.empleado> listaFiltrada;
            string filtro = txbNombreFiltro.Text;
            if (filtro.Length >= 1)
            {
                listaFiltrada = listaEmpleado.FindAll(x => x.nombre.ToLower().Contains(filtro.ToLower()));
                dgvEmpleados.DataSource = null;
                dgvEmpleados.DataSource = listaFiltrada;
            }
            else
            {
                dgvEmpleados.DataSource = null;
                dgvEmpleados.DataSource = listaEmpleado;
            }
        }

        private void empleados_Load(object sender, EventArgs e)
        {
            cargar();
        }

        private void btnAgregar_Click(object sender, EventArgs e)
        {
            AgregarEmpleado alta = new AgregarEmpleado();
            alta.ShowDialog();
            cargar();
        }

        private void btnEliminar_Click(object sender, EventArgs e)
        {
            try
            {
                dominio.empleado seleccionado = (dominio.empleado)dgvEmpleados.CurrentRow.DataBoundItem;
                EmpleadoConexion conexion = new EmpleadoConexion();
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
            dominio.empleado seleccionado = (dominio.empleado)dgvEmpleados.CurrentRow.DataBoundItem;
            AgregarEmpleado modificar = new AgregarEmpleado(seleccionado);

            modificar.ShowDialog();
            cargar();
        }

        private void txbNombreFiltro_KeyPress(object sender, KeyPressEventArgs e)
        {
            filtrar();
        }

        private void dgvEmpleados_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }
    }
}
