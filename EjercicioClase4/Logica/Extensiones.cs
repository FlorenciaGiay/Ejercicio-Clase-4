﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Text.RegularExpressions;


namespace Logica
{
    public static class Extensiones
    {
        public static int RetornarCantidadPalabras(this string cadena)
        {
            string[] arregloPalabras = cadena.Split(' ');
            return arregloPalabras.Count();
        }

        public static int RetornarCantidadPalabras(this string cadena, char separador)
        {
            string[] arregloPalabras = cadena.Split(separador);
            return arregloPalabras.Count();
        }

        public static decimal CalcularDiferenciaFechas(this DateTime fechaMayor, DateTime fechaMenor)
        {
            return Convert.ToDecimal((fechaMayor - fechaMenor).TotalSeconds) / 60;
        }

        public static double DevolverPromedio(this List<int> listaNumeros)
        {
            return Convert.ToDouble(listaNumeros.Average());

        }

        public static int ObtenerMultipicacionSumaParesRestaImpares(this List<int> listaNumeros)
        {
            return (listaNumeros.FindAll(x => x % 2 == 0).Sum()) * ((listaNumeros.First(x=>x % 2 != 0)*2) + ((listaNumeros.FindAll(x => x % 2 != 0).Sum())*-1));
        }

        public static DateTime ObtenerFechaDeUnString (this string fecha)
        {
            DateTime fechaConvertida = new DateTime();
            try
            {
                fechaConvertida = DateTime.Parse(fecha);
            }
            catch(Exception)
            {
                fechaConvertida = DateTime.MinValue;
            }
            return fechaConvertida;
        }

        public static string DevolverStringInvertido(this string cadena)
        {
            return cadena.Reverse().ToString();
        }

        public static string ConcatenarArrayStrings(this string[] cadenas, char separador)
        {
            return string.Join(separador.ToString(), cadenas);
        }

        public static bool ComprobarEmail(this string email)
        {
            String formato = "\\w+([-+.']\\w+)*@\\w+([-.]\\w+)*\\.\\w+([-.]\\w+)*";
            if (Regex.IsMatch(email, formato))
            {
                if (Regex.Replace(email, formato, String.Empty).Length == 0)
                {
                    return true;
                }
                else
                {
                    return false;
                }
            }
            else
            {
                return false;
            }
        }

        public static int RestarDosNumeros(this int entero1, int entero2)
        {
            return entero1 - entero2;
        }

        
    }
}
