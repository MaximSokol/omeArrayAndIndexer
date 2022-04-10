using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ArraysAndIndexers
{
    class MyMatrix
    {
        int[][] arr;
        //-------------

        public MyMatrix(int row, int col)
        {
            arr = new int[Math.Abs(row)][];
            for(int i = 0; i < Math.Abs(row); i++)
            {
                arr[i] = new int[Math.Abs(col)];
            }
            FillTheArray();
        }
        //-------------------------------------

        public void FillTheArray()
        {
            var rand = new Random();
            for(int i = 0; i < arr.Length; i++)
            {
                for(int j = 0; j < arr[i].Length; j++)
                {
                    arr[i][j] = rand.Next(0, 50);
                }
            }
        }
        //------------------------------

        public void ChangeSize(int row, int col)
        {
            if(row <= 0 && col <= 0)
            {
                Console.WriteLine("The row and col values can't be less or equal to zero!!!");
                return;
            }

            var newArr = new int[row][];
            for(int i = 0; i < row; i++)
            {
                newArr[i] = new int[col];
            }
            
            for(int i = 0; i < Math.Min(arr.Length, row); i++)
            {
                for(int j = 0; j < Math.Min(arr[i].Length, col); j++)
                {
                    newArr[i][j] = arr[i][j];
                }
            }

            Random rand = new Random();
            if (row > arr.Length)
            {
                for(int i = arr.Length; i < row; i++)
                {
                    for(int j = 0; j < Math.Min(col, arr[0].Length); j++)
                    {
                        newArr[i][j] = rand.Next(10, 90);
                    }
                }
            }

            if(col > arr[0].Length)
            {
                for(int i = arr[0].Length; i < col; i++)
                {
                    for(int j = 0; j < row; j++)
                    {
                        newArr[i][j] = rand.Next(10, 90);
                    }
                }
            }

            arr = newArr;
        }
        //--------------------------------------------

        public void ShowPartly(int startRow, int startCol, int endRow, int endCol)
        {
            for(int i = startRow; i < endRow; i++)
            {
                for(int j = startCol; j < endCol; j++)
                {
                    Console.Write(arr[i][j]);
                }
                Console.WriteLine();
            }
        }
        //-------------------------------------------------------------------------------

        public void Show()
        {
            ShowPartly(0, 0, arr.Length, arr[0].Length);
        }
        //----------------------

        public int this[int index1, int index2]
        {
            get
            {
                if (index1 >= 0 && index1 <= arr.Length && index2 >= 0 && index2 <= arr[0].Length)
                 return arr[index1][index2];

                    Console.WriteLine("The values of indexers are not valiable!!!");
                    return 0;
            }
            set
            {
                if (index1 >= 0 && index1 <= arr.Length && index2 >= 0 && index2 <= arr[0].Length)
                    arr[index1][index2] = value;

                    Console.WriteLine("The values of indexers are not valiable!!!"); 
            }
        }
        //--------------------------------------------
    }
}
