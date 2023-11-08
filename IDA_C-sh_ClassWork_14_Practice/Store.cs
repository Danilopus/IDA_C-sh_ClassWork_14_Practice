using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace IDA_C_sh_ClassWork_14_Practice
{
    internal class Store
    {
        public List<Order> orders_list { set; get; } = new List<Order>();

        public void AddOder(Order order) 
        {
            orders_list.Add(order);
        }
        public void ProcessOders() 
        {
           bool alpha = false;
            foreach (Order order in orders_list)
                order.GetEvent();
        }
    
    }
}
