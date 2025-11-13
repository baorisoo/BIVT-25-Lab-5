using System.Linq;
using System.Runtime.InteropServices;

namespace Lab5
{
    public class Purple
    {
        public int[] Task1(int[,] matrix)
        {
            int[] answer = null;

            // code here
            answer = new int[matrix.GetLength(1)];
            int ind = 0;
            
            for (int i = 0; i < matrix.GetLength(1); i++)
            {
                int cnt = 0;
                for (int j = 0; j < matrix.GetLength(0); j++)
                {
                    if (matrix[j, i] < 0)
                    {
                        cnt++;
                    }
                }
                answer[ind] = cnt;
                ind++;
            }
            // end

            return answer;
        }
        public void Task2(int[,] matrix)
        {

            // code here
            
            for (int i = 0; i < matrix.GetLength(0);i++)
            {
                for (int j = 0; j < matrix.GetLength(1); j++)
                {
                    int[] a = new int[matrix.GetLength(1)];
                    a[j] = matrix[i, j];
                    int mn = int.MaxValue;
                    int ind = 0;
                    for (int k = 0; k < a.Length; k++)
                    {
                        if (a[k] < mn)
                        {
                            mn = a[k];
                            ind = k;
                        }
                    }
                    if (matrix[i, 0] == mn) continue;
                    else
                    {
                        matrix[i, 0] = mn;

                    }
                        
                }

            }
            // end

        }
        public int[,] Task3(int[,] matrix)
        {
            int[,] answer = null;

            // code here

            // end

            return answer;
        }
        public void Task4(int[,] matrix)
        {

            // code here

            // end

        }
        public void Task5(int[,] matrix, int k)
        {

            // code here

            // end

        }
        public void Task6(int[,] matrix, int[] array)
        {

            // code here

            // end

        }
        public void Task7(int[,] matrix)
        {

            // code here

            // end

        }
        public int[] Task8(int[,] matrix)
        {
            int[] answer = null;

            // code here

            // end

            return answer;
        }
        public void Task9(int[,] matrix, int k)
        {

            // code here

            // end

        }
        public int[,] Task10(int[,] A, int[,] B)
        {
            int[,] answer = null;

            // code here

            // end

            return answer;
        }
        public int[][] Task11(int[,] matrix)
        {
            int[][] answer = null;

            // code here

            // end

            return answer;
        }
        public int[,] Task12(int[][] array)
        {
            int[,] answer = null;

            // code here

            // end

            return answer;
        }
    }
}
