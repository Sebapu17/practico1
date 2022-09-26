using System;

namespace p1_ej5
{
    class Program
    {
        static void Main(string[] args)
        {
            Reloj reloj = new Reloj();

            Operaciones horas = new Operaciones();
            Console.WriteLine(horas.sumahoras());
            Console.WriteLine(horas.restahoras());

            reloj.aumentarHora(1, 58);
            reloj.Aumentar();


        }
    }
}

