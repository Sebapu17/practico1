using System;
namespace p1_ej7
{
    public class ReciboSueldo : Impresora
    {
        public int legajo;
        public int Total;

        public ReciboSueldo()
        {
        }
        public override void Imprimir()
        {
            Console.WriteLine("Recibo de sueldo impreso");
        }
    }
}

