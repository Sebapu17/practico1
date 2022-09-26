using System;
namespace p1_ej6
{
    public class Matriz
    {

        public int[,] MatrizA;
        public int[,] MatrizB;
        public int[,] sumaMatrices;

        public Matriz(int n, int m)
        {

            Random aleatorio = new Random();
            MatrizA = new int[n, m];
            MatrizB = new int[n, m];
            sumaMatrices = new int[n, m];




            for (int i = 0; i < n; i++)
            {
                for (int j = 0; j < m; j++)
                {
                    MatrizA[i, j] = aleatorio.Next(0, 100);
                }
            }


            for (int i = 0; i < n; i++)
            {
                for (int j = 0; j < m; j++)
                {
                    MatrizB[i, j] = aleatorio.Next(0, 100);
                }
            }

        }




        public void sumarMatrices()
        {
            for (int fila = 0; fila < 2; fila++)
            {
                for (int col = 0; col < 2; col++)
                {
                    sumaMatrices[fila, col] = MatrizA[fila, col] + MatrizB[fila, col];
                }
            }

        }

        public void mostrarMatrices(/*int matriz1, int matriz2*/)
        {
            for (int fila = 0; fila < 2; fila++)
            {
                for (int col = 0; col < 2; col++)
                {
                    Console.WriteLine("MATRIZ A: " + MatrizA[fila,col]);
                }
            }

            for (int fila = 0; fila < 2; fila++)
            {
                for (int col = 0; col < 2; col++)
                {
                    Console.WriteLine("MATRIZ B: " + MatrizB[fila, col]);
                }
            }
            for (int fila = 0; fila < 2; fila++)
            {
                for (int col = 0; col < 2; col++)
                {
                    Console.WriteLine("MATRIZ SUMA: " + sumaMatrices[fila, col]);
                }
            }
        }
    }
}

