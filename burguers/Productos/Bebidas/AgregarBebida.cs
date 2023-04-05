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
    public partial class AgregarBebida : Form
    {
        private bebida Bebidas = null;
        public AgregarBebida()
        {
            InitializeComponent();
        }
        public AgregarBebida(bebida bebidas)
        {
            InitializeComponent();
            this.Bebidas = bebidas;
        }
        private void cargar()
        {
            if(Bebidas == null)
            {
                txtNombre.Text = " ";
                txtPrecio.Text = "0";
                txtRecargo.Text = "0";
            }
            else
            {
                txtNombre.Text = Bebidas.nombre.ToString();
                txtPrecio.Text = Bebidas.precio.ToString();
                txtRecargo.Text = Bebidas.recargo.ToString();
            }

        }
        private void btnAceptar_Click(object sender, EventArgs e)
        {
            try
            {
                if (Bebidas != null)
                {
                    bebida modificado = new bebida();
                    BebidaConexion conexion = new BebidaConexion();
                    modificado.id = Bebidas.id;
                    modificado.nombre = txtNombre.Text;
                    modificado.precio = int.Parse(txtPrecio.Text);
                    modificado.recargo = int.Parse(txtRecargo.Text);

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
                    bebida nuevo = new bebida();
                    BebidaConexion conexion = new BebidaConexion();

                    nuevo.nombre = txtNombre.Text;
                    nuevo.precio = int.Parse(txtPrecio.Text);
                    nuevo.recargo = int.Parse(txtRecargo.Text);
                    conexion.agregar(nuevo);

                    if (nuevo.nombre.Trim() == "")
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

        private void AgregarBebida_Load(object sender, EventArgs e)
        {
            cargar();
        }
    }
}
