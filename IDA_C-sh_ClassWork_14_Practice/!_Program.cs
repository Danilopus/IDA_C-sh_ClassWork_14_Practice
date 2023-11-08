// ClassWork template 1.2 // date: 29.09.2023

using IDA_C_sh_ClassWork_14_Practice;
using Service;
using System;
using System.Linq.Expressions;
using System.Text;


// ClassWork 14 : [C sharp] 8.11.2023 --------------------------------

namespace IDA_C_sh_ClassWork
{
    internal class Program
    {
        static void Main(string[] args)
        {

            // StoreTask
            Task_1();
            // Task_2();
            // Task_3();


            Console.ReadKey();

        }

        public static void Task_1() 
        {
        Product product_1 = new Product("Computer", 999);
        Product product_2 = new Product("Printer", 499);
        Product product_3 = new Product("Keyboard", 99.99);

        Customer customer_1 = new Customer("Customer_Name_1", "Russia, Ekaterinburg");
        Customer customer_2 = new Customer("Customer_Name_2", "Georgia, Tblisi");
        Customer customer_3 = new Customer("Customer_Name_3", "Israel, Tel-Aviv");

        Order order_1 = new Order(customer_1);
            order_1.product_list.Add(product_1);
            order_1.product_list.Add(product_2);
        Order order_2 = new Order(customer_2);
            order_2.product_list.Add(product_2);
            order_2.product_list.Add(product_3);
        Order order_3 = new Order(customer_3);
            order_3.product_list.Add(product_1);
            order_3.product_list.Add(product_2);
            order_3.product_list.Add(product_3);

        Store store_1 = new Store();
            store_1.AddOder(order_1);
            store_1.AddOder(order_2);
            store_1.AddOder(order_3);


        store_1.ProcessOders();

        }
        public static void Task_2() { }
        public static void Task_3() { }

    } // class Programm
}// namespace

