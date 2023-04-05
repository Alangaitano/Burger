using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Negocio_;
using dominio;

namespace burguers
{
    public partial class AgregarCombo : Form
    {
        public class tamañocombo
        {
            public string nombre { get; set; }
            public int id { get; set; }
        }
        private int id_detalle = 0;
        private int seleccionado = 0;
        private string nombre;
        public AgregarCombo()
        {
            InitializeComponent();
        }
        public AgregarCombo(int id_detalle)
        {
            InitializeComponent();
            this.id_detalle = id_detalle;
        }
        public AgregarCombo(int seleccionado, int id_detalle, string nombre)
        {
            InitializeComponent();
            this.seleccionado = seleccionado;
            this.id_detalle = id_detalle;
            this.nombre = nombre;
        }
        private void AgregarCombo_Load(object sender, EventArgs e)
        {
            try
            {
                txtIDdetalle.Text = id_detalle.ToString();
                if (seleccionado != 0)
                {
                    txtNombre.Text = nombre;
                }

            }
            catch (Exception ex)
            {
                MessageBox.Show("error..." + ex);
            }

        }

        private void btnAceptar_Click(object sender, EventArgs e)
        {
            ComboConexion conexion = new ComboConexion();
            int iddetalle = int.Parse(txtIDdetalle.Text);
            string nombre = txtNombre.Text;
            if (seleccionado != 0)
            {
                if (nombre.Trim() == "")
                {
                    MessageBox.Show("Completar todos los campos!");
                    return;
                }
                conexion.modificar(iddetalle, nombre);
                AgregarDetalleCombo modificar = new AgregarDetalleCombo(iddetalle);
                modificar.ShowDialog();
                Close();
            }
            else
            {
                conexion.agregar(iddetalle, nombre);
                if (nombre.Trim() == "")
                {
                    MessageBox.Show("Completar todos los campos!");
                    return;
                }
                MessageBox.Show("Agregado correctamente....");
                Close();
            }

        }
    }
}
