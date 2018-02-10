using System;

namespace mnogomerni_masivi
{
    class Program
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine()); // br redove
            int m = int.Parse(Console.ReadLine()); // br colums
            double sum = 0;
            

            int[,] array2dim = new int[n, m];
            for (int i = 0; i < n; i++) // i obikalq red po red
            {
                for (int j = 0; j < m; j++) // j obikalq po elementite na 1 red
                {
                    array2dim[i, j] = int.Parse(Console.ReadLine());
                  
                }
            }
            for (int i = 0; i < n; i++) // i obikalq red po red
            {
                for (int j = 0; j < m; j++) // j obikalq po elementite na 1 red
                {
                    Console.Write("{0,10}", array2dim[i, j]);
                    sum += array2dim[i, j];
                  
                }
               
                Console.WriteLine("{0,10}", sum / m);
                sum = 0;
            }
        }
    }
}