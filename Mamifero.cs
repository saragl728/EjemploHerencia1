using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EjemploHerencia1
{
    internal class Mamifero : Animal
    {
        
        public override string tipoAlimentacion()
        {
            string cadena;
            //_alimentacion = "";
            cadena = base.tipoAlimentacion();
            cadena += ": Otros seres vivos";

            return cadena;
        }

        public override string Nombre
        {
            get { return _nombre; }
            set
            {
                if (string.IsNullOrWhiteSpace(value)) throw new Exception("El nombre no puede ser nulo");
                base.Nombre = value;
            }
        }
    }
}
