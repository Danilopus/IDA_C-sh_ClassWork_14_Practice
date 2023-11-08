using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace IDA_C_sh_ClassWork_14_Practice
{
    internal class Order
    {
        public int ID;
        static int ID_counter;
        DateTime OrderDateTime;
        Customer current_customer;
        public List<Product> product_list { get; set; } = new List<Product>();
        public event Action<bool> OrderProcessed_event;

        public Order(Customer customer)
        {
        ID = ID_counter++;
        OrderProcessed_event += OrderProcessedHandler;
        OrderDateTime = DateTime.Now;
        current_customer = customer;
        }
        public void OrderProcessedHandler(bool alpha)
        {
            Console.WriteLine("\nOrder ID" + ID);
            foreach (var item in product_list)
            Console.WriteLine(item.ProductName + " | ");
        }
        public void GetEvent()
        {
            OrderProcessed_event(true); 
        }
          

}

}
