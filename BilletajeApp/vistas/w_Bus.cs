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
    public partial class w_Bus : Form
    {
        //servicios
        private BusServices services;
        private EmpresaTransporte empresa;

        public w_Bus(EmpresaTransporte empresa)
        {
            InitializeComponent();
            services = new BusServices();
            this.empresa = empresa;

        }

        private void w_Bus_Load(object sender, EventArgs e)
        {
            
        }

        private void btnCancelar_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnGuardar_Click(object sender, EventArgs e)
        {
            if (preparaCrear())
            {
                MessageBox.Show("Bus Creado con éxito!", "Confirmación", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            else
            {
                MessageBox.Show("Algo salio mal!", "Confirmación", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            this.Close();
        }

        private bool preparaCrear()
        {
            bool R = false;

            try
            {
                
                TipoBus tipo;

                if (rbRegular.Checked == true) {
                    tipo = TipoBus.REGULAR;
                }
                else
                {
                    tipo = TipoBus.EJECUTIVO;
                }

                Bus bus = new Bus((int)this.nudNumeroCoche.Value, tipo);
                bus.Empresa = this.empresa;
                if (services.create(bus))
                {
                    R = true;
                }
                else
                {
                    R = false;
                }

            }
            catch (Exception)
            {

                R = false;
            }

            return R;
        }
    }
}
