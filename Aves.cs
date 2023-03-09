using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EjemploHerencia1
{
    internal class Aves : Animal
    {
        public override string tipoAlimentacion()
        {
            return base.tipoAlimentacion() + ": Insectos";
        }
    }
}
