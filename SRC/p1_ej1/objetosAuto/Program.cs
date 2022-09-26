using System;

namespace objetosAuto
{
    class Program
    {
        static void Main(string[] args)
        {
            Auto auto1 = new Auto();

            Auto auto2 = new Auto(3.5,2.5);

            auto2.setThisExtras(true, "cuero");

            Console.WriteLine(auto1.getInfoAuto());
            Console.WriteLine(auto1.getExtras());
            Console.WriteLine(auto2.getInfoAuto());
            Console.WriteLine(auto2.getExtras());
        }

    }




    class Auto
    {


        private int ruedas;
        private double largo;
        private double ancho;
        private bool climatizador;
        private string tapiceria;

        public Auto() {

            ruedas = 4;
            largo = 3;
            ancho = 2;
            climatizador = false;
            tapiceria = "tela";

 }
        public Auto(double largoAuto, double anchoLargo)
        {
            ruedas = 4;
            largo = largoAuto;
            ancho = anchoLargo;
            climatizador = false;
            tapiceria = "tela";
         }

        public string getInfoAuto() {

            return "El auto tiene : \n " + " ruedas " + ruedas + " largo " + largo + " ancho " + ancho;
             
        }

        public void setThisExtras(bool climatizador, string tapiceria) {

            this.climatizador = climatizador;
            this.tapiceria = tapiceria;
        }

        public string getExtras() {

            return " El auto tiene : \n" + " climatizador : " + climatizador + " tapiceria " + tapiceria + "\n"; 

                }








    }
}

