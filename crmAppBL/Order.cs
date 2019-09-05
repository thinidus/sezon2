using System;
using System.Collections.Generic;

namespace crmAppBL
{
    public class Order
    {

        public Order()
        {

        }

        public Order(int orderID)
        {
            OrderID = orderID;
        }

        public int OrderID { get; private set; }
        public DateTimeOffset? OrderDate { get; set; }

        public bool Validate()
        {


            var status = true;

            if (OrderDate == null) { status = false; }

            return status;

        }


        public bool SaveOrder()
        {
            /// <summary>
            /// Funkcja zapisująca
            /// </summary>
            /// <returns></returns>
            return true;

        }

        public Order GetOrder(int orderID)
        {
            /// <summary>
            /// Funkcja pobierająca produkt po ID
            /// </summary>
            /// <returns></returns>
            return new Order();

        }

        public List<Order> GetOrder()
        {
            /// <summary>
            /// Funkcja pobierająca wszystkie produkty
            /// </summary>
            /// <returns></returns>
            return new List<Order>();

        }



    }
}
