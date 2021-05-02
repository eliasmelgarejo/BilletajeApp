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
    public class EmpresaBilletajeRepo : IRepository<EmpresaBilletaje>
    {
        private string path;

        public EmpresaBilletajeRepo()
        {
            EmpresaBilletaje t = new EmpresaBilletaje();
            this.path = Directory.GetParent(Directory.GetCurrentDirectory()).Parent.FullName.ToString() + "/bd/" + t.className + ".json";
        }

        public bool create(EmpresaBilletaje t)
        {
            bool R;
            try
            {
                //recuperar el archivo y convertir en una lista de objetos
                string archivo;
                List<EmpresaBilletaje> lista;

                try
                {
                    archivo = File.ReadAllText(path);
                    lista = JsonConvert.DeserializeObject<List<EmpresaBilletaje>>(archivo);
                }
                catch (Exception)
                {
                    File.WriteAllText(path, "");
                    lista = null;
                }


                if (lista == null) lista = new List<EmpresaBilletaje>();

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

        public bool edit(EmpresaBilletaje t)
        {
            bool R;
            try
            {
                //recuperar el archivo y convertir en una lista de objetos
                string archivo = File.ReadAllText(path);

                List<EmpresaBilletaje> lista = JsonConvert.DeserializeObject<List<EmpresaBilletaje>>(archivo);
                //busco el objeto y lo remuevo de las lista
                List<EmpresaBilletaje> lista2 = new List<EmpresaBilletaje>();
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

        public bool remove(EmpresaBilletaje t)
        {
            bool R;
            try
            {
                //recuperar el archivo y convertir en una lista de objetos
                string archivo = File.ReadAllText(path);

                List<EmpresaBilletaje> lista = JsonConvert.DeserializeObject<List<EmpresaBilletaje>>(archivo);
                //busco el objeto y lo remuevo de las lista
                List<EmpresaBilletaje> lista2 = new List<EmpresaBilletaje>();
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

        public List<EmpresaBilletaje> findAll()
        {
            List<EmpresaBilletaje> R;
            try
            {
                //recuperar el archivo y convertir en una lista de objetos
                string archivo = File.ReadAllText(path);

                R = JsonConvert.DeserializeObject<List<EmpresaBilletaje>>(archivo);
            }
            catch (Exception e)
            {
                R = null;
                Console.WriteLine("Error: " + e.Message);
            }
            return R;
        }

        public EmpresaBilletaje findById(Guid uuid)
        {
            EmpresaBilletaje R;
            try
            {
                //recuperar el archivo y convertir en una lista de objetos
                string archivo = File.ReadAllText(path);

                List<EmpresaBilletaje> lista = JsonConvert.DeserializeObject<List<EmpresaBilletaje>>(archivo);
                R = lista.Find(x => x.UUID == uuid);
            }
            catch (Exception e)
            {
                R = null;
                Console.WriteLine("Error: " + e.Message);
            }
            return R;
        }

        public EmpresaBilletaje findByNombre(String nombre)
        {
            EmpresaBilletaje R;
            try
            {
                //recuperar el archivo y convertir en una lista de objetos
                string archivo = File.ReadAllText(path);

                List<EmpresaBilletaje> lista = JsonConvert.DeserializeObject<List<EmpresaBilletaje>>(archivo);
                R = lista.Find(x => x.Nombre == nombre);
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