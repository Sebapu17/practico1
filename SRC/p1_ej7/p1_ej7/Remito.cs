using System;
namespace p1_ej7
{
    public class Remito : Impresora
    {
        private int cantBultos;
        private int fecha;
        private int numero;

        public Remito()
        {
        }

        public override void Imprimir()
        {
            Console.WriteLine("Remito impreso");
        }
    }
}

