using System;
using System.Collections.Generic;
using System.Diagnostics.CodeAnalysis;
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
        public string  TipoDocumento { get; set; }
        public int EscalaSalarial { get; set; }

        #endregion

        //No tengo una propiedad llamada nombres completos
        public string ObtenerNombresCompletos()
        {
            return Nombres + " " + Apellidos;
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
