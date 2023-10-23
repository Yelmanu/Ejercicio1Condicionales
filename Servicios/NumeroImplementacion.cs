using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ejercicio1Condicionales.Servicios
{
    internal class NumeroImplementacion:NumeroInterfaz
    {
        /// <summary>
        /// Método para pedir el número o los números utilizados para realizar la comprobación si es par o impar
        /// 231023 - MDN
        /// </summary>
        /// <returns>int - Devuelve el número introducido por el usuario por consola</returns>
        public int pedirNumero()
        {
            int numero;
            Console.WriteLine("Introduce un número: ");
            numero = Convert.ToInt32(Console.ReadLine());
            return numero;
        }
    }
}
