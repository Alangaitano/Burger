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
    public partial class AgregarAcompañamiento : Form
    {
        private acompañamiento Acompañamiento = null;
        public AgregarAcompañamiento()
        {
            InitializeComponent();
        }

        public AgregarAcompañamiento(acompañamiento acompañamiento)
        {
            InitializeComponent();
            this.Acompañamiento = acompañamiento;
        }

        private void cargar()
        {
            if(Acompañamiento == null)
            {
                txtNombre.Text = "";
            }
            else
            {
                txtNombre.Text = Acompañamiento.nombre.ToString();
            }

        }
        private void btnAceptar_Click(object sender, EventArgs e)
        {
            try
            {
                if (Acompañamiento != null)
                {
                    acompañamiento modificado = new acompañamiento();
                    AcompañamientoConexion conexion = new AcompañamientoConexion();
                    modificado.nombre = txtNombre.Text;
                    modificado.recargo = int.Parse(txtRecargo.Text);

                    conexion.modificar(modificado);
                    if (modificado.nombre.Trim() == "")
                    {
                        MessageBox.Show("Completar todos los campos!");
                        return;
                    }
                    MessageBox.Show("Modificado correctamente..");
                    Close();

                }
                else
                {
                    acompañamiento nuevo = new acompañamiento();
                    AcompañamientoConexion conexion = new AcompañamientoConexion();
                    nuevo.nombre = txtNombre.Text;
                    nuevo.recargo = int.Parse(txtRecargo.Text);
                    if (nuevo.nombre.Trim() == "")
                    {
                        MessageBox.Show("Completar todos los campos!");
                        return;
                    }
                    MessageBox.Show("Agregado correctamente..");
                    
                    int idacompañamiento = int.Parse(conexion.Agregar(nuevo.nombre, nuevo.recargo).ToString());
                    Close();
                    agregarDetalleAcompañamiento detalle = new agregarDetalleAcompañamiento(idacompañamiento);
                    detalle.ShowDialog();
                    
                }
                
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

        private void AgregarAcompañamiento_Load(object sender, EventArgs e)
        {
            cargar();
        }
    }
}
