using System;

namespace lab2._5._1

{
    class Program
    {

        static void Main(string[] args)
        {

            Console.WriteLine("Enter n");
            int n = int.Parse(Console.ReadLine());
            Console.WriteLine("Enter m");
            int m = int.Parse(Console.ReadLine());
            double[,] arr = new double[n, m];
            Console.WriteLine("Enter your array");
            Random rand = new Random();
            for (int i = 0; i < n; i++)
            {
                for (int j = 0; j < m; j++)
                {
                    arr[i,j] = rand.Next(100);
                    Console.WriteLine(arr[i,j]);

                }

            }
            Console.WriteLine("Your array");
            for (int i = 0; i < n; i++)
            {
                for (int j = 0; j < m; j++)
                    Console.Write("\t" + arr[i, j]);
                Console.WriteLine();
            }
            Console.WriteLine("New array");
            for (int i = 0; i < n; i++)
            {
                for (int j = 0; j < m; j++)
                {
                    if (i + j == n - 1)
                    {
                        arr[i, j] = 0;
                    }
                    if ((i + j < n - 1) || (i + j > n - 1))
                    {
                        arr[i, j]=Math.Pow(arr[i,j],2);
                    }

                }

            }
            for (int i = 0; i < n; i++)
            {
                for (int j = 0; j < m; j++)
                    Console.Write("\t" + arr[i, j]);
                Console.WriteLine();
            }

        }
    }
}

