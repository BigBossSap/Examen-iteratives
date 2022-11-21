using System;

namespace Ex05
{
    internal class Program
    {
        static void Main(string[] args)
        {

            //Si el resto está entre 0 y 9, este mismo valor es el del dígito de control. Pero si el resto es 10, entonces se establece como dígito de control la letra X.

            int isbn, unitats, suma=0, i=9,multi;
            char digitControl;

            Console.WriteLine("ISBN: ");
            isbn = Convert.ToInt32(Console.ReadLine());

         
            while (isbn<100000000 || isbn>999999999)
            {
                Console.WriteLine("ISBN incorrecte. Torna a introduir: ");
                Console.WriteLine("numero: ");
                isbn = Convert.ToInt32(Console.ReadLine());
            }

            Console.WriteLine("Digit de Control: ");
            digitControl = Convert.ToChar(Console.ReadLine());

            if (digitControl != 120)
            {
                while (digitControl < 48 || digitControl > 57)
                {
                    Console.WriteLine("Digit de Control Incorrecte");
                    Console.WriteLine("Digit de Control: ");
                    digitControl = Convert.ToChar(Console.ReadLine());
                }
            }
            while (isbn > 0)
            {
                unitats = isbn % 10;
                isbn /=  10;                                         
                multi = unitats *i;
                i--;
                suma += multi;                                
            }

            Console.WriteLine(suma);
            if (suma%11+48==(int)digitControl)
                Console.WriteLine("ISBN Correcto");
            else if (suma%11==10 && digitControl==120)
                Console.WriteLine("ISBN Correcto");
            else
                Console.WriteLine("ISBN Incorrecto");
            

            
            












        }
    }
}
