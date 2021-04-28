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
                Console.WriteLine("Numero + Suma: " + numero + " + " + suma + " = " + (numero+suma));
                suma = suma + numero;
                numero = numero + 2;
            }

            Console.WriteLine("Suma pares entre 2 y 10 = " + suma);
        }
    }
}
