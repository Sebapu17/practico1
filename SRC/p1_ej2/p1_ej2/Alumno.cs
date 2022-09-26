using System;
namespace p1_ej2
{

    public class Alumno
    {
        private string nom;
        private int edad;


        public Alumno()
        {
            nom = "pepe";
            edad = 0;
        }

        public Alumno(string nombreAlumno, int edadAlumno)
        {
            nom = nombreAlumno;
            edad = edadAlumno;
        }

        public string getNombreAlumno()
        {
            return "El nombre del alumno es: " + nom;
        }

        public string getNombreYEdad()
        {
            return getNombreAlumno() + " y su edad es de: " + edad;
        }

        public void setNombreYedad(string nombreAlumno, int edadAlumno)
        {
            nom = nombreAlumno;
            edad = edadAlumno;
        }
    }

}

