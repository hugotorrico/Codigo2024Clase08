using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Demo02
{
    public class Estudiante : Persona
    {      

        public List<string> Materias { get; set; }

        public List<int> Notas { get; set; }


        //public string PaisIntercambio { get; set; }
        //public string CiudadIntercambio { get; set; }
        //public string NumeroPasaporte { get; set; }



        //public string NombreEscuela { get; set; }
        //public string DireccionEscuela { get; set; }
        //public string CantidadEstudianteEscuela { get; set; }

        public double CalcularPromedio()
        {
            return Notas.Average();
        }
        //public Estudiante()
        //{
        //    Materias = new List<string>();
        //}
    }
}
