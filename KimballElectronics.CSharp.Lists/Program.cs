using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace KimballElectronics.CSharp.Lists
{
    class Program
    {
        static void Main(string[] args)
        {
            // Tablice (arrays)
            // mają określony stały rozmiar

            ArrayTest();

            // 2D
            // Array2DTest();

            // Array2DTest2();

            // ArrayObjectsTest();

            // Listy (lists)
            // mają dynamiczny rozmiar

            // ListTest();

            // SetOperationsTest();

            ForEachTest();

        }

        private static void ForEachTest()
        {
            List<Fixture> fixtures = new List<Fixture>();
            fixtures.Add(new Fixture { BarCode = "11111" });
            fixtures.Add(new Fixture { BarCode = "22222" });
            fixtures.Add(new Fixture { BarCode = "33333" });

            //for (int i = 0; i < fixtures.Count; i++)
            //{
            //    Fixture currentFixture = fixtures[i];

            //    Console.WriteLine(currentFixture.BarCode);
            //}

            foreach (Fixture currentFixture in fixtures)
            {
                Console.WriteLine(currentFixture.BarCode);
            }
        }

        private static void SetOperationsTest()
        {
            List<int> barcodes = new List<int> { 10, 30, 40, 50, 60, 70 };
            List<int> braki = new List<int> { 20, 30, 40, 50, 60, 70 };

            // Except - różnica zbiorów
            List<int> diff = barcodes.Except(braki).ToList();

            if (diff.Any())
            {
                Console.WriteLine("Zbiory są różne");
            }
            else
            {
                Console.WriteLine("Zbiory są identyczne");
            }

            if (barcodes.All(p => p > 0))
            {

            }

            List<int> sum = barcodes.Union(braki).ToList();
        }

        private static void ListTest()
        {
            List<int> numbers = new List<int>();
            numbers.Add(10);
            numbers.Add(20);
            numbers.Add(30);
            numbers.Add(40);
            numbers.Add(30);

            // Usunięcie elementu o wartości 30
            numbers.Remove(30);

            if (numbers.Contains(90))
            {
                numbers.Remove(90);
            }

            // numbers.RemoveAll(p => p == 30);    // wyrażenie lambda

            // Usunięcie elementy pod podanym indeksem
            numbers.RemoveAt(0);

            numbers[2] = 99;

            for (int i = 0; i < numbers.Count; i++)
            {
                Console.WriteLine(numbers[i]);      // [] - indekser
            }
        }

        private static void ArrayObjectsTest()
        {
            Fixture[] fixtures = new Fixture[10];

            fixtures[0] = new Fixture { BarCode = "1111" };
            fixtures[1] = new Fixture { BarCode = "2222" };
            fixtures[3] = new Fixture { BarCode = "3333" };
        }

        private static void Array2DTest()
        {
            int[,] board = new int[8, 4];

            board[4, 1] = 10;
            board[4, 2] = 20;
            board[6, 1] = 30;

            int dimensionX = board.GetLength(0);
            int dimensionY = board.GetLength(1);

            for (int i = 0; i < dimensionX; i++)
            {
                for (int j = 0; j < dimensionY; j++)
                {
                    Console.Write($"[ {board[i, j]} ]");
                }

                Console.WriteLine();
            }
        }

        private static void Array2DTest2()
        {
            int[,] matrix = new int[,]
            {
                {1, 2},
                {3, 4},
                {5, 6}
            };

            int dimensionX = matrix.GetLength(0);
            int dimensionY = matrix.GetLength(1);

            for (int i = 0; i < dimensionX; i++)
            {
                for (int j = 0; j < dimensionY; j++)
                {
                    Console.Write($"[ {matrix[i, j]} ]");
                }

                Console.WriteLine();
            }


        }

        private static void ArrayTest()
        {
            int n = 6;

            int[] numbers = new int[n];

            numbers[0] = 10;
            numbers[1] = 20;
            numbers[2] = 30;

            for (int i = 0; i < numbers.Length; i++)
            {
                Console.WriteLine(numbers[i]);
            }

            foreach (int number in numbers)
            {
                Console.WriteLine(number);
            }
        }

        private static void ArrayTest2()
        {
            int[] numbers = new int[] { 10, 20, 30, 45 };

            for (int i = 0; i < numbers.Length; i++)
            {
                Console.WriteLine(numbers[i]);
            }
        }
    }
}
