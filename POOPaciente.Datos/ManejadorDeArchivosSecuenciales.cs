using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using POOPaciente.Entidades;

namespace POOPaciente.Datos
{
    public class ManejadorDeArchivosSecuenciales
    {
        private static string archivo = "Paciente.txt";

        public static void GuardarArchivoSecuencial(List<Personas> listaPersonas)
        {
            using (var escritor = new StreamWriter(archivo))
            {
                foreach (var persona in listaPersonas)
                {
                    string linea = costruirlinea(persona);
                    escritor.WriteLine(linea);
                }
            }
        }

        private static string costruirlinea(Personas persona)
        {
            return $"{persona.PrimerNombre}|{persona.SegundoNombre}|{persona.Apellido}|{persona.Documento}|{persona.Edad}|{(int)persona.sexo}|{(Double)persona.Altura}|{(double)persona.Peso}";

        }
        public static List<Personas> LeerArchivoSecuencial()
        {
            List<Personas> lista = new List<Personas>();
            if (File.Exists(archivo))
            {
                using (var lector = new StreamReader(archivo))
                {
                    while (!lector.EndOfStream)
                    {
                        string linea = lector.ReadLine();
                        Personas personas = CrearPersonas(linea);
                        lista.Add(personas);
                    }
                }

            }
            return lista;
        }

        private static Personas CrearPersonas(string linea)
        {
            var campos = linea.Split('|');
            Personas personas = new Personas()
            {
                PrimerNombre = campos[0],
                SegundoNombre = campos[1],
                Apellido = campos[2],
                Documento = long.Parse(campos[3]),
                Edad = DateTime.Parse(campos[4]),
                sexo = (Sexo)int.Parse(campos[5]),
                Altura = int.Parse(campos[6]),
                Peso = int.Parse(campos[7])
            };
            return personas;
        }
    }
}




