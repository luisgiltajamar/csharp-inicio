using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClasesPersonas
{
    public class Telefono
    {
        public String Marca { get; set; }
        public String Modelo { get; set; }
        public double Precio { get; set; }

        public double PrecioConIva()
        {
            return Precio*1.21;
        }

    }
}
