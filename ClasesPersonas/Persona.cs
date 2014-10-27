using System;


namespace ClasesPersonas
{
    public abstract class Persona
    {
        protected int _edad;

        public static int AñoActual=2014;

        public static void IncrementarAñoActual(int n)
        {
            AñoActual += n;
          
        }

        public int Edad {
            get { return _edad; }
            set { _edad = value*365; }
        }

        public String Nombre { get; set; }

        public Persona()
        {
        }

        public Persona(String nombre, int edad)
        {
            Nombre = nombre;
            Edad = edad;
        }

        public void Detalles()
        {
            Console.WriteLine("Nombre: {0} Edad: {1}",Nombre,Edad);
        }

        public void Detalles(int extra, bool unaLinea = true, bool años = false)
        {
            if (años)
            {
                if (unaLinea)
                    Console.WriteLine("Nombre: {0} Edad: {1}", Nombre, Edad/365);
                else
                {
                    Console.WriteLine("Nombre: {0} ", Nombre);
                    Console.WriteLine("Edad: {0}", Edad/365);
                }
            }
            else
            {
                if (unaLinea)
                    Console.WriteLine("Nombre: {0} Edad: {1}", Nombre, Edad +extra);
                else
                {
                    Console.WriteLine("Nombre: {0} ", Nombre);
                    Console.WriteLine("Edad: {0}", Edad+extra );
                }
            }
        }
    }
}
