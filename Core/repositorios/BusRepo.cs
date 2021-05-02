using BilletajeApp.Core.dominio;
using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BilletajeApp.Core.repositorios
{
    public class BusRepo : IRepository<Bus>
    {
        private string path;

        public BusRepo()
        {
            Bus t = new Bus();
            this.path = Directory.GetParent(Directory.GetCurrentDirectory()).Parent.FullName.ToString() + "/bd/" + t.className.ToLower() + ".json";
        }

        public bool create(Bus t)
        {
            bool R;
            try
            {
                //recuperar el archivo y convertir en una lista de objetos
                string archivo;
                List<Bus> lista;

                try
                {
                    archivo = File.ReadAllText(path);
                    lista = JsonConvert.DeserializeObject<List<Bus>>(archivo);
                }
                catch (Exception e)
                {
                    Console.WriteLine(e.Message);
                    File.WriteAllText(path, "");
                    lista = null;
                }


                if (lista == null) lista = new List<Bus>();

                //agrego el nuevo objeto creado al final
                lista.Add(t);

                //pasar nueva lista a json
                string nuevoArchivo = JsonConvert.SerializeObject(lista, Formatting.Indented);
                File.WriteAllText(path, nuevoArchivo);

                R = true;

            }
            catch (Exception e)
            {
                R = false;
                Console.WriteLine("Error: " + e.Message);
            }
            return R;
        }

        public bool edit(Bus t)
        {
            bool R;
            try
            {
                //recuperar el archivo y convertir en una lista de objetos
                string archivo = File.ReadAllText(path);

                List<Bus> lista = JsonConvert.DeserializeObject<List<Bus>>(archivo);
                //busco el objeto y lo remuevo de las lista
                List<Bus> lista2 = new List<Bus>();
                foreach (var item in lista)
                {
                    if (item.UUID != t.UUID)
                    {
                        lista2.Add(item);
                    }
                }

                lista2.Add(t);

                //pasar nueva lista a json
                string nuevoArchivo = JsonConvert.SerializeObject(lista2, Formatting.Indented);
                File.WriteAllText(path, nuevoArchivo);

                R = true;
            }
            catch (Exception e)
            {
                R = false;
                Console.WriteLine("Error: " + e.Message);
            }
            return R;
        }

        public bool remove(Bus t)
        {
            bool R;
            try
            {
                //recuperar el archivo y convertir en una lista de objetos
                string archivo = File.ReadAllText(path);

                List<Bus> lista = JsonConvert.DeserializeObject<List<Bus>>(archivo);
                //busco el objeto y lo remuevo de las lista
                List<Bus> lista2 = new List<Bus>();
                foreach (var item in lista)
                {
                    if (item.UUID != t.UUID)
                    {
                        lista2.Add(item);
                    }
                }

                //pasar nueva lista a json
                string nuevoArchivo = JsonConvert.SerializeObject(lista2, Formatting.Indented);
                File.WriteAllText(path, nuevoArchivo);

                R = true;
            }
            catch (Exception e)
            {
                R = false;
                Console.WriteLine("Error: " + e.Message);
            }
            return R;
        }

        public List<Bus> findAll()
        {
            List<Bus> R;
            try
            {
                //recuperar el archivo y convertir en una lista de objetos
                string archivo = File.ReadAllText(path);

                R = JsonConvert.DeserializeObject<List<Bus>>(archivo);
            }
            catch (Exception e)
            {
                R = null;
                Console.WriteLine("Error: " + e.Message);
            }
            return R;
        }

        public Bus findById(Guid uuid)
        {
            Bus R;
            try
            {
                //recuperar el archivo y convertir en una lista de objetos
                string archivo = File.ReadAllText(path);

                List<Bus> lista = JsonConvert.DeserializeObject<List<Bus>>(archivo);
                R = lista.Find(x => x.UUID == uuid);
            }
            catch (Exception e)
            {
                R = null;
                Console.WriteLine("Error: " + e.Message);
            }
            return R;
        }
    }
}
