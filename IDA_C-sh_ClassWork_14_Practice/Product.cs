using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace IDA_C_sh_ClassWork_14_Practice
{
    internal class Product
    {
        public int ProductID { get; set; }
        static int ID_counter;
        public string ProductName { get; set; }
        public double ProductPrice { get; set; }
        public Product(string productName, double productPrice)
        {
            ProductID = ID_counter++;
            ProductName = productName;
            ProductPrice = productPrice;
        }
    }
}
