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
    public partial class menu : Form
    {
        public menu()
        {
            InitializeComponent();
        }

        private void btnIngrediente_Click(object sender, EventArgs e)
        {
            ingrediente ing = new ingrediente();
            ing.ShowDialog();
        }

        private void btnBebidas_Click(object sender, EventArgs e)
        {
            Bebidas beb = new Bebidas();
            beb.ShowDialog();
        }

        private void btnHamburguesa_Click(object sender, EventArgs e)
        {
            Hamburguesa hamb = new Hamburguesa();
            hamb.ShowDialog();
        }

        private void btnCombo_Click(object sender, EventArgs e)
        {
            Combo combo = new Combo();
            combo.ShowDialog();
        }

        private void btnEmpleado_Click(object sender, EventArgs e)
        {
            empleados empleados = new empleados();
            empleados.ShowDialog();
        }

        private void btnAcompañamiento_Click(object sender, EventArgs e)
        {
            Acompañamiento acom = new Acompañamiento();
            acom.ShowDialog();
        }
    }
}
