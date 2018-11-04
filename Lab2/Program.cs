using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab2
{
    class Program
    {
        static void Main(string[] args)
        {
            using (Lab2Entities lab = new Lab2Entities())
            {
                foreach (Good good in lab.Goods)
                {
                    Console.WriteLine(string.Format("Good - {0} Price=> {1}", good.name,good.price));
                    int i = 0;                    
                }
                foreach (Store store in lab.Stores)
                {
                    Console.WriteLine(string.Format("Store city- {0} goodID=>", store.city,store.goodId));
                    int i = 0;
                }
                foreach (Customer customer in lab.Customers)
                {
                    Console.WriteLine(string.Format("Company - {0} City: {1} Service Level=> {2} " , 
                        customer.company, customer.city, customer.serviceLevel));
                    int i = 0;
                }
            }
            Console.ReadLine();
        }
    }
}
