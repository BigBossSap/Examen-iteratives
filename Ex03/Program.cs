using System;
using System.Collections.Concurrent;

namespace Ex03
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int num, suma = 0, producto=1, unidades=0, seguent=0;
            int aux;

            

            Console.WriteLine("Introduce un numero a comprobar: ");
            num= Convert.ToInt32(Console.ReadLine());
            aux = num;



            while (num>0) 
            {
                
                unidades = num % 10;
                num = num / 10;            
                suma += unidades;
                
                producto *= unidades;
                



            }

            if (suma==producto)
                Console.WriteLine($"La suma de las cifras de {aux} es {suma}, y el resultado de multiplicar sus cifras es {producto}. Coincide!" );
            else
                Console.WriteLine($"La suma de las cifras de {aux} es {suma}, y el resultado de multiplicar sus cifras es {producto}. No coincide!");




        }
    }
}
