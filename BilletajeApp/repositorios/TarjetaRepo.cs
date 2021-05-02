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
        private string path;

        public TarjetaRepo() {
            Tarjeta t = new Tarjeta();
            this.path = Directory.GetParent(Directory.GetCurrentDirectory()).Parent.FullName.ToString() + "/bd/"+t.className+".json";
        }

        public bool create(Tarjeta t)
        {
            bool R;
            try
            {
                //recuperar el archivo y convertir en una lista de objetos
                string archivo;
                List<Tarjeta> lista;
                
                try
                {
                    archivo = File.ReadAllText(path);
                    lista = JsonConvert.DeserializeObject<List<Tarjeta>>(archivo);
                }
                catch (Exception)
                {
                    File.WriteAllText(path, "");
                    lista = null;
                }


                if (lista == null) lista = new List<Tarjeta>();

                //agrego el nuevo objeto creado al final
                lista.Add(t);

                //pasar nueva lista a json
                string nuevoArchivo = JsonConvert.SerializeObject(lista,Formatting.Indented);
                File.WriteAllText(path, nuevoArchivo);

                R = true;

            }
            catch (Exception e)
            {
                R = false;
                Console.WriteLine("Error: "+e.Message);
            }
            return R;
        }

        public bool edit(Tarjeta t)
        {
            bool R;
            try
            {
                //recuperar el archivo y convertir en una lista de objetos
                string archivo = File.ReadAllText(path);

                List<Tarjeta> lista = JsonConvert.DeserializeObject<List<Tarjeta>>(archivo);
                //busco el objeto y lo remuevo de las lista
                List<Tarjeta> lista2 = new List<Tarjeta>();
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

        public bool remove(Tarjeta t)
        {
            bool R;
            try
            {
                //recuperar el archivo y convertir en una lista de objetos
                string archivo = File.ReadAllText(path);

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

        public List<Tarjeta> findAll()
        {
            List<Tarjeta> R;
            try
            {
                //recuperar el archivo y convertir en una lista de objetos
                string archivo = File.ReadAllText(path);

                R = JsonConvert.DeserializeObject<List<Tarjeta>>(archivo);                
            }
            catch (Exception e)
            {
                R = null;
                Console.WriteLine("Error: " + e.Message);
            }
            return R;
        }

        public Tarjeta findById(Guid uuid)
        {
            Tarjeta R;
            try
            {
                //recuperar el archivo y convertir en una lista de objetos
                string archivo = File.ReadAllText(path);

                List<Tarjeta> lista = JsonConvert.DeserializeObject<List<Tarjeta>>(archivo);
                R = lista.Find(x => x.UUID == uuid);                
            }
            catch (Exception e)
            {
                R = null;
                Console.WriteLine("Error: " + e.Message);
            }
            return R;
        }

        public Tarjeta findByNumero(String numero)
        {
            Tarjeta R;
            try
            {
                //recuperar el archivo y convertir en una lista de objetos
                string archivo = File.ReadAllText(path);

                List<Tarjeta> lista = JsonConvert.DeserializeObject<List<Tarjeta>>(archivo);
                R = lista.Find(x => x.numero == numero);
            }
            catch (Exception e)
            {
                R = null;
                Console.WriteLine("Error: " + e.Message);
            }
            return R;
        }

        public double sumarSaldo(String numero, double monto)
        {
            Tarjeta t;
            double R;
            try
            {
                //recuperar el archivo y convertir en una lista de objetos
                string archivo = File.ReadAllText(path);

                List<Tarjeta> lista = JsonConvert.DeserializeObject<List<Tarjeta>>(archivo);
                t = lista.Find(x => x.numero == numero);
                t.saldo += monto;
                R = t.saldo;
            }
            catch (Exception e)
            {
                R = 0;
                Console.WriteLine("Error: " + e.Message);
            }
            return R;
        }

        public double restarSaldo(String numero, double monto)
        {
            Tarjeta t;
            double R;
            try
            {
                //recuperar el archivo y convertir en una lista de objetos
                string archivo = File.ReadAllText(path);

                List<Tarjeta> lista = JsonConvert.DeserializeObject<List<Tarjeta>>(archivo);
                t = lista.Find(x => x.numero == numero);
                t.saldo -= monto;
                R = t.saldo;
            }
            catch (Exception e)
            {
                R = 0;
                Console.WriteLine("Error: " + e.Message);
            }
            return R;
        }

        public bool asignarUsuario(String numero, Usuario u)
        {
            Tarjeta t;
            bool R;
            try
            {
                //recuperar el archivo y convertir en una lista de objetos
                string archivo = File.ReadAllText(path);

                List<Tarjeta> lista = JsonConvert.DeserializeObject<List<Tarjeta>>(archivo);
                t = lista.Find(x => x.numero == numero);
                t.usuario = u;
                R = true;
            }
            catch (Exception e)
            {
                R = false;
                Console.WriteLine("Error: "+e.Message);
            }
            return R;
        }
    }
}
