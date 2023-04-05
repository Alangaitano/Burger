using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;
using dominio;
using Negocio_;

namespace burguers
{
    public partial class bebidasDesactivadas : Form
    {
        private List<bebida> listabebidas;
        public bebidasDesactivadas()
        {
            InitializeComponent();
        }
        public void cargar()
        {
            try
            {
                BebidaConexion conexion = new BebidaConexion();
                listabebidas = conexion.listaBebidasDesac();
                dgvbebidasdesactivados.DataSource = listabebidas;
                dgvbebidasdesactivados.Columns[1].Visible = false;
                dgvbebidasdesactivados.Columns[2].Visible = false;
            }
            catch (Exception ex)
            {
                MessageBox.Show("Hubo un error.." + ex.Message);
            }
        }
        private void bebidasDesactivadas_Load(object sender, EventArgs e)
        {
            cargar();
        }

        private void btnActivar_Click(object sender, EventArgs e)
        {
            try
            {
                bebida seleccionado = (bebida)dgvbebidasdesactivados.CurrentRow.DataBoundItem;
                BebidaConexion conexion = new BebidaConexion();
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
