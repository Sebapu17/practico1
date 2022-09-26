using System;
namespace p1_ej7
{
    public class Factura : Impresora
    {
        private int fecha;
        private int importe;

        public Factura()
        {
        }
        public override void Imprimir()
        {
            Console.WriteLine("Factura impresa");
        }
    }
}

