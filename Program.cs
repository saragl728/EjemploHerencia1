namespace EjemploHerencia1
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Animal animal1;
            Mamifero mamifero1;
            Aves pajaro;

            animal1 = new Animal();
            mamifero1 = new Mamifero();
            pajaro = new Aves();

            animal1.Nombre = "Elefante";
            mamifero1.Nombre = "Ballena";
            pajaro.Nombre = "Zorzal";
            Console.WriteLine(animal1.tipoAlimentacion());
            Console.WriteLine(mamifero1.tipoAlimentacion());
            Console.WriteLine(pajaro.tipoAlimentacion());


            Console.WriteLine(animal1.Nombre);
            Console.WriteLine(mamifero1.Nombre);
            Console.WriteLine(pajaro.Nombre);

            Console.WriteLine(animal1.ToString());
        }
    }
}