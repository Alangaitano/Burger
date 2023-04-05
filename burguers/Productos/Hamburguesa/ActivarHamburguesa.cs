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
    public partial class ActivarHamburguesa : Form
    {
        private List<hamburguesa> listaHamburguesas;
        public ActivarHamburguesa()
        {
            InitializeComponent();
        }
        public void cargar()
        {
            try
            {
                HamburguesaConexion conexion = new HamburguesaConexion();
                listaHamburguesas = conexion.listaHamburguesasDest();
                dgvActivar.DataSource = listaHamburguesas;
                dgvActivar.Columns[1].Visible = false;
                dgvActivar.Columns[2].Visible = false;
            }
            catch (Exception ex)
            {
                MessageBox.Show("Hubo un error.." + ex.Message);
            }
        }

        private void ActivarHamburguesa_Load(object sender, EventArgs e)
        {
            cargar();
        }

        private void btnAceptar_Click(object sender, EventArgs e)
        {
            try
            {
                hamburguesa seleccionado = (hamburguesa)dgvActivar.CurrentRow.DataBoundItem;
                HamburguesaConexion conexion = new HamburguesaConexion();
                conexion.activar(seleccionado);
                MessageBox.Show("Agregado correctamente..");
            }
            catch (Exception ex)
            {
                MessageBox.Show("Hubo un error al intentar agregar.. " + ex.Message);
            }
            finally
            {
                cargar();
            }
        }
    }
}
