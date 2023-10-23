using Ejercicio1Condicionales.Servicios;

namespace Ejercicio1Condicionales.Controladores
{
    class Program
    {
        static public void Main(string[] args)
        {
            NumeroInterfaz ni = new NumeroImplementacion();
            int num;
            num = ni.pedirNumero();
            
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
