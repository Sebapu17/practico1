using System;

namespace p1_ej2
{
    class Program
    {
        static void Main(string[] args)
        {
            Alumno alumno1 = new Alumno();

            Alumno alumno2 = new Alumno("sebastian", 30);

            Console.WriteLine(alumno1.getNombreAlumno());
            Console.WriteLine(alumno2.getNombreAlumno());
            Console.WriteLine(alumno1.getNombreYEdad());
            Console.WriteLine(alumno2.getNombreYEdad());
            alumno1.setNombreYedad("diego", 28);
            Console.WriteLine(alumno1.getNombreYEdad());

        }
    }
}

