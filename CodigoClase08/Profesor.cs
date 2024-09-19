using Microsoft.VisualBasic;
using System;
using System.Collections.Generic;
using System.Diagnostics.CodeAnalysis;
using System.Dynamic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CodigoClase08
{
    //Las clases singular
    public class Profesor
    {

        #region Propiedades

        public string Nombres { get; set; }
        public string Apellidos { get; set; }
        public double Sueldo { get; set; }
        
        //prop + tap y se genera la propiedad
        public string TipoDocumento { get; set; }
        public int EscalaSalarial { get; set; }
        public DateTime FechaNacimiento { get; set; }
        public DateTime FechaIngreso { get; set; }

        #endregion
        

        public int ObtenerAnniosTrabajados()
        {
            int anniosTrabajados = DateAndTime.Now.Year - FechaIngreso.Year;
            return anniosTrabajados;
        }
          
        //No tengo una propiedad llamada nombres completos
        public string ObtenerNombresCompletos()
        {
            return Nombres + " " + Apellidos;
        }

        public int CalcularEdad()
        {
            int edad = DateAndTime.Now.Year - FechaNacimiento.Year;
            return edad;
        }

        //Si tengo una propiedad llamada asignar Sueldo
        public void AsignarSueldo()
        {
            switch (EscalaSalarial)
            {
                case 1:
                    Sueldo = 1000;
                    break;
                case 2:
                    Sueldo = 2000;
                    break;
                case 3:
                    Sueldo = 3000;
                    break;
            }
        }

       
       
        
       


    }
}
