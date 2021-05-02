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
    public partial class w_Post : Form
    {
        //services
        private TransaccionServices service;
        private TarjetaServices tarjetaServices;
        private BusServices busServices;
        private List<Bus> buses;

        //constants
        private string message1 = "COBRO REALIZADO";
        private string message2 = "GS. ";
        private string message3 = "SALDDO";
        private string message4 = "GS. ";

        private Transaccion transaccion;
        

        public w_Post()
        {
            InitializeComponent();
            service = new TransaccionServices();
            tarjetaServices = new TarjetaServices();
            busServices = new BusServices();
                        
        }

        private void w_Post_Load(object sender, EventArgs e)
        {
            buses = busServices.findAll();
            cboBuses.DataSource = buses;
            cboBuses.DisplayMember = "Numero";
            cboBuses.ValueMember = "UUID";
        }

        //private void txtNroTarjeta_TextChanged(object sender, EventArgs e)
        //{
        //    txtMessage1.Text = message1;
        //    txtMessage2.Text = message2;
        //    txtMessage3.Text = message3;
        //    txtMessage4.Text = message4;
        //}

        private void btnProcesar_Click(object sender, EventArgs e)
        {
            //procesar el cobro
            generaDatosTransaccion();
            if (service.create(transaccion))
            {
                double saldo = tarjetaServices.saldo(txtNroTarjeta.Text);
                txtMessage1.Text = message1;
                txtMessage2.Text = message2+transaccion.monto;
                txtMessage3.Text = message3;
                txtMessage4.Text = message4+saldo;
            }
            else
            {
                txtMessage1.Text = "ERROR!";
                txtMessage2.Text = "";
                txtMessage3.Text = "Saldo insuficiente";
                txtMessage4.Text = "";
            }
        }

        private void generaDatosTransaccion()
        {
            Tarjeta t = tarjetaServices.findByNumero(this.txtNroTarjeta.Text);
            transaccion = new Transaccion((Bus)cboBuses.SelectedItem,t,TipoOperacion.COBRO);
        }

        private void cboBuses_SelectedIndexChanged(object sender, EventArgs e)
        {
            this.txtNroBus.Text = ((Bus)cboBuses.SelectedItem).Numero.ToString();
        }
    }
}
