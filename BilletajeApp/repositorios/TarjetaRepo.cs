using BilletajeApp.dominio;
using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BilletajeApp.repositorios
{
    public class TarjetaRepo : IRepository<Tarjeta>
    {
        public bool create(Tarjeta t)
        {
            bool R;
            try
            {
                string output = JsonConvert.SerializeObject(t);
                //si el archivo no existe, lo creo
                using (StreamWriter sw = 
                    new StreamWriter(@"C:\Users\Elias\source\repos\BilletajeApp\BilletajeApp\bd\tarjeta.json"))
                

                //agrego el nuevo objeto creado al final

                R = true;

            }
            catch (Exception)
            {
                R = false;
                throw;
            }
            return R;
        }

        public bool remove(Tarjeta t)
        {
            bool R;
            try
            {
                string output = JsonConvert.SerializeObject(t);
                //busco el objeto dentro del archivo y lo elimino

                R = true;
            }
            catch (Exception)
            {
                R = false;
                throw;
            }
            return R;
        }

        public List<Tarjeta> findAll()
        {
            //extraer del archivo el json

            //convertir en objeto o clase y delvolver

            throw new NotImplementedException();
        }

        public Tarjeta findById(int id)
        {
            //extraer del archivo el json

            //convertir en objeto o clase y delvolver

            throw new NotImplementedException();
        }
    }
}
