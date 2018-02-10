using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace minimumpokoloni
{
    class Program
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine()); // br redove
            int m = int.Parse(Console.ReadLine()); // br colums
            int[,] array2dim = new int[n, m];
            int[] minCol = new int[m];
            // 
            for (int i = 0; i < n; i++) // masiv za vseki red
            {
                int[] oneRow = Console.ReadLine().Split(' ').Select(int.Parse).ToArray();
                for (int j = 0; j < m; j++)
                {
                    array2dim[i, j] = oneRow[j];
                }
                // obrabotka
            }
            for (int j = 0; j < m; j++) // kolona
            {
                int min = array2dim[0, j];
                minCol[j] = array2dim[0, j];
                for (int i = 0; i < n; i++)
                {
                    if (minCol[j] > array2dim[i, j])
                    {
                        minCol[j] = array2dim[i, j];
                    }
                }
            }
        }
    }
}
