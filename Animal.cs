using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EjemploHerencia1
{
    internal class Animal
    {
        private const int TAM_NOMBRE = 20; 
        protected string _alimentacion = "Comida";
        protected string _nombre;
        protected string _habitat;

        public virtual string Nombre
        {
            get { return _nombre; }
            set
            {
                if (value.Length > TAM_NOMBRE) throw new Exception("El nombre es demasiado largo");
                _nombre = value;
            }
        }

        public virtual string Habitat
        {
            get { return _habitat ; }
            set
            {
                _habitat = value;
            }
        }

        public virtual string tipoAlimentacion()
        {
            return _alimentacion;
        }

        public override string ToString()
        {
            string cadena = "Datos animal\n";
            cadena += $"Especie: {Nombre}\n";
            cadena += $"Hábitat: {Habitat}\n";
            cadena += $"Alimentación: {tipoAlimentacion()}";
            return cadena;
        }
    }
}
