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
    public partial class w_Tarjeta : Form
    {

        private TarjetaServices services;
        private EmpresaBilletajeServices empServices;
        private List<EmpresaBilletaje> empresas;
        private List<Tarjeta> lista;

        public w_Tarjeta()
        {
            InitializeComponent();
            services = new TarjetaServices();
            empServices = new EmpresaBilletajeServices();
            empresas = empServices.findAll();
            lista = new List<Tarjeta>();
        }

        private void w_Tarjeta_Load(object sender, EventArgs e)
        {
            cboEmpresaBilletaje.DataSource = empresas;
            cboEmpresaBilletaje.DisplayMember = "Marca";
            cboEmpresaBilletaje.ValueMember = "Nombre";
            dataGridView1.ReadOnly = true;
        }

        private void btnCancelar_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnProcesar_Click(object sender, EventArgs e)
        {             
            if (MessageBox.Show("Está seguro de iniciar el proceso?",
                "Generación de tarjetas", MessageBoxButtons.OKCancel, MessageBoxIcon.Question) == DialogResult.OK)
            {
                Tarjeta ultima = services.findAll().OrderBy(x => x.numero).Last();
                string numerotc = ultima.numero;
                Int64 valor = Convert.ToInt64(numerotc);

                int cantidad = (int) nudCantidadGenerar.Value;
                for (int i = 1; i <= cantidad; i++)
                {

                    valor += 1;
                    Tarjeta t = new Tarjeta(valor.ToString(), (EmpresaBilletaje)cboEmpresaBilletaje.SelectedItem);
                    lista.Add(t);
                }
                MessageBox.Show("Generación finalizado", "Info", MessageBoxButtons.OK, MessageBoxIcon.Information);
                dataGridView1.DataSource = lista;
            }
        }

        private void btnLimpiar_Click(object sender, EventArgs e)
        {
            limpiar();
        }

        private void btnGuardar_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Está seguro de guardar, este proceso es irreversible?",
               "Generación de tarjetas", MessageBoxButtons.OKCancel, MessageBoxIcon.Question) == DialogResult.OK)
            {
                int cantidad = (int)nudCantidadGenerar.Value;
                foreach (Tarjeta t in lista)
                {
                    services.create(t);
                }
                MessageBox.Show("Creación finalizada", "Info", MessageBoxButtons.OK, MessageBoxIcon.Information);

                limpiar();
            }
        }

        private void limpiar()
        {
            nudCantidadGenerar.Value = 0;
            lista.Clear();
            dataGridView1.DataSource = null;
            dataGridView1.Rows.Clear();
            dataGridView1.Columns.Clear();
        }
    }
}
