using System;

namespace GenericosRestriccion
{
    class Program
    {
        static void Main(string[] args)
        {
            AlamcenEmpleados<Director> empleados = new AlamcenEmpleados<Director>(3);
            //AlamcenEmpleados<Estudiante> empleados = new AlamcenEmpleados<Estudiante>(3); // No implementa la interfaz

            empleados.Agregar(new Director(4500));
            empleados.Agregar(new Director(1500));
            empleados.Agregar(new Director(2500));

        }
    }

    class AlamcenEmpleados <T> where T : IParaEmpleados
    {
        private int i = 0;
        private T[] datosEmpleados;

        public AlamcenEmpleados(int z)
        {
            datosEmpleados = new T[z];
        }

        public void Agregar( T obj)
        {
            datosEmpleados[i] = obj;
            i++;
        }

        public T GetEmpleado(int i)
        {
            return datosEmpleados[i];
        }
    }

    class Director : IParaEmpleados
    {
        private double salario;

        public Director(double salario)
        {
            this.salario = salario;
        }

        public double GetSalario()
        {
            return salario;
        }
    }

    class Secretaria : IParaEmpleados
    {
        private double salario;

        public Secretaria(double salario)
        {
            this.salario = salario;
        }

        public double GetSalario()
        {
            return salario;
        }

    }

    class Electricista : IParaEmpleados
    {
        private double salario;

        public Electricista(double salario)
        {
            this.salario = salario;
        }

        public double GetSalario()
        {
            return salario;
        }
    }

    class Estudiante
    {
        private int edad;

        public Estudiante(int edad)
        {
            this.edad = edad;
        }

        public int GetEdad()
        {
            return edad;
        }
    }

    interface IParaEmpleados
    {
        double GetSalario();
    }
}
