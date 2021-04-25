using BilletajeApp.dominio;
using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.IO;
using System.Reflection;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BilletajeApp.repositorios
{
    public class TarjetaRepo : IRepository<Tarjeta>
    {
        private const string path = @"c:\bd\tarjeta.json";
        public bool create(Tarjeta t)
        {
            bool R;
            try
            {
                //recuperar el archivo y convertir en una lista de objetos
                string archivo = System.IO.File.ReadAllText(path);

                List<Tarjeta> lista;
                lista = JsonConvert.DeserializeObject<List<Tarjeta>>(archivo);

                if (lista == null) lista = new List<Tarjeta>();
                //agrego el nuevo objeto creado al final
                lista.Add(t);

                //pasar nueva lista a json
                string nuevoArchivo = JsonConvert.SerializeObject(lista,Formatting.Indented);
                System.IO.File.WriteAllText(path, nuevoArchivo);

                R = true;

            }
            catch (Exception e)
            {
                R = false;
                Console.WriteLine("Error: "+e.Message);
            }
            return R;
        }

        public bool remove(Tarjeta t)
        {
            bool R;
            try
            {
                //recuperar el archivo y convertir en una lista de objetos
                string archivo = System.IO.File.ReadAllText(path);

                List<Tarjeta> lista = JsonConvert.DeserializeObject<List<Tarjeta>>(archivo);
                //busco el objeto y lo remuevo de las lista
                List<Tarjeta> lista2 = new List<Tarjeta>();
                foreach (var item in lista)
                {
                    if (item.UUID!=t.UUID)
                    {
                        lista2.Add(item);
                    }
                }

                //pasar nueva lista a json
                string nuevoArchivo = JsonConvert.SerializeObject(lista2, Formatting.Indented);
                System.IO.File.WriteAllText(path, nuevoArchivo);

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
            List<Tarjeta> R;
            try
            {
                //recuperar el archivo y convertir en una lista de objetos
                string archivo = System.IO.File.ReadAllText(path);

                R = JsonConvert.DeserializeObject<List<Tarjeta>>(archivo);                
            }
            catch (Exception)
            {
                R = null;
                throw;
            }
            return R;
        }

        public Tarjeta findById(Guid uuid)
        {
            Tarjeta R;
            try
            {
                //recuperar el archivo y convertir en una lista de objetos
                string archivo = System.IO.File.ReadAllText(path);

                List<Tarjeta> lista = JsonConvert.DeserializeObject<List<Tarjeta>>(archivo);
                R = lista.Find(x => x.UUID == uuid);                
            }
            catch (Exception)
            {
                R = null;
                throw;
            }
            return R;
        }
               
    }
}
