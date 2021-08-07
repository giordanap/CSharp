using System;

namespace EjercicioHerencia
{
    class Program
    {
        static void Main(string[] args)
        {

            Vehiculo[] arrVehiculo = new Vehiculo[2];

            arrVehiculo[0] = new Avion(false);
            arrVehiculo[1] = new coche(false);

            arrVehiculo[0].conducir();
            arrVehiculo[1].conducir();

        }
    }

    class Vehiculo
    {

        protected bool encendido;

        public Vehiculo(bool encendido)
        {
            encendido = false;
        }

        protected void arrancarMotor()
        {
            Console.WriteLine("El motor ha arrancado");
            encendido = true;
        }
        protected void pararMotor()
        {
            Console.WriteLine("Se apago el motor");
            encendido = false;
        }

        public virtual void conducir()
        {
            Console.WriteLine("El vehiculo esta en movimiento");
        }

    }

    class Avion : Vehiculo
    {
        public Avion(bool encendido) : base(encendido)
        {
            
        }

        public override void conducir()
        {
            Console.WriteLine("La conduccion es compleja");
        }

    }

    class coche : Vehiculo
    {
        #region constructor coche heredado
        public coche(bool encendido) : base(encendido)
        {

        }
        #endregion

        public override void conducir()
        {
            Console.WriteLine("La conduccion es intermedia");
        }

    }
}
