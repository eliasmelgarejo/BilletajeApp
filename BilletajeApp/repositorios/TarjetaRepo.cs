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
                //recuperar el archivo y convertir en una lista de objetos
                String path = @"C:\Users\Elias\source\repos\BilletajeApp\BilletajeApp\bd\"+
                    getFileName(t.className).ToLower();
                string archivo = System.IO.File.ReadAllText(path);

                List<Tarjeta> lista;
                lista = JsonConvert.DeserializeObject<List<Tarjeta>>(archivo);

                if (lista == null) lista = new List<Tarjeta>();
                //agrego el nuevo objeto creado al final
                lista.Add(t);

                //pasar nueva lista a json
                string nuevoArchivo = JsonConvert.SerializeObject(lista);
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
                String path = @"C:\Users\Elias\source\repos\BilletajeApp\BilletajeApp\bd\" + getFileName(t.className).ToLower();
                string archivo = System.IO.File.ReadAllText(path);

                List<Tarjeta> lista = JsonConvert.DeserializeObject<List<Tarjeta>>(archivo);
                //busco el objeto y lo remuevo de las lista
                lista.Remove(t);

                //pasar nueva lista a json
                string nuevoArchivo = JsonConvert.SerializeObject(lista);
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
                String path = @"C:\Users\Elias\source\repos\BilletajeApp\BilletajeApp\bd\" + getFileName("tarjeta");
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

        public Tarjeta findById(long id)
        {
            Tarjeta R;
            try
            {
                //recuperar el archivo y convertir en una lista de objetos
                String path = @"C:\Users\Elias\source\repos\BilletajeApp\BilletajeApp\bd\" + getFileName("tarjeta");
                string archivo = System.IO.File.ReadAllText(path);

                List<Tarjeta> lista = JsonConvert.DeserializeObject<List<Tarjeta>>(archivo);
                R = lista.Find(x => x.id == id);                
            }
            catch (Exception)
            {
                R = null;
                throw;
            }
            return R;
        }

        public string getFileName(string className)
        {
            return className+".json";
        }
    }
}
