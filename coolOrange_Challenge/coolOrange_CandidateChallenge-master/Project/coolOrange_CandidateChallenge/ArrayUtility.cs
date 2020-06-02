using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace coolOrange_CandidateChallenge
{
    public class ArrayUtility
    {

        private int[] A;
        private int i, j, val;
      

        public ArrayUtility(int[] A, int i , int j ) // Konstruktor um die Werte zu übergeben
        {
            this.j = j;
            this.i = i;
            this.A = A;
            
        }
     

        public static int FindMax(int[] A, int i, int j)
        {
            int maxValue = 0;
            for (int k = i; k <= j; k++)
            {

                if(A[k] > maxValue) // geht alle werte durch und vergleicht ob der derzeitige Wert größer als der Maximale wert ist
                {
                    maxValue = A[k];
                }
             
            }
            return maxValue;
        }
        public static int FindMinPos(int[] A, int i, int j)
        {
            int minValuepos = A[i];
            int index =0 ;
       
            for (int k = i; k <= j; k++)
            {

                if (A[k] < minValuepos)
                {
                   minValuepos = A[k];
                    index = k;
                }

            }
            return index;
        }
        public static int[] Swap(int[] A, int i, int j)
        {
            int temp1 = A[i];         
            A[i] = A[j];
            A[j] = temp1;
            return A;
        }
        //public static void ShiftLeft(int[] A, int i, int j)
        //{
        //    A.CopyTo(A, i);
        //}
        public static int[] CreateRandomArray(int size, int min, int max)
        {
           
            int[] randomArray = new int[size];
            Random rnd = new Random();
            for (int i = 0; i < size; i ++) // Generiert zufällige Werte für jede position des arrys bis dieser voll ist 
           {
               randomArray[i] = rnd.Next(min,max);
           }

            return randomArray;
        }
        public static int[,] CreateRandomMatrix(int rows, int cols, int min, int max)
        {
            Random rnd = new Random();
            int[,] twoD_Array = new int[rows, cols];

            for (int i = 0; i < rows; i++) //erstellt die angegebne anzahl an Rows und cols des Arrays und füllt diese mit zufälligen Werten
            {
                for (int j = 0; j < cols; j++)

                    twoD_Array[i,j] = rnd.Next(min, max);
            }

            return twoD_Array;
        }
        //public static int[,] CopyArray(int[] A)
        //{
        //    int[,] copied_Array = new int[2, 10000];

        //    for (int i = 0; i < )
        //    {
        //        copied_Array[0] = A[item];
        //        copied_Array[1,] = A[item];
        //    }


        //    return copied_Array;
        //}
        public static int FindInSortedArrary(int[] A, int q)
        {
   
            int a = Array.IndexOf(A, q);          // sucht die übergebene position im array 
            return a;

        }
    }
   
}
