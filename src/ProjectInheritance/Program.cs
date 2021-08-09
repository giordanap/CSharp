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

            // Aplico el principio de sustitucion para poder acceder a los metodos
            // que se tuvieron que modificar su acceso para resolver la ambiguedad.
            IMamiferosTerresters IMTcaballito = caballito;
            ISaltoConPatas ISCPcaballito = caballito;

            //Mamiferos animal = new Caballo("Animalito");

            //Mamiferos peluchito = new Mamiferos("Caballo de peluche");
            //Caballo juguete = new Caballo("Tiro al blanco");

            king.GetNombre();

            //peluchito = juguete;

            //juguete = peluchito; // sale error porque un mamifero no siempre es un caballo

            Mamiferos[] almacenAnimales = new Mamiferos[3];

            almacenAnimales[0] = caballito;
            almacenAnimales[1] = papa;
            almacenAnimales[2] = king;

            almacenAnimales[1].GetNombre();

            for (int i = 0; i < 3; i++)
            {
                almacenAnimales[i].Pensar();
            }

            Ballena miWally = new Ballena("Wally");

            miWally.Nadar();

            Console.WriteLine("El numero de patas es: " + IMTcaballito.NumeroPatas());
            Console.WriteLine("Salta con " + ISCPcaballito.NumeroPatas() + " patas");

        }

    }

    interface IMamiferosTerresters
    {
        // definir los metodos que obligatoriamente se van a heredar.
        // No es necesario un modificador de acceso como un public o private
        int NumeroPatas();

    }

    interface IAnimalesYDeportes
    {
        // Debo definir los metodos que quiero que se definan si o si
        string TipoDeporte();
        bool EsOlimpico();
    }
    interface ISaltoConPatas
    {
        int NumeroPatas();
    }
    class Mamiferos
    {
        public Mamiferos(String nombre)
        {
            nombreSerVivo = nombre;
        }

        protected void Respirar() // Es accesible de la clase principal y las que heredan.
        {
            Console.WriteLine("Soy capaz de respirar");
        }
        public virtual void Pensar() // Metodo modificable
        {
            Console.WriteLine("Pensamiento basico instintivo");
        }
        public void CuidarCrias() // Public es accesible desde cualquier otra clase del programa.
        {
            Console.WriteLine("Cuido de mis crias hasta que se valgan por si solas");
        }
        public void GetNombre()
        {
            Console.WriteLine("El nombre del ser vivo es " + nombreSerVivo);
        }

        private String nombreSerVivo; // Es mas recomendable encapsular los objetos con private. 
        // Solo permite acceso desde la misma clase.
    }

    class Ballena : Mamiferos
    {
        public Ballena(String nombreBallena) : base(nombreBallena)
        {

        }

        public void Nadar()
        {
            Console.WriteLine("Soy capaz de nadar");
        }
    }

    class Caballo : Mamiferos, IMamiferosTerresters, IAnimalesYDeportes, ISaltoConPatas
        // Clase que hereda y Clase de la que hereda
    {
        // Si la clase padre no tiene un constructor definido, no es necesario introducir ":base()"
        public Caballo(String nombreCaballo) : base(nombreCaballo) // Base es el constructor de la clase padre
        {

        }

        public void Galopar()
        {
            Console.WriteLine("Soy capaz de galopar");
        }
        int IMamiferosTerresters.NumeroPatas()
        {
            return 4;
        }
        int ISaltoConPatas.NumeroPatas()
        {
            return 2;
        }

        public string TipoDeporte()
        {
            return "Hipica";
        }
        public bool EsOlimpico()
        {
            return true;
        }
    }

    class Humano : Mamiferos
    {
        public Humano(String nombreHumano) : base(nombreHumano)
        { 

        }
        public override void Pensar() // Es una modificacion o sobre escritura del metodo. No es uno diferente.
        {
            Console.WriteLine("Soy capaz de pensar");
        }
    }

    class Gorila : Mamiferos, IMamiferosTerresters
    {
        public Gorila(String nombreGorila) : base(nombreGorila)
        {

        }
        new public void Pensar() // se puede corregir con una sobrecarga de parametros, se corrije con new.
        {
            Console.WriteLine("Pensamiento distintivo avanzado");
        }
        public void Trepar()
        {
            Console.WriteLine("Soy capaz de trepar");
        }
        
        public int NumeroPatas()
        {
            return 2;
        }
    }
}
