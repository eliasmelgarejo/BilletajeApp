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
    public partial class w_EmpresaBilletaje : Form
    {
        private List<EmpresaBilletaje> lista;
        private EmpresaBilletaje empresa;
        private EmpresaBilletajeServices services;

        public w_EmpresaBilletaje()
        {
            InitializeComponent();
            services = new EmpresaBilletajeServices();
            
        }

        private void w_EmpresaBilletaje_Load(object sender, EventArgs e)
        {

            lista = services.findAll();
            dataGridView1.DataSource = lista;

        }

        private void btnCancelar_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnGuardar_Click(object sender, EventArgs e)
        {
            prepara_guardar();
            this.Close();
        }

        private void prepara_guardar()
        {
            empresa = new EmpresaBilletaje();
            empresa.Nombre = this.txtNombre.Text.ToLower();
            empresa.Marca = this.txtMarca.Text.ToLower();

            if (services.create(empresa))
            {
                MessageBox.Show("Empresa creada éxitosamente!", "Confirmación", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            else
            {
                MessageBox.Show("No se creo Empresa!", "Confirmación", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
                
    }
}
