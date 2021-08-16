using System;
using System.IO; // Lectura de archivos

namespace PropiedadesAcceso
{
    enum Bonus { bajo = 500, normal = 1000, bueno = 1500, extra = 3000 }

    class Program
    {
        enum Estaciones { Primavera, Verano, Otonio, Invierno}

        static void Main(string[] args)
        {
            Empleado Juan = new Empleado("Juan", Bonus.bueno);

            Juan.SALARIO = 1200;

            Console.WriteLine("El salario del empleado es: " + Juan.SALARIO);

            Estaciones alergia = Estaciones.Primavera;

            string La_alergia = alergia.ToString();

            Console.WriteLine(alergia);

            Bonus Antonio = Bonus.bajo;

            double bonusAntonio = (double)Antonio;

            Console.WriteLine(bonusAntonio);

            ManejoArchivos miArchivo = new ManejoArchivos();

            miArchivo.Mensaje();

        }
    }

    class Empleado
    {
        private string nombreEmpleado;
        private double _salario, bonus;
        

        public Empleado(string nombreEmpleado, Bonus bonusEmpleado)
        {
            this.bonus = (double)bonusEmpleado;
            this.nombreEmpleado = nombreEmpleado;
        }

        //public void SetSalario(double salario)
        //{
        //    if (salario < 0)
        //    {
        //        Console.WriteLine("No puedes ingresar un salario negativo. Sera reemplazado por cero.");
        //        this.salario = salario;
        //    }
        //    else
        //    {
        //        this.salario = salario;
        //    }
        //}

        //public double GetSalario()
        //{
        //    return salario;
        //}

        private double EvaluarSalario(double salario)
        {
            if (salario < 0) return 0;
            else return salario;
        }

        //public double SALARIO
        //{
        //    get { return this.salario; }
        //    set { this.salario = EvaluarSalario(value); }
        //}

        public double SALARIO
        {
            get => this._salario + this.bonus;
            set => this._salario = EvaluarSalario(value);
        }

    }

    class ManejoArchivos
    {

        StreamReader archivo = null;

        int contador = 0;
        string linea;

        public ManejoArchivos()
        {
            archivo = new StreamReader(@"C:\Users\Usuario\Documents\GitHub\CSharp\text.txt");

            while( ( linea = archivo.ReadLine() ) != null )
            {
                Console.WriteLine(linea);
                contador++;
            }
        }

        public void Mensaje()
        {
            Console.WriteLine("Hay {0} lineas",contador);
        }

        ~ManejoArchivos()
        {
            archivo.Close();
        }
    }
}
