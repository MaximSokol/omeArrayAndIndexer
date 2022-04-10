using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ArraysAndIndexers
{
    class SomeArray
    {
        int size;
        int[] arr;
        //----------------------

        public SomeArray() { }

        public SomeArray(int size)
        {
            this.size = size;
            arr = new int[size];
        }
        //------------------------------

        public void FillInTheArray()
        {
            Random rand = new Random();
            for(int i = 0; i < size; i++)
            {
                arr[i] = rand.Next(0, 10);
            }
        }
        //------------------------------------

        public void ShowArray()
        {
            for(int i = 0; i < size; i++)
            {
                Console.WriteLine($"{arr[i]}");
            }
        }
        //------------------------------------

        public void SearchMin()
        {
            int minElem = arr[0];
            for(int i = 0; i < arr.Length; i++)
            {
                if(arr[i] < minElem)
                {
                    minElem = arr[i];
                    Console.WriteLine($"The min elem\t{minElem}");
                }
            }
        }
        //------------------------------------

        public void SearchMax()
        {
            int maxElem = arr[0];
            for(int i = 0; i < arr.Length; i++)
            {
                if(arr[i] > maxElem)
                {
                    maxElem = arr[i];
                    Console.WriteLine($"The max elem\t{maxElem}");
                }
            }
        }
        //------------------------------------

        public void TheMainSumOfelements()
        {
            int sum = 0;
            for (int i = 0; i < arr.Length; i++)
            {
                sum += arr[i];  
            }
            Console.WriteLine(sum);
        }
        //------------------------------------

        public void Average()
        {
            int sum = 0;
            for(int i = 0; i < arr.Length; i++)
            {
                sum += arr[i];
            }
            int avg = sum / arr.Length;
            Console.WriteLine("Average\t" + avg);
        }
        //------------------------------------

        public void UncountableElements()
        {
            int elements = 0;
            for(int i = 0; i < arr.Length; i++)
            {
                if (arr[i] % 2 == 0) { }
                else
                {
                    elements = arr[i];
                    Console.WriteLine($"{elements}");
                }
            }
        }
        //------------------------------------

    }
}