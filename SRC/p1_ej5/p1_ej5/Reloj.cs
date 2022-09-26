using System;
using System.Threading;

namespace p1_ej5
{
    public class Reloj
    {

       public byte bytHora, bytSegundo, bytMinuto;
       public int bytMilisegundo;

        public void Aumentar()
        {
            byte hora = bytHora;
            byte minuto = bytMinuto;
            byte segundo = bytSegundo;
            int milisegundo = bytMilisegundo;

            Console.SetCursorPosition(40, 1);


            for (hora = 0; hora <= 24; hora++)
            {

                for (minuto = 0; minuto <= 59; minuto++)
                {
                    for (segundo = 0; segundo <= 59; segundo++)
                    {
                        for (milisegundo = 0; milisegundo <= 999; milisegundo++)
                        {
                            Console.SetCursorPosition(50, 10);
                            Console.WriteLine("{0}:{1}:{2}:{3}", hora, minuto, segundo, milisegundo);
                            Thread.Sleep(1);
                        }
                    }
                }
            }
            Console.ReadKey();
        }

        public void aumentarHora(byte dif)
        {
            byte hora = dif;
            byte minuto = bytMinuto;
            byte segundo = bytSegundo;
            int milisegundo = bytMilisegundo;

            Console.SetCursorPosition(40, 1);


            for (hora = hora; hora <= 24; hora++)
            {

                for (minuto = 0; minuto <= 59; minuto++)
                {
                    for (segundo = 0; segundo <= 59; segundo++)
                    {
                        for (milisegundo = 0; milisegundo <= 999; milisegundo++)
                        {
                            Console.SetCursorPosition(50, 10);
                            Console.WriteLine("{0}:{1}:{2}:{3}", hora, minuto, segundo, milisegundo);
                            Thread.Sleep(1);
                        }
                    }
                }
            }
            Console.ReadKey();
        }
        public void aumentarHora(byte dif, byte dif2)
        {
            byte hora = dif;
            byte minuto = dif2;
            byte segundo = bytSegundo;
            int milisegundo = bytMilisegundo;

            Console.SetCursorPosition(40, 1);


            for (hora = hora; hora <= 24; hora++)
            {

                for (minuto = minuto; minuto <= 59; minuto++)
                {
                    for (segundo = 0; segundo <= 59; segundo++)
                    {
                        for (milisegundo = 0; milisegundo <= 999; milisegundo++)
                        {
                            Console.SetCursorPosition(50, 10);
                            Console.WriteLine("{0}:{1}:{2}:{3}", hora, minuto, segundo, milisegundo);
                            Thread.Sleep(1);
                        }
                    }
                }
            }
            Console.ReadKey();
        }

    }
}

