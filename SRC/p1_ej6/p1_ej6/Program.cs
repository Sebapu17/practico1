using System;

namespace p1_ej6
{
    class Program
    {
        static void Main(string[] args)
        {
            int n;
            int m;

            Console.WriteLine("INGRESE EL LARGO DE LA MATRIZ");
            n = Int32.Parse(Console.ReadLine());

            Console.WriteLine("INGRESE EL ANCHO DE LA MATRIZ");
            m = Int32.Parse(Console.ReadLine());
            //int[,] MatrizA = new int[n, m];
            //int[,] MatrizB = new int[n, m];


            Matriz nuevas = new Matriz(n, m);
            nuevas.sumarMatrices();
            nuevas.mostrarMatrices();

            //Random aleatorio = new Random();


            //for (int i = 0; i<n; i++)
            //{
            //    for(int j = 0; j<m; j++)
            //    {
            //        MatrizA[i, j] = aleatorio.Next(0, 100);
            //    }
            //}


            //for (int i = 0; i < n; i++)
            //{
            //    for (int j = 0; j < m; j++)
            //    {
            //        MatrizB[i, j] = aleatorio.Next(0, 100);
            //    }
            //}




            


            /*
            person.MatrizA[0, 1] = aleatorio.Next(0, 100);
            person.MatrizA[0, 0] = aleatorio.Next(0, 100);
            person.MatrizA[1, 0] = aleatorio.Next(0, 100);
            person.MatrizA[1, 1] = aleatorio.Next(0, 100);

            person.MatrizB[0, 1] = aleatorio.Next(0, 100);
            person.MatrizB[0, 0] = aleatorio.Next(0, 100);
            person.MatrizB[1, 0] = aleatorio.Next(0, 100);
            person.MatrizB[1, 1] = aleatorio.Next(0, 100);
            */

            
        }
    }
}

