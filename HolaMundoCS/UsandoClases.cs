using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ClasesPersonas;

namespace HolaMundoCS
{
    class UsandoClases
    {
        public static void Main(string[] args)
        {
            var p = new Persona();
            p.Nombre = "Luis";
            p.Edad = 22;

            Console.WriteLine(p.Nombre);

            var p2 = new Persona()
            {
                Nombre = "Luis",
                Edad = 22

            };
        p2.Detalles();

            Console.WriteLine();
        }

    }
}
