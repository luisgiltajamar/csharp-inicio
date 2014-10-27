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
            Operaciones.Sumar(5, 9);
            Persona.AñoActual = 2015;
            var p = new Alumno();
            p.Nombre = "Luis";
            p.Edad = 10;

            Console.WriteLine(p.Nombre);

            var p2 = new Alumno()
            {
                Nombre = "Luis",
                Edad = 22

            };
            Persona.IncrementarAñoActual(8);
            p.Detalles(60,años:true);

        p2.Detalles();

            Console.ReadLine();
        }

    }
}
