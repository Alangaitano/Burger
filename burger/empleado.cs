using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace burger
{
    public partial class empleado : Form
    {
        public empleado()
        {
            InitializeComponent();
        }
        private List<empleado> listaEmpleado;

        public void cargar()
        {
            try
            {
                EmpleadoConexion conexion = new EmpleadoConexion();
                listaEmpleado = conexion.listaEmpleado();
                dgvListaEmpleado.DataSource = listaEmpleado;
                dgvListaEmpleado.Columns[0].Visible = false;
            }
            catch (Exception ex)
            {
                MessageBox.Show("Hubo un error.." + ex.Message);
            }
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            cargar();
        }


        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }
    }
}
