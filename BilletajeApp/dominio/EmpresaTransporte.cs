using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BilletajeApp.dominio
{
    public abstract class EmpresaTransporte
    {
        private int id;
        private string nombre;

        public int Id
        {
            set { this.id = value; }
            get { return this.id; }
        }
        
        public string Nombre
        {
            set {this.nombre = value;}
            get { return this.nombre; }
        }

        public override string ToString()
        {
            return "Id: "+Id+" Nombre: "+Nombre;
        }
    }
}
