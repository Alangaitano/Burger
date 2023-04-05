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
    public partial class AcompañamientoDesactivados : Form
    {
        private List<acompañamiento> listaAcompañamiento;
        public AcompañamientoDesactivados()
        {
            InitializeComponent();
        }
        public void cargar()
        {
            try
            {
                AcompañamientoConexion conexion = new AcompañamientoConexion();
                listaAcompañamiento = conexion.listaAcompañamientodesc();
                dgvDesactivados.DataSource = listaAcompañamiento;
                dgvDesactivados.Columns[2].Visible = false;
            }
            catch (Exception ex)
            {
                MessageBox.Show("Hubo un error.." + ex.Message);
            }
        }
        private void AcompañamientoDesactivados_Load(object sender, EventArgs e)
        {
            cargar();
        }

        private void btnActivar_Click(object sender, EventArgs e)
        {
            try
            {
                acompañamiento seleccionado = (acompañamiento)dgvDesactivados.CurrentRow.DataBoundItem;
                AcompañamientoConexion conexion = new AcompañamientoConexion();
                conexion.activar(seleccionado);
                MessageBox.Show("agregado correctamente..");
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

        private void btnCancelar_Click(object sender, EventArgs e)
        {
            Close();
        }
    }
}
