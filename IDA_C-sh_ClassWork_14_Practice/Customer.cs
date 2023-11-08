using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace IDA_C_sh_ClassWork_14_Practice
{
    internal class Customer
    {
        public int CustomerID { set; get; }
        static int CustomerID_counter;
        public string CustomerName { set; get; }
        public string CustomerAdress { set; get; }
        public Customer(string customerName, string customerAdress)
        {
            CustomerID = CustomerID_counter++;
            CustomerName = customerName;
            CustomerAdress = customerAdress;
        }
    }
}
