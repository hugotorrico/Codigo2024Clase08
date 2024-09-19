using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CodigoClase08
{
    public class Trabajador
    {
        public double SueldoBruto { get; set; }

        double CalcularDescuento()
        {         
            return SueldoBruto * Impuesto.ReciboHonorarios;
        }
   
        public double CalcularSueldoNeto()
        {
            return SueldoBruto - CalcularDescuento();
        }
    }
}
