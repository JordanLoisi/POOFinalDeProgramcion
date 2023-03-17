using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using POOPaciente.Entidades;

namespace POOPaciente.Datos
{
    public class Repositorio
    {
        private bool hayCambios = false;
        private List<Personas> ListaDePersonas;
        public Repositorio()
        {
            ListaDePersonas = new List<Personas>();
            ListaDePersonas = ManejadorDeArchivosSecuenciales.LeerArchivoSecuencial();
        }
        public int Getcantidad()
        {
            return ListaDePersonas.Count();
        }
        public List<Personas> GetLista()
        {
            return ListaDePersonas;
        }
        public void Agregar(Personas personas)
        {
            hayCambios = true;
            ListaDePersonas.Add(personas);

        }
        public void Borrar(Personas personas)
        {
            if (ListaDePersonas.Contains(personas))
            {
                hayCambios = true;
                ListaDePersonas.Remove(personas);
            }

        }
        public void Editar(Personas personas)
        {
            hayCambios = true;
        }
        public void Guardar()
        {
            if (hayCambios)
            {
                ManejadorDeArchivosSecuenciales.GuardarArchivoSecuencial(ListaDePersonas);
            }
        }
        static public double IMC(double Altura, double Peso)
        {
            return Peso / (Altura * 2);
        }
        public String CategoriaIMC(Personas personas)
        {
            var imc = Repositorio.IMC(personas.Altura, personas.Peso);

            if (imc < 18.5)
            {
                return "BajoDePeso";
            }
            else if (imc > 18.5 && imc < 24.9)
            {
                return "Normal";
            }
            else if (imc > 25.0 && imc < 29.9)
            {
                return "Sobrepeso";
            }
            else
            {
                return "obesidad";
            }


        }

        public List<Personas> GetOrden(Ordenar orden)
        {
            return orden == Ordenar.Acendente ? ListaDePersonas.OrderBy(J => J.Edad).ToList() : ListaDePersonas.OrderByDescending(E => E.Edad).ToList();
        }

        public List<Personas> FiltrarLista(Sexo filtro)
        {
            return ListaDePersonas.Where(P => P.sexo == filtro).ToList();
        }
    }
}


