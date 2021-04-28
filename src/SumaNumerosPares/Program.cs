using System;

namespace SumaNumerosPares
{
    class Program
    {
        static void Main(string[] args)
        {
            int numero = 4;
            int suma = 2;

            while(numero <= 10){
                suma = suma + numero;
                numero = numero + 2;
            }

            Console.WriteLine("Suma pares entre 2 y 10 = " + suma);
        }
    }
}
