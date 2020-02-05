using System;
using System.Collections.Generic;

namespace apuestaruleta
{
    class Program
    {
        static void Main(string[] args)

        {
           Random random = new Random();
           int numero = random.Next(0,37); // genera numero aleatorio del 0 al 36
           

            List<int> listaapuestas = new List<int>();
            Console.WriteLine("¿Cuántos apostadores hay?");

            int apostadores = Int32.Parse(Console.ReadLine()); // se ingresa la cantidad de apostadores y convierte el valor a entero
            int i = 0;
            int numeroapostador = 1;
            
            while ( i < apostadores)
            {
                Console.WriteLine("Apostador N°: " + numeroapostador + " ingrese su apuesta: (Deber ser un número del 0 al 36)");

                int apuesta = Int32.Parse(Console.ReadLine()); // se ingresa la apuesta y se convierte a entero

                if(apuesta >= 0 & apuesta <= 36) // si el numero ingresado es valido...
                     {
                         listaapuestas.Add(apuesta); // se almacena la apuesta en una lista.
                         i++;
                         numeroapostador++;  
                     }
                else 
                    {
                         Console.WriteLine("Debes ingresar una apuesta del 0 al 36");
                    }
            }


            Console.WriteLine("Presione enter para girar la ruleta.");

            Console.ReadKey();

            cantidadganadores(listaapuestas,numero);
        
            Console.WriteLine("Ganadores: " + ganadores);

            int perdedores = apostadores-ganadores;

            Console.WriteLine("Perdedores: " + perdedores);
        }
        public static int ganadores;
        public static int cantidadganadores (List <int> Lista2, int num)
         {
             foreach(var k in Lista2)
            {
                if(k == num)
                {
                    ganadores++;
                }
            }
            return ganadores;
        }
    }
}
