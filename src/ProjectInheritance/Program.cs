using System;

namespace ProjectInheritance
{
    class Program
    {
        static void Main(string[] args)
        {

            Caballo caballito = new Caballo("Spirit");
            Humano papa = new Humano("Guillermo");
            Gorila king = new Gorila("Kong");

            Mamiferos animal = new Caballo("Animalito");
            
            Mamiferos peluchito = new Mamiferos("Caballo de peluche");
            Caballo juguete = new Caballo("Tiro al blanco");

            king.getNombre();

            peluchito = juguete;

            //juguete = peluchito; // sale error porque un mamifero no siempre es un caballo

            Mamiferos[] almacenAnimales = new Mamiferos[3];

            almacenAnimales[0] = caballito;
            almacenAnimales[1] = papa;
            almacenAnimales[2] = king;

            almacenAnimales[1].getNombre();

            for (int i = 0; i < 3; i++)
            {
                almacenAnimales[i].pensar();
            }

        }

    }

    class Mamiferos
    {
        public Mamiferos(String nombre)
        {
            nombreSerVivo = nombre;
        }

        protected void respirar() // Es accesible de la clase principal y las que heredan.
        {
            Console.WriteLine("Soy capaz de respirar");
        }
        public virtual void pensar() // Metodo modificable
        {
            Console.WriteLine("Pensamiento basico instintivo");
        }
        public void cuidarCrias() // Public es accesible desde cualquier otra clase del programa.
        {
            Console.WriteLine("Cuido de mis crias hasta que se valgan por si solas");
        }
        public void getNombre()
        {
            Console.WriteLine("El nombre del ser vivo es " + nombreSerVivo);
        }

        private String nombreSerVivo; // Es mas recomendable encapsular los objetos con private. 
        // Solo permite acceso desde la misma clase.
    }

    class Caballo : Mamiferos // Clase que hereda y Clase de la que hereda
    {
        // Si la clase padre no tiene un constructor definido, no es necesario introducir ":base()"
        public Caballo(String nombreCaballo) : base(nombreCaballo) // Base es el constructor de la clase padre
        {

        }

        public void galopar()
        {
            Console.WriteLine("Soy capaz de galopar");
        }

    }

    class Humano : Mamiferos
    {
        public Humano(String nombreHumano) : base(nombreHumano)
        { 

        }
        public override void pensar() // Es una modificacion o sobre escritura del metodo. No es uno diferente.
        {
            Console.WriteLine("Soy capaz de pensar");
        }
    }

    class Gorila : Mamiferos
    {
        public Gorila(String nombreGorila) : base(nombreGorila)
        {

        }
        new public void pensar() // se puede corregir con una sobrecarga de parametros, se corrije con new.
        {
            Console.WriteLine("Pensamiento distintivo avanzado");
        }
        public void trepar()
        {
            Console.WriteLine("Soy capaz de trepar");
        }
        
    }
}
