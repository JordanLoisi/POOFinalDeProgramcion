using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace POOPaciente.Entidades
{
   public class Personas
    {
        public string PrimerNombre { get; set; }

        public string SegundoNombre { get; set; }

        public string Apellido { get; set; }

        public long Documento { get; set; }

        public Sexo sexo { get; set; }
        public double Altura { get; set; }
        public double Peso { get; set; }
        public DateTime Edad { get; set; }

        public string MostrarNombre()
        {
            return $"{Apellido.ToUpper()},{PrimerNombre}/{SegundoNombre.ToUpper()}.";
        }

        public int GetSacarEdad()
        {
            int edad = DateTime.Today.Year - Edad.Year;
            if (Edad.AddYears(edad) > DateTime.Today)
            {
                edad--;
            }
            return edad;
        }
    }
}
