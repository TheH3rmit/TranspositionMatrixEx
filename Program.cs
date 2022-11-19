namespace TranspositionMatrixEx
{
    internal class Program
    {
        static void Main()
        {
            Random random = new Random();
            Console.WriteLine("Write number of columns of matrix");
            Int32.TryParse(Console.ReadLine(), out int m);
            Console.WriteLine("Write number of columns of matrix");
            Int32.TryParse(Console.ReadLine(), out int n);
            if (m >= 1 && n <= 200)
            {
                int numberOfRows = m;
                int numberOfColumns = n;
                int[,] macierz = new int[numberOfRows, numberOfColumns];
                for (int i = 0; i < numberOfRows; i++)
                { 
                    for(int j = 0; j < numberOfColumns; j++)
                    {
                        Console.Write(" " + macierz[i, j] + " ");
                    }
                    Console.WriteLine();
                }

                //(int,int)temp = (numberOfRows, numberOfColumns);//use of tuple to swap values
                //numberOfRows = temp.Item2;
                //numberOfColumns = temp.Item1;

                Console.WriteLine("Tanspositioning");
                int[,] macierz2 = new int[numberOfColumns, numberOfRows];
                for(int i = 0; i < numberOfRows; i++)
                {
                    for(int j = 0; j < numberOfColumns; j++)
                    {
                        macierz2[j, i] = macierz[i, j];
                    }
                }

                for (int i = 0; i < numberOfColumns; i++)
                {
                    for (int j = 0; j < numberOfRows; j++)
                    {
                        Console.Write(" " + macierz2[i, j] + " ");
                    }
                    Console.WriteLine();
                }

            }
            {
                Console.WriteLine("Try diffrent numbers");
            }
        }
    }
}