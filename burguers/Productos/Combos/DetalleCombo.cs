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
    public partial class DetalleCombo : Form
    {
        private int id_detalle = 0;
        private List<detalle_combo> detallecombo;
        public DetalleCombo()
        {
            InitializeComponent();
        }
        public DetalleCombo(int id_detalle)
        {
            InitializeComponent();
            this.id_detalle = id_detalle;
        }
        private void cargar()
        {
            try
            {
                detallleComboConexion detalle = new detallleComboConexion();
                detallecombo = detalle.DetalleCombo(id_detalle);
                foreach (var componente in detallecombo)
                {
                    int rowId = dgvDetalleCombo.Rows.Add();

                    dgvDetalleCombo.Rows[rowId].Cells[0].Value = componente.id;
                    dgvDetalleCombo.Rows[rowId].Cells[1].Value = componente.bebida.nombre;
                    dgvDetalleCombo.Rows[rowId].Cells[2].Value = componente.Acompañamiento.nombre;
                    dgvDetalleCombo.Rows[rowId].Cells[3].Value = componente.hamburguesa.nombre;
                }

            }
            catch (Exception ex)
            {
                MessageBox.Show("Hubo un error.." + ex.Message);
            }
        }

        private void DetalleCombo_Load(object sender, EventArgs e)
        {
            cargar();
        }
    }
}
