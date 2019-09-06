using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using crmAppBL;

namespace crmAppBL
{
    public class OrderRepo
    {

        

        public Order GetOrder(int orderID)
        {

            Order order = new Order(orderID);
            /// <summary>
            /// Funkcja pobierająca produkt po ID
            /// </summary>
            /// <returns></returns>
            /// 

            if(orderID == 10)
            {
                order.OrderDate = new DateTimeOffset(2018, 4, 20,  11, 00, 00, new TimeSpan(7, 0, 0));
            }

            return order;

        }

        public List<Order> GetOrder()
        {
            /// <summary>
            /// Funkcja pobierająca wszystkie produkty
            /// </summary>
            /// <returns></returns>
            return new List<Order>();

        }

        public bool SaveOrder()
        {
            /// <summary>
            /// Funkcja zapisująca
            /// </summary>
            /// <returns></returns>
            return true;

        }

    }
}
