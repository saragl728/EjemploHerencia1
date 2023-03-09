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
        protected float _tiempoVida;

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

        public virtual float TiempoDeVida
        {
            get { return _tiempoVida; }
            set
            {
                if (value < 0) throw new Exception("Error: valor no posible");
                _tiempoVida = value;
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
            cadena += $"Esperanza de vida: {TiempoDeVida} años\n";
            cadena += $"Alimentación: {tipoAlimentacion()}";
            return cadena;
        }
    }
}
