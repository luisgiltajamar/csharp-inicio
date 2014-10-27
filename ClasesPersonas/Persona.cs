using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClasesPersonas
{
    public class Persona
    {
        private int _edad;


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
    }
}
