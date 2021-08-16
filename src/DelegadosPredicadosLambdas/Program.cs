using System;
using System.Collections.Generic;

namespace DelegadosPredicadosLambdas
{
    class Program
    {
        // Definicion del objeto delegado
        delegate void ObjetoDelegado(string msg);

        //public delegate int OperacionesMatematicas(int numero);
        public delegate int OperacionesMatematicas(int numero1, int numero2);
        public delegate bool ComparaPersonas(int edad1, int edad2);

        static void Main(string[] args)
        {
            // Creacion del objeto delegado apuntando a Mensaje Bienvenida
            ObjetoDelegado ElDelegado = new ObjetoDelegado(MensajeBienvenida.SaludosBienvenida);
            // Utilizacion del delegado para llamar al metodo saludo bienvenida
            ElDelegado("Hola acabo de llegar");

            List<int> listaNumeros = new List<int>();
            
            listaNumeros.AddRange(new int[] { 1, 2, 3, 4, 5, 6, 7, 8, 9, 10 });

            // Declaramos delegado predicado
            Predicate<int> elDelegadoPred = new Predicate<int>(DamePares);

            foreach (int i in listaNumeros.FindAll(elDelegadoPred)) { Console.WriteLine(i); }

            List<Personsas> gente = new List<Personsas>();

            Personsas P1 = new Personsas();
            P1.Nombre = "Juan";
            P1.Edad = 16;

            Personsas P2 = new Personsas();
            P2.Nombre = "Maria";
            P2.Edad = 16;

            Personsas P3 = new Personsas();
            P3.Nombre = "Ana";
            P3.Edad = 37;

            gente.AddRange(new Personsas[] { P1, P2, P3 });

            Predicate<Personsas> elPredNombre = new Predicate<Personsas>(ExisteJuan);
            Predicate<Personsas> elPredEdad = new Predicate<Personsas>(MayoresEdad);

            if (gente.Exists(elPredNombre)) { Console.WriteLine("Hay personas que se llaman Juan"); }
            else { Console.WriteLine("No hay personas que se llamen Juan"); }

            if (gente.Exists(elPredEdad)) { Console.WriteLine("Hay personas mayores de edad"); }
            else { Console.WriteLine("No hay personas mayores de edad"); }

            // Uso del delegado
            //OperacionesMatematicas operacion = new OperacionesMatematicas(Cuadrado);
            //OperacionesMatematicas operacion = new OperacionesMatematicas(num => num*num);

            //OperacionesMatematicas operacion = new OperacionesMatematicas(Suma);
            OperacionesMatematicas operacion = new OperacionesMatematicas((num1, num2) => num1 + num2);

            Console.WriteLine(operacion(4,7));

            List<int> numeros = new List<int> { 1,2,3,4,5,6,7,8,9} ;

            List<int> numerosPares = numeros.FindAll(i => i % 2 == 0);

            //foreach (int i in numerosPares) Console.WriteLine(i);

            numerosPares.ForEach(i => {

                    Console.Write("El numero par es: ");
                    Console.WriteLine(i);   
            
            });

            ComparaPersonas comparaEdad = (persona1, persona2) => persona1 == persona2;

            Console.WriteLine(comparaEdad(P1.Edad,P2.Edad));

        }

        public static int Cuadrado(int num) 
        {
            return num * num;
        }

        public static int Suma(int num1, int num2)
        {
            return num1 + num2;
        }

        static bool DamePares(int num)
        {
            if (num % 2 == 0) return true;
            else return false;
        }

        static bool ExisteJuan(Personsas persona)
        {
            if (persona.Nombre == "Juan") return true;
            else return false;
        }

        static bool MayoresEdad(Personsas persona)
        {
            if (persona.Edad >= 18) return true;
            else return false;
        }
    }

    class Personsas
    {
        private string nombre;
        private int edad;

        public string Nombre { get => nombre; set => nombre = value; }
        public int Edad { get => edad; set => edad = value; }
    }

    class MensajeBienvenida
    {
        public static void SaludosBienvenida(string msg)
        {
            Console.WriteLine("Mensaje de bienvenida: {0}", msg);
        }
    }

    class MensajeDespedida
    {
        public static void SaludosDespedida(string msg)
        {
            Console.WriteLine("Mensaje de despedida: {0}", msg);
        }
    }

}
