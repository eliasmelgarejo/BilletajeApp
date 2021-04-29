using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace BilletajeApp.vistas
{
    public partial class MDIHOME : Form
    {
        public MDIHOME()
        {
            InitializeComponent();
        }

        private void salirMenuItem_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void maestros_empBilletajeMenuItem_Click(object sender, EventArgs e)
        {
            w_EmpresaBilletaje frm = new w_EmpresaBilletaje();
            frm.Show();
        }

        private void maestros_usuariosMenuItem_Click(object sender, EventArgs e)
        {
            w_Usuario frm = new w_Usuario();
            frm.Show();
        }
    }
}
