using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClasesPersonas
{
   public class Alumno: Persona
    {
       //public void borrar()
       //{
       //    _edad = 22;
       //}

       public int Nota { get; set; }

       public Alumno()
       {
       }

       public Alumno(int edad, int nota)//:base(,edad)
       {
           Edad = edad;
           Nota = nota;
       }

       public Alumno(String nombre, int edad, int nota)
         : base(nombre, edad)
       {
           Nota = nota;

       }

       sealed public  override  void  Detalles()
       {
           Console.WriteLine("Nombre: {0} Edad: {1} Nota: {2}", Nombre, Edad,Nota);
       }

       public override string ToString()
       {
           return "Pepe";
       }
    }
}
