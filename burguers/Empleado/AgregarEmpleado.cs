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
    public partial class AgregarEmpleado : Form
    {
        private dominio.empleado empleado = null;

        public AgregarEmpleado()
        {
            InitializeComponent();
        }

        public AgregarEmpleado(dominio.empleado empleado)
        {
            InitializeComponent();
            this.empleado = empleado;
        }

        private void btnAceptar_Click(object sender, EventArgs e)
        {
            try
            {
                if (empleado != null)
                {
                    dominio.empleado modificado = new dominio.empleado();
                    Negocio.EmpleadoConexion conexion = new Negocio.EmpleadoConexion();
                    modificado.id = empleado.id;
                    modificado.nombre = txtNombre.Text;
                    modificado.apellido = txtApellido.Text;
                    modificado.telefono = int.Parse(txtTelefono.Text);
                    modificado.email = txtEmail.Text;

                    conexion.modificar(modificado);
                    if (modificado.nombre.Trim() == "" || modificado.apellido.Trim() == "" || modificado.telefono <= 0 || modificado.email.Trim() == "")
                    {
                        MessageBox.Show("Completar todos los campos!");
                        return;
                    }

                    MessageBox.Show("Modificado correctamente..");
                }
                else
                {
                    dominio.empleado nuevo = new dominio.empleado();
                    Negocio.EmpleadoConexion conexion = new Negocio.EmpleadoConexion();

                    nuevo.nombre = txtNombre.Text;
                    nuevo.apellido = txtApellido.Text;
                    nuevo.telefono = int.Parse(txtTelefono.Text);
                    nuevo.email = txtEmail.Text;
                    conexion.agregar(nuevo);

                    if (nuevo.nombre.Trim() == "" || nuevo.apellido.Trim() == "" || nuevo.telefono <= 0 || nuevo.email.Trim() == "")
                    {
                        MessageBox.Show("Completar todos los campos!");
                        return;
                    }

                    MessageBox.Show("Agregado correctamente..");
                }
                Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Hubo un error..." + ex.Message);
            }
        }

        private void btnCancelar_Click(object sender, EventArgs e)
        {
            Close();
        }
    }
}
