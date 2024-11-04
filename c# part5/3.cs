using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace c__exceptionalhandling
{
    public enum Orderstatus
    {
        Pending,
        Shipped,
        Delivered
    }
    //Defined enum orderstatus
    public class Order
    {
        public Orderstatus status;
        //enum property
        public int ProductID;
        public Order(int productID, Orderstatus Orderstatus)
        {
            ProductID = productID;
            status = Orderstatus;
        }
        public static void DisplayStatus(Order order)
        {
            switch (order.status)
            {
                case Orderstatus.Pending:
                    Console.WriteLine("status:pending");
                    break;
                case Orderstatus.Shipped:
                    Console.WriteLine("status:shipped");
                    break;
                case Orderstatus.Delivered:
                    Console.WriteLine("status:delivered");
                    break;
                default:
                    Console.WriteLine("invalid order");
                    break;
            }
        }// display order status by getting order objects
    }
}
