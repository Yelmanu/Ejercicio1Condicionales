using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ejercicio1Condicionales.Servicios
{
    internal interface NumeroInterfaz
    {
        /// <summary>
        /// Pide un número por consola para realizar la comprobación
        /// 231023 - MDN
        /// </summary>
        /// <returns>int - Devuelve el número introducido por el usuario</returns>
        public int pedirNumero();
    }
}
