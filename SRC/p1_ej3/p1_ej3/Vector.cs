using System;
namespace p1_ej3
{
    public class Vector
    {
        private int[] vec1;
        private int[] vec2;
        private int[] vecSuma;
        private int[] vecResta;
        private double distancia;
        private double distancia2;


        public void ingresar()
        {
            vec1 = new int[4];
            vec2 = new int[4];

            Console.WriteLine("Ingrese el primer vector: ");
            for(int i=0; i<4; i++)
            {
                Console.Write("Ingrese 4 datos del primer vector: ");


                string linea;
                linea = Console.ReadLine();
                vec1[i] = int.Parse(linea);
            }
            Console.WriteLine("Ingrese el segundo vector: ");
            for (int j = 0; j < 4; j++)
            {
                Console.Write("Ingrese 4 datos del segundo vector: ");


                string linea;
                linea = Console.ReadLine();
                vec2[j] = int.Parse(linea);
            }

        }

        public void sumaVectores()
        {
            vecSuma = new int[4];
            for (int h=0; h<4; h++)
            {
                vecSuma[h] = vec1[h] + vec2[h];
            }
            Console.WriteLine("Resultado de la suma de vectores");
            for (int f=0; f<4; f++)
            {
                Console.WriteLine(vecSuma[f]);
            }

        }

        public void restaVectores()
        {
            vecResta = new int[4];
            for (int h = 0; h < 4; h++)
            {
                vecResta[h] = vec1[h] - vec2[h];
            }
            Console.WriteLine("Resultado de la resta de vectores");
            for (int f = 0; f < 4; f++)
            {
                Console.WriteLine(vecResta[f]);
            }

        }

        public void distanciaVectores()
        {
            distancia2 = (vec1[0] - vec2[0])*(vec1[0] - vec2[0])+ (vec1[1] - vec2[1]) * (vec1[1] - vec2[1]) + (vec1[2] - vec2[2]) * (vec1[2] - vec2[2]) + (vec1[3] - vec2[3]) * (vec1[3] - vec2[3]);

            distancia = Math.Sqrt(distancia2);

            Console.WriteLine($"La distancia de los vectores es de {distancia}");
        }
    }

}

