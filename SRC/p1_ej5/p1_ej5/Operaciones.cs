using System;
namespace p1_ej5
{
    public class Operaciones
    {
        TimeSpan resultadohora;

       int hora1, hora2, minutos1, minutos2, segundos1, segundos2;


        public Operaciones() {
            //Console.WriteLine("Ingrese la primer hora, minutos y segundos: ");
            //hora1 = Int32.Parse(Console.ReadLine());
            //minutos1 = Int32.Parse(Console.ReadLine());
            //segundos1 = Int32.Parse(Console.ReadLine());

            //Console.WriteLine("Ingrese la segunda hora, minutos y segundos");
            //hora2 = Int32.Parse(Console.ReadLine());
            //minutos2 = Int32.Parse(Console.ReadLine());
            //segundos2 = Int32.Parse(Console.ReadLine());


        TimeSpan horario1 = new TimeSpan(hora1, minutos1, segundos1);
        TimeSpan horario2 = new TimeSpan(hora2, minutos2, segundos2);
        }

        public string sumahoras()
        {
            Console.WriteLine("Ingrese la primer hora, minutos y segundos que se van a sumar: ");
            hora1 = Int32.Parse(Console.ReadLine());
            minutos1 = Int32.Parse(Console.ReadLine());
            segundos1 = Int32.Parse(Console.ReadLine());

            Console.WriteLine("Ingrese la segunda hora, minutos y segundos que se van a sumar: ");
            hora2 = Int32.Parse(Console.ReadLine());
            minutos2 = Int32.Parse(Console.ReadLine());
            segundos2 = Int32.Parse(Console.ReadLine());


            TimeSpan horario1 = new TimeSpan(hora1, minutos1, segundos1);
            TimeSpan horario2 = new TimeSpan(hora2, minutos2, segundos2);



            resultadohora = (horario1 + horario2);
            return "La suma de las horas es: " + resultadohora;
        }

        public string restahoras()
        {

            Console.WriteLine("Ingrese la primer hora, minutos y segundos que se va a restar: ");
            hora1 = Int32.Parse(Console.ReadLine());
            minutos1 = Int32.Parse(Console.ReadLine());
            segundos1 = Int32.Parse(Console.ReadLine());

            Console.WriteLine("Ingrese la segunda hora, minutos y segundos que se va a restar: ");
            hora2 = Int32.Parse(Console.ReadLine());
            minutos2 = Int32.Parse(Console.ReadLine());
            segundos2 = Int32.Parse(Console.ReadLine());


            TimeSpan horario1 = new TimeSpan(hora1, minutos1, segundos1);
            TimeSpan horario2 = new TimeSpan(hora2, minutos2, segundos2);

            resultadohora = (horario1 - horario2);
            return "La resta de las horas es: " + resultadohora;
        }
    }
}

