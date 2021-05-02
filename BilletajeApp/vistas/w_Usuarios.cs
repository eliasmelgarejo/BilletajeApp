using BilletajeApp.dominio;
using BilletajeApp.servicios;
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
    public partial class w_Usuarios : Form
    {
        private List<Usuario> usuarios;
        private UsuarioServices services;

        public w_Usuarios()
        {
            InitializeComponent();
            services = new UsuarioServices();
            usuarios = services.findAll();
        }

        private void w_Usuarios_Load(object sender, EventArgs e)
        {
            dataGridView1.DataSource = usuarios;
            dataGridView1.ReadOnly = true;
        }

        private void btnCancelar_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnGuardar_Click(object sender, EventArgs e)
        {
            if (preparaCreacion())
            {
                MessageBox.Show("Usuario creado!", "Info", MessageBoxButtons.OK, MessageBoxIcon.Information);

            }
            else
            {
                MessageBox.Show("No se creo usuario", "Info", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private bool preparaCreacion()
        {
            bool R = false;
            try
            {
                Usuario u = new Usuario(txtNombre.Text, txtCedula.Text);
                R = services.create(u);
            }
            catch (Exception e)
            {

                R = false;
                MessageBox.Show("Error: "+e.Message, "Info", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            return R;
        }
    }
}
