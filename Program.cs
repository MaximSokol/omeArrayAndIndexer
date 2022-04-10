using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ArraysAndIndexers
{
    class Program
    {
        static void Main(string[] args)
        {
            //Dog[] arr = { new Dog(), new Dog(), new Dog() };

            //Console.WriteLine("Before covariance");
            //for (int i = 0; i < arr.Length; i++)
            //{
            //    arr[i].Voice();
            //    arr[i].Jump();
            //}
            //Console.WriteLine();
            ////------------------------------------------------


            //IInterface[] iArr = arr; // Covariance

            //Console.WriteLine("After covariance");
            //for (int i = 0; i < iArr.Length; i++)
            //{
            //    iArr[i].Voice();
            //}
            //Console.WriteLine();
            ////------------------------------------------------


            //Dog[] secondArr = (Dog[])iArr; // Contravariance

            //Console.WriteLine("After contravariance");
            //for (int i = 0; i < secondArr.Length; i++)
            //{
            //    secondArr[i].Voice();
            //    secondArr[i].Jump();
            //}
            //Console.WriteLine();

            // Task 1

            //SomeIndexer indexer = new SomeIndexer();

            //Console.WriteLine(indexer["eyes"]);
            //Console.WriteLine(indexer["natue"]);
            //Console.WriteLine(indexer["crying"]);
            //Console.WriteLine(indexer["necessary"]);
            //Console.WriteLine(indexer["gun"]);

            //for(int i = 0; i < 5; i++)
            //{
            //    Console.WriteLine($"{indexer[i]}");
            //}
            //Console.WriteLine();

            // Task 2

            //SomeArray some = new SomeArray(5);

            //some.FillInTheArray();
            //some.ShowArray();

            //Console.WriteLine();

            //some.SearchMax();
            //some.SearchMin();

            //Console.WriteLine();

            //some.TheMainSumOfelements();
            //some.Average();
            //some.UncountableElements();

            // Task 3

            //MyMatrix matrix = new MyMatrix(4, 5);
            //matrix.FillTheArray();
            //matrix.Show();

            //matrix.ShowPartly(5, 5, 0, 4);

            // Task 4


            //Store obj = new Store(3);

            //obj.AddProduct(new Article(20.5, "Bread", "Kyiv Bread"), 0);
            //obj.AddProduct(new Article(17.99, "Tomato", "Mexicon's Goods"), 1);
            //obj.AddProduct(new Article(78.64, "Vodka", "Ukrainian's Alchohol Factory"), 2);

            //obj.Show();




        }
    }
}
