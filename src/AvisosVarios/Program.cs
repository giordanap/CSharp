using System;

namespace AvisosVarios
{
    class Program
    {
        static void Main(string[] args)
        {
            AvisosTrafico av1 = new AvisosTrafico();
            av1.MostrarAvisos();

            AvisosTrafico av2 = new AvisosTrafico("Jefatura Provincial de Madrid", "Sancion de velocidad: 300 $", "02-05-19");
            Console.WriteLine(av2.GetFecha());
            av2.MostrarAvisos();
        }
    }
}
