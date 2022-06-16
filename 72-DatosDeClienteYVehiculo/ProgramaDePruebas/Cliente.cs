using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace ProgramaDePruebas
{
    class Cliente
    {
        public string Nombre { get; set; }
        public string Apellido { get; set; }
        public int DNI { get; set; }
        public string ModPago { get; set; }
        public int NumCuotas { get; set; }

        public List<Auto> Autos { get; set; }

        public Cliente()
        {
            this.Autos = new List<Auto>();
        }
    }
}
