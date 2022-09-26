using System;
namespace p1_ej7
{
    public class FacturaLuz : Impresora
    {
        public int codigoPago;
        public int importe;

        public FacturaLuz()
        {
        }
        public override void Imprimir()
        {
            Console.WriteLine("Factura de luz impresa");
        }
    }
}

