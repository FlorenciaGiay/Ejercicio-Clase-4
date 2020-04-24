using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Logica
{
    public static class ConversorTemperatura
    {
        private static double factorConversion = 2.12;

        public static double ObtenerTemperaturaFahrenheit(double temperatura)
        {
            return temperatura * factorConversion;
        }

        public static double ObtenerTemperaturaCelcius(double temperatura)
        {
            return temperatura / factorConversion;
        }
    }
}
