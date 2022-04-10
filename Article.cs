using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ArraysAndIndexers
{
    class Article
    {
        double costUAH;
        //--------------------

        public string ProductName { get; set; }
        public string StoreName { get; set; }

        public double Price
        {
            set
            {
                if(value >= 0)
                {
                    costUAH = value;
                }
                Console.WriteLine("The value is too low to be add!");
            }
            get{ return costUAH; }
        }
        //------------------------------------------

       public Article()
        {
            this.ProductName = " ";
            this.StoreName = " ";
            this.costUAH = 0.0;
        }

       public Article(double costUAH, string productName, string storeName)
        {
            this.costUAH = costUAH;
            this.ProductName = productName;
            this.StoreName = storeName;
        }
        //---------------------------------

        public string Info()
        {
            return $"Price in UAH\t{this.costUAH}\n" +
                $"Product Name\t{ProductName}\n" +
                $"Store Name\t{StoreName}\n";
        }
        //---------------------------------
    }
}
