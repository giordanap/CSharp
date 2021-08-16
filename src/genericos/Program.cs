using System;

namespace genericos
{
    class Program
    {
        static void Main(string[] args)
        {
            //AlmacenObjetos archivos = new AlmacenObjetos(4);
            AlmacenObjetos<Empleado> archivos = new AlmacenObjetos<Empleado>(4);

            //archivos.Agregar("Juan");
            //archivos.Agregar(43);
            //archivos.Agregar("Antonio");
            //archivos.Agregar(123);

            archivos.Agregar(new Empleado(1500));
            archivos.Agregar(new Empleado(2500));
            archivos.Agregar(new Empleado(4000));
            archivos.Agregar(new Empleado(3500));

            Empleado salarioEmpleado = archivos.GetElemento(2);

            Console.WriteLine(salarioEmpleado.GetSalario());
        }
    }

    //class AlmacenObjetos
    //{
    //    private Object[] datosElemento;
    //    private int contador = 0;

    //    public AlmacenObjetos(int z)
    //    {
    //        datosElemento = new Object[z];
    //    }

    //    public void Agregar(Object obj)
    //    {
    //        datosElemento[contador] = obj;
    //        contador++;
    //    }

    //    public Object GetElemento(int z)
    //    {
    //        return datosElemento[z];
    //    }
    //}

    class AlmacenObjetos <T>
    {
        private T[] datosElemento; // Esto especifica que se puede alvergar cualquier tipo de objeto
        private int contador = 0;

        public AlmacenObjetos(int z)
        {
            datosElemento = new T[z];
        }

        public void Agregar(T obj)
        {
            datosElemento[contador] = obj;
            contador++;
        }

        public T GetElemento(int z)
        {
            return datosElemento[z];
        }
    }

    class Empleado
    {
        private double salario;

        public Empleado(double salario)
        {
            this.salario = salario;
        }

        public double GetSalario()
        {
            return salario;
        }
    }
}
