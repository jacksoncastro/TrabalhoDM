using System;

namespace TrabalhoDM
{
    internal class Question12 : Question
    {
        public void Execute()
        {
            int[,] matriz = GenerateMatriz(5);

            int[] array = MatrizToUnidimensional(matriz);
            matriz = GetMatrizA(matriz.GetLength(0), array);

            PrintMatriz(matriz);
        }

        private int[,] GenerateMatriz(int size)
        {
            int[,] matriz = new int[size, size];

            int value = 1;
            for (int i=0; i < size; i++)
            {
                for (int j = 0; j < size; j++)
                {
                    matriz[i, j] = value;
                    value++;
                }
            }
            return matriz;
        }

        /**
         *
         *     0 1 2 j
         * 0 { 9 8 6 }
         * 1 { 7 5 3 }
         * 2 { 4 2 1 }
         * i
         *
         *     0   1   2   3
         * 0 { 1,  2,  3,  4  },
         * 1 { 5,  6,  7,  8  },
         * 2 { 9,  10, 11, 12 },
         * 3 { 13, 14, 15, 16 }
         *
         *     0   1   2   3
         * 0 { 16, 15, 13, 10 },
         * 1 { 14, 12, 9,  6 },
         * 2 { 11, 8,  5,  3 },
         * 3 { 7,  4,  2,  1 }
         *
         * (0, 0) => (3, 3)
         * (0, 1) => (3, 2)
         * (0, 2) => (3, 0)
         * (0, 3) => (2, 1)
         * (1, 0) => (3, 1)
         * (1, 1) => (2, 3)
         * (1, 2) => (2, 0)
         * (1, 3) => (1, 1)
         * (2, 0) => (2, 2)
         * (2, 1) => (1, 3)
         * (2, 2) => (1, 0)
         * (2, 3) => (0, 2)
         * (3, 0) => (1, 2)
         * (3, 1) => (0, 3)
         * (3, 2) => (0, 1)
         * (3, 3) => (0, 0)
         */
        private int[,] GetMatrizA(int size, int[] numbers)
        {
            int n = size - 1;
            int[,] matriz = new int[size, size];

            int indexI = n;
            int indexJ = n;
            int lastI = 1;
            int lastJ = n - 1;

            for (int i = 0; i < numbers.Length; i++)
            {
                matriz[indexI, indexJ] = numbers[i];

                indexI--;
                indexJ++;
                if (indexJ > n)
                {
                    indexI += lastI;
                    indexJ = lastJ;
                    lastJ--;
                    lastI++;
                }

                if (indexJ < 0)
                {
                    indexJ = 0;
                    indexI--;
                    lastI = n + lastJ;
                }

                if (indexI < 0)
                {
                    indexI = lastI;
                    indexJ = 0;
                    lastI--;
                }
            }
            return matriz;
        }


        private static int[] MatrizToUnidimensional(int[,] matriz)
        {
            int[] array = new int[matriz.Length];
            int index = 0;
            for (int i = 0; i < matriz.GetLength(0); i++)
            {
                for (int j = 0; j < matriz.GetLength(0); j++)
                {
                    array[index] = matriz[i,j];
                    index++;
                }
            }
            return array;
        }

        private void PrintMatriz(int[,] matriz)
        {
            int matrizLength = matriz.GetLength(0);
            for (int i=0; i<matrizLength; i++)
            {
                for (int j = 0; j < matrizLength; j++)
                {
                    Console.Write("{0}\t", matriz[i, j]);
                }
                Console.WriteLine();
            }
        }
    }
}