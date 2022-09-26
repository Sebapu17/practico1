using System;

namespace p1_ej7
{
    class Program
    {
        static void Main(string[] args)
        {

            int op;
            do
            {

                Console.WriteLine("Bienvenido al programa de impresión \n" +
                    "Ingrese la opción que desee\n" +
                    "Ingrese 1 si desea imprimir un remito\n" +
                    "ingrese 2 si desea imprimir una factura de luz\n" +
                    "ingrese 3 si desea imprimir un municipal \n" +
                    "ingrese 4 si desea imprimir el recibo de sueldo \n" +
                    "ingrese 5 si desea imprimir una factura \n" +
                    "ingrese 6 si desea probar la impresora\n" +
                    "o ingrese 0 si desea salir");

                op = Int32.Parse(Console.ReadLine());
                Console.Clear();
                switch (op)
                {
                    case 1:
                        Remito miRemito = new Remito();
                        miRemito.Imprimir();
                        break;
                    case 2:
                        FacturaLuz miFacturaLuz = new FacturaLuz();
                        miFacturaLuz.Imprimir();
                        break;
                    case 3:
                        Municipal miMunicipal = new Municipal();
                        miMunicipal.Imprimir();
                        break;
                    case 4:
                        ReciboSueldo miReciboSueldo = new ReciboSueldo();
                        miReciboSueldo.Imprimir();
                        break;
                    case 5:
                        Factura miFactura = new Factura();
                        miFactura.Imprimir();
                        break;
                    case 6:
                        Impresora miImpresora = new Impresora();
                        miImpresora.Imprimir();
                        break;
                    default:
                        Console.WriteLine("Ingrese una opción válida: ");
                        break;
                }
            } while (op != 0);





            

           
           
        }
    }
}

