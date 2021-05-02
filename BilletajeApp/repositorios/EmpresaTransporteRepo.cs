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
    public class EmpresaTransporteRepo : IRepository<EmpresaTransporte>
    {
        private string path;

        public EmpresaTransporteRepo()
        {
            EmpresaTransporte t = new EmpresaTransporte();
            this.path = Directory.GetParent(Directory.GetCurrentDirectory()).Parent.FullName.ToString() + "/bd/" + t.className + ".json";
        }

        public bool create(EmpresaTransporte t)
        {
            bool R;
            try
            {
                //recuperar el archivo y convertir en una lista de objetos
                string archivo;
                List<EmpresaTransporte> lista;

                try
                {
                    archivo = File.ReadAllText(path);
                    lista = JsonConvert.DeserializeObject<List<EmpresaTransporte>>(archivo);
                }
                catch (Exception)
                {
                    File.WriteAllText(path, "");
                    lista = null;
                }


                if (lista == null) lista = new List<EmpresaTransporte>();

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

        public bool edit(EmpresaTransporte t)
        {
            bool R;
            try
            {
                //recuperar el archivo y convertir en una lista de objetos
                string archivo = File.ReadAllText(path);

                List<EmpresaTransporte> lista = JsonConvert.DeserializeObject<List<EmpresaTransporte>>(archivo);
                //busco el objeto y lo remuevo de las lista
                List<EmpresaTransporte> lista2 = new List<EmpresaTransporte>();
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

        public bool remove(EmpresaTransporte t)
        {
            bool R;
            try
            {
                //recuperar el archivo y convertir en una lista de objetos
                string archivo = File.ReadAllText(path);

                List<EmpresaTransporte> lista = JsonConvert.DeserializeObject<List<EmpresaTransporte>>(archivo);
                //busco el objeto y lo remuevo de las lista
                List<EmpresaTransporte> lista2 = new List<EmpresaTransporte>();
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

        public List<EmpresaTransporte> findAll()
        {
            List<EmpresaTransporte> R;
            try
            {
                //recuperar el archivo y convertir en una lista de objetos
                string archivo = File.ReadAllText(path);

                R = JsonConvert.DeserializeObject<List<EmpresaTransporte>>(archivo);
            }
            catch (Exception e)
            {
                R = null;
                Console.WriteLine("Error: " + e.Message);
            }
            return R;
        }

        public EmpresaTransporte findById(Guid uuid)
        {
            EmpresaTransporte R;
            try
            {
                //recuperar el archivo y convertir en una lista de objetos
                string archivo = File.ReadAllText(path);

                List<EmpresaTransporte> lista = JsonConvert.DeserializeObject<List<EmpresaTransporte>>(archivo);
                R = lista.Find(x => x.UUID == uuid);
            }
            catch (Exception e)
            {
                R = null;
                Console.WriteLine("Error: " + e.Message);
            }
            return R;
        }

        public EmpresaTransporte findByNombre(String nombre)
        {
            EmpresaTransporte R;
            try
            {
                //recuperar el archivo y convertir en una lista de objetos
                string archivo = File.ReadAllText(path);

                List<EmpresaTransporte> lista = JsonConvert.DeserializeObject<List<EmpresaTransporte>>(archivo);
                R = lista.Find(x => x.nombre == nombre);
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