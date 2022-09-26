using System;
namespace p1_ej7
{
    public class Municipal : Impresora
    {
        public int importe;
        public int Partida;

        public Municipal()
        {
        }
        public override void Imprimir()
        {
            Console.WriteLine("Municipal impreso");
        }
    }
}

