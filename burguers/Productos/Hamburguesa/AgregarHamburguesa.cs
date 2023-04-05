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
    public partial class AgregarHamburguesa : Form
    {
        private hamburguesa hamburguesa = null;
        public AgregarHamburguesa()
        {
            InitializeComponent();
        }
        public AgregarHamburguesa(hamburguesa hamburguesa)
        {
            InitializeComponent();
            this.hamburguesa = hamburguesa;
        }
        private void cargar()
        {
            if(hamburguesa == null)
            {
                txtNombre.Text = "";
            }
            else
            {
                txtNombre.Text = hamburguesa.nombre;
            }
        }
        private void btnAceptar_Click(object sender, EventArgs e)
        {
            try
            {
                if (hamburguesa != null)
                {
                    hamburguesa modificado = new hamburguesa();
                    HamburguesaConexion conexion = new HamburguesaConexion();
                    modificado.id = hamburguesa.id;
                    modificado.nombre = txtNombre.Text;

                    conexion.modificar(modificado);
                    if (modificado.nombre.Trim() == "")
                    {
                        MessageBox.Show("Completar todos los campos!");
                        return;
                    }

                    MessageBox.Show("Modificado correctamente..");
                }
                else
                {
                    hamburguesa nuevo = new hamburguesa();
                    HamburguesaConexion conexion = new HamburguesaConexion();

                    nuevo.nombre = txtNombre.Text;

                    if (nuevo.nombre.Trim() == "")
                    {
                        MessageBox.Show("Completar todos los campos!");
                        return;
                    }
                    int id_hamburguesa = int.Parse(conexion.agregar(nuevo.nombre).ToString());
                    DetalleHamburguesa detalle = new DetalleHamburguesa(id_hamburguesa);
                    detalle.ShowDialog();
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

        private void AgregarHamburguesa_Load(object sender, EventArgs e)
        {
            cargar();
        }
    }
}
