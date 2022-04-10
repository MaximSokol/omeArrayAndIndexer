using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ArraysAndIndexers
{
    class Store
    {
       private Article[] arr;
        //---------------

        public Store(int size)
        {
            arr = new Article[size];
        }
        //---------------------------

        public string this[int index]
        {
            get
            {
                if (index >= 0 && index < arr.Length)
                    return arr[index].Info();

                return "The try to out of range arr!";
            }
        }
        //----------------------------------------------

        public void AddProduct(Article value, int index)
        {
            if(index >= 0 && index <= arr.Length)
            {
                arr[index] = value;
            }
            else
            {
                Console.WriteLine("The try to out of range arr!");
            }
        }
        //----------------------------------------------

        public string this[string index]
        {
            get
            {
                for(int i = 0; i < arr.Length; i++)
                {
                    if(arr[i].ProductName == index)
                    {
                        return arr[i].Info();
                    }
                }
                return $"The product with such name is absent!\t{index}\n";
            }
        }
        //----------------------------------------------

        public void Show()
        {
            for(int i = 0; i < arr.Length; i++)
            {
                Console.Write(arr[i].Info());
            }
            Console.WriteLine();
        }
        //----------------------------------------------

        public void Sort()
        {
            for(int i = 0; i <= arr.Length -1; i++)
            {
                for(int j = 0; j <= arr.Length -1; j++)
                {
                    if (arr[i].Price <= arr[j].Price)
                    {
                        Article art = arr[i];
                        arr[i] = arr[j];
                        arr[j] = art;
                    }
                }
            }
        }
        //----------------------------------------------
    }
}
