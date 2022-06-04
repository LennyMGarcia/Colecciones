using System;
using System.Collections.Generic;//Paquete para manejar colecciones

namespace Colecciones
{
    class Program
    {
        static void Main(string[] args)
        {
           //permite agregar elementos en tiempo de ejecucion
            List<int> numeros = new List<int>();//Declarar una coleccion de tipo lista
                                                //agrega elementos
            /*numeros.Add(8);
            numeros.Add(5);
            numeros.Add(9);*/

            /*int[] listaNumeros = new int[] { 3, 6, 8, 10, 50 };

            //agrega los numeros de la lista de arriba
            for(int i = 0;i<5;i++)
            {
                numeros.Add(listaNumeros[i]);
            }

            //recorre la lista
            for(int i= 0;i<5;i++)
            {
                Console.WriteLine(numeros[i]);
            }*/

            /*Console.WriteLine("How many elements do you want put into the list?");

            int elem = int.Parse(Console.ReadLine());
            for(int i = 0; i<elem;i++)
            {

                numeros.Add(int.Parse(Console.ReadLine()));
            }
            Console.WriteLine("Los elementos almacenados son: ");
            //count funciona como el del array que es lenght
            for (int i = 0; i < numeros.Count; i++)
            {
                Console.WriteLine(numeros[i]);
            }*/

            Console.WriteLine("introduce elementos en la coleccion (0 para salir)");

            int element = 1;

            while(element!=0)
            {
                element = int.Parse(Console.ReadLine());

                numeros.Add(element);

            }
            //remove el total de elementos contados menos el ultimo
            numeros.RemoveAt(numeros.Count - 1);

            Console.WriteLine("Elementos introducidos: ");

            foreach(int elementos in numeros)
            {
                Console.WriteLine(elementos);
            }
        }
    }
}
