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
    public partial class agregarIngrediente : Form
    {
        private ingredientes ingrediente = null;
        public agregarIngrediente()
        {
            InitializeComponent();
        }
        public agregarIngrediente(ingredientes ingrediente)
        {
            InitializeComponent();
            this.ingrediente = ingrediente;
        }
        private void cargar()
        {
            if(ingrediente == null)
            {
                txtNombre.Text = "";
                txtPrecio.Text = "0";
            }
            else
            {
                txtNombre.Text = ingrediente.nombre.ToString();
                txtPrecio.Text = ingrediente.precio.ToString();
            }
        }
        private void btnAceptar_Click(object sender, EventArgs e)
        {
            try
            {
                if (ingrediente != null)
                {
                    ingredientes modificado = new ingredientes();
                    IngredienteConexion conexion = new IngredienteConexion();
                    modificado.id = ingrediente.id;
                    modificado.nombre = txtNombre.Text;
                    modificado.precio = int.Parse(txtPrecio.Text);

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
                    ingredientes nuevo = new ingredientes();
                    IngredienteConexion conexion = new IngredienteConexion();

                    nuevo.nombre = txtNombre.Text;
                    nuevo.precio = int.Parse(txtPrecio.Text);
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

        private void agregarIngrediente_Load(object sender, EventArgs e)
        {
            cargar();
        }
    }
}
