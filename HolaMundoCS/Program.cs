using System;


namespace HolaMundoCS
{
    class Program
    {
       
        static void Mai(string[] args)
        {
            var edad = 22M;

            var nombre = "Luis";

            var fecha = DateTime.Now;

            var texto = String.Format("Hola {0} tienes {1} años. Hoy es {2:d}"
                , nombre, edad,fecha);

            var arr1 = new int[4];
            arr1[0] = 44;
            arr1[1] = 22;
            arr1[2] = 15;
            arr1[3] = 82;

            int[] arr2 = {4, 7, 3, 9};

            for (int i = 0; i < arr1.Length; i++)
            {
                Console.WriteLine("La posicion {0} vale {1}",i,arr1[i]);
            }

            foreach (var i in arr2)
            {
                Console.WriteLine("Vale {0}",i);
            }

            Console.WriteLine("Hola mundo soy un programa c#");

            Console.WriteLine(texto);
            Console.ReadLine();
        }
    }
}
