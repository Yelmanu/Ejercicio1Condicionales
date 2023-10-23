using Ejercicio1Condicionales.Servicios;

namespace Ejercicio1Condicionales.Controladores
{
    class Program
    {
        static public void Main(string[] args)
        {
            //Instanciamos la clase donde se encuentra el método a usar
            NumeroInterfaz ni = new NumeroImplementacion();

            //Declaramos las variables
            int num;
            num = ni.pedirNumero();
            
            //Realizamos la comprobación si el número es par o impar tal como pide el ejercicio
            if (num%2==0)
            {
                Console.WriteLine("El número {0} es un número par", num);
            }
            else
            {
                Console.WriteLine("El número {0} es un número impar", num);
            }
        }
    }
}
