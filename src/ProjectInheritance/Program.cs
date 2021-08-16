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

            Lagartija Juancho = new Lagartija("Juancho");

            Juancho.Respirar();
            Juancho.GetNombre();

            Animal Juan = new Humano("Juan");
            Juan.Respirar();
            Juan.GetNombre();

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

    abstract class Animal
    {
        public void Respirar() 
        {
            Console.WriteLine("Soy capaz de respirar");
        }

        public abstract void GetNombre();
    }

    class Lagartija : Animal
    {
        private string nombreReptil;

        public Lagartija(string nombreReptil)
        {
            this.nombreReptil = nombreReptil;
        }

        public override void GetNombre()
        {
            Console.WriteLine("El nombre del reptil es " + nombreReptil);
        }

    }

    class Mamiferos : Animal
    {
        public Mamiferos(String nombre)
        {
            nombreSerVivo = nombre;
        }

        public virtual void Pensar() // Metodo modificable
        {
            Console.WriteLine("Pensamiento basico instintivo");
        }

        public void CuidarCrias() // Public es accesible desde cualquier otra clase del programa.
                                  // Es accesible de la clase principal y las que heredan.
        {
            Console.WriteLine("Cuido de mis crias hasta que se valgan por si solas");
        }

        public override void GetNombre()
        {
            Console.WriteLine("El nombre del mamifero es " + nombreSerVivo);
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
        public sealed override void Pensar() // Es una modificacion o sobre escritura del metodo. No es uno diferente.
        {
            Console.WriteLine("Soy capaz de pensar");
        }
    }

    //class Adolescente : Humano
    //{
    //    public Adolescente(string nombreAdolescente) : base(nombreAdolescente)
    //    {

    //    }

    //    //public override void Pensar() // No se puede sobreescribir porque el metodo es sellado.
    //    //{
    //    //    Console.WriteLine("Las hormonas me impiden pensar con claridad"); ;
    //    //}
    //}

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

    class Chimpance : Gorila 
    {
        public Chimpance(string nombreChimpance): base(nombreChimpance)
        {

        }
    }
}
